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
    public class FlujoFormularioNotasController : ControllerBase
    {
        private readonly IFlujoFormularioNotasService _flujoFormularioNotasService;
        private readonly ILogger<FlujoFormularioNotasController> _logger;

        public FlujoFormularioNotasController(IFlujoFormularioNotasService flujoFormularioNotasService, ILogger<FlujoFormularioNotasController> logger)
        {
            _flujoFormularioNotasService = flujoFormularioNotasService;
            _logger = logger;
        }

        [HttpPost("Create")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<AdmFlujoFormularioNotaDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> CreateFlujoFormularioNotaItem(AdmFlujoFormularioNotaInsertDto admFlujoFormularioNotaInsertDto)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
                var result = await _flujoFormularioNotasService.CreateFlujoFormularioNotaItem(admFlujoFormularioNotaInsertDto, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in CreateFlujoFormularioNotaItem Result:{@result}", result.Value);
                    return Ok(new ResponseDto<AdmFlujoFormularioNotaDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in CreateFlujoFormularioNotaItem Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al crear la nota del flujo del formulario");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpGet("{formularioId}")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<ICollection<AdmFlujoFormularioNotaDto>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> GetFlujoFormularioNotas(int formularioId)
        {
            try
            {
                var result = await _flujoFormularioNotasService.GetFlujoFormularioNotas(formularioId);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in GetFlujoFormularioNotas Result:{@result}", result.Value);
                    return Ok(new ResponseDto<ICollection<AdmFlujoFormularioNotaDto>> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in GetFlujoFormularioNotas Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al obtener las notas del flujo del formulario");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpGet("getByFormularioNotaId/{formularioNotaId}")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<AdmFlujoFormularioNotaDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> GetFlujoFormularioNota(int formularioNotaId)
        {
            try
            {
                var result = await _flujoFormularioNotasService.GetFlujoFormularioNota(formularioNotaId);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in GetFlujoFormularioNota Result:{@result}", result.Value);
                    return Ok(new ResponseDto<AdmFlujoFormularioNotaDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in GetFlujoFormularioNota Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al obtener la nota del flujo del formulario");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpPut("Update")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<AdmFlujoFormularioNotaDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> UpdateFlujoFormularioNotaItem(AdmFlujoFormularioNotaUpdateDto admFlujoFormularioNotaUpdateDto)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
                var result = await _flujoFormularioNotasService.UpdateFlujoFormularioNotaItem(admFlujoFormularioNotaUpdateDto, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in UpdateFlujoFormularioNotaItem Result:{@result}", result.Value);
                    return Ok(new ResponseDto<AdmFlujoFormularioNotaDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in UpdateFlujoFormularioNotaItem Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al actualizar la nota del flujo del formulario");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpDelete("Remove/{formularioNotaId}")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<AdmFlujoFormularioNotaDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> DeleteFlujoFormularioNotaItem(int formularioNotaId)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
                var result = await _flujoFormularioNotasService.DeleteFlujoFormularioNotaItem(formularioNotaId, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in DeleteFlujoFormularioNotaItem Result:{@result}", result.Value);
                    return Ok(new ResponseDto<AdmFlujoFormularioNotaDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in DeleteFlujoFormularioNotaItem Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al eliminar la nota del flujo del formulario");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }
    }
}
