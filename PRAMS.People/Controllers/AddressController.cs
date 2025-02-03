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
    public class AddressController : ControllerBase
    {
        private readonly IPersonasDireccionesService _personasDireccionesService;
        private readonly ILogger<AddressController> _logger;

        public AddressController(IPersonasDireccionesService personasDireccionesService, ILogger<AddressController> logger)
        {
            _personasDireccionesService = personasDireccionesService;
            _logger = logger;
        }

        [HttpGet("{personaId}")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<ICollection<PersonasDireccionDto>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> GetPersonaDirecciones([FromRoute] int personaId)
        {
            try
            {
                var result = await _personasDireccionesService.GetPersonaDirecciones(personaId);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in GetPersonaDirecciones Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<ICollection<PersonasDireccionDto>> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in GetPersonaDirecciones Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError("Error in GetPersonaDirecciones Error:{@error}", error);
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpPost]
        [Authorize]
        [Consumes(MediaTypeNames.Application.Json)]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<PersonasDireccionDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> CreatePersonaDireccionItem([FromBody] PersonasDireccionInsertDto personasDireccionInsertDto)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
                var result = await _personasDireccionesService.CreatePersonaDireccionItem(personasDireccionInsertDto, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in CreatePersonaDireccionItem Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<PersonasDireccionDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in CreatePersonaDireccionItem Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError("Error in CreatePersonaDireccionItem Error:{@error}", error);
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpPut]
        [Authorize]
        [Consumes(MediaTypeNames.Application.Json)]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<PersonasDireccionDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> UpdatePersonaDireccionItem([FromBody] PersonasDireccionUpdateDto personasDireccionUpdateDto)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
                var result = await _personasDireccionesService.UpdatePersonaDireccionItem(personasDireccionUpdateDto, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in UpdatePersonaDireccionItem Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<PersonasDireccionDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in UpdatePersonaDireccionItem Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError("Error in UpdatePersonaDireccionItem Error:{@error}", error);
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpDelete("{direccionId}")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<PersonasDireccionDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> DeletePersonaDireccionItem([FromRoute] int direccionId)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
                var result = await _personasDireccionesService.DeletePersonaDireccionItem(direccionId, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in DeletePersonaDireccionItem Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<PersonasDireccionDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in DeletePersonaDireccionItem Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError("Error in DeletePersonaDireccionItem Error:{@error}", error);
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }
    }
}
