using FluentResults;
using PRAMS.Domain.Entities.People.Dto;
using PRAMS.Domain.Entities.Shared;

namespace PRAMS.Application.Contract.People
{
    public interface IPersonasService
    {
        Task<Result<ICollection<PersonDto>>> ListPersonas();
        Task<Result<DtResult<PersonDto>>> ListPersonas(FilterCriteria filterCriteria);
        Task<Result<PersonDto>> GetPersona(int personaId);
        Task<Result<PersonDto>> CreatePersonItem(PersonInsertDto personInsertDto, string user);
        Task<Result<PersonDto>> UpdatePersonItem(PersonUpdateDto personUpdateDto, string user);
        Task<Result<ICollection<PersonDto>>> SearchPersonItem(PersonSearchDto personSearchDto);
        Task<Result<PersonDto>> MergePersonItem(int mainPersonaId, int mergePersonaId, string user);
        Task<Result<PersonDto>> UnmergePersonItem(int mainPersonaId, string user);
    }
}
