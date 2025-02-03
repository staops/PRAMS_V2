using FluentResults;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PRAMS.Application.Contract.Forms;
using PRAMS.Domain.Entities.Forms.Dto;
using PRAMS.Domain.Entities.Shared;
using System.Net.Mime;

namespace PRAMS.Configuration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormReferridosController : ControllerBase
    {
        private readonly IFormReferidoService _formReferidoService;
        private readonly ILogger<FormReferridosController> _logger;

        public FormReferridosController(IFormReferidoService formReferidoService, ILogger<FormReferridosController> logger)
        {
            _formReferidoService = formReferidoService;
            _logger = logger;
        }

        [HttpGet]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<ICollection<FormReferidoDto>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> GetFormReferidos()
        {
            try
            {
                var result = await _formReferidoService.GetFormReferidos();
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in GetFormReferidos Result:{@result}", result.Value);
                    return Ok(new ResponseDto<ICollection<FormReferidoDto>> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in GetFormReferidos Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al obtener los formularios referidos");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpPost("paged")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<DtResult<FormReferidoDto>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> ListFormReferidos([FromBody] FilterCriteria filterCriteria)
        {
            try
            {
                var result = await _formReferidoService.ListFormReferidos(filterCriteria);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in ListFormReferidos Result:{@result}", result.Value);
                    return Ok(new ResponseDto<DtResult<FormReferidoDto>> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in ListFormReferidos Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al obtener los formularios referidos");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpGet("ByReferidoId/{referidoId}")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<FormReferidoDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> GetFormReferido(int referidoId)
        {
            try
            {
                var result = await _formReferidoService.GetFormReferido(referidoId);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in GetFormReferido Result:{@result}", result.Value);
                    return Ok(new ResponseDto<FormReferidoDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in GetFormReferido Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al obtener el formulario referido");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpGet("CompletadosSP")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<IList<SelectReferidosCompletadosSpDto>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> SelectReferidosCompletadosSP()
        {
            try
            {
                var result = await _formReferidoService.SelectReferidosCompletadosSP();
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in SelectReferidosCompletadosSP Result:{@result}", result.Value);
                    return Ok(new ResponseDto<IList<SelectReferidosCompletadosSpDto>> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in SelectReferidosCompletadosSP Errors:{@errors}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al obtener los referidos completados");
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }


    }
}
