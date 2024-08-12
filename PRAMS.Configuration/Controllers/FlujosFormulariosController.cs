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
    public class FlujosFormulariosController : ControllerBase
    {
        private readonly IFlujosFormulariosService _flujosFormulariosService;
        private readonly ILogger<FlujosFormulariosController> _logger;

        public FlujosFormulariosController(IFlujosFormulariosService flujosFormulariosService, ILogger<FlujosFormulariosController> logger)
        {
            _flujosFormulariosService = flujosFormulariosService;
            _logger = logger;
        }

        [HttpGet("{formularioId}")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<AdmFlujoFormularioDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> GetFlujosFormulario(int formularioId)
        {
            try
            {
                var result = await _flujosFormulariosService.GetFlujoFormulario(formularioId);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in GetFlujosFormulario Result:{@result}", result.Value);
                    return Ok(new ResponseDto<AdmFlujoFormularioDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in GetFlujosFormulario Errors:{@errors}", result.Errors);
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
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<ICollection<AdmFlujoFormularioDto>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> GetFlujosFormularios()
        {
            try
            {
                var result = await _flujosFormulariosService.GetFlujosFormularios();
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in GetFlujosFormularios Result:{@result}", result.Value);
                    return Ok(new ResponseDto<ICollection<AdmFlujoFormularioDto>> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in GetFlujosFormularios Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al obtener los flujos de los formularios");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpPost]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<AdmFlujoFormularioDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> CreateFlujoFormulario([FromBody] AdmFlujoFormularioInsertDto itemToInsert)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;

                var result = await _flujosFormulariosService.CreateFlujoFormulario(itemToInsert, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in CreateFlujoFormulario Result:{@result}", result.Value);
                    return Ok(new ResponseDto<AdmFlujoFormularioDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in CreateFlujoFormulario Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al insertar el flujo del formulario");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpDelete("{formularioId}")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<bool>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> RemoveFlujoFormulario(int formularioId)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;

                var result = await _flujosFormulariosService.RemoveFlujoFormulario(formularioId, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in RemoveFlujoFormulario Result:{@result}", result.Value);
                    return Ok(new ResponseDto<bool> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in RemoveFlujoFormulario Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al eliminar el flujo del formulario");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpPut]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<AdmFlujoFormularioDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> UpdateFlujoFormulario([FromBody] AdmFlujoFormularioUpdateDto itemToUpdate)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;

                var result = await _flujosFormulariosService.UpdateFlujoFormulario(itemToUpdate, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in UpdateFlujoFormulario Result:{@result}", result.Value);
                    return Ok(new ResponseDto<AdmFlujoFormularioDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in UpdateFlujoFormulario Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al actualizar el flujo del formulario");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }


    }
}
