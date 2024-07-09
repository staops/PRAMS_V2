using AutoMapper;
using FluentResults;
using Microsoft.Extensions.Logging;
using PRAMS.Application.Contract.People;
using PRAMS.Infraestructure.Data.SystemConfiguration;

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

        public Task<Result<ICollection<object>>> GetPersona(int personaId)
        {
            throw new NotImplementedException();
        }
    }
}
