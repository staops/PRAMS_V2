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
    public class FormAsignacionUsuarioController : ControllerBase
    {
        private readonly IFormAsignacionUsuarioService _formAsignacionUsuarioService;
        private readonly ILogger<FormAsignacionUsuarioController> _logger;

        public FormAsignacionUsuarioController(IFormAsignacionUsuarioService formAsignacionUsuarioService, ILogger<FormAsignacionUsuarioController> logger)
        {
            _formAsignacionUsuarioService = formAsignacionUsuarioService;
            _logger = logger;
        }

        [HttpGet("ByIdReferido/{IdReferido}")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<FormAsignacionUsuariosDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> GetByIdReferido(int IdReferido)
        {
            try
            {
                var result = await _formAsignacionUsuarioService.GetByIdReferido(IdReferido);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in GetByIdReferido Result:{@result}", result.Value);
                    return Ok(new ResponseDto<FormAsignacionUsuariosDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in GetByIdReferido Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al obtener los formularios referidos");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpPost]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<FormAsignacionUsuariosDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> CreateFormAsignacionUsuario([FromBody] FormAsignacionUsuariosInsertDto formAsignacionUsuariosInsertDto)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
                var result = await _formAsignacionUsuarioService.CreateFormAsignacionUsuario(formAsignacionUsuariosInsertDto, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in CreateFormAsignacionUsuario Result:{@result}", result.Value);
                    return Ok(new ResponseDto<FormAsignacionUsuariosDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in CreateFormAsignacionUsuario Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al crear el formulario de asignación de usuario");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpPut]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<FormAsignacionUsuariosDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> UpdateFormAsignacionUsuario([FromBody] FormAsignacionUsuariosUpdateDto formAsignacionUsuariosUpdateDto)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
                var result = await _formAsignacionUsuarioService.UpdateFormAsignacionUsuario(formAsignacionUsuariosUpdateDto, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in UpdateFormAsignacionUsuario Result:{@result}", result.Value);
                    return Ok(new ResponseDto<FormAsignacionUsuariosDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in UpdateFormAsignacionUsuario Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al actualizar el formulario de asignación de usuario");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpDelete("{IdAsignacionUsuario}")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<FormAsignacionUsuariosDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> RemoveFormAsignacionUsuario(int IdAsignacionUsuario)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
                var result = await _formAsignacionUsuarioService.RemoveFormAsignacionUsuario(IdAsignacionUsuario, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in RemoveFormAsignacionUsuario Result:{@result}", result.Value);
                    return Ok(new ResponseDto<FormAsignacionUsuariosDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in RemoveFormAsignacionUsuario Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al eliminar el formulario de asignación de usuario");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

    }
}
