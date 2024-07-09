using FluentResults;

namespace PRAMS.Application.Contract.People
{
    public interface IPersonasIngresoService
    {
        Task<Result<ICollection<object>>> GetPersonasIngreso(int personaIngresoId);

    }
}
