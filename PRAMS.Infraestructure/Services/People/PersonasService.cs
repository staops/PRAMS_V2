using AutoMapper;
using FluentResults;
using LinqKit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using PRAMS.Application.Contract.People;
using PRAMS.Domain.Entities.People.Dto;
using PRAMS.Domain.Entities.Shared;
using PRAMS.Domain.Models.People;
using PRAMS.Infraestructure.Data.People;
using System.Linq.Expressions;

namespace PRAMS.Infraestructure.Services.People
{
    public class PersonasService : IPersonasService
    {
        private readonly AppPeopleDbContext _appConfigDbContext;
        private readonly IMapper _mapper;
        private readonly ILogger<IPersonasIngresoService> _logger;

        public PersonasService(AppPeopleDbContext appConfigDbContext, IMapper mapper, ILogger<IPersonasIngresoService> logger)
        {
            _appConfigDbContext = appConfigDbContext;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Result<PersonDto>> CreatePersonItem(PersonInsertDto personInsertDto, string user)
        {
            try
            {
                var persona = _mapper.Map<Persona>(personInsertDto);
                persona.CreateUser = user;
                persona.CreateDate = DateTime.Now;

                await _appConfigDbContext.personas.AddAsync(persona);
                await _appConfigDbContext.SaveChangesAsync();

                var personaDto = _mapper.Map<PersonDto>(persona);
                return Result.Ok(personaDto);
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in GetPersonasIngreso");
                return Result.Fail(new Error($"Error in CreatePersonItem {error.Message}")).WithError(error.StackTrace);
            }
        }

        public async Task<Result<PersonDto>> GetPersona(int personaId)
        {
            try
            {
                var personaIngreso = await _appConfigDbContext.personas
                    .Where(x => x.PersonaId == personaId)
                    .Include(x => x.MergedPerson)
                    .FirstOrDefaultAsync();
                if (personaIngreso == null)
                {
                    return Result.Fail(new Error($"PersonasIngreso with id {personaId} not found"));
                }
                var personaIngresoDto = _mapper.Map<PersonDto>(personaIngreso);
                return Result.Ok(personaIngresoDto);

            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in GetPersonasIngreso");
                return Result.Fail(new Error($"Error in GetPersonasIngreso {error.Message}")).WithError(error.StackTrace);
            }
        }

        public async Task<Result<ICollection<PersonDto>>> ListPersonas()
        {
            try
            {
                var personas = await _appConfigDbContext.personas
                    .Include(x => x.MergedPerson)
                    .ToListAsync();
                var personasDto = _mapper.Map<ICollection<PersonDto>>(personas);
                return Result.Ok(personasDto);

            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in ListPersonas");
                return Result.Fail(new Error($"Error in ListPersonas {error.Message}")).WithError(error.StackTrace);
            }

        }

        public async Task<Result<DtResult<PersonDto>>> ListPersonas(FilterCriteria filterCriteria)
        {
            try
            {
                string searchBy = filterCriteria.Search?.Value ?? string.Empty;

                // if we have an empty search then just order the results by Id ascending
                string orderCriteria = "PersonaId";
                bool orderAscendingDirection = true;

                if (filterCriteria.Order != null && filterCriteria.Order.Any())
                {
                    // in this example we just default sort on the 1st column
                    orderCriteria = filterCriteria.Columns[filterCriteria.Order[0].Column].Data;
                    orderAscendingDirection = filterCriteria.Order[0].Dir.ToString().Equals("asc", StringComparison.CurrentCultureIgnoreCase);
                }

                // Build the predicate based on the search criteria
                var predicate = PredicateBuilder.New<Persona>(true);

                if (!string.IsNullOrEmpty(searchBy))
                {
                    predicate = predicate.Or(x => x.Nombre.Contains(searchBy));
                    predicate = predicate.Or(x => x.ApellidoPaterno != null && x.ApellidoPaterno.Contains(searchBy));
                    predicate = predicate.Or(x => x.ApellidoMaterno != null && x.ApellidoMaterno.Contains(searchBy));
                    predicate = predicate.Or(x => x.SeguroSocial != null && x.SeguroSocial.Contains(searchBy));
                    predicate = predicate.Or(x => x.TelefonoResidencia != null && x.TelefonoResidencia.Contains(searchBy));
                    predicate = predicate.Or(x => x.TelefonoCelular != null && x.TelefonoCelular.Contains(searchBy));
                    predicate = predicate.Or(x => x.TelefonoFamiliar != null && x.TelefonoFamiliar.Contains(searchBy));
                    predicate = predicate.Or(x => x.Email != null && x.Email.Contains(searchBy));
                }

                // Get the data for the current page
                IQueryable<Persona> result = _appConfigDbContext.personas.Where(predicate)
                    .Include(x => x.MergedPerson)
                    .AsQueryable();

                // now just get the count of items (without the skip and take) - eg how many could be returned with filtering
                int filteredResultsCount = await result.CountAsync();
                int totalResultsCount = await _appConfigDbContext.personas.CountAsync();

                IQueryable<PersonDto> basicInfApplicantDtos = _mapper.Map<List<PersonDto>>(result).AsQueryable();


                // Ordering using reflection 
                string command = orderAscendingDirection ? "OrderBy" : "OrderByDescending";
                var type = typeof(PersonDto);
                var property = type.GetProperty(orderCriteria.ToUpper(), System.Reflection.BindingFlags.IgnoreCase | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
                var parameter = Expression.Parameter(type, "p");
                var propertyAccess = Expression.MakeMemberAccess(parameter, property);
                var orderByExpression = Expression.Lambda(propertyAccess, parameter);
                var resultExpression = Expression.Call(typeof(Queryable), command, [type, property.PropertyType], basicInfApplicantDtos.AsQueryable().Expression, Expression.Quote(orderByExpression));


                // Get the data for the current page
                List<PersonDto> data = [.. basicInfApplicantDtos.Provider.CreateQuery<PersonDto>(resultExpression)
                    .Skip(filterCriteria.Start)
                    .Take(filterCriteria.Length)];

                DtResult<PersonDto> objectResult = new()
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
                _logger.LogError(error, "Error in ListPersonas");
                return Result.Fail(new Error($"Error in ListPersonas {error.Message}")).WithError(error.StackTrace);
            }
        }

        public async Task<Result<PersonDto>> MergePersonItem(int mainPersonaId, int mergePersonaId, string user)
        {
            try
            {
                var mainPersona = await _appConfigDbContext.personas.Where(x => x.PersonaId == mainPersonaId).FirstOrDefaultAsync();
                if (mainPersona == null)
                {
                    return Result.Fail(new Error($"PersonasIngreso with id {mainPersonaId} not found"));
                }

                var mergePersona = await _appConfigDbContext.personas.Where(x => x.PersonaId == mergePersonaId).FirstOrDefaultAsync();
                if (mergePersona == null)
                {
                    return Result.Fail(new Error($"PersonasIngreso with id {mergePersonaId} not found"));
                }
                if (mergePersona.Merged == true)
                {
                    return Result.Fail(new Error($"PersonasIngreso with id {mergePersonaId} is already merged"));
                }
                if (mainPersona.Merged == true)
                {
                    return Result.Fail(new Error($"PersonasIngreso with id {mainPersonaId} is already merged"));
                }

                mainPersona.Merged = true;
                mainPersona.MergedDate = DateTime.Now;
                mainPersona.MergedUser = user;
                mainPersona.MergedPersonId = mergePersonaId;
                mainPersona.MergedPerson = mergePersona;

                await _appConfigDbContext.SaveChangesAsync();

                var personaDto = _mapper.Map<PersonDto>(mainPersona);
                return Result.Ok(personaDto);
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in ListPersonas");
                return Result.Fail(new Error($"Error in ListPersonas {error.Message}")).WithError(error.StackTrace);
            }
        }

        public async Task<Result<ICollection<PersonDto>>> SearchPersonItem(PersonSearchDto personSearchDto)
        {
            try
            {
                // If all the search criteria are empty, return an empty list
                if (string.IsNullOrEmpty(personSearchDto.Nombre) &&
                    string.IsNullOrEmpty(personSearchDto.ApellidoPaterno) &&
                    string.IsNullOrEmpty(personSearchDto.ApellidoMaterno) &&
                    string.IsNullOrEmpty(personSearchDto.SeguroSocial) &&
                    string.IsNullOrEmpty(personSearchDto.TelefonoResidencia) &&
                    string.IsNullOrEmpty(personSearchDto.TelefonoCelular) &&
                    string.IsNullOrEmpty(personSearchDto.TelefonoFamiliar) &&
                    string.IsNullOrEmpty(personSearchDto.Email))
                {
                    ICollection<PersonDto> emptyList = [];
                    return Result.Ok(emptyList);
                }

                // Build the predicate based on the search criteria
                var predicate = PredicateBuilder.New<Persona>(true);

                if (!string.IsNullOrEmpty(personSearchDto.Nombre))
                {
                    predicate = predicate.Or(x => x.Nombre.Contains(personSearchDto.Nombre));
                }
                if (!string.IsNullOrEmpty(personSearchDto.ApellidoPaterno))
                {
                    predicate = predicate.Or(x => x.ApellidoPaterno != null && x.ApellidoPaterno.Contains(personSearchDto.ApellidoPaterno));
                }
                if (!string.IsNullOrEmpty(personSearchDto.ApellidoMaterno))
                {
                    predicate = predicate.Or(x => x.ApellidoMaterno != null && x.ApellidoMaterno.Contains(personSearchDto.ApellidoMaterno));
                }
                if (!string.IsNullOrEmpty(personSearchDto.SeguroSocial))
                {
                    predicate = predicate.Or(x => x.SeguroSocial != null && x.SeguroSocial.Contains(personSearchDto.SeguroSocial));
                }
                if (!string.IsNullOrEmpty(personSearchDto.TelefonoResidencia))
                {
                    predicate = predicate.Or(x => x.TelefonoResidencia != null && x.TelefonoResidencia.Contains(personSearchDto.TelefonoResidencia));
                }
                if (!string.IsNullOrEmpty(personSearchDto.TelefonoCelular))
                {
                    predicate = predicate.Or(x => x.TelefonoCelular != null && x.TelefonoCelular.Contains(personSearchDto.TelefonoCelular));
                }
                if (!string.IsNullOrEmpty(personSearchDto.TelefonoFamiliar))
                {
                    predicate = predicate.Or(x => x.TelefonoFamiliar != null && x.TelefonoFamiliar.Contains(personSearchDto.TelefonoFamiliar));
                }
                if (!string.IsNullOrEmpty(personSearchDto.Email))
                {
                    predicate = predicate.Or(x => x.Email != null && x.Email.Contains(personSearchDto.Email));
                }

                var personas = await _appConfigDbContext.personas.Where(predicate).ToListAsync();

                var personasDto = _mapper.Map<ICollection<PersonDto>>(personas);
                return Result.Ok(personasDto);

            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in SearchPersonItem");
                return Result.Fail(new Error($"Error in SearchPersonItem {error.Message}")).WithError(error.StackTrace);
            }
        }

        public async Task<Result<PersonDto>> UnmergePersonItem(int mainPersonaId, string user)
        {
            try
            {
                var mainPersona = await _appConfigDbContext.personas.Where(x => x.PersonaId == mainPersonaId).FirstOrDefaultAsync();
                if (mainPersona == null)
                {
                    return Result.Fail(new Error($"PersonasIngreso with id {mainPersonaId} not found"));
                }
                if (mainPersona.MergedPersonId == null)
                {
                    return Result.Fail(new Error($"PersonasIngreso with id {mainPersonaId} is not merged"));
                }

                mainPersona.Merged = false;
                mainPersona.MergedPersonId = null;
                mainPersona.MergedPerson = null;

                await _appConfigDbContext.SaveChangesAsync();

                var personaDto = _mapper.Map<PersonDto>(mainPersona);
                return Result.Ok(personaDto);

            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in UpdatePersonItem");
                return Result.Fail(new Error($"Error in UpdatePersonItem {error.Message}")).WithError(error.StackTrace);
            }
        }

        public async Task<Result<PersonDto>> UpdatePersonItem(PersonUpdateDto personUpdateDto, string user)
        {
            try
            {
                var persona = await _appConfigDbContext.personas.Where(x => x.PersonaId == personUpdateDto.PersonaId).FirstOrDefaultAsync();
                if (persona == null)
                {
                    return Result.Fail(new Error($"PersonasIngreso with id {personUpdateDto.PersonaId} not found"));
                }

                _mapper.Map(personUpdateDto, persona);
                persona.ModifiedUser = user;
                persona.ModifiedDate = DateTime.Now;

                await _appConfigDbContext.SaveChangesAsync();

                var personaDto = _mapper.Map<PersonDto>(persona);
                return Result.Ok(personaDto);
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in UpdatePersonItem");
                return Result.Fail(new Error($"Error in UpdatePersonItem {error.Message}")).WithError(error.StackTrace);
            }
        }
    }
}
