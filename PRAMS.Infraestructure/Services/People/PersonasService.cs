using AutoMapper;
using FluentResults;
using LinqKit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PRAMS.Application.Contract.People;
using PRAMS.Domain.Entities.People.Dto;
using PRAMS.Domain.Models.People;
using PRAMS.Infraestructure.Data.SystemConfiguration;
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

        public Task<Result<PersonDto>> CreatePersonItem(PersonInsertDto personInsertDto, string user)
        {
            throw new NotImplementedException();
        }

        public async Task<Result<PersonDto>> GetPersona(int personaId)
        {
            try
            {
                var personaIngreso = await _appConfigDbContext.personas.Where(x => x.PersonaId == personaId).FirstOrDefaultAsync();
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
                var personas = await _appConfigDbContext.personas.ToListAsync();
                var personasDto = _mapper.Map<ICollection<PersonDto>>(personas);
                return Result.Ok(personasDto);

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

        public Task<Result<PersonDto>> UpdatePersonItem(PersonUpdateDto personUpdateDto, string user)
        {
            throw new NotImplementedException();
        }
    }
}
