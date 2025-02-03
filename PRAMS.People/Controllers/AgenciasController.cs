using FluentResults;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PRAMS.Application.Contract.Agencies;
using PRAMS.Domain.Entities.Agencies.Dto;
using PRAMS.Domain.Entities.Shared;
using System.Net.Mime;
using System.Security.Claims;

namespace PRAMS.People.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgenciasController : ControllerBase
    {
        private readonly IAgenciasService _agenciasService;
        private readonly ILogger<AgenciasController> _logger;

        public AgenciasController(IAgenciasService agenciasService, ILogger<AgenciasController> logger)
        {
            _agenciasService = agenciasService;
            _logger = logger;
        }

        [HttpGet]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<ICollection<AgenciaDto>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> ListAgencias()
        {
            try
            {
                var result = await _agenciasService.ListAgencias();
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in ListAgencias Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<ICollection<AgenciaDto>> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in ListAgencias Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError("Error in ListAgencias Error:{@error}", error);
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpGet("{id}")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<AgenciaDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> GetAgencia([FromRoute] int id)
        {
            try
            {
                var result = await _agenciasService.GetAgencia(id);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in GetAgencia Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<AgenciaDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in GetAgencia Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError("Error in GetAgencia Error:{@error}", error);
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpPost("paged")]
        [Authorize]
        [Consumes(MediaTypeNames.Application.Json)]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<DtResult<AgenciaDto>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> ListAgencias([FromBody] FilterCriteria filterCriteria)
        {
            try
            {
                var result = await _agenciasService.ListAgencias(filterCriteria);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in ListAgencias Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<DtResult<AgenciaDto>> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in ListAgencias Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError("Error in ListAgencias Error:{@error}", error);
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpPost]
        [Authorize]
        [Consumes(MediaTypeNames.Application.Json)]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<AgenciaDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> InsertAgencia([FromBody] AgenciaInsertDto agenciaInsertDto)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
                var result = await _agenciasService.InsertAgencia(agenciaInsertDto, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in InsertAgencia Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<AgenciaDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in InsertAgencia Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError("Error in InsertAgencia Error:{@error}", error);
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpPut]
        [Authorize]
        [Consumes(MediaTypeNames.Application.Json)]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<AgenciaDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> UpdateAgencia([FromBody] AgenciaUpdateDto agenciaUpdateDto)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
                var result = await _agenciasService.UpdateAgencia(agenciaUpdateDto, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in UpdateAgencia Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<AgenciaDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in UpdateAgencia Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError("Error in UpdateAgencia Error:{@error}", error);
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpDelete("{id}")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<AgenciaDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> DeleteAgencia([FromRoute] int id)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
                var result = await _agenciasService.DeleteAgencia(id, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in DeleteAgencia Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<AgenciaDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in DeleteAgencia Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError("Error in DeleteAgencia Error:{@error}", error);
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpGet]
        [Route("activeAgencies")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<ICollection<AgenciaDto>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> ListActiveAgencies()
        {
            try
            {
                var result = await _agenciasService.ListAgenciasActivas();
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in ListActiveAgencies Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<ICollection<AgenciaDto>> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in ListActiveAgencies Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError("Error in ListActiveAgencies Error:{@error}", error);
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpGet]
        [Route("inactiveAgencies")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<ICollection<AgenciaDto>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> ListInactiveAgencies()
        {
            try
            {
                var result = await _agenciasService.ListAgenciasInactivas();
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in ListInactiveAgencies Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<ICollection<AgenciaDto>> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in ListInactiveAgencies Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError("Error in ListInactiveAgencies Error:{@error}", error);
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpPut]
        [Route("deactivate/{id}")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<AgenciaDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> DeactivateAgencia([FromRoute] int id)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
                var result = await _agenciasService.SetAgenciaFechaFin(id, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in DeactivateAgencia Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<AgenciaDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in DeactivateAgencia Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError("Error in DeactivateAgencia Error:{@error}", error);
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

        [HttpPost]
        [Route("search")]
        [Authorize]
        [Consumes(MediaTypeNames.Application.Json)]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<DtResult<AgenciaDto>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> SearchAgencias([FromBody] AgenciaSearchDto filterCriteria)
        {
            try
            {
                var result = await _agenciasService.SearchAgenciaItem(filterCriteria);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in SearchAgencias Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<ICollection<AgenciaDto>> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in SearchAgencias Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError("Error in SearchAgencias Error:{@error}", error);
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });
            }
        }

    }
}
