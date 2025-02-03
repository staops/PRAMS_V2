using FluentResults;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PRAMS.Application.Contract.People;
using PRAMS.Domain.Entities.People.Dto;
using PRAMS.Domain.Entities.Shared;
using System.Net.Mime;
using System.Security.Claims;

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

        [HttpPost("paged")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<DtResult<PersonDto>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> ListPersonasPaged([FromBody] FilterCriteria filterCriteria)
        {
            try
            {
                var result = await _personasService.ListPersonas(filterCriteria);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in ListPersonasPaged Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<DtResult<PersonDto>> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in ListPersonasPaged Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError("Error in ListPersonasPaged Error:{@error}", error);
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

        [HttpPost("create")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<PersonDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> CreatePersonItem([FromBody] PersonInsertDto personInsertDto)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
                var result = await _personasService.CreatePersonItem(personInsertDto, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in CreatePersonItem Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<PersonDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in CreatePersonItem Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError("Error in CreatePersonItem Error:{@error}", error);
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpPut("update")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<PersonDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> UpdatePersonItem([FromBody] PersonUpdateDto personUpdateDto)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
                var result = await _personasService.UpdatePersonItem(personUpdateDto, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in UpdatePersonItem Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<PersonDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in UpdatePersonItem Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError("Error in UpdatePersonItem Error:{@error}", error);
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpGet("merge")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<PersonDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> MergePersonItem([FromQuery] int mainPersonaId, [FromQuery] int mergePersonaId)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
                var result = await _personasService.MergePersonItem(mainPersonaId, mergePersonaId, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in MergePersonItem Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<PersonDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in MergePersonItem Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError("Error in MergePersonItem Error:{@error}", error);
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpGet("unmerge")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<PersonDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> UnmergePersonItem([FromQuery] int mainPersonaId)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
                var result = await _personasService.UnmergePersonItem(mainPersonaId, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in UnmergePersonItem Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<PersonDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in UnmergePersonItem Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError("Error in UnmergePersonItem Error:{@error}", error);
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

    }
}
