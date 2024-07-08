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

        public async Task<Result<ICollection<AdmMenuElementDto>>> GetRoleMenu(string roleId)
        {
            try
            {
                var query = _appConfigDbContext.AdmMenuElements
                    .Include(i => i.AdmMenuChildElements
                                    .Where(w => _appConfigDbContext.AdmMenuRoles
                                                .Where(ww => ww.RoleId == roleId && ww.Activo == true)
                                                .Select(s => s.MenuElementId)
                                                .Contains(w.MenuElementId))
                            )
                    .Include("AdmMenuChildElements.AdmMenuChildElements")
                                    .Where(w => _appConfigDbContext.AdmMenuRoles
                                                .Where(ww => ww.RoleId == roleId && ww.Activo == true)
                                                .Select(s => s.MenuElementId)
                                                .Contains(w.MenuElementId))
                    .Where(w =>
                           w.Activo == true &&
                           w.MenuElementParentId == null &&
                           _appConfigDbContext.AdmMenuRoles
                                .Where(ww => ww.RoleId == roleId && ww.Activo == true)
                                .Select(s => s.MenuElementId)
                                .Contains(w.MenuElementId)
                           )
                    .OrderBy(o => o.Orden)
                    .AsQueryable();

                var result = await query.ToListAsync();
                var mapped = _mapper.Map<ICollection<AdmMenuElementDto>>(result);

                return Result.Ok(mapped);
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in GetRoleMenu");
                return Result.Fail(new Error($"Error in GetRoleMenu {error.Message}")).WithError(error.StackTrace);
            }
        }

        public async Task<Result<AdmMenuElementDto>> UpdateMenuItem(AdmMenuUpdateDto admMenuRoleInsertDto, string user)
        {
            try
            {
                // Validate if the item already exists
                var item = await _appConfigDbContext.AdmMenuElements
                    .FirstOrDefaultAsync(f => f.MenuElementId == admMenuRoleInsertDto.MenuElementId && f.Activo == true);

                if (item is not null)
                {
                    // Merge the item with the new values from the dto using automapper
                    var mapped = _mapper.Map(admMenuRoleInsertDto, item);

                    // Update the item
                    _appConfigDbContext.AdmMenuElements.Update(mapped);
                    await _appConfigDbContext.SaveChangesAsync();

                    return Result.Ok(_mapper.Map<AdmMenuElementDto>(mapped));
                }
                else
                {
                    return Result.Fail(new Error($"Item with id {admMenuRoleInsertDto.MenuElementId} not found"));
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in UpdateMenuItem");
                return Result.Fail(new Error($"Error in UpdateMenuItem {error.Message}")).WithError(error.StackTrace);
            }
        }

        public async Task<Result<AdmMenuElementDto>> CreateMenuItem(AdmMenuInsertDto admMenuRoleInsertDto, string user)
        {
            try
            {
                // Map the dto to the entity
                var objToInsert = _mapper.Map<AdmMenuElements>(admMenuRoleInsertDto);
                objToInsert.CreateDate = DateTime.Now;
                objToInsert.CreateUser = user;

                // Insert the item
                await _appConfigDbContext.AdmMenuElements.AddAsync(objToInsert);
                await _appConfigDbContext.SaveChangesAsync();

                return Result.Ok(_mapper.Map<AdmMenuElementDto>(objToInsert));
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in CreateMenuItem");
                return Result.Fail(new Error($"Error in CreateMenuItem {error.Message}")).WithError(error.StackTrace);
            }
        }

        public async Task<Result<AdmMenuElementDto>> DeleteMenuItem(int menuElementId, string user)
        {
            try
            {
                // Validate if the item already exists
                var item = await _appConfigDbContext.AdmMenuElements
                    .FirstOrDefaultAsync(f => f.MenuElementId == menuElementId && f.Activo == true);

                if (item is not null)
                {
                    // Update the item to inactive
                    item.Activo = false;
                    _appConfigDbContext.AdmMenuElements.Update(item);
                    await _appConfigDbContext.SaveChangesAsync();

                    return Result.Ok(_mapper.Map<AdmMenuElementDto>(item));
                }
                else
                {
                    return Result.Fail(new Error($"Item with id {menuElementId} not found"));
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in DeleteMenuItem");
                return Result.Fail(new Error($"Error in DeleteMenuItem {error.Message}")).WithError(error.StackTrace);
            }
        }

        public async Task<Result<ICollection<AdmMenuRoleDto>>> ListRolMenuItems()
        {
            try
            {
                var query = _appConfigDbContext.AdmMenuRoles
                    .Include(i => i.AdmMenuElement)
                    .Where(w => w.Activo == true)
                    .OrderBy(o => o.MenuRoleId)
                    .AsQueryable();

                var result = await query.ToListAsync();
                var mapped = _mapper.Map<ICollection<AdmMenuRoleDto>>(result);

                return Result.Ok(mapped);

            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in ListRolMenuItems");
                return Result.Fail(new Error($"Error in ListRolMenuItems {error.Message}")).WithError(error.StackTrace);
            }
        }

        public async Task<Result<ICollection<AdmMenuRoleDto>>> ListRolMenuItemsByRol(string rolId)
        {
            try
            {
                var query = _appConfigDbContext.AdmMenuRoles
                    .Include(i => i.AdmMenuElement)
                    .Where(w => w.RoleId == rolId && w.Activo == true)
                    .OrderBy(o => o.MenuRoleId)
                    .AsQueryable();

                var result = await query.ToListAsync();
                var mapped = _mapper.Map<ICollection<AdmMenuRoleDto>>(result);

                return Result.Ok(mapped);

            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in ListRolMenuItemsByRol");
                return Result.Fail(new Error($"Error in ListRolMenuItemsByRol {error.Message}")).WithError(error.StackTrace);
            }
        }

        public async Task<Result<AdmMenuRoleDto>> CreateRolMenuItem(AdmMenuRoleInsertDto admMenuRoleDto, string user)
        {
            try
            {
                // Validate if the item already exists
                var item = await _appConfigDbContext.AdmMenuRoles
                    .FirstOrDefaultAsync(f => f.MenuElementId == admMenuRoleDto.MenuElementId && f.RoleId == admMenuRoleDto.RoleId && f.Activo == true);

                if (item is null)
                {
                    // Map the dto to the entity
                    var objToInsert = _mapper.Map<AdmMenuRole>(admMenuRoleDto);
                    objToInsert.CreateDate = DateTime.Now;
                    objToInsert.CreateUser = user;

                    // Insert the item
                    await _appConfigDbContext.AdmMenuRoles.AddAsync(objToInsert);
                    await _appConfigDbContext.SaveChangesAsync();

                    return Result.Ok(_mapper.Map<AdmMenuRoleDto>(objToInsert));
                }
                else
                {
                    return Result.Fail(new Error($"Item with id {admMenuRoleDto.MenuElementId} and role {admMenuRoleDto.RoleId} already exists"));
                }

            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in CreateRolMenuItem");
                return Result.Fail(new Error($"Error in CreateRolMenuItem {error.Message}")).WithError(error.StackTrace);
            }
        }

        public async Task<Result<AdmMenuRoleDto>> UpdateRolMenuItem(AdmMenuRoleUpdateDto admMenuRoleDto, string user)
        {
            try
            {
                // Validate if the item already exists
                var item = await _appConfigDbContext.AdmMenuRoles
                    .FirstOrDefaultAsync(f => f.MenuRoleId == admMenuRoleDto.MenuRoleId && f.Activo == true);

                if (item is not null)
                {
                    // Merge the item with the new values from the dto using automapper
                    var mapped = _mapper.Map(admMenuRoleDto, item);

                    // Update the item
                    _appConfigDbContext.AdmMenuRoles.Update(mapped);
                    await _appConfigDbContext.SaveChangesAsync();

                    return Result.Ok(_mapper.Map<AdmMenuRoleDto>(mapped));
                }
                else
                {
                    return Result.Fail(new Error($"Item with id {admMenuRoleDto.MenuRoleId} not found"));
                }

            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in UpdateRolMenuItem");
                return Result.Fail(new Error($"Error in UpdateRolMenuItem {error.Message}")).WithError(error.StackTrace);
            }
        }

        public async Task<Result<AdmMenuRoleDto>> DeleteRolMenuItem(int menuElementId, string user)
        {
            try
            {
                // Validate if the item already exists
                var item = await _appConfigDbContext.AdmMenuRoles
                    .FirstOrDefaultAsync(f => f.MenuRoleId == menuElementId && f.Activo == true);

                if (item is not null)
                {
                    // Update the item to inactive
                    item.Activo = false;
                    _appConfigDbContext.AdmMenuRoles.Update(item);
                    await _appConfigDbContext.SaveChangesAsync();

                    return Result.Ok(_mapper.Map<AdmMenuRoleDto>(item));
                }
                else
                {
                    return Result.Fail(new Error($"Item with id {menuElementId} not found"));
                }

            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in DeleteRolMenuItem");
                return Result.Fail(new Error($"Error in DeleteRolMenuItem {error.Message}")).WithError(error.StackTrace);
            }
        }
    }
}
