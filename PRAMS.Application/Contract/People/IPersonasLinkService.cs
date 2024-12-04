using FluentResults;
using PRAMS.Domain.Entities.People.Dto;

namespace PRAMS.Application.Contract.People
{
    public interface IPersonasLinkService
    {
        Task<Result<ICollection<PersonasLinkDto>>> GetPersonasLink(int personaId);
        Task<Result<ICollection<PersonasLinkPersonaDto>>> GetPersonasLinkByReferidoId(int referidoId);
        Task<Result<PersonasLinkDto>> CreatePersonasLinkItem(PersonasLinkInsertDto personasLinkInsertDto, string user);
        Task<Result<PersonasLinkDto>> UpdatePersonasLinkItem(PersonasLinkUpdateDto personasLinkUpdateDto, string user);
        Task<Result<PersonasLinkDto>> DeletePersonasLinkItem(int linkId, string user);
    }
}
