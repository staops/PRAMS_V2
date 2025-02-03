using FluentResults;
using PRAMS.Domain.Entities.Agencies.Dto;
using PRAMS.Domain.Entities.People.Dto;
using PRAMS.Domain.Entities.Shared;

namespace PRAMS.Application.Contract.Agencies
{
    public interface IAgenciasService
    {
        Task<Result<ICollection<AgenciaDto>>> ListAgencias();
        Task<Result<ICollection<AgenciaDto>>> ListAgenciasActivas();
        Task<Result<ICollection<AgenciaDto>>> ListAgenciasInactivas();
        Task<Result<AgenciaDto>> SetAgenciaFechaFin(int id, string user);
        Task<Result<DtResult<AgenciaDto>>> ListAgencias(FilterCriteria filterCriteria);
        Task<Result<AgenciaDto>> GetAgencia(int id);
        Task<Result<AgenciaDto>> InsertAgencia(AgenciaInsertDto agencia, string user);
        Task<Result<AgenciaDto>> UpdateAgencia(AgenciaUpdateDto agencia, string user);
        Task<Result<AgenciaDto>> DeleteAgencia(int id, string user);
        Task<Result<ICollection<AgenciaDto>>> SearchAgenciaItem(AgenciaSearchDto agenciaSearchDto);

    }
}
