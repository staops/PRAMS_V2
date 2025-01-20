using FluentResults;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PRAMS.Authentication.Models.Dto;
using PRAMS.Authentication.Services.IServices;
using System.Net.Mime;

namespace PRAMS.Authentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(IAuthService authService) : ControllerBase
    {
        private readonly IAuthService _authService = authService;

        [HttpPost("register")]
        [Consumes(MediaTypeNames.Application.Json)]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<UserDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ResponseDto<List<IError>>))]
        public async Task<IActionResult> Register([FromBody] RegistrationRequestDto registrationRequiredDto)
        {
            if (ModelState.IsValid)
            {
                Result<UserDto> errorMesage = await _authService.RegisterUserAsync(registrationRequiredDto);
                return errorMesage.IsSuccess ? Ok(new ResponseDto<UserDto> { Result = errorMesage.Value })
                    : BadRequest(new ResponseDto<List<IError>> { IsSuccess = false, Message = errorMesage.Errors.First().Message });
            }
            // Return message "Invalid model" if the model is invalid and the invalid fields
            List<IError> requiredFields = ModelState.Values.SelectMany(x => x.Errors).Select(x => (IError)new Error(x.ErrorMessage)).ToList();
            return BadRequest(new ResponseDto<List<IError>> { IsSuccess = false, Message = "Invalid model", Result = requiredFields });
        }

        [HttpPost("login")]
        [Consumes(MediaTypeNames.Application.Json)]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<LoginResponseDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ResponseDto<List<IError>>))]
        public async Task<IActionResult> Login([FromBody] LoginRequestDto loginRequestDto)
        {
            Result<LoginResponseDto> loginResponse = await _authService.LoginAsync(loginRequestDto);
            return loginResponse.IsSuccess ? Ok(new ResponseDto<LoginResponseDto> { Result = loginResponse.Value })
                : BadRequest(new ResponseDto<List<IError>> { IsSuccess = false, Message = loginResponse.Errors.First().Message });

        }

        [HttpGet("CheckToken")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<LoginResponseDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 401)]
        [Authorize]
        public async Task<IActionResult> CheckToken()
        {
            string? token = HttpContext.Request.Headers.Authorization;
            if (!string.IsNullOrEmpty(token))
            {
                Result<LoginResponseDto> checkToken = await _authService.CheckToken(token);
                return checkToken.IsSuccess ? Ok(new ResponseDto<LoginResponseDto> { Result = checkToken.Value })
                    : BadRequest(new ResponseDto<List<IError>> { IsSuccess = false, Message = checkToken.Errors.First().Message });
            }
            return BadRequest(new ResponseDto<List<IError>> { IsSuccess = false, Message = "Token is required" });
        }

        [HttpPost("AssignRole")]
        [Consumes(MediaTypeNames.Application.Json)]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<bool>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 401)]
        [ProducesResponseType(statusCode: 403)]
        [Authorize(Roles = "SU")]
        public async Task<IActionResult> AssignRole([FromBody] SetRoleRequestDto model)
        {
            // Return message "Role assigned successfully" if the role is assigned successfully
            Result<bool> asignRole = await _authService.AssignRole(model.Email, model.Role.ToUpper());
            return asignRole.IsSuccess ? Ok(new ResponseDto<bool>
            {
                Result = asignRole.Value,
                Message = "Role assigned successfully"
            })
                : BadRequest(new ResponseDto<List<IError>> { IsSuccess = false, Message = asignRole.Errors.First().Message });
        }

        [HttpPost("AssignLocalAndRegion")]
        [Consumes(MediaTypeNames.Application.Json)]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<bool>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ResponseDto<List<IError>>))]
        [ProducesResponseType(statusCode: 401)]
        [ProducesResponseType(statusCode: 403)]
        [Authorize(Roles = "SU")]
        public async Task<IActionResult> AssignLocalAndRegion([FromBody] SetLocalAndRegionRequestDto model)
        {
            // Return message "Local and region assigned successfully" if the local and region are assigned successfully
            Result<bool> asignLocalAndRegion = await _authService.AssignLocalAndRegion(model.Email, model.Local, model.Region);
            return asignLocalAndRegion.IsSuccess ? Ok(new ResponseDto<bool>
            {
                Result = asignLocalAndRegion.Value,
                Message = "Local and region assigned successfully"
            })
                : BadRequest(new ResponseDto<List<IError>> { IsSuccess = false, Message = asignLocalAndRegion.Errors.First().Message });
        }
    }
}
