using FluentResults;

namespace PRAMS.Application.Contract.People
{
    public interface IPersonasDireccionesService
    {
        Task<Result<ICollection<object>>> GetPersonaDirecciones(int personaId);
    }
}
