using AutoMapper;
using FluentResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PRAMS.Application.Contract.SystemConfiguration;
using PRAMS.Domain.Entities.SystemConfiguration.Dto;
using PRAMS.Infraestructure.Data.SystemConfiguration;

namespace PRAMS.Infraestructure.Services.SystemConfiguration
{
    public class MenuService : IMenuService
    {
        private readonly AppConfigDbContext _appConfigDbContext;
        private readonly IMapper _mapper;
        private readonly ILogger<IMenuService> _logger;

        public MenuService(AppConfigDbContext appConfigDbContext, IMapper mapper, ILogger<IMenuService> logger)
        {
            _appConfigDbContext = appConfigDbContext;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Result<ICollection<AdmMenuRoleDto>>> GetRoleMenu(string roleId)
        {
            try
            {
                var query = _appConfigDbContext.AdmMenuElements
                    .Include(i => i.AdmMenuRoles)
                    .Where(w => w.Activo == true)
                    .OrderBy(o => o.Orden)
                    .AsQueryable();

                var result = await query.ToListAsync();
                var mapped = _mapper.Map<ICollection<AdmMenuRoleDto>>(result);

                return Result.Ok(mapped);
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in GetRoleMenu");
                return Result.Fail(new Error($"Error in GetRoleMenu {error.Message}")).WithError(error.StackTrace);
            }
        }
    }
}
