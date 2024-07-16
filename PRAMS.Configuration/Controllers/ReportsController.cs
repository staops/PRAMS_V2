using FluentResults;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PRAMS.Application.Contract.SystemConfiguration;
using PRAMS.Domain.Entities.Shared;
using PRAMS.Domain.Entities.SystemConfiguration.Dto;
using PRAMS.Infraestructure.Services.SystemConfiguration;
using System.Net.Mime;
using System.Security.Claims;
namespace PRAMS.Configuration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        private readonly IRoleService _roleService;
        private readonly ILogger<ReportsController> _logger;

        public ReportsController(IRoleService roleService, ILogger<ReportsController> logger)
        {
            _roleService = roleService;
            _logger = logger;
        }

        [HttpGet("GetRoleReports")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<ICollection<AdmReportDto>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> GetReports()
        {
            try
            {
                // Get the role id from the claims
                var roleId = User.FindFirst(ClaimTypes.Role)?.Value ?? string.Empty;
                Result<ICollection<AdmReportDto>> result = await _roleService.GetRoleReports(roleId);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in GetRoleReports Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<ICollection<AdmReportDto>> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in GetRoleReports Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in GetRoleReports");
                return BadRequest(new ErrorResponseDto<List<IError>> { IsSuccess = false, Message = $"Error in GetRoleReports {error.Message}" });
            }
        }

        [HttpPost("CreateReportItem")]
        [Authorize(Roles = "SU")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<AdmReportDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> CreateReportItem([FromBody] AdmReportInsertDto admMenuElementDto)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;

                Result<AdmReportDto> result = await _roleService.CreateReportItem(admMenuElementDto, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in CreateReportItem Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<AdmReportDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in CreateReportItem Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in CreateReportItem");
                return BadRequest(new ErrorResponseDto<List<IError>> { IsSuccess = false, Message = $"Error in CreateReportItem {error.Message}" });
            }
        }

        [HttpPut("UpdateReportItem")]
        [Authorize(Roles = "SU")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<AdmReportDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> UpdateReportItem([FromBody] AdmReportUpdateDto admMenuElementDto)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;

                Result<AdmReportDto> result = await _roleService.UpdateReportItem(admMenuElementDto, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in UpdateReportItem Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<AdmReportDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in UpdateReportItem Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in UpdateReportItem");
                return BadRequest(new ErrorResponseDto<List<IError>> { IsSuccess = false, Message = $"Error in UpdateReportItem {error.Message}" });
            }
        }

        [HttpDelete("DeleteReportItem/{reportId}")]
        [Authorize(Roles = "SU")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<AdmReportDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> DeleteReportItem(int reportId)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;

                Result<AdmReportDto> result = await _roleService.DeleteReportItem(reportId, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in DeleteReportItem Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<AdmReportDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in DeleteReportItem Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in DeleteReportItem");
                return BadRequest(new ErrorResponseDto<List<IError>> { IsSuccess = false, Message = $"Error in DeleteReportItem {error.Message}" });
            }
        }

        [HttpGet("ListRolReportItems")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<ICollection<AdmReportsRoleDto>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> ListRolReportItems()
        {
            try
            {
                Result<ICollection<AdmReportsRoleDto>> result = await _roleService.ListRolReportItems();
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in ListRolReportItems Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<ICollection<AdmReportsRoleDto>> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in ListRolReportItems Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in ListRolReportItems");
                return BadRequest(new ErrorResponseDto<List<IError>> { IsSuccess = false, Message = $"Error in ListRolReportItems {error.Message}" });
            }
        }

        [HttpGet("ListRolReportItemsByRol/{rolId}")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<ICollection<AdmReportsRoleDto>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> ListRolReportItemsByRol(string rolId)
        {
            try
            {
                Result<ICollection<AdmReportsRoleDto>> result = await _roleService.ListRolReportItemsByRol(rolId);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in ListRolReportItemsByRol Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<ICollection<AdmReportsRoleDto>> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in ListRolReportItemsByRol Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in ListRolReportItemsByRol");
                return BadRequest(new ErrorResponseDto<List<IError>> { IsSuccess = false, Message = $"Error in ListRolReportItemsByRol {error.Message}" });
            }
        }

        [HttpPost("CreateRolReportItem")]
        [Authorize(Roles = "SU")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<AdmReportsRoleDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> CreateRolReportItem([FromBody] AdmReportsRoleInsertDto admReportsRoleInsertDto)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;

                Result<AdmReportsRoleDto> result = await _roleService.CreateRolReportItem(admReportsRoleInsertDto, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in CreateRolReportItem Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<AdmReportsRoleDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in CreateRolReportItem Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in CreateRolReportItem");
                return BadRequest(new ErrorResponseDto<List<IError>> { IsSuccess = false, Message = $"Error in CreateRolReportItem {error.Message}" });
            }
        }

        [HttpPut("UpdateRolReportItem")]
        [Authorize(Roles = "SU")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<AdmReportsRoleDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> UpdateRolReportItem([FromBody] AdmReportsRoleUpdateDto admReportsRoleUpdateDto)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;

                Result<AdmReportsRoleDto> result = await _roleService.UpdateRolReportItem(admReportsRoleUpdateDto, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in UpdateRolReportItem Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<AdmReportsRoleDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in UpdateRolReportItem Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in UpdateRolReportItem");
                return BadRequest(new ErrorResponseDto<List<IError>> { IsSuccess = false, Message = $"Error in UpdateRolReportItem {error.Message}" });
            }
        }

        [HttpDelete("DeleteRolReportItem/{reportRoleId}")]
        [Authorize(Roles = "SU")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<AdmReportsRoleDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> DeleteRolReportItem(int reportRoleId)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;

                Result<AdmReportsRoleDto> result = await _roleService.DeleteRolReportItem(reportRoleId, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in DeleteRolReportItem Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<AdmReportsRoleDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in DeleteRolReportItem Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in DeleteRolReportItem");
                return BadRequest(new ErrorResponseDto<List<IError>> { IsSuccess = false, Message = $"Error in DeleteRolReportItem {error.Message}" });
            }
        }

    }
}
