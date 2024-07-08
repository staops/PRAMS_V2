using AutoMapper;
using FluentResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PRAMS.Application.Contract.SystemConfiguration;
using PRAMS.Domain.Entities.SystemConfiguration.Dto;
using PRAMS.Domain.Models.SystemConfiguration;
using PRAMS.Infraestructure.Data.SystemConfiguration;

namespace PRAMS.Infraestructure.Services.SystemConfiguration
{
    public class RoleService : IRoleService
    {
        private readonly AppConfigDbContext _appConfigDbContext;
        private readonly IMapper _mapper;
        private readonly ILogger<IMenuService> _logger;

        public RoleService(AppConfigDbContext appConfigDbContext, IMapper mapper, ILogger<IMenuService> logger)
        {
            _appConfigDbContext = appConfigDbContext;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Result<ICollection<AdmReportDto>>> GetRoleReports(string roleId)
        {
            try
            {
                var query = _appConfigDbContext.AdmReports
                    .Include(i => i.AdmReportsRoles.Where(w => w.Activo == true))
                    .Where(w =>
                        w.Activo == true &&
                        _appConfigDbContext.AdmReportsRoles
                            .Where(w => w.RoleId == roleId && w.Activo == true)
                            .Select(s => s.ReportId)
                            .Contains(w.ReportId)
                     )
                    .OrderBy(w => w.Orden)
                    .AsQueryable();

                var result = await query.ToListAsync();
                var mapped = _mapper.Map<ICollection<AdmReportDto>>(result);

                return Result.Ok(mapped);
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in GetRoleMenu");
                return Result.Fail(new Error($"Error in GetRoleMenu {error.Message}")).WithError(error.StackTrace);
            }
        }

        public async Task<Result<AdmReportDto>> CreateReportItem(AdmReportInsertDto admReportInsertDto, string user)
        {
            try
            {
                // Map the dto to the entity
                var objToCreate = _mapper.Map<AdmReports>(admReportInsertDto);
                objToCreate.CreateUser = user;
                objToCreate.CreateDate = DateTime.Now;

                // Insert the item
                await _appConfigDbContext.AdmReports.AddAsync(objToCreate);
                await _appConfigDbContext.SaveChangesAsync();

                return Result.Ok(_mapper.Map<AdmReportDto>(objToCreate));
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in CreateReportItem");
                return Result.Fail(new Error($"Error in CreateReportItem {error.Message}")).WithError(error.StackTrace);
            }
        }

        public async Task<Result<AdmReportDto>> UpdateReportItem(AdmReportUpdateDto admReportUpdateDto, string user)
        {
            try
            {
                // Validate if the item already exists
                var item = await _appConfigDbContext.AdmReports
                    .FirstOrDefaultAsync(f => f.ReportId == admReportUpdateDto.ReportId && f.Activo == true);

                if (item is not null)
                {
                    // Merge the item with the new values from the dto using automapper
                    var mapped = _mapper.Map(admReportUpdateDto, item);

                    // Update the item
                    _appConfigDbContext.AdmReports.Update(mapped);
                    await _appConfigDbContext.SaveChangesAsync();

                    return Result.Ok(_mapper.Map<AdmReportDto>(mapped));
                }
                else
                {
                    return Result.Fail(new Error($"Report with id {admReportUpdateDto.ReportId} not found"));
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in UpdateReportItem");
                return Result.Fail(new Error($"Error in UpdateReportItem {error.Message}")).WithError(error.StackTrace);
            }
        }

        public async Task<Result<AdmReportDto>> DeleteReportItem(int reportId, string user)
        {
            try
            {
                // Validate if the item already exists
                var item = await _appConfigDbContext.AdmReports
                    .FirstOrDefaultAsync(f => f.ReportId == reportId && f.Activo == true);

                if (item is not null)
                {
                    // Update the item to inactive
                    item.Activo = false;
                    _appConfigDbContext.AdmReports.Update(item);
                    await _appConfigDbContext.SaveChangesAsync();

                    return Result.Ok(_mapper.Map<AdmReportDto>(item));
                }
                else
                {
                    return Result.Fail(new Error($"Report with id {reportId} not found"));
                }

            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in DeleteReportItem");
                return Result.Fail(new Error($"Error in DeleteReportItem {error.Message}")).WithError(error.StackTrace);
            }
        }

        public async Task<Result<ICollection<AdmReportsRoleDto>>> ListRolReportItems()
        {
            try
            {
                var query = _appConfigDbContext.AdmReportsRoles
                    .Include(i => i.AdmReports)
                    .Where(w => w.Activo == true)
                    .OrderBy(w => w.ReportRoleId)
                    .AsQueryable();

                var result = await query.ToListAsync();
                var mapped = _mapper.Map<ICollection<AdmReportsRoleDto>>(result);

                return Result.Ok(mapped);

            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in ListRolReportItems");
                return Result.Fail(new Error($"Error in ListRolReportItems {error.Message}")).WithError(error.StackTrace);
            }
        }

        public async Task<Result<ICollection<AdmReportsRoleDto>>> ListRolReportItemsByRol(string rolId)
        {
            try
            {
                var query = _appConfigDbContext.AdmReportsRoles
                    .Include(i => i.AdmReports)
                    .Where(w => w.Activo == true && w.RoleId == rolId)
                    .OrderBy(w => w.ReportRoleId)
                    .AsQueryable();

                var result = await query.ToListAsync();
                var mapped = _mapper.Map<ICollection<AdmReportsRoleDto>>(result);

                return Result.Ok(mapped);

            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in ListRolReportItemsByRol");
                return Result.Fail(new Error($"Error in ListRolReportItemsByRol {error.Message}")).WithError(error.StackTrace);
            }
        }

        public async Task<Result<AdmReportsRoleDto>> CreateRolReportItem(AdmReportsRoleInsertDto admReportsRoleInsertDto, string user)
        {
            try
            {
                // Validate if the item already exists
                var item = await _appConfigDbContext.AdmReportsRoles
                    .FirstOrDefaultAsync(f => f.ReportId == admReportsRoleInsertDto.ReportId && f.RoleId == admReportsRoleInsertDto.RoleId && f.Activo == true);

                if (item is null)
                {
                    // Map the dto to the entity
                    var objToCreate = _mapper.Map<AdmReportsRole>(admReportsRoleInsertDto);
                    objToCreate.CreateUser = user;
                    objToCreate.CreateDate = DateTime.Now;

                    // Insert the item
                    await _appConfigDbContext.AdmReportsRoles.AddAsync(objToCreate);
                    await _appConfigDbContext.SaveChangesAsync();

                    var created = _appConfigDbContext.AdmReportsRoles
                        .Include(i => i.AdmReports)
                        .FirstOrDefault(f => f.ReportRoleId == objToCreate.ReportRoleId);

                    return Result.Ok(_mapper.Map<AdmReportsRoleDto>(created));
                }
                else
                {
                    return Result.Fail(new Error($"Report with id {admReportsRoleInsertDto.ReportId} and Role with id {admReportsRoleInsertDto.RoleId} already exists"));
                }

            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in CreateRolReportItem");
                return Result.Fail(new Error($"Error in CreateRolReportItem {error.Message}")).WithError(error.StackTrace);
            }
        }

        public async Task<Result<AdmReportsRoleDto>> UpdateRolReportItem(AdmReportsRoleUpdateDto admReportsRoleUpdateDto, string user)
        {
            try
            {
                // Validate if the item already exists
                var item = await _appConfigDbContext.AdmReportsRoles
                    .FirstOrDefaultAsync(f => f.ReportRoleId == admReportsRoleUpdateDto.ReportRoleId && f.Activo == true);

                if (item is not null)
                {
                    // Merge the item with the new values from the dto using automapper
                    var mapped = _mapper.Map(admReportsRoleUpdateDto, item);

                    // Update the item
                    _appConfigDbContext.AdmReportsRoles.Update(mapped);
                    await _appConfigDbContext.SaveChangesAsync();

                    var updated = _appConfigDbContext.AdmReportsRoles
                        .Include(i => i.AdmReports)
                        .FirstOrDefault(f => f.ReportRoleId == mapped.ReportRoleId);

                    return Result.Ok(_mapper.Map<AdmReportsRoleDto>(updated));
                }
                else
                {
                    return Result.Fail(new Error($"Report with id {admReportsRoleUpdateDto.ReportRoleId} not found"));
                }

            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in UpdateRolReportItem");
                return Result.Fail(new Error($"Error in UpdateRolReportItem {error.Message}")).WithError(error.StackTrace);
            }
        }

        public async Task<Result<AdmReportsRoleDto>> DeleteRolReportItem(int rReportRoleId, string user)
        {
            try
            {
                // Validate if the item already exists
                var item = await _appConfigDbContext.AdmReportsRoles
                    .FirstOrDefaultAsync(f => f.ReportRoleId == rReportRoleId && f.Activo == true);

                if (item is not null)
                {
                    // Update the item to inactive
                    item.Activo = false;
                    _appConfigDbContext.AdmReportsRoles.Update(item);
                    await _appConfigDbContext.SaveChangesAsync();

                    return Result.Ok(_mapper.Map<AdmReportsRoleDto>(item));
                }
                else
                {
                    return Result.Fail(new Error($"Report with id {rReportRoleId} not found"));
                }

            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in DeleteRolReportItem");
                return Result.Fail(new Error($"Error in DeleteRolReportItem {error.Message}")).WithError(error.StackTrace);
            }
        }
    }
}
