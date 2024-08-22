using FluentResults;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PRAMS.Application.Contract.Forms;
using PRAMS.Domain.Entities.Forms.Dto;
using PRAMS.Domain.Entities.Shared;
using System.Net.Mime;
using System.Security.Claims;

namespace PRAMS.Configuration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormFirmasController : ControllerBase
    {
        private readonly IFormulariosFirmasService _formulariosFirmasService;
        private readonly ILogger<FormFirmasController> _logger;

        public FormFirmasController(IFormulariosFirmasService formulariosFirmasService, ILogger<FormFirmasController> logger)
        {
            _formulariosFirmasService = formulariosFirmasService;
            _logger = logger;
        }

        [HttpPost("Create")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<FormFormularioFirmaDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> CreateFormularioFirma(FormFormularioFirmaInsertDto formFormularioFirmaInsertDto)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;

                var result = await _formulariosFirmasService.CreateFormularioFirma(formFormularioFirmaInsertDto, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in CreateFormularioFirma Result:{@result}", result.Value);
                    return Ok(new ResponseDto<FormFormularioFirmaDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in CreateFormularioFirma Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al crear el formulario de firma");
                return StatusCode(StatusCodes.Status500InternalServerError, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpGet("{formularioFirmaId}")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<FormFormularioFirmaDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> GetFormularioFirma(int formularioFirmaId)
        {
            try
            {
                var result = await _formulariosFirmasService.GetFormularioFirma(formularioFirmaId);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in GetFormularioFirma Result:{@result}", result.Value);
                    return Ok(new ResponseDto<FormFormularioFirmaDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in GetFormularioFirma Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al obtener el formulario de firma");
                return StatusCode(StatusCodes.Status500InternalServerError, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpGet]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<ICollection<FormFormularioFirmaDto>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> GetFormulariosFirmas()
        {
            try
            {
                var result = await _formulariosFirmasService.GetFormulariosFirmas();
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in GetFormulariosFirmas Result:{@result}", result.Value);
                    return Ok(new ResponseDto<ICollection<FormFormularioFirmaDto>> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in GetFormulariosFirmas Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al obtener los formularios de firma");
                return StatusCode(StatusCodes.Status500InternalServerError, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpGet("ByFormularioEtapa/{formularioEtapaId}")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<ICollection<FormFormularioFirmaDto>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> GetFormulariosFirmasByFormularioEtapa(int formularioEtapaId)
        {
            try
            {
                var result = await _formulariosFirmasService.GetFormularioFirmaByFormularioEtapa(formularioEtapaId);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in GetFormulariosFirmasByFormularioEtapa Result:{@result}", result.Value);
                    return Ok(new ResponseDto<ICollection<FormFormularioFirmaDto>> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in GetFormulariosFirmasByFormularioEtapa Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al obtener los formularios de firma por formulario etapa");
                return StatusCode(StatusCodes.Status500InternalServerError, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpDelete("Remove/{formularioFirmaId}")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<FormFormularioFirmaDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> RemoveFormularioFirma(int formularioFirmaId)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;

                var result = await _formulariosFirmasService.RemoveFormularioFirma(formularioFirmaId, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in RemoveFormularioFirma Result:{@result}", result.Value);
                    return Ok(new ResponseDto<FormFormularioFirmaDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in RemoveFormularioFirma Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al eliminar el formulario de firma");
                return StatusCode(StatusCodes.Status500InternalServerError, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpPut("Update")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<FormFormularioFirmaDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> UpdateFormularioFirmaItem(FormFormularioFirmaUpdateDto formFormularioFirmaUpdateDto)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;

                var result = await _formulariosFirmasService.UpdateFormularioFirma(formFormularioFirmaUpdateDto, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in UpdateFormularioFirmaItem Result:{@result}", result.Value);
                    return Ok(new ResponseDto<FormFormularioFirmaDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in UpdateFormularioFirmaItem Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al actualizar el formulario de firma");
                return StatusCode(StatusCodes.Status500InternalServerError, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

    }
}
