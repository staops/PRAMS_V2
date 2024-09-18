using FluentResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PRAMS.Authentication.Data;
using PRAMS.Authentication.Services.IServices;

namespace PRAMS.Authentication.Services
{
    public class RoleService : IRoleService
    {
        private readonly AppDbContext _db;
        private readonly RoleManager<IdentityRole> _roleManager;

        public RoleService(AppDbContext db, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _roleManager = roleManager;
        }


        public async Task<Result<IList<IdentityRole>>> GetRoles()
        {
            try
            {
                IList<IdentityRole> roles = await _roleManager.Roles.ToListAsync();
                return Result.Ok(roles);
            }
            catch (Exception error)
            {
                return Result.Fail(error.Message);
            }
        }
    }
}
