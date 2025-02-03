using FluentResults;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PRAMS.Authentication.Models.Dto;
using PRAMS.Authentication.Services.IServices;
using PRAMS.Domain.Entities.Shared;
using System.Net.Mime;

namespace PRAMS.Authentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ILogger<UsersController> _logger;

        public UsersController(IUserService userService, ILogger<UsersController> logger)
        {
            _userService = userService;
            _logger = logger;
        }


        [HttpPost("paged")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<DtResult<UserDto>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(ErrorResponseDto<List<IError>>))]
        [Authorize]
        public async Task<IActionResult> ListUsersPaged([FromBody] FilterCriteria filterCriteria)
        {
            try
            {
                var result = await _userService.ListUsersPaged(filterCriteria);
                return Ok(new ResponseDto<DtResult<UserDto>>() { Result = result.Value });
            }
            catch (Exception error)
            {
                _logger.LogError("Error in ListUsersPaged Error:{@error}", error);
                return StatusCode(500, new ErrorResponseDto<List<IError>>() { Message = error.Message, Result = [new Error(error.Message)] });

            }
        }


    }
}
