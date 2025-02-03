using FluentResults;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PRAMS.Authentication.Models;
using PRAMS.Authentication.Services.IServices;
using PRAMS.Domain.Entities.Shared;
using System.Net.Mime;

namespace PRAMS.Authentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IRoleService _roleService;
        private readonly ILogger<RolesController> _logger;

        public RolesController(IRoleService roleService, ILogger<RolesController> logger)
        {
            _roleService = roleService;
            _logger = logger;
        }

        [HttpGet("GetRoles")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<IList<ApplicationRole>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ResponseDto<List<IError>>))]
        public async Task<IActionResult> GetRoles()
        {
            var result = await _roleService.GetRoles();
            if (result.IsSuccess)
            {
                _logger.LogInformation("Success in GetRoles Result:{@result}", result.Value);
                return Ok(new ResponseDto<IList<ApplicationRole>> { Result = result.Value });

            }
            else
            {
                _logger.LogError("Error in GetRoles Errors:{@errors}", result.Errors);
                return BadRequest(new ResponseDto<List<IError>> { Message = result.Errors.First().Message, Result = result.Errors });
            }
        }
    }
}
