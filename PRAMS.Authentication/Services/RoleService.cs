using FluentResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PRAMS.Authentication.Data;
using PRAMS.Authentication.Models;
using PRAMS.Authentication.Services.IServices;

namespace PRAMS.Authentication.Services
{
    public class RoleService : IRoleService
    {
        private readonly AppDbContext _db;
        private readonly RoleManager<ApplicationRole> _roleManager;

        public RoleService(AppDbContext db, RoleManager<ApplicationRole> roleManager)
        {
            _db = db;
            _roleManager = roleManager;
        }


        public async Task<Result<IList<ApplicationRole>>> GetRoles()
        {
            try
            {
                IList<ApplicationRole> roles = await _roleManager.Roles.ToListAsync();
                return Result.Ok(roles);
            }
            catch (Exception error)
            {
                return Result.Fail(error.Message);
            }
        }
    }
}
