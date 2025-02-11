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
    public class PersonasLinkService : IPersonasLinkService
    {
        private readonly AppPeopleDbContext _appConfigDbContext;
        private readonly IMapper _mapper;
        private readonly ILogger<IPersonasLinkService> _logger;

        public PersonasLinkService(AppPeopleDbContext appConfigDbContext, IMapper mapper, ILogger<IPersonasLinkService> logger)
        {
            _appConfigDbContext = appConfigDbContext;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Result<PersonasLinkDto>> CreatePersonasLinkItem(PersonasLinkInsertDto personasLinkInsertDto, string user)
        {
            try
            {
                // Validate id the person has an address with the same RMO
                var personasLinks = await _appConfigDbContext.personasLinks
                    .Where(x => x.PersonaId == personasLinkInsertDto.PersonaId && x.RMO == personasLinkInsertDto.RMO)
                    .FirstOrDefaultAsync();

                if (personasLinks != null)
                {
                    return Result.Fail(new Error($"The person already has a link with the RMO {personasLinkInsertDto.RMO}"));
                }

                var personasLink = _mapper.Map<PersonasLink>(personasLinkInsertDto);

                await _appConfigDbContext.personasLinks.AddAsync(personasLink);
                await _appConfigDbContext.SaveChangesAsync();

                var personasLinkDto = _mapper.Map<PersonasLinkDto>(personasLink);

                return Result.Ok(personasLinkDto);
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in CreatePersonasLinkItem");
                return Result.Fail(new Error($"Error in CreatePersonasLinkItem {error.Message}")).WithError(error.StackTrace);
            }
        }

        public async Task<Result<PersonasLinkDto>> DeletePersonasLinkItem(int linkId, string user)
        {
            try
            {
                var personasLink = await _appConfigDbContext.personasLinks
                    .Where(x => x.LinkId == linkId)
                    .FirstOrDefaultAsync();

                if (personasLink == null)
                {
                    return Result.Fail(new Error($"The link with id {linkId} does not exist"));
                }


                _appConfigDbContext.Remove(personasLink);
                await _appConfigDbContext.SaveChangesAsync();

                var personasLinkDto = _mapper.Map<PersonasLinkDto>(personasLink);

                return Result.Ok(personasLinkDto);
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in DeletePersonasLinkItem");
                return Result.Fail(new Error($"Error in DeletePersonasLinkItem {error.Message}")).WithError(error.StackTrace);
            }
        }

        public async Task<Result<ICollection<PersonasLinkDto>>> GetPersonasLink(int personaId)
        {
            try
            {
                var personasLinks = await _appConfigDbContext.personasLinks
                    .Where(x => x.PersonaId == personaId)
                    .Include(x => x.Persona)
                    .ToListAsync();

                var personasLinksDto = _mapper.Map<ICollection<PersonasLinkDto>>(personasLinks);

                return Result.Ok(personasLinksDto);
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in GetPersonasLink");
                return Result.Fail(new Error($"Error in GetPersonasLink {error.Message}")).WithError(error.StackTrace);
            }
        }

        public async Task<Result<ICollection<PersonasLinkPersonaDto>>> GetPersonasLinkByReferidoId(int referidoId)
        {
            try
            {
                var personasLinks = await _appConfigDbContext.personasLinks
                    .Where(x => x.ReferidoId == referidoId)
                    .Include(x => x.Persona)
                    .ThenInclude(x => x.PersonasDirecciones)
                    .ToListAsync();

                var personasLinksDto = _mapper.Map<ICollection<PersonasLinkPersonaDto>>(personasLinks);

                return Result.Ok(personasLinksDto);
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in GetPersonasLinkByReferidoId");
                return Result.Fail(new Error($"Error in GetPersonasLinkByReferidoId {error.Message}")).WithError(error.StackTrace);
            }
        }

        public async Task<Result<PersonasLinkDto>> UpdatePersonasLinkItem(PersonasLinkUpdateDto personasLinkUpdateDto, string user)
        {
            try
            {
                var personasLink = await _appConfigDbContext.personasLinks
                    .Where(x => x.LinkId == personasLinkUpdateDto.LinkId)
                    .FirstOrDefaultAsync();

                if (personasLink == null)
                {
                    return Result.Fail(new Error($"The link with id {personasLinkUpdateDto.LinkId} does not exist"));
                }

                personasLink = _mapper.Map(personasLinkUpdateDto, personasLink);

                await _appConfigDbContext.SaveChangesAsync();

                var personasLinkDto = _mapper.Map<PersonasLinkDto>(personasLink);

                return Result.Ok(personasLinkDto);
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in UpdatePersonasLinkItem");
                return Result.Fail(new Error($"Error in UpdatePersonasLinkItem {error.Message}")).WithError(error.StackTrace);
            }
        }
    }
}
