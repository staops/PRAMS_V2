using AutoMapper;
using FluentResults;
using LinqKit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PRAMS.Application.Contract.Agencies;
using PRAMS.Domain.Entities.Agencies.Dto;
using PRAMS.Domain.Entities.Shared;
using PRAMS.Domain.Models.Agencies;
using PRAMS.Infraestructure.Data.People;
using System.Linq.Expressions;

namespace PRAMS.Infraestructure.Services.Agencies
{
    public class AgenciasService : IAgenciasService
    {
        private readonly AppPeopleDbContext _appConfigDbContext;
        private readonly IMapper _mapper;
        private readonly ILogger<IAgenciasService> _logger;

        public AgenciasService(AppPeopleDbContext appConfigDbContext, IMapper mapper, ILogger<IAgenciasService> logger)
        {
            _appConfigDbContext = appConfigDbContext;
            _mapper = mapper;
            _logger = logger;
        }


        public async Task<Result<AgenciaDto>> DeleteAgencia(int id, string user)
        {
            try
            {
                // Validate if the agency exists
                var agencia = await _appConfigDbContext.agencias.Where(x => x.AgenciaId == id && x.Activo).FirstOrDefaultAsync();
                if (agencia == null)
                {
                    return Result.Fail(new Error($"Agencia with id {id} not found"));
                }
                // Validate if the agency is already an active agency
                if (agencia.FechaFin == null)
                {
                    return Result.Fail(new Error($"Agencia with id {id} is already an active agency"));
                }

                agencia.Activo = false;
                agencia.UpdateDate = DateTime.Now;
                agencia.UpdateUser = user;

                await _appConfigDbContext.SaveChangesAsync();
                var agenciaDto = _mapper.Map<AgenciaDto>(agencia);
                return Result.Ok(agenciaDto);
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in DeleteAgencia");
                return Result.Fail(new Error($"Error in DeleteAgencia {error.Message}")).WithError(error.StackTrace);
            }
        }

        public async Task<Result<AgenciaDto>> GetAgencia(int id)
        {
            try
            {
                var agencia = await _appConfigDbContext.agencias.Where(x => x.AgenciaId == id && x.Activo).FirstOrDefaultAsync();
                if (agencia == null)
                {
                    return Result.Fail(new Error($"Agencia with id {id} not found"));
                }

                var agenciaDto = _mapper.Map<AgenciaDto>(agencia);
                return Result.Ok(agenciaDto);
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in GetAgencia");
                return Result.Fail(new Error($"Error in GetAgencia {error.Message}")).WithError(error.StackTrace);
            }
        }

        public async Task<Result<AgenciaDto>> InsertAgencia(AgenciaInsertDto agencia, string user)
        {
            try
            {
                // Search if the agency already exists
                var agenciaExists = await _appConfigDbContext.agencias
                    .Where(x =>
                           x.NombreAgencia == agencia.NombreAgencia &&
                           x.TipoAgencia == agencia.TipoAgencia &&
                           x.Region == agencia.Region &&
                           x.FechaFin == null &&
                           x.Activo)
                    .FirstOrDefaultAsync();
                if (agenciaExists != null)
                {
                    // Set the FechaFin to now and the user that is updating the agency
                    agenciaExists.FechaFin = DateTime.Now;
                    agenciaExists.UpdateUser = user;
                    agenciaExists.UpdateDate = DateTime.Now;
                    await _appConfigDbContext.SaveChangesAsync();
                }


                var agenciaEntity = _mapper.Map<Agencia>(agencia);
                agenciaEntity.CreateUser = user;
                agenciaEntity.Activo = true;
                agenciaEntity.CreateDate = DateTime.Now;
                _appConfigDbContext.agencias.Add(agenciaEntity);
                await _appConfigDbContext.SaveChangesAsync();
                var agenciaDto = _mapper.Map<AgenciaDto>(agenciaEntity);
                return Result.Ok(agenciaDto);
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in InsertAgencia");
                return Result.Fail(new Error($"Error in InsertAgencia {error.Message}")).WithError(error.StackTrace);
            }
        }

