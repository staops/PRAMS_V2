using AutoMapper;
using FluentResults;
using Microsoft.Extensions.Logging;
using PRAMS.Application.Contract.People;
using PRAMS.Domain.Entities.People.Dto;
using PRAMS.Infraestructure.Data.People;

namespace PRAMS.Infraestructure.Services.People
{
    public class PersonasIngresoService : IPersonasIngresoService
    {
        private readonly AppPeopleDbContext _appConfigDbContext;
        private readonly IMapper _mapper;
        private readonly ILogger<IPersonasIngresoService> _logger;

        public PersonasIngresoService(AppPeopleDbContext appConfigDbContext, IMapper mapper, ILogger<IPersonasIngresoService> logger)
        {
            _appConfigDbContext = appConfigDbContext;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Result<PersonDto>> GetPersonasIngreso(int personaId)
        {
            throw new NotImplementedException();
        }
    }
}
