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
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<ICollection<AdmMenuRoleDto>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> GetCatalog()
        {
            try
            {
                // Get the role id from the claims
                var roleId = User.FindFirst(ClaimTypes.Role)?.Value ?? string.Empty;
                Result<ICollection<AdmMenuRoleDto>> result = await _menuService.GetRoleMenu(roleId);
                if (result.IsSuccess)
                {
                    _logger.LogInformation("Success in GetCatalogTwo Result:{@resut}", result.Value);
                    return Ok(new ResponseDto<ICollection<AdmMenuRoleDto>> { Result = result.Value });
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

    }
}
