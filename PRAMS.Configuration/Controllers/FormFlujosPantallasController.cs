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
    public class FormFlujosPantallasController : ControllerBase
    {
        private readonly IFlujosPantallasService _flujosPantallasService;
        private readonly ILogger<FormFlujosPantallasController> _logger;

        public FormFlujosPantallasController(IFlujosPantallasService flujosPantallasService, ILogger<FormFlujosPantallasController> logger)
        {
            _flujosPantallasService = flujosPantallasService;
            _logger = logger;
        }

        [HttpGet]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<ICollection<FormFlujoPantallaDto>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> GetFlujosPantallas()
        {
            try
            {
                var result = await _flujosPantallasService.GetFlujosPantallas();
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in GetFlujosPantallas Result:{@result}", result.Value);
                    return Ok(new ResponseDto<ICollection<FormFlujoPantallaDto>> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in GetFlujosPantallas Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al obtener los flujos de pantallas");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpGet("{flujoPantallaId}")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<FormFlujoPantallaDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> GetFlujoPantalla(int flujoPantallaId)
        {
            try
            {
                var result = await _flujosPantallasService.GetFlujoPantalla(flujoPantallaId);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in GetFlujoPantalla Result:{@result}", result.Value);
                    return Ok(new ResponseDto<FormFlujoPantallaDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in GetFlujoPantalla Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al obtener el flujo de pantalla");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpGet("ByFormularioId{formularioId}")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<ICollection<FormFlujoPantallaDto>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> GetFlujosPantallasByFormularioId(int formularioId)
        {
            try
            {
                var result = await _flujosPantallasService.GetFlujosPantallasByFormularioId(formularioId);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in GetFlujosPantallasByFormularioId Result:{@result}", result.Value);
                    return Ok(new ResponseDto<ICollection<FormFlujoPantallaDto>> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in GetFlujosPantallasByFormularioId Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al obtener los flujos de pantallas por formulario");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpGet("ByFormaId/{formaId}")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<ICollection<FormFlujoPantallaDto>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> GetFlujosPantallasByFormaId(int formaId)
        {
            try
            {
                var result = await _flujosPantallasService.GetFlujosPantallasByFormaId(formaId);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in GetFlujosPantallasByFormaId Result:{@result}", result.Value);
                    return Ok(new ResponseDto<ICollection<FormFlujoPantallaDto>> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in GetFlujosPantallasByFormaId Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al obtener los flujos de pantallas por forma");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpPost("Create")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<FormFlujoPantallaDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> CreateFlujoPantalla([FromBody] FormFlujoPantallaInsertDto formFlujoPantallaDto)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;

                var result = await _flujosPantallasService.CreateFlujoPantalla(formFlujoPantallaDto, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in CreateFlujoPantalla Result:{@result}", result.Value);
                    return Ok(new ResponseDto<FormFlujoPantallaDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in CreateFlujoPantalla Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al crear el flujo de pantalla");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpPut("Update")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<FormFlujoPantallaDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> UpdateFlujoPantalla([FromBody] FormFlujoPantallaUpdateDto formFlujoPantallaDto)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;

                var result = await _flujosPantallasService.UpdateFlujoPantalla(formFlujoPantallaDto, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in UpdateFlujoPantalla Result:{@result}", result.Value);
                    return Ok(new ResponseDto<FormFlujoPantallaDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in UpdateFlujoPantalla Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al actualizar el flujo de pantalla");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpDelete("Remove/{flujoPantallaId}")]
        [Authorize]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<bool>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> RemoveFlujoPantalla(int flujoPantallaId)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;

                var result = await _flujosPantallasService.RemoveFlujoPantalla(flujoPantallaId, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in RemoveFlujoPantalla Result:{@result}", result.Value);
                    return Ok(new ResponseDto<FormFlujoPantallaDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in RemoveFlujoPantalla Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al eliminar el flujo de pantalla");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }


        }

        [HttpPost("paged")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<DtResult<FormFlujoPantallaDto>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> ListFlujosPantallas([FromBody] FilterCriteria filterCriteria)
        {
            try
            {
                var result = await _flujosPantallasService.ListFlujosPantallass(filterCriteria);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in ListFlujosPantallas Result:{@result}", result.Value);
                    return Ok(new ResponseDto<DtResult<FormFlujoPantallaDto>> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in ListFlujosPantallas Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al obtener los flujos de pantallas");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }
    }
}
