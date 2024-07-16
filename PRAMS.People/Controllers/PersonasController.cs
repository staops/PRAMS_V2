using FluentResults;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PRAMS.Application.Contract.People;
using PRAMS.Domain.Entities.People.Dto;
using PRAMS.Domain.Entities.Shared;
using System.Net.Mime;

namespace PRAMS.People.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        private readonly IPersonasService _personasService;
        private readonly ILogger<PersonasController> _logger;

        public PersonasController(IPersonasService personasService, ILogger<PersonasController> logger)
        {
            _personasService = personasService;
            _logger = logger;
        }

        [HttpGet("{personaId}")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<PersonDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> GetPersonasIngreso([FromRoute] int personaId)
        {
            try
            {
                var result = await _personasService.GetPersona(personaId);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in GetPersonasIngreso Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<PersonDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in GetPersonasIngreso Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError("Error in GetPersonasIngreso Error:{@error}", error);
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpGet]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<ICollection<PersonDto>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> ListPersonas()
        {
            try
            {
                var result = await _personasService.ListPersonas();
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in ListPersonas Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<ICollection<PersonDto>> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in ListPersonas Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError("Error in ListPersonas Error:{@error}", error);
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpPost("search")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<ICollection<PersonDto>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> SearchPersonItem([FromBody] PersonSearchDto personSearchDto)
        {
            try
            {
                var result = await _personasService.SearchPersonItem(personSearchDto);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in SearchPersonItem Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<ICollection<PersonDto>> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in SearchPersonItem Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError("Error in SearchPersonItem Error:{@error}", error);
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }



    }
}
