using FluentResults;
using PRAMS.Domain.Entities.People.Dto;

namespace PRAMS.Application.Contract.People
{
    public interface IPersonasDireccionesService
    {
        Task<Result<ICollection<PersonasDireccionDto>>> GetPersonaDirecciones(int personaId);
        Task<Result<PersonasDireccionDto>> CreatePersonaDireccionItem(PersonasDireccionInsertDto personasDireccionInsertDto, string user);
        Task<Result<PersonasDireccionDto>> UpdatePersonaDireccionItem(PersonasDireccionUpdateDto personasDireccionUpdateDto, string user);
        Task<Result<PersonasDireccionDto>> DeletePersonaDireccionItem(int direccionId, string user);
    }
}
