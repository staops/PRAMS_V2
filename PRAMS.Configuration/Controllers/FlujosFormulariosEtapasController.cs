using FluentResults;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PRAMS.Application.Contract.Flujos;
using PRAMS.Domain.Entities.Flujos.Dto;
using PRAMS.Domain.Entities.Shared;
using System.Net.Mime;
using System.Security.Claims;

namespace PRAMS.Configuration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlujosFormulariosEtapasController : ControllerBase
    {
        private readonly IFlujosFormulariosEtapasService _flujosFormulariosEtapas;
        private readonly ILogger<FlujosFormulariosController> _logger;

        public FlujosFormulariosEtapasController(IFlujosFormulariosEtapasService flujosFormulariosEtapas, ILogger<FlujosFormulariosController> logger)
        {
            _flujosFormulariosEtapas = flujosFormulariosEtapas;
            _logger = logger;
        }

        [HttpGet("{formularioId}")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<AdmFlujoFormularioEtapaDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> GetFlujosFormularioEtapa(int formularioId)
        {
            try
            {
                var result = await _flujosFormulariosEtapas.GetFlujoFormularioEtapa(formularioId);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in GetFlujosFormularioEtapa Result:{@result}", result.Value);
                    return Ok(new ResponseDto<AdmFlujoFormularioEtapaDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in GetFlujosFormularioEtapa Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al obtener el flujo del formulario");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpGet]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<ICollection<AdmFlujoFormularioEtapaDto>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> GetFlujosFormulariosEtapas()
        {
            try
            {
                var result = await _flujosFormulariosEtapas.GetFlujosFormulariosEtapas();
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in GetFlujosFormulariosEtapas Result:{@result}", result.Value);
                    return Ok(new ResponseDto<ICollection<AdmFlujoFormularioEtapaDto>> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in GetFlujosFormulariosEtapas Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al obtener los flujos de los formularios");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpPost("Create")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<AdmFlujoFormularioEtapaDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> CreateFlujoFormularioEtapa(AdmFlujoFormularioEtapaInsertDto itemToInsert)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;

                var result = await _flujosFormulariosEtapas.CreateFlujoFormularioEtapa(itemToInsert, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in CreateFlujoFormularioEtapa Result:{@result}", result.Value);
                    return Ok(new ResponseDto<AdmFlujoFormularioEtapaDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in CreateFlujoFormularioEtapa Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al crear el flujo del formulario");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpPut("Update")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<AdmFlujoFormularioEtapaDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> UpdateFlujoFormularioEtapa(AdmFlujoFormularioEtapaUpdateDto itemToUpdate)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;

                var result = await _flujosFormulariosEtapas.UpdateFlujoFormularioEtapa(itemToUpdate, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in UpdateFlujoFormularioEtapa Result:{@result}", result.Value);
                    return Ok(new ResponseDto<AdmFlujoFormularioEtapaDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in UpdateFlujoFormularioEtapa Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al actualizar el flujo del formulario");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpDelete("Remove/{formularioId}")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<bool>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> RemoveFlujoFormularioEtapa(int formularioId)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;

                var result = await _flujosFormulariosEtapas.RemoveFlujoFormularioEtapa(formularioId, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in RemoveFlujoFormularioEtapa Result:{@result}", result.Value);
                    return Ok(new ResponseDto<bool> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in RemoveFlujoFormularioEtapa Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al eliminar el flujo del formulario");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

    }
}
