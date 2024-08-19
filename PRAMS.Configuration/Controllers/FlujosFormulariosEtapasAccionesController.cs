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
    public class FlujosFormulariosEtapasAccionesController : ControllerBase
    {
        private readonly IFlujosFormulariosEtapasAccionesService _flujosFormulariosEtapasAccionesService;
        private readonly ILogger<FlujosFormulariosEtapasAccionesController> _logger;

        public FlujosFormulariosEtapasAccionesController(IFlujosFormulariosEtapasAccionesService flujosFormulariosEtapasAccionesService, ILogger<FlujosFormulariosEtapasAccionesController> logger)
        {
            _flujosFormulariosEtapasAccionesService = flujosFormulariosEtapasAccionesService;
            _logger = logger;
        }

        [HttpGet("GetByFormularioEtapaId/{formularioEtapaId}")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<ICollection<AdmFlujoFormularioEtapaAccionDto>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> GetFlujosFormulariosEtapasAccionesByFormularioEtapaId(int formularioEtapaId)
        {
            try
            {
                var result = await _flujosFormulariosEtapasAccionesService.GetFlujosFormulariosEtapasAccionesByFormularioEtapaId(formularioEtapaId);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in GetFlujosFormulariosEtapasAccionesByFormularioEtapaId Result:{@result}", result.Value);
                    return Ok(new ResponseDto<ICollection<AdmFlujoFormularioEtapaAccionDto>> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in GetFlujosFormulariosEtapasAccionesByFormularioEtapaId Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al obtener los flujos de formularios etapas acciones");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpGet("{formularioEtapaAccionId}")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<AdmFlujoFormularioEtapaAccionDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> GetFlujosFormulariosEtapasAccion(int formularioEtapaAccionId)
        {
            try
            {
                var result = await _flujosFormulariosEtapasAccionesService.GetFlujoFormularioEtapaAccion(formularioEtapaAccionId);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in GetFlujosFormulariosEtapasAccion Result:{@result}", result.Value);
                    return Ok(new ResponseDto<AdmFlujoFormularioEtapaAccionDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in GetFlujosFormulariosEtapasAccion Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al obtener los flujos de formularios etapas acciones");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpPost("Create")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<AdmFlujoFormularioEtapaAccionDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> CreateFlujoFormularioEtapaAccionItem(AdmFlujoFormularioEtapaAccionInsertDto admFlujoFormularioEtapaAccionInsertDto)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;

                var result = await _flujosFormulariosEtapasAccionesService.CreateFlujoFormularioEtapaAccionItem(admFlujoFormularioEtapaAccionInsertDto, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in CreateFlujoFormularioEtapaAccionItem Result:{@result}", result.Value);
                    return Ok(new ResponseDto<AdmFlujoFormularioEtapaAccionDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in CreateFlujoFormularioEtapaAccionItem Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al crear la accion de la etapa del flujo del formulario");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpDelete("Remove/{formularioEtapaAccionId}")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<AdmFlujoFormularioEtapaAccionDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> RemoveFlujoFormularioEtapaAccionItem(int formularioEtapaAccionId)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;

                var result = await _flujosFormulariosEtapasAccionesService.DeleteFlujoFormularioEtapaAccionItem(formularioEtapaAccionId, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in RemoveFlujoFormularioEtapaAccionItem Result:{@result}", result.Value);
                    return Ok(new ResponseDto<AdmFlujoFormularioEtapaAccionDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in RemoveFlujoFormularioEtapaAccionItem Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al eliminar la accion de la etapa del flujo del formulario");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpPut("Update")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<AdmFlujoFormularioEtapaAccionDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> UpdateFlujoFormularioEtapaAccionItem(AdmFlujoFormularioEtapaAccionUpdateDto admFlujoFormularioEtapaAccionUpdateDto)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
                var result = await _flujosFormulariosEtapasAccionesService.UpdateFlujoFormularioEtapaAccionItem(admFlujoFormularioEtapaAccionUpdateDto, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in UpdateFlujoFormularioEtapaAccionItem Result:{@result}", result.Value);
                    return Ok(new ResponseDto<AdmFlujoFormularioEtapaAccionDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in UpdateFlujoFormularioEtapaAccionItem Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al actualizar la accion de la etapa del flujo del formulario");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

    }
}
