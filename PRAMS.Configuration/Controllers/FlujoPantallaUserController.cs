using FluentResults;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PRAMS.Application.Contract.Flujos;
using PRAMS.Domain.Entities.Shared;
using PRAMS.Domain.Entities.SystemConfiguration.Dto;
using System.Net.Mime;
using System.Security.Claims;

namespace PRAMS.Configuration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlujoPantallaUserController : ControllerBase
    {
        private readonly IFlujoPantallaUserService _flujoPantallaUserService;
        private readonly ILogger<FlujoPantallaUserController> _logger;

        public FlujoPantallaUserController(IFlujoPantallaUserService flujoPantallaUserService, ILogger<FlujoPantallaUserController> logger)
        {
            _flujoPantallaUserService = flujoPantallaUserService;
            _logger = logger;
        }

        [HttpPost("Create")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<AdmFlujoPantallaUserDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> CreateFlujoPantallaUserItem(AdmFlujoPantallaUserInsertDto admFlujoPantallaUserInsertDto)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
                var result = await _flujoPantallaUserService.CreateFlujoPantallaUserItem(admFlujoPantallaUserInsertDto, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in CreateFlujoPantallaUserItem Result:{@result}", result.Value);
                    return Ok(new ResponseDto<AdmFlujoPantallaUserDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in CreateFlujoPantallaUserItem Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al crear la nota del flujo del formulario");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpPost]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<AdmFlujoPantallaUserDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> DeleteFlujoPantallaUserItem(int flujoUserID)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
                var result = await _flujoPantallaUserService.DeleteFlujoPantallaUserItem(flujoUserID, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in DeleteFlujoPantallaUserItem Result:{@result}", result.Value);
                    return Ok(new ResponseDto<AdmFlujoPantallaUserDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in DeleteFlujoPantallaUserItem Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al crear la nota del flujo del formulario");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpGet("GetByFormularioEtapaId/{formularioEtapaId}")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<ICollection<AdmFlujoPantallaUserDto>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> GetFlujoPantallaUsers(int formularioEtapaId)
        {
            try
            {
                var result = await _flujoPantallaUserService.GetFlujoPantallaUsers(formularioEtapaId);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in GetFlujoPantallaUsers Result:{@result}", result.Value);
                    return Ok(new ResponseDto<ICollection<AdmFlujoPantallaUserDto>> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in GetFlujoPantallaUsers Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al crear la nota del flujo del formulario");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpGet("GetByFlujoUserID/{flujoUserID}")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<AdmFlujoPantallaUserDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> GetFlujoPantallaUser(int flujoUserID)
        {
            try
            {
                var result = await _flujoPantallaUserService.GetFlujoPantallaUser(flujoUserID);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in GetFlujoPantallaUser Result:{@result}", result.Value);
                    return Ok(new ResponseDto<AdmFlujoPantallaUserDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in GetFlujoPantallaUser Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al crear la nota del flujo del formulario");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }
    }
}
