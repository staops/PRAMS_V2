using FluentResults;
using PRAMS.Domain.Entities.Flujos.Dto;

namespace PRAMS.Application.Contract.Flujos
{
    public interface IFlujoFormularioNotasService
    {
        Task<Result<ICollection<AdmFlujoFormularioNotaDto>>> GetFlujoFormularioNotas(int formularioId);
        Task<Result<AdmFlujoFormularioNotaDto>> GetFlujoFormularioNota(int formularioNotaId);
        Task<Result<AdmFlujoFormularioNotaDto>> CreateFlujoFormularioNotaItem(AdmFlujoFormularioNotaInsertDto admFlujoFormularioNotaInsertDto, string user);
        Task<Result<AdmFlujoFormularioNotaDto>> UpdateFlujoFormularioNotaItem(AdmFlujoFormularioNotaUpdateDto admFlujoFormularioNotaUpdateDto, string user);
        Task<Result<AdmFlujoFormularioNotaDto>> DeleteFlujoFormularioNotaItem(int formularioNotaId, string user);
    }
}
