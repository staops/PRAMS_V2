using FluentResults;
using PRAMS.Domain.Entities.People.Dto;

namespace PRAMS.Application.Contract.People
{
    public interface IPersonasService
    {
        Task<Result<ICollection<PersonDto>>> ListPersonas();
        Task<Result<PersonDto>> GetPersona(int personaId);
        Task<Result<PersonDto>> CreatePersonItem(PersonInsertDto personInsertDto, string user);
        Task<Result<PersonDto>> UpdatePersonItem(PersonUpdateDto personUpdateDto, string user);
        Task<Result<ICollection<PersonDto>>> SearchPersonItem(PersonSearchDto personSearchDto);

    }
}
