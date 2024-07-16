using FluentResults;
using PRAMS.Domain.Entities.People.Dto;

namespace PRAMS.Application.Contract.People
{
    public interface IPersonasIngresoService
    {
        Task<Result<PersonDto>> GetPersonasIngreso(int personaId);

    }
}
