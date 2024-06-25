using AutoMapper;
using FluentResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PRAMS.Application.Contract.SystemConfiguration;
using PRAMS.Domain.Entities.SystemConfiguration.Dto;
using PRAMS.Domain.Models.SystemConfiguration;
using PRAMS.Infraestructure.Data.SystemConfiguration;

namespace PRAMS.Infraestructure.Services
{
    public class CatalogsService : ICatalogsService
    {
        private readonly AppConfigDbContext _appConfigDbContext;
        private readonly IMapper _mapper;
        private readonly ILogger<ICatalogsService> _logger;

        public CatalogsService(AppConfigDbContext appConfigDbContext, IMapper mapper, ILogger<ICatalogsService> logger)
        {
            _appConfigDbContext = appConfigDbContext;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Result<ICollection<AdmParametrosNivel0Dto>>> GetCatalogZero(int catalogId)
        {
            try
            {
                // Get the required catalog from AdmParametrosSeleccion table and map it to AdmParametrosNivel0Dto
                /*
                 * Select P.CategoriaID, C.Categoria, P.Parametro as Parametro, P.TX_Filtro1 as TX_Filtro1, C.Descripcion as CatDescripcion, 
                 * P.Descripcion as ParamDescripcion,
                 * P.TX_Filtro2 AS TX_Filtro2 
                 * from dbo.Adm_ParametrosSeleccion P
                 * CROSS APPLY ( 
                 * SELECT * FROM dbo.Adm_ParametroCategoria 
                 * WHERE 1 = 1
                 * AND CategoriaID = P.CategoriaID 
                 * AND Activo = 1
                 * ) C
                 * WHERE 1 = 1
                 * AND P.CategoriaID = 16
                 * ORDER BY P.CategoriaID, P.Parametro
                */


                //var query = _appConfigDbContext.AdmParamSelections
                //    .Where(w => w.Activo == true)
                //    .Join(
                //        _appConfigDbContext.AdmParamCategories.Where(w => w.Activo == true),
                //        p => p.CategoriaID,
                //        c => c.CategoriaID,
                //        (p, c) => new AdmParametrosNivel0Dto
                //        {
                //            CategoriaID = c.CategoriaID,
                //            ParamterosID = p.ParamterosID,
                //            Category = c.Categoria,
                //            Paremeter = p.Parametro ?? string.Empty,
                //            TX_FilterOne = p.TX_Filtro1,
                //            CatDescription = c.Descripcion,
                //            ParamDescription = p.Descripcion,
                //            TX_FilterTwo = p.TX_Filtro2
                //        })
                //    .Where(p => p.CategoriaID == catalogId)
                //    .OrderBy(o => o.Category)
                //    .ThenBy(o => o.Paremeter)
                //    .AsQueryable();

                var query = _appConfigDbContext.AdmParamSelections
                    .Include(i => i.AdmParametroCategoria)
                    .Where(w => w.Activo == true && w.AdmParametroCategoria.Activo == true && w.CategoriaID == catalogId)
                    .OrderBy(o => o.CategoriaID)
                    .ThenBy(o => o.Parametro)
                    .AsQueryable();

                //ICollection<AdmParametrosNivel0Dto> nivel0Dtos = await query.ToListAsync();
                ICollection<AdmParametrosNivel0Dto> nivel0Dtos = await _mapper.ProjectTo<AdmParametrosNivel0Dto>(query).ToListAsync();

                return Result.Ok(nivel0Dtos);

            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in GetCatalogZero");
                return Result.Fail(new Error($"Error in GetCatalogZero {error.Message}")).WithError(error.StackTrace);
            }
        }

        public async Task<Result<ICollection<AdmParametrosNivel1Dto>>> GetCatalogOne(int catalogId)
        {
            try
            {
                var query = _appConfigDbContext.AdmParamSelections
                    .Include(i => i.AdmParametroCategoria)
                    .Where(w => w.Activo == true && w.AdmParametroCategoria.Activo == true && w.CategoriaID == catalogId)
                    .OrderBy(o => o.TX_Filtro1)
                    .AsQueryable();

                ICollection<AdmParametrosNivel1Dto> nivel1Dtos = await _mapper.ProjectTo<AdmParametrosNivel1Dto>(query).ToListAsync();

                nivel1Dtos = nivel1Dtos.GroupBy(g => new { g.CategoriaID, g.Category, g.CatDescription, g.TX_Filter, g.TX_FilterTwo })
                    .Select(s => new AdmParametrosNivel1Dto
                    {
                        CategoriaID = s.Key.CategoriaID,
                        Category = s.Key.Category,
                        CatDescription = s.Key.CatDescription,
                        TX_Filter = s.Key.TX_Filter,
                        TX_FilterTwo = s.Key.TX_FilterTwo
                    }).ToList();

                return Result.Ok(nivel1Dtos);

            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in GetCatalogOne");
                return Result.Fail(new Error($"Error in GetCatalogOne {error.Message}")).WithError(error.StackTrace);
            }
        }

        public async Task<Result<ICollection<AdmParametrosNivel2Dto>>> GetCatalogTwo(int catalogId)
        {
            try
            {

                var query = _appConfigDbContext.AdmParamSelections
                    .Include(i => i.AdmParametroCategoria)
                    .Where(w => w.Activo == true && w.AdmParametroCategoria.Activo == true && w.CategoriaID == catalogId)
                    .OrderBy(o => o.TX_Filtro1)
                    .AsQueryable();

                ICollection<AdmParametrosNivel2Dto> nivel2Dtos = await _mapper.ProjectTo<AdmParametrosNivel2Dto>(query).ToListAsync();

                nivel2Dtos = nivel2Dtos.GroupBy(g => new { g.CategoriaID, g.Category, g.CatDescription, g.TX_Filter, g.TX_FilterTwo })
                    .Select(s => new AdmParametrosNivel2Dto
                    {
                        CategoriaID = s.Key.CategoriaID,
                        Category = s.Key.Category,
                        CatDescription = s.Key.CatDescription,
                        TX_Filter = s.Key.TX_Filter,
                        TX_FilterTwo = s.Key.TX_FilterTwo
                    }).ToList();

                return Result.Ok(nivel2Dtos);

            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in GetCatalogTwo");
                return Result.Fail(new Error($"Error in GetCatalogTwo {error.Message}")).WithError(error.StackTrace);
            }
        }

        public async Task<Result<ICollection<AdmParametrosNivel3Dto>>> GetCatalogTree(int catalogId)
        {
            try
            {

                var query = _appConfigDbContext.AdmParamSelections
                    .Include(i => i.AdmParametroCategoria)
                    .Where(w => w.Activo == true && w.AdmParametroCategoria.Activo == true && w.CategoriaID == catalogId)
                    .OrderBy(o => o.TX_Filtro1)
                    .AsQueryable();

                ICollection<AdmParametrosNivel3Dto> nivel3Dtos = await _mapper.ProjectTo<AdmParametrosNivel3Dto>(query).ToListAsync();

                nivel3Dtos = nivel3Dtos.GroupBy(g => new { g.CategoriaID, g.Category, g.CatDescription, g.TX_Filter, g.TX_FilterTwo })
                    .Select(s => new AdmParametrosNivel3Dto
                    {
                        CategoriaID = s.Key.CategoriaID,
                        Category = s.Key.Category,
                        CatDescription = s.Key.CatDescription,
                        TX_Filter = s.Key.TX_Filter,
                        TX_FilterTwo = s.Key.TX_FilterTwo
                    }).ToList();

                return Result.Ok(nivel3Dtos);

            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in GetCatalogTree");
                return Result.Fail(new Error($"Error in GetCatalogTree {error.Message}")).WithError(error.StackTrace);
            }
        }

        public async Task<Result<AdmParametrosNivel0Dto>> InsertCatalog(AdmParametrosNivel0InsertDto itemToInsert, string user)
        {
            try
            {
                // Valide if category exists
                var category = await _appConfigDbContext.AdmParamCategories.FirstOrDefaultAsync(f => f.CategoriaID == itemToInsert.CategoriaID);
                if (category is not null)
                {

                    // Validate if the item already exists
                    var itemExists = await _appConfigDbContext.AdmParamSelections
                        .FirstOrDefaultAsync(f =>
                            f.CategoriaID == itemToInsert.CategoriaID &&
                            f.Parametro == itemToInsert.Paremeter &&
                            f.Descripcion == itemToInsert.ParamDescription &&
                            f.TX_Filtro1 == itemToInsert.TX_Filter &&
                            f.TX_Filtro2 == itemToInsert.TX_FilterTwo &&
                            f.TX_Filtro3 == itemToInsert.TX_FilterThree &&
                            f.TX_Filtro4 == itemToInsert.TX_FilterFour &&
                            f.Activo == true);


                    if (itemExists is null)
                    {
                        // Insert the new item
                        AdmParametrosSeleccion newItem = new()
                        {
                            CategoriaID = category.CategoriaID,
                            Parametro = itemToInsert.Paremeter,
                            Descripcion = itemToInsert.ParamDescription,
                            TX_Filtro1 = itemToInsert.TX_Filter,
                            TX_Filtro2 = itemToInsert.TX_FilterTwo,
                            TX_Filtro3 = itemToInsert.TX_FilterThree,
                            TX_Filtro4 = itemToInsert.TX_FilterFour,
                            CreateUser = user,
                            CreateDate = DateTime.Now,
                            Activo = true
                        };

                        _appConfigDbContext.AdmParamSelections.Add(newItem);
                        await _appConfigDbContext.SaveChangesAsync();

                        return Result.Ok(_mapper.Map<AdmParametrosNivel0Dto>(newItem));
                    }
                    else
                    {
                        return Result.Fail(new Error($"Item '{itemToInsert.Paremeter}' already exists"));
                    }
                }
                else
                {
                    return Result.Fail(new Error($"Category '{itemToInsert.CategoriaID}' does not exist"));
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in InsertCatalog");
                return Result.Fail(new Error($"Error in InsertCatalog {error.Message}")).WithError(error.StackTrace);
            }

        }

        public async Task<Result<bool>> RemoveCatalog(int paramterosID, string user)
        {
            try
            {
                // Validate if the item already exists
                var itemExists = await _appConfigDbContext.AdmParamSelections
                    .FirstOrDefaultAsync(f => f.ParamterosID == paramterosID && f.Activo == true);


                if (itemExists is not null)
                {
                    itemExists.Activo = false;
                    itemExists.ModifiedUser = user;
                    itemExists.ModifiedDate = DateTime.Now;

                    _appConfigDbContext.AdmParamSelections.Update(itemExists);
                    await _appConfigDbContext.SaveChangesAsync();

                    return Result.Ok(true);
                }
                else
                {
                    return Result.Fail(new Error($"Item '{paramterosID}' does not exist").WithMetadata("ParamterosID", paramterosID));
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in RemoveCatalog");
                return Result.Fail(new Error($"Error in RemoveCatalog {error.Message}")).WithError(error.StackTrace);
            }

        }

        public async Task<Result<AdmParametrosNivel0Dto>> UpdateCatalog(AdmParametrosNivel0UpdateDto itemToUpdate, string user)
        {
            try
            {
                // Validate if the item already exists
                var itemExists = await _appConfigDbContext.AdmParamSelections
                    .Include(i => i.AdmParametroCategoria)
                    .FirstOrDefaultAsync(f =>
                        f.ParamterosID == itemToUpdate.ParamterosID &&
                        f.CategoriaID == itemToUpdate.CategoriaID &&
                        f.Activo == true);


                if (itemExists is not null)
                {
                    // Update the item
                    itemExists.Parametro = itemToUpdate.Paremeter;
                    itemExists.Descripcion = itemToUpdate.ParamDescription;
                    itemExists.TX_Filtro1 = itemToUpdate.TX_Filter;
                    itemExists.TX_Filtro2 = itemToUpdate.TX_FilterTwo;
                    itemExists.TX_Filtro3 = itemToUpdate.TX_FilterThree;
                    itemExists.TX_Filtro4 = itemToUpdate.TX_FilterFour;
                    itemExists.ModifiedUser = user;
                    itemExists.ModifiedDate = DateTime.Now;

                    _appConfigDbContext.AdmParamSelections.Update(itemExists);
                    await _appConfigDbContext.SaveChangesAsync();

                    return Result.Ok(_mapper.Map<AdmParametrosNivel0Dto>(itemExists));

                }
                else
                {
                    return Result.Fail(new Error($"Category '{itemToUpdate.CategoriaID}' does not exist in category '{itemToUpdate.CategoriaID}."));
                }

            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in UpdateCatalog");
                return Result.Fail(new Error($"Error in UpdateCatalog {error.Message}")).WithError(error.StackTrace);
            }
        }

    }
}
