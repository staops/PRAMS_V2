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
    public class FlujoFormularioController : ControllerBase
    {
        private readonly IFormFlowBuilderService _formFlowBuilderService;
        private readonly ILogger<FlujoFormularioController> _logger;

        public FlujoFormularioController(IFormFlowBuilderService formFlowBuilderService, ILogger<FlujoFormularioController> logger)
        {
            _formFlowBuilderService = formFlowBuilderService;
            _logger = logger;
        }


        /// <summary>
        /// Valida el formulario para la creación de un nuevo registro en la tabla de formularios y flujos pantalla.
        /// </summary>
        /// <param name="formFlowBuilder"></param>
        /// <returns></returns>
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
                var role = User.FindFirst(ClaimTypes.Role)?.Value ?? string.Empty;
                var result = await _formFlowBuilderService.ValidaFormulario(formFlowBuilder, user, role);
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

        /// <summary>
        /// Crea un nuevo registro de formulario en la tabla del formulario correspondiente y añade un registro en la tabla de flujos pantalla.
        /// </summary>
        /// <param name="formFlowBuilder"></param>
        /// <returns></returns>
        [HttpPost]
        [Authorize]
        [Route("Create")]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<FormFlowBuilderObjectResult<object>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> CreateRegistroFormulario(FormFlowBuilder formFlowBuilder)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
                var role = User.FindFirst(ClaimTypes.Role)?.Value ?? string.Empty;
                var result = await _formFlowBuilderService.CreaRegistrosFormulario(formFlowBuilder, user, role);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in CreaRegistrosFormulario Result:{@result}", result.Value);
                    return Ok(new ResponseDto<object> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in CreaRegistrosFormulario Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al crear los registros del formulario");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        /// <summary>
        /// Actualiza un registro de formulario en la tabla del formulario correspondiente y añade un registro en la tabla de flujos pantalla.
        /// </summary>
        /// <param name="formFlowBuilder"></param>
        /// <returns></returns>
        [HttpPost]
        [Authorize]
        [Route("Update")]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<FormFlowBuilderObjectResult<object>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> UpdateRegistroFormulario(FormFlowBuilder formFlowBuilder)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
                var role = User.FindFirst(ClaimTypes.Role)?.Value ?? string.Empty;
                var result = await _formFlowBuilderService.CreaRegistrosFormulario(formFlowBuilder, user, role);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in CreaRegistrosFormulario Result:{@result}", result.Value);
                    return Ok(new ResponseDto<object> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in CreaRegistrosFormulario Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al crear los registros del formulario");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        /// <summary>
        /// Añade una firma a un formulario.
        /// Verifica si el formulario ya ha completado todas las etapas y si es así, añade la firma al formulario.
        /// 
        /// </summary>
        /// <param name="formSignatureBuilder">Objeto con la información de la firma</param>
        /// <returns></returns>
        [HttpPost]
        [Authorize]
        [Route("Sign")]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<FormFlowBuilderObjectResult<object>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> SignFormulario(FormSignatureBuilder formSignatureBuilder)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
                var role = User.FindFirst(ClaimTypes.Role)?.Value ?? string.Empty;
                var result = await _formFlowBuilderService.SignFormulario(formSignatureBuilder, user, role);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in SignFormulario Result:{@result}", result.Value);
                    return Ok(new ResponseDto<object> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in SignFormulario Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al firmar el formulario");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }



    }
}
