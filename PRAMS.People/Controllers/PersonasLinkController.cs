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
    public class PersonasLinkController : ControllerBase
    {
        private readonly IPersonasLinkService _personasLinkService;
        private readonly ILogger<PersonasLinkController> _logger;

        public PersonasLinkController(IPersonasLinkService personasLinkService, ILogger<PersonasLinkController> logger)
        {
            _personasLinkService = personasLinkService;
            _logger = logger;
        }

        [HttpGet("{personaId}")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<ICollection<PersonasLinkDto>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> GetPersonasLink([FromRoute] int personaId)
        {
            try
            {
                var result = await _personasLinkService.GetPersonasLink(personaId);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in GetPersonasLink Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<ICollection<PersonasLinkDto>> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in GetPersonasLink Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError("Error in GetPersonasLink Error:{@error}", error);
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpGet("referido/{referidoId}")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<ICollection<PersonasLinkPersonaDto>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> GetPersonasLinkByReferidoId([FromRoute] int referidoId)
        {
            try
            {
                var result = await _personasLinkService.GetPersonasLinkByReferidoId(referidoId);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in GetPersonasLinkByReferidoId Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<ICollection<PersonasLinkPersonaDto>> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in GetPersonasLinkByReferidoId Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError("Error in GetPersonasLinkByReferidoId Error:{@error}", error);
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpPost]
        [Authorize]
        [Consumes(MediaTypeNames.Application.Json)]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<PersonasLinkDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> CreatePersonasLinkItem([FromBody] PersonasLinkInsertDto personasLinkInsertDto)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
                var result = await _personasLinkService.CreatePersonasLinkItem(personasLinkInsertDto, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in CreatePersonasLinkItem Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<PersonasLinkDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in CreatePersonasLinkItem Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError("Error in CreatePersonasLinkItem Error:{@error}", error);
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpDelete("{linkId}")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<PersonasLinkDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> DeletePersonasLinkItem([FromRoute] int linkId)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
                var result = await _personasLinkService.DeletePersonasLinkItem(linkId, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in DeletePersonasLinkItem Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<PersonasLinkDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in DeletePersonasLinkItem Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError("Error in DeletePersonasLinkItem Error:{@error}", error);
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpPut]
        [Authorize]
        [Consumes(MediaTypeNames.Application.Json)]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<PersonasLinkDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> UpdatePersonasLinkItem([FromBody] PersonasLinkUpdateDto personasLinkUpdateDto)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
                var result = await _personasLinkService.UpdatePersonasLinkItem(personasLinkUpdateDto, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in UpdatePersonasLinkItem Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<PersonasLinkDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in UpdatePersonasLinkItem Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError("Error in UpdatePersonasLinkItem Error:{@error}", error);
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

    }
}
