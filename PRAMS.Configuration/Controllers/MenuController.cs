using FluentResults;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PRAMS.Application.Contract.SystemConfiguration;
using PRAMS.Domain.Entities.Shared;
using PRAMS.Domain.Entities.SystemConfiguration.Dto;
using System.Net.Mime;
using System.Security.Claims;

namespace PRAMS.Configuration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IMenuService _menuService;
        private readonly ILogger<MenuController> _logger;

        public MenuController(IMenuService menuService, ILogger<MenuController> logger)
        {
            _menuService = menuService;
            _logger = logger;
        }

        [HttpGet("GetRoleMenu")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<ICollection<AdmMenuElementDto>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> GetCatalog()
        {
            try
            {
                // Get the role id from the claims
                var roleId = User.FindFirst(ClaimTypes.Role)?.Value ?? string.Empty;
                Result<ICollection<AdmMenuElementDto>> result = await _menuService.GetRoleMenu(roleId);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in GetCatalogTwo Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<ICollection<AdmMenuElementDto>> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in GetCatalogTwo Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in GetRoleMenu");
                return BadRequest(Result.Fail(new Error($"Error in GetRoleMenu {error.Message}")).WithError(error.StackTrace));
            }
        }

        [HttpPost("CreateMenuItem")]
        [Authorize(Roles = "SU")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<AdmMenuInsertDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> CreateMenuItem([FromBody] AdmMenuInsertDto admMenuRoleInsertDto)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;

                Result<AdmMenuElementDto> result = await _menuService.CreateMenuItem(admMenuRoleInsertDto, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in CreateMenuItem Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<AdmMenuElementDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in CreateMenuItem Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in CreateMenuItem");
                return BadRequest(Result.Fail(new Error($"Error in CreateMenuItem {error.Message}")).WithError(error.StackTrace));
            }
        }

        [HttpPut("UpdateMenuItem")]
        [Authorize(Roles = "SU")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<AdmMenuInsertDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> UpdateMenuItem([FromBody] AdmMenuUpdateDto admMenuRoleInsertDto)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;

                Result<AdmMenuElementDto> result = await _menuService.UpdateMenuItem(admMenuRoleInsertDto, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in UpdateMenuItem Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<AdmMenuElementDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in UpdateMenuItem Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in UpdateMenuItem");
                return BadRequest(Result.Fail(new Error($"Error in UpdateMenuItem {error.Message}")).WithError(error.StackTrace));
            }
        }

        [HttpDelete("DeleteMenuItem/{menuElementId}")]
        [Authorize(Roles = "SU")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<AdmMenuInsertDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> DeleteMenuItem(int menuElementId)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;

                Result<AdmMenuElementDto> result = await _menuService.DeleteMenuItem(menuElementId, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in DeleteMenuItem Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<AdmMenuElementDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in DeleteMenuItem Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in DeleteMenuItem");
                return BadRequest(Result.Fail(new Error($"Error in DeleteMenuItem {error.Message}")).WithError(error.StackTrace));
            }
        }

        [HttpGet("ListRolMenuItems")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<ICollection<AdmMenuRoleDto>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> ListRolMenuItems()
        {
            try
            {
                Result<ICollection<AdmMenuRoleDto>> result = await _menuService.ListRolMenuItems();
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in ListRolMenuItems Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<ICollection<AdmMenuRoleDto>> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in ListRolMenuItems Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in ListRolMenuItems");
                return BadRequest(Result.Fail(new Error($"Error in ListRolMenuItems {error.Message}")).WithError(error.StackTrace));
            }
        }

        [HttpGet("ListRolMenuItemsByRol/{rolId}")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<ICollection<AdmMenuRoleDto>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> ListRolMenuItemsByRol(string rolId)
        {
            try
            {
                Result<ICollection<AdmMenuRoleDto>> result = await _menuService.ListRolMenuItemsByRol(rolId);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in ListRolMenuItemsByRol Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<ICollection<AdmMenuRoleDto>> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in ListRolMenuItemsByRol Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in ListRolMenuItemsByRol");
                return BadRequest(Result.Fail(new Error($"Error in ListRolMenuItemsByRol {error.Message}")).WithError(error.StackTrace));
            }
        }

        [HttpPost("CreateRolMenuItem")]
        [Authorize(Roles = "SU")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<AdmMenuRoleDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> CreateRolMenuItem([FromBody] AdmMenuRoleInsertDto admMenuRoleDto)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;

                Result<AdmMenuRoleDto> result = await _menuService.CreateRolMenuItem(admMenuRoleDto, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in CreateRolMenuItem Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<AdmMenuRoleDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in CreateRolMenuItem Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in CreateRolMenuItem");
                return BadRequest(Result.Fail(new Error($"Error in CreateRolMenuItem {error.Message}")).WithError(error.StackTrace));
            }
        }

        [HttpPut("UpdateRolMenuItem")]
        [Authorize(Roles = "SU")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<AdmMenuRoleDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> UpdateRolMenuItem([FromBody] AdmMenuRoleUpdateDto admMenuRoleDto)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;

                Result<AdmMenuRoleDto> result = await _menuService.UpdateRolMenuItem(admMenuRoleDto, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in UpdateRolMenuItem Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<AdmMenuRoleDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in UpdateRolMenuItem Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in UpdateRolMenuItem");
                return BadRequest(Result.Fail(new Error($"Error in UpdateRolMenuItem {error.Message}")).WithError(error.StackTrace));
            }
        }

        [HttpDelete("DeleteRolMenuItem/{menuElementId}")]
        [Authorize(Roles = "SU")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<AdmMenuRoleDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> DeleteRolMenuItem(int menuElementId)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;

                Result<AdmMenuRoleDto> result = await _menuService.DeleteRolMenuItem(menuElementId, user);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in DeleteRolMenuItem Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<AdmMenuRoleDto> { Result = result.Value });
                }
                else
                {
                    _logger.LogError("Error in DeleteRolMenuItem Error:{@error}", result.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in DeleteRolMenuItem");
                return BadRequest(Result.Fail(new Error($"Error in DeleteRolMenuItem {error.Message}")).WithError(error.StackTrace));
            }
        }

    }
}
