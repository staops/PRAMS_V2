using FluentResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PRAMS.Authentication.Data;
using PRAMS.Authentication.Models;
using PRAMS.Authentication.Models.Dto;
using PRAMS.Authentication.Services.IServices;


namespace PRAMS.Authentication.Services
{
    public class AuthService(
        AppDbContext db,
        IJwtTokenGenerator jwtTokenGenerator,
        UserManager<ApplicationUser> userManager,
        RoleManager<ApplicationRole> roleManager) : IAuthService
    {
        private readonly AppDbContext _db = db;
        private readonly UserManager<ApplicationUser> _userManager = userManager;
        private readonly RoleManager<ApplicationRole> _roleManager = roleManager;
        private readonly IJwtTokenGenerator _jwtTokenGenerator = jwtTokenGenerator;

        public async Task<Result<bool>> AssignRole(string email, string roleName)
        {

            var user = _db.ApplicationUsers.FirstOrDefault(x => x.UserName != null && x.UserName.ToUpper() == email.ToUpper());
            if (user != null)
            {
                if (!_roleManager.RoleExistsAsync(roleName).GetAwaiter().GetResult())
                {
                    // Create the role if it does not exist
                    _roleManager.CreateAsync(new ApplicationRole(roleName)).GetAwaiter().GetResult();
                }

                await _userManager.AddToRoleAsync(user, roleName);
                return Result.Ok(true);
            }
            return Result.Fail<bool>("User not found or unauthorized");
        }

        public async Task<Result<bool>> AssignLocalAndRegion(string email, string local, string region)
        {
            var user = _db.ApplicationUsers.FirstOrDefault(x => x.UserName != null && x.UserName.ToUpper() == email.ToUpper());
            if (user != null)
            {
                user.Local = local;
                user.Region = region;
                await _db.SaveChangesAsync();
                return Result.Ok(true);
            }
            return Result.Fail<bool>("User not found or unauthorized");
        }

        public async Task<Result<LoginResponseDto>> CheckToken(string token)
        {
            try
            {
                // Remove the Bearer prefix
                token = token.Replace("Bearer ", "");

                string? tokenValidation = _jwtTokenGenerator.ValidateToken(token);
                if (tokenValidation != null)
                {
                    ApplicationUser? user = await _userManager.FindByIdAsync(tokenValidation);
                    if (user != null)
                    {
                        var roles = await _userManager.GetRolesAsync(user);
                        UserDto userDto = new()
                        {
                            ID = user.Id,
                            Email = user.Email,
                            Name = user.FirstName,
                            PhoneNumber = user.PhoneNumber,
                            Roles = roles,
                            Region = user.Region ?? string.Empty,
                            Local = user.Local ?? string.Empty
                        };

                        LoginResponseDto loginResponseDto = new()
                        {
                            User = userDto,
                            Token = token,
                        };

                        return Result.Ok(loginResponseDto);
                    }
                }
                return Result.Fail<LoginResponseDto>("Invalid token");
            }
            catch (Exception error)
            {
                return Result.Fail(error.Message);
            }
        }

        public async Task<Result<LoginResponseDto>> LoginAsync(LoginRequestDto loginRequestDto)
        {
            try
            {
                ApplicationUser? user = _db.ApplicationUsers.FirstOrDefault(x => x.UserName != null && x.UserName.ToUpper() == loginRequestDto.UserName.ToUpper());
                if (user is not null)
                {
                    bool isPasswordValid = await _userManager.CheckPasswordAsync(user, loginRequestDto.Password);
                    if (user == null)
                    {
                        return Result.Fail("Invalid credentials");
                    }
                    if (!isPasswordValid)
                    {
                        await _userManager.AccessFailedAsync(user);
                        return Result.Fail("Invalid credentials");
                    }

                    // Log user login in NetUserLogins table


                    // If user was found, generate JWT token
                    var roles = await _userManager.GetRolesAsync(user);
                    var token = _jwtTokenGenerator.CreateToken(user, roles);

                    UserDto userDto = new()
                    {
                        ID = user.Id,
                        Email = user.Email,
                        Name = user.FirstName,
                        PhoneNumber = user.PhoneNumber,
                        Roles = roles,
                        Region = user.Region ?? string.Empty,
                        Local = user.Local ?? string.Empty
                    };

                    LoginResponseDto loginResponseDto = new()
                    {
                        User = userDto,
                        Token = token,
                    };

                    return Result.Ok(loginResponseDto);
                }
                else
                {
                    return Result.Fail("Invalid credentials");
                }
            }
            catch (Exception error)
            {
                return Result.Fail(error.Message);
            }
        }

        public async Task<Result<UserDto>> RegisterUserAsync(RegistrationRequestDto registrationRequiredDto)
        {
            try
            {
                Result<UserDto> result = new();

                ApplicationUser user = new()
                {
                    FirstName = registrationRequiredDto.FirstName,
                    LastName = registrationRequiredDto.LastName,
                    SecondLastName = registrationRequiredDto.SecondLastName,
                    Initial = registrationRequiredDto.Initial,
                    UserName = registrationRequiredDto.Email,
                    Email = registrationRequiredDto.Email,
                    NormalizedEmail = registrationRequiredDto.Email.ToUpper(),
                    Region = registrationRequiredDto.Region,
                    Local = registrationRequiredDto.Local,
                    PhoneNumber = registrationRequiredDto.PhoneNumber
                };

                var creationResult = await _userManager.CreateAsync(user, registrationRequiredDto.Password);
                if (creationResult.Succeeded)
                {
                    var userToReturn = await _db.Users
                        .Where(x => x.Email == registrationRequiredDto.Email)
                        .FirstOrDefaultAsync();

                    if (userToReturn is not null)
                    {
                        string requiredRole = registrationRequiredDto.Role?.ToUpper() ?? "USER";

                        // Validate if role exists
                        if (!_roleManager.RoleExistsAsync(requiredRole).GetAwaiter().GetResult())
                        {
                            // Create the role if it does not exist
                            _roleManager.CreateAsync(new ApplicationRole(requiredRole)).GetAwaiter().GetResult();
                        }

                        var roleResult = await _userManager.AddToRoleAsync(userToReturn, requiredRole);
                        if (userToReturn != null && roleResult != null)
                        {
                            {
                                // Get the user roles
                                var roles = await _userManager.GetRolesAsync(userToReturn);

                                UserDto userDto = new()
                                {
                                    ID = userToReturn.Id,
                                    Email = userToReturn.Email,
                                    Name = userToReturn.FirstName,
                                    PhoneNumber = userToReturn.PhoneNumber,
                                    Roles = roles,
                                    Region = registrationRequiredDto.Region,
                                    Local = registrationRequiredDto.Local
                                };

                                result = Result.Ok(userDto);
                            }

                        }
                        else
                        {
                            result = Result.Fail("User registration failed");
                        }

                    }
                    else
                    {
                        result = Result.Fail("User registration failed");
                    }
                }
                else
                {
                    result = Result.Fail(string.Join(' ', creationResult.Errors.Select(s => s.Description)));
                }

                return result;
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
                throw;
            }

        }


    }
}