        public async Task<Result<ICollection<AgenciaDto>>> ListAgencias()
        {
            try
            {
                var agencias = await _appConfigDbContext.agencias.Where(x => x.Activo).ToListAsync();
                var agenciasDto = _mapper.Map<ICollection<AgenciaDto>>(agencias);
                return Result.Ok(agenciasDto);
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in ListAgencias");
                return Result.Fail(new Error($"Error in ListAgencias {error.Message}")).WithError(error.StackTrace);
            }
        }

        public async Task<Result<DtResult<AgenciaDto>>> ListAgencias(FilterCriteria filterCriteria)
        {
            try
            {
                string searchBy = filterCriteria.Search?.Value ?? string.Empty;

                // if we have an empty search then just order the results by Id ascending
                string orderCriteria = "AgenciaId";
                bool orderAscendingDirection = true;

                if (filterCriteria.Order != null && filterCriteria.Order.Any())
                {
                    // in this example we just default sort on the 1st column
                    orderCriteria = filterCriteria.Columns[filterCriteria.Order[0].Column].Data;
                    orderAscendingDirection = filterCriteria.Order[0].Dir.ToString().Equals("asc", StringComparison.CurrentCultureIgnoreCase);
                }

                // Build the predicate based on the search criteria
                var predicate = PredicateBuilder.New<Agencia>(true);

                if (!string.IsNullOrEmpty(searchBy))
                {
                    predicate = predicate.Or(x => x.TipoAgencia.Contains(searchBy));
                    predicate = predicate.Or(x => x.NombreAgencia.Contains(searchBy));
                    predicate = predicate.Or(x => x.Region.Contains(searchBy));
                    predicate = predicate.Or(x => x.Direccion1 != null && x.Direccion1.Contains(searchBy));
                    predicate = predicate.Or(x => x.Direccion2 != null && x.Direccion2.Contains(searchBy));
                    predicate = predicate.Or(x => x.Ciudad != null && x.Ciudad.Contains(searchBy));
                    predicate = predicate.Or(x => x.Estado != null && x.Estado.Contains(searchBy));
                }

                // Get the data for the current page
                IQueryable<Agencia> result = _appConfigDbContext.agencias.Where(predicate)
                    .AsQueryable();

                // now just get the count of items (without the skip and take) - eg how many could be returned with filtering
                int filteredResultsCount = await result.CountAsync();
                int totalResultsCount = await _appConfigDbContext.agencias.CountAsync();

                IQueryable<AgenciaDto> basicInfApplicantDtos = _mapper.Map<List<AgenciaDto>>(result).AsQueryable();


                // Ordering using reflection 
                string command = orderAscendingDirection ? "OrderBy" : "OrderByDescending";
                var type = typeof(AgenciaDto);
                var property = type.GetProperty(orderCriteria.ToUpper(), System.Reflection.BindingFlags.IgnoreCase | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
                var parameter = Expression.Parameter(type, "p");
                var propertyAccess = Expression.MakeMemberAccess(parameter, property);
                var orderByExpression = Expression.Lambda(propertyAccess, parameter);
                var resultExpression = Expression.Call(typeof(Queryable), command, [type, property.PropertyType], basicInfApplicantDtos.AsQueryable().Expression, Expression.Quote(orderByExpression));


                // Get the data for the current page
                List<AgenciaDto> data = [.. basicInfApplicantDtos.Provider.CreateQuery<AgenciaDto>(resultExpression)
                    .Skip(filterCriteria.Start)
                    .Take(filterCriteria.Length)];

                DtResult<AgenciaDto> objectResult = new()
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
                _logger.LogError(error, "Error in ListAgencias");
                return Result.Fail(new Error($"Error in ListAgencias {error.Message}")).WithError(error.StackTrace);
            }
        }

        public async Task<Result<ICollection<AgenciaDto>>> ListAgenciasActivas()
        {
            try
            {
                var agencias = await _appConfigDbContext.agencias
                    .Where(x => x.Activo && x.FechaFin == null)
                    .ToListAsync();
                var agenciasDto = _mapper.Map<ICollection<AgenciaDto>>(agencias);
                return Result.Ok(agenciasDto);
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in ListAgencias");
                return Result.Fail(new Error($"Error in ListAgencias {error.Message}")).WithError(error.StackTrace);
            }
        }

        public async Task<Result<ICollection<AgenciaDto>>> ListAgenciasInactivas()
        {
            try
            {
                var agencias = await _appConfigDbContext.agencias
                    .Where(x => x.Activo && x.FechaFin != null)
                    .ToListAsync();
                var agenciasDto = _mapper.Map<ICollection<AgenciaDto>>(agencias);
                return Result.Ok(agenciasDto);
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in ListAgencias");
                return Result.Fail(new Error($"Error in ListAgencias {error.Message}")).WithError(error.StackTrace);
            }
        }

        public async Task<Result<ICollection<AgenciaDto>>> SearchAgenciaItem(AgenciaSearchDto agenciaSearchDto)
        {
            try
            {
                if (string.IsNullOrEmpty(agenciaSearchDto.TipoAgencia) &&
                     string.IsNullOrEmpty(agenciaSearchDto.Region) &&
                     string.IsNullOrEmpty(agenciaSearchDto.NombreAgencia))
                {
                    return Result.Fail<ICollection<AgenciaDto>>("Error in SearchAgenciaItem");
                }

                // Build the predicate based on the search criteria
                var predicate = PredicateBuilder.New<Agencia>(true);

                if (!string.IsNullOrEmpty(agenciaSearchDto.TipoAgencia))
                {
                    predicate = predicate.Or(x => x.TipoAgencia.Contains(agenciaSearchDto.TipoAgencia));
                }
                if (!string.IsNullOrEmpty(agenciaSearchDto.Region))
                {
                    predicate = predicate.Or(x => x.Region.Contains(agenciaSearchDto.Region));
                }
                if (!string.IsNullOrEmpty(agenciaSearchDto.NombreAgencia))
                {
                    predicate = predicate.Or(x => x.NombreAgencia.Contains(agenciaSearchDto.NombreAgencia));
                }

                var result = await _appConfigDbContext.agencias.Where(predicate).ToListAsync();

                var agenciasDto = _mapper.Map<ICollection<AgenciaDto>>(result);
                return Result.Ok(agenciasDto);
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in SearchAgenciaItem");
                return Result.Fail<ICollection<AgenciaDto>>("Error in SearchAgenciaItem");
            }
        }

        public async Task<Result<AgenciaDto>> SetAgenciaFechaFin(int id, string user)
        {
            try
            {
                var agencia = await _appConfigDbContext.agencias.Where(x => x.AgenciaId == id && x.Activo).FirstOrDefaultAsync();
                if (agencia == null)
                {
                    return Result.Fail(new Error($"Agencia with id {id} not found"));
                }

                agencia.FechaFin = DateTime.Now;
                agencia.UpdateDate = DateTime.Now;
                agencia.UpdateUser = user;
                await _appConfigDbContext.SaveChangesAsync();
                var agenciaDto = _mapper.Map<AgenciaDto>(agencia);
                return Result.Ok(agenciaDto);

            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in SetAgenciaFechaFin");
                return Result.Fail(new Error($"Error in SetAgenciaFechaFin {error.Message}")).WithError(error.StackTrace);
            }

        }

        public async Task<Result<AgenciaDto>> UpdateAgencia(AgenciaUpdateDto agencia, string user)
        {
            try
            {
                var agenciaEntity = await _appConfigDbContext.agencias.Where(x => x.AgenciaId == agencia.AgenciaId && x.Activo).FirstOrDefaultAsync();
                if (agenciaEntity == null)
                {
                    return Result.Fail(new Error($"Agencia with id {agencia.AgenciaId} not found"));
                }

                agenciaEntity = _mapper.Map(agencia, agenciaEntity);
                agenciaEntity.UpdateDate = DateTime.Now;
                agenciaEntity.UpdateUser = user;
                await _appConfigDbContext.SaveChangesAsync();
                var agenciaDto = _mapper.Map<AgenciaDto>(agenciaEntity);
                return Result.Ok(agenciaDto);
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in UpdateAgencia");
                return Result.Fail(new Error($"Error in UpdateAgencia {error.Message}")).WithError(error.StackTrace);
            }
        }
    }
}
