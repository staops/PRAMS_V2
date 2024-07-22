using AutoMapper;
using FluentResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PRAMS.Application.Contract.People;
using PRAMS.Domain.Entities.People.Dto;
using PRAMS.Domain.Models.People;
using PRAMS.Infraestructure.Data.People;


namespace PRAMS.Infraestructure.Services.People
{
    public class PersonasDireccionesService : IPersonasDireccionesService
    {
        private readonly AppPeopleDbContext _appConfigDbContext;
        private readonly IMapper _mapper;
        private readonly ILogger<IPersonasIngresoService> _logger;

        public PersonasDireccionesService(AppPeopleDbContext appConfigDbContext, IMapper mapper, ILogger<IPersonasIngresoService> logger)
        {
            _appConfigDbContext = appConfigDbContext;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Result<PersonasDireccionDto>> CreatePersonaDireccionItem(PersonasDireccionInsertDto personasDireccionInsertDto, string user)
        {
            try
            {
                // Validate id the person has an address with the same type to add the end date
                var personasDirecciones = await _appConfigDbContext.personasDirecciones
                    .Where(x => 
                           x.PersonaId == personasDireccionInsertDto.PersonaId && 
                           x.TipoDireccion == personasDireccionInsertDto.TipoDireccion && 
                           x.FechaFin == null &&
                           x.Activo)
                    .ToListAsync();

                foreach (var item in personasDirecciones)
                {
                    item.FechaFin = DateTime.Now;
                }

                var personasDireccion = _mapper.Map<PersonasDireccion>(personasDireccionInsertDto);
                personasDireccion.FechaInicio = DateTime.Now;
                personasDireccion.CreateDate = DateTime.Now;
                personasDireccion.CreateUser = user;
                personasDireccion.Activo = true;


                await _appConfigDbContext.personasDirecciones.AddAsync(personasDireccion);
                await _appConfigDbContext.SaveChangesAsync();
                var personasDireccionDto = _mapper.Map<PersonasDireccionDto>(personasDireccion);
                return Result.Ok(personasDireccionDto);
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in CreatePersonaDireccionItem");
                return Result.Fail(new Error($"Error in CreatePersonaDireccionItem {error.Message}")).WithError(error.StackTrace);
            }

        }

        public async Task<Result<PersonasDireccionDto>> DeletePersonaDireccionItem(int direccionId, string user)
        {
            try
            {
                // Validate if the address exists
                var personasDireccion = await _appConfigDbContext.personasDirecciones
                    .FirstOrDefaultAsync(x => x.DireccionId == direccionId);
                if (personasDireccion == null)
                {
                    return Result.Fail(new Error($"DireccionId {direccionId} not found"));
                }
                // If the address does not have the end date return error message 
                if (personasDireccion.FechaFin == null)
                {
                    return Result.Fail(new Error($"DireccionId {direccionId} is already an active address"));
                }

                personasDireccion.Activo = false;

                await _appConfigDbContext.SaveChangesAsync();
                var personasDireccionDto = _mapper.Map<PersonasDireccionDto>(personasDireccion);
                return Result.Ok(personasDireccionDto);
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in DeletePersonaDireccionItem");
                return Result.Fail(new Error($"Error in DeletePersonaDireccionItem {error.Message}")).WithError(error.StackTrace);
            }

        }

        public async Task<Result<ICollection<PersonasDireccionDto>>> GetPersonaDirecciones(int personaId)
        {
            try
            {
                // Validate if the address exists
                var personaDirecciones = await _appConfigDbContext.personasDirecciones
                    .Where(x => x.PersonaId == personaId && x.Activo)
                    .ToListAsync();
                var personaDireccionesDto = _mapper.Map<ICollection<PersonasDireccionDto>>(personaDirecciones);
                return Result.Ok(personaDireccionesDto);

            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in GetPersonaDirecciones");
                return Result.Fail(new Error($"Error in GetPersonaDirecciones {error.Message}")).WithError(error.StackTrace);
            }
        }

        public async Task<Result<PersonasDireccionDto>> UpdatePersonaDireccionItem(PersonasDireccionUpdateDto personasDireccionUpdateDto, string user)
        {
            try
            {
                // Validate if the address exists
                var personasDireccion = await _appConfigDbContext.personasDirecciones
                    .FirstOrDefaultAsync(x => x.DireccionId == personasDireccionUpdateDto.DireccionId && x.Activo);
                if (personasDireccion == null)
                {
                    return Result.Fail(new Error($"DireccionId {personasDireccionUpdateDto.DireccionId} not found"));
                }


                // Validate id the person has an address with the same type to add the end date
                var personasDirecciones = await _appConfigDbContext.personasDirecciones
                    .Where(x =>
                           x.PersonaId == personasDireccion.PersonaId &&
                           x.DireccionId != personasDireccion.DireccionId &&
                           x.TipoDireccion == personasDireccion.TipoDireccion &&
                           x.FechaFin == null &&
                           x.Activo)
                    .ToListAsync();

                foreach (var item in personasDirecciones)
                {
                    item.FechaFin = DateTime.Now;
                }

                personasDireccion.FechaFin = null;


                _mapper.Map(personasDireccionUpdateDto, personasDireccion);
                await _appConfigDbContext.SaveChangesAsync();
                var personasDireccionDto = _mapper.Map<PersonasDireccionDto>(personasDireccion);
                return Result.Ok(personasDireccionDto);
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in UpdatePersonaDireccionItem");
                return Result.Fail(new Error($"Error in UpdatePersonaDireccionItem {error.Message}")).WithError(error.StackTrace);

            }
        }
    }
}
