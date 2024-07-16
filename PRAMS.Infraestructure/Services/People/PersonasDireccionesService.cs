using AutoMapper;
using FluentResults;
using Microsoft.Extensions.Logging;
using PRAMS.Application.Contract.People;
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

        public Task<Result<ICollection<object>>> GetPersonaDirecciones(int personaId)
        {
            throw new NotImplementedException();
        }
    }
}
