using AutoMapper;
using FluentResults;
using LinqKit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PRAMS.Application.Contract.Forms;
using PRAMS.Application.Contract.Shared;
using PRAMS.Domain.Entities.Forms.Dto;
using PRAMS.Domain.Entities.Shared;
using PRAMS.Domain.Models.Forms;
using PRAMS.Infraestructure.Data.SystemConfiguration;
using System.Linq.Expressions;

namespace PRAMS.Infraestructure.Services.Forms
{

    public class FlujosPantallasService : IFlujosPantallasService
    {
        private readonly AppConfigDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<IFlujosPantallasService> _logger;
        private readonly IBaseSqlService<IList<FormFlujoPantallaSPDto>> _baseSqlService;

        public FlujosPantallasService(AppConfigDbContext context, IMapper mapper, ILogger<IFlujosPantallasService> logger, IBaseSqlService<IList<FormFlujoPantallaSPDto>> baseSqlService)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
            _baseSqlService = baseSqlService;
        }

        public async Task<Result<FormFlujoPantallaDto>> CreateFlujoPantalla(FormFlujoPantallaInsertDto itemToInsert, string user)
        {
            try
            {
                // Validate if the FormularioId exists
                var forma = await _context.AdmFlujoFormularios
                    .Where(w => w.FormularioId == itemToInsert.FormularioId)
                    .FirstOrDefaultAsync();

                if (forma == null)
                {
                    return Result.Fail<FormFlujoPantallaDto>(new Error($"The form with id {itemToInsert.FormularioId} does not exist"));
                }


                var admFlujoPantalla = _mapper.Map<FormFlujoPantalla>(itemToInsert);


                admFlujoPantalla.UsuarioFlujoId = user;
                admFlujoPantalla.FechaFlujo = DateTime.Now;


                await _context.FormFlujoPantallas.AddAsync(admFlujoPantalla);
                await _context.SaveChangesAsync();

                var admFlujoPantallaDto = _mapper.Map<FormFlujoPantallaDto>(admFlujoPantalla);
                return Result.Ok(admFlujoPantallaDto);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error in the flow creation: {error.Message}");
                return Result.Fail<FormFlujoPantallaDto>(new Error($"Error in the flow creation: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<FormFlujoPantallaDto>> GetFlujoPantalla(int flujoPantallaId)
        {
            try
            {
                var query = _context.FormFlujoPantallas.Where(x => x.FlujoPantallaId == flujoPantallaId);
                FormFlujoPantallaDto? result = await _mapper.ProjectTo<FormFlujoPantallaDto>(query).FirstOrDefaultAsync();
                if (result == null)
                {
                    return Result.Fail<FormFlujoPantallaDto>(new Error("The flow does not exist"));
                }

                return Result.Ok(result);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error getting the flow: {error.Message}");
                return Result.Fail<FormFlujoPantallaDto>(new Error($"Error getting the flow: {error.Message}")).WithError(error.Message);
            }

        }

        public async Task<Result<ICollection<FormFlujoPantallaDto>>> GetFlujosPantallas()
        {
            try
            {
                var query = _context.FormFlujoPantallas;
                ICollection<FormFlujoPantallaDto> result = await _mapper.ProjectTo<FormFlujoPantallaDto>(query).ToListAsync();

                return Result.Ok(result);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error getting the flows: {error.Message}");
                return Result.Fail<ICollection<FormFlujoPantallaDto>>(new Error($"Error getting the flows: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<ICollection<FormFlujoPantallaDto>>> GetFlujosPantallasByFormaId(int formaId, int formularioId)
        {
            try
            {
                var query = _context.FormFlujoPantallas
                    .Where(x => x.FormaId == formaId && x.FormularioId == formularioId)
                    .OrderBy(x => x.OrdenEtapa);

                ICollection<FormFlujoPantallaDto> result = await _mapper.ProjectTo<FormFlujoPantallaDto>(query).ToListAsync();

                return Result.Ok(result);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error getting the flows: {error.Message}");
                return Result.Fail<ICollection<FormFlujoPantallaDto>>(new Error($"Error getting the flows: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<ICollection<FormFlujoPantallaDto>>> GetFlujosPantallasByFormularioId(int formularioId)
        {
            try
            {
                var query = _context.FormFlujoPantallas.Where(x => x.FormularioId == formularioId);
                ICollection<FormFlujoPantallaDto> result = await _mapper.ProjectTo<FormFlujoPantallaDto>(query).ToListAsync();

                return Result.Ok(result);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error getting the flows: {error.Message}");
                return Result.Fail<ICollection<FormFlujoPantallaDto>>(new Error($"Error getting the flows: {error.Message}")).WithError(error.Message);

            }
        }

        public async Task<Result<DtResult<FormFlujoPantallaDto>>> ListFlujosPantallass(FilterCriteria filterCriteria)
        {
            try
            {
                string searchBy = filterCriteria.Search?.Value ?? string.Empty;

                // if we have an empty search then just order the results by Id ascending
                string orderCriteria = "FlujoPantallaId";
                bool orderAscendingDirection = true;

                if (filterCriteria.Order != null && filterCriteria.Order.Any())
                {
                    // in this example we just default sort on the 1st column
                    orderCriteria = filterCriteria.Columns[filterCriteria.Order[0].Column].Data;
                    orderAscendingDirection = filterCriteria.Order[0].Dir.ToString().Equals("asc", StringComparison.CurrentCultureIgnoreCase);
                }

                // Build the predicate based on the search criteria
                var predicate = PredicateBuilder.New<FormFlujoPantalla>(true);

                if (!string.IsNullOrEmpty(searchBy))
                {
                    predicate = predicate.Or(x => x.RMO != null && x.RMO.Contains(searchBy));
                    predicate = predicate.Or(x => x.NumeroCaso != null && x.NumeroCaso.Contains(searchBy));
                    predicate = predicate.Or(x => x.Region != null && x.Region.Contains(searchBy));
                    predicate = predicate.Or(x => x.Local != null && x.Local.Contains(searchBy));
                    predicate = predicate.Or(x => x.Persona != null && x.Persona.Contains(searchBy));
                }

                // Get the data for the current page
                IQueryable<FormFlujoPantalla> result = _context.FormFlujoPantallas.Where(predicate)
                    .AsQueryable();

                // now just get the count of items (without the skip and take) - eg how many could be returned with filtering
                int filteredResultsCount = await result.CountAsync();
                int totalResultsCount = await _context.FormFlujoPantallas.CountAsync();

                IQueryable<FormFlujoPantallaDto> basicInfApplicantDtos = _mapper.Map<List<FormFlujoPantallaDto>>(result).AsQueryable();


                // Ordering using reflection 
                string command = orderAscendingDirection ? "OrderBy" : "OrderByDescending";
                var type = typeof(FormFlujoPantallaDto);
                var property = type.GetProperty(orderCriteria.ToUpper(), System.Reflection.BindingFlags.IgnoreCase | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
                var parameter = Expression.Parameter(type, "p");
                var propertyAccess = Expression.MakeMemberAccess(parameter, property);
                var orderByExpression = Expression.Lambda(propertyAccess, parameter);
                var resultExpression = Expression.Call(typeof(Queryable), command, [type, property.PropertyType], basicInfApplicantDtos.AsQueryable().Expression, Expression.Quote(orderByExpression));


                // Get the data for the current page
                List<FormFlujoPantallaDto> data = [.. basicInfApplicantDtos.Provider.CreateQuery<FormFlujoPantallaDto>(resultExpression)
                    .Skip(filterCriteria.Start)
                    .Take(filterCriteria.Length)];

                DtResult<FormFlujoPantallaDto> objectResult = new()
                {
                    Draw = filterCriteria.Draw,
                    RecordsTotal = filteredResultsCount,
                    RecordsFiltered = filteredResultsCount,
                    Data = data
                };

                return Result.Ok(objectResult);
            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error listing the FlujosPantallas: {error.Message}");
                return Result.Fail<DtResult<FormFlujoPantallaDto>>(new Error($"Error listing the FlujosPantallas: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<FormFlujoPantallaDto>> RemoveFlujoPantalla(int flujoPantallaId, string user)
        {
            try
            {
                var entity = await _context.FormFlujoPantallas.FindAsync(flujoPantallaId);
                if (entity == null)
                {
                    return Result.Fail<FormFlujoPantallaDto>(new Error($"The flow with id {flujoPantallaId} does not exist"));
                }

                _context.FormFlujoPantallas.Remove(entity);
                await _context.SaveChangesAsync();

                var admFlujoPantallaDto = _mapper.Map<FormFlujoPantallaDto>(entity);
                return Result.Ok(admFlujoPantallaDto);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error deleting the flow: {error.Message}");
                return Result.Fail<FormFlujoPantallaDto>(new Error($"Error deleting the flow: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<FormFlujoPantallaDto>> UpdateFlujoPantalla(FormFlujoPantallaUpdateDto itemToUpdate, string user)
        {
            try
            {
                var entity = await _context.FormFlujoPantallas
                    .Where(x => x.FormularioId == itemToUpdate.FormularioId)
                    .FirstOrDefaultAsync();

                if (entity == null)
                {
                    return Result.Fail<FormFlujoPantallaDto>(new Error($"The flow with id {itemToUpdate.FormularioId} does not exist"));
                }

                entity = _mapper.Map(itemToUpdate, entity);

                await _context.SaveChangesAsync();

                var result = _mapper.Map<FormFlujoPantallaDto>(entity);
                return Result.Ok(result);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error updating the flow: {error.Message}");
                return Result.Fail<FormFlujoPantallaDto>(new Error($"Error updating the flow: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<IList<FormFlujoPantallaSPDto>>> GetFlujosPantallasSP()
        {
            try
            {

                Result<IList<FormFlujoPantallaSPDto>> dataResult = await _baseSqlService.ExecuteStoreProcedure(new RequestSQLDto
                {
                    ConnectionString = _context.Database.GetDbConnection().ConnectionString,
                    StoreProcedureName = "[dbo].[SelectFlujoPendiente]",
                    Parameters = new Dictionary<string, object>()
                });

                if (dataResult.IsSuccess)
                {
                    return Result.Ok(dataResult.Value);
                }
                return Result.Fail<IList<FormFlujoPantallaSPDto>>(new Error("The flow does not exist"));

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error getting the flows: {error.Message}");
                return Result.Fail<IList<FormFlujoPantallaSPDto>>(new Error($"Error getting the flows: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<int>> GetCountByRegionAndLocal(string region, string local)
        {
            try
            {
                var query = _context.FormFlujoPantallas
                    .Where(x => x.Region == region && x.Local == local)
                    .Distinct();

                int result = await query.CountAsync();

                return Result.Ok(result);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error getting the count: {error.Message}");
                return Result.Fail<int>(new Error($"Error getting the count: {error.Message}")).WithError(error.Message);
            }
        }
    }
}
