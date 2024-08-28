using FluentResults;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PRAMS.Application.Contract.Forms;
using PRAMS.Domain.Entities.Forms.Entities;
using PRAMS.Domain.Entities.Shared;
using System.Net.Mime;
using System.Security.Claims;

namespace PRAMS.Configuration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormFlowBuilderController : ControllerBase
    {
        private readonly IFormFlowBuilderService _formFlowBuilderService;
        private readonly ILogger<FormFlowBuilderController> _logger;

        public FormFlowBuilderController(IFormFlowBuilderService formFlowBuilderService, ILogger<FormFlowBuilderController> logger)
        {
            _formFlowBuilderService = formFlowBuilderService;
            _logger = logger;
        }

        [HttpPost]
        [Authorize]
        [Route("validaFormulario")]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<FormFlowBuilderResult>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> ValidaFormulario(FormFlowBuilder formFlowBuilder)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
                var result = await _formFlowBuilderService.ValidaFormulario(formFlowBuilder);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in ValidaFormulario Result:{@result}", result.Value);
                    return Ok(new ResponseDto<FormFlowBuilderResult> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in ValidaFormulario Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al validar el formulario");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }



    }
}
