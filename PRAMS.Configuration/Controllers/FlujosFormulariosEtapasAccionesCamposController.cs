using FluentResults;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PRAMS.Application.Contract.People;
using PRAMS.Domain.Entities.People.Dto;
using PRAMS.Domain.Entities.Shared;
using System.Net.Mime;
using System.Security.Claims;

namespace PRAMS.Configuration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlujosFormulariosEtapasAccionesCamposController : ControllerBase
    {
        private readonly IFlujosFormulariosEtapasAccionesCamposService _flujosFormulariosEtapasAccionesCamposService;
        private readonly ILogger<FlujosFormulariosEtapasAccionesCamposController> _logger;

        public FlujosFormulariosEtapasAccionesCamposController(IFlujosFormulariosEtapasAccionesCamposService flujosFormulariosEtapasAccionesCamposService, ILogger<FlujosFormulariosEtapasAccionesCamposController> logger)
        {
            _flujosFormulariosEtapasAccionesCamposService = flujosFormulariosEtapasAccionesCamposService;
            _logger = logger;
        }

        [HttpGet]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<ICollection<AdmFlujoFormularioEtapaAccionCampoDto>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> GetFlujosFormulariosEtapasAccionesCampos()
        {
            try
            {
                var result = await _flujosFormulariosEtapasAccionesCamposService.GetFlujosFormulariosEtapasAccionesCampos();
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in GetFlujosFormulariosEtapasAccionesCampos Result:{@result}", result.Value);
                    return Ok(new ResponseDto<ICollection<AdmFlujoFormularioEtapaAccionCampoDto>> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in GetFlujosFormulariosEtapasAccionesCampos Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al obtener los flujos de formularios etapas acciones campos");
                return StatusCode(StatusCodes.Status500InternalServerError, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpGet("{formularioEtapaAccionCampoId}")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<AdmFlujoFormularioEtapaAccionCampoDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> GetFlujosFormulariosEtapasAccionesCampos(int formularioEtapaAccionCampoId)
        {
            try
            {
                var result = await _flujosFormulariosEtapasAccionesCamposService.GetFlujoFormularioEtapaAccionCampo(formularioEtapaAccionCampoId);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in GetFlujosFormulariosEtapasAccionesCampos Result:{@result}", result.Value);
                    return Ok(new ResponseDto<AdmFlujoFormularioEtapaAccionCampoDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in GetFlujosFormulariosEtapasAccionesCampos Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al obtener los flujos de formularios etapas acciones campos");
                return StatusCode(StatusCodes.Status500InternalServerError, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpGet("ByEtapaAccionId/{formularioEtapaAccionCampoId}")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<ICollection<AdmFlujoFormularioEtapaAccionCampoDto>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> GetFlujosFormulariosEtapasAccionesCamposByEtapaAccionCampo(int formularioEtapaAccionCampoId)
        {
            try
            {
                var result = await _flujosFormulariosEtapasAccionesCamposService.GetFlujoFormularioEtapaAccionCampoByFormularioEtapaAccionId(formularioEtapaAccionCampoId);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in GetFlujosFormulariosEtapasAccionesCamposByEtapaAccionCampo Result:{@result}", result.Value);
                    return Ok(new ResponseDto<ICollection<AdmFlujoFormularioEtapaAccionCampoDto>> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in GetFlujosFormulariosEtapasAccionesCamposByEtapaAccionCampo Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al obtener los flujos de formularios etapas acciones campos");
                return StatusCode(StatusCodes.Status500InternalServerError, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpPost("Create")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<AdmFlujoFormularioEtapaAccionCampoDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> CreateFlujosFormulariosEtapasAccionesCampos([FromBody] AdmFlujoFormularioEtapaAccionCampoInsertDto admFlujoFormularioEtapaAccionCampoDto)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;

                var result = await _flujosFormulariosEtapasAccionesCamposService.CreateFlujoFormularioEtapaAccionCampo(admFlujoFormularioEtapaAccionCampoDto, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in CreateFlujosFormulariosEtapasAccionesCampos Result:{@result}", result.Value);
                    return Ok(new ResponseDto<AdmFlujoFormularioEtapaAccionCampoDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in CreateFlujosFormulariosEtapasAccionesCampos Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al crear los flujos de formularios etapas acciones campos");
                return StatusCode(StatusCodes.Status500InternalServerError, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpPut("Update")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<AdmFlujoFormularioEtapaAccionCampoDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> UpdateFlujosFormulariosEtapasAccionesCampos([FromBody] AdmFlujoFormularioEtapaAccionCampoUpdateDto admFlujoFormularioEtapaAccionCampoDto)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;

                var result = await _flujosFormulariosEtapasAccionesCamposService.UpdateFlujoFormularioEtapaAccionCampo(admFlujoFormularioEtapaAccionCampoDto, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in UpdateFlujosFormulariosEtapasAccionesCampos Result:{@result}", result.Value);
                    return Ok(new ResponseDto<AdmFlujoFormularioEtapaAccionCampoDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in UpdateFlujosFormulariosEtapasAccionesCampos Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al actualizar los flujos de formularios etapas acciones campos");
                return StatusCode(StatusCodes.Status500InternalServerError, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpDelete("Remove/{formularioEtapaAccionCampoId}")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<AdmFlujoFormularioEtapaAccionCampoDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> RemoveFlujosFormulariosEtapasAccionesCampos(int formularioEtapaAccionCampoId)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;

                var result = await _flujosFormulariosEtapasAccionesCamposService.RemoveFlujoFormularioEtapaAccionCampo(formularioEtapaAccionCampoId, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in RemoveFlujosFormulariosEtapasAccionesCampos Result:{@result}", result.Value);
                    return Ok(new ResponseDto<AdmFlujoFormularioEtapaAccionCampoDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in RemoveFlujosFormulariosEtapasAccionesCampos Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al eliminar los flujos de formularios etapas acciones campos");
                return StatusCode(StatusCodes.Status500InternalServerError, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }

        }
    }
}
