using FluentResults;
using PRAMS.Domain.Entities.Agencies.Dto;
using PRAMS.Domain.Entities.Shared;

namespace PRAMS.Application.Contract.Agencies
{
    public interface IAgenciasService
    {
        Task<Result<ICollection<AgenciaDto>>> ListAgencias();
        Task<Result<DtResult<AgenciaDto>>> ListAgencias(FilterCriteria filterCriteria);
        Task<Result<AgenciaDto>> GetAgencia(int id);
        Task<Result<AgenciaDto>> InsertAgencia(AgenciaInsertDto agencia, string user);
        Task<Result<AgenciaDto>> UpdateAgencia(AgenciaUpdateDto agencia, string user);
        Task<Result<AgenciaDto>> DeleteAgencia(int id, string user);
    }
}
