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
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<ICollection<AdmMenuRoleDto>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> GetCatalog()
        {
            try
            {
                // Get the role id from the claims
                var roleId = User.FindFirst(ClaimTypes.Role)?.Value ?? string.Empty;
                var result = await _menuService.GetRoleMenu(roleId);
                return Ok(Result.Ok(result));

            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in GetRoleMenu");
                return BadRequest(Result.Fail(new Error($"Error in GetRoleMenu {error.Message}")).WithError(error.StackTrace));
            }
        }

    }
}
