using FluentResults;

namespace PRAMS.Application.Contract.People
{
    public interface IPersonasService
    {
        Task<Result<ICollection<object>>> GetPersona(int personaId);
    }
}
