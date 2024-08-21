using FluentResults;
using PRAMS.Domain.Entities.Flujos.Dto;

namespace PRAMS.Application.Contract.Flujos
{
    public interface IFlujosFormulariosEtapasService
    {
        Task<Result<ICollection<AdmFlujoFormularioEtapaDto>>> GetFlujosFormulariosEtapas();
        Task<Result<AdmFlujoFormularioEtapaDto>> GetFlujoFormularioEtapa(int formularioEtapaId);
        Task<Result<AdmFlujoFormularioEtapaDto>> CreateFlujoFormularioEtapa(AdmFlujoFormularioEtapaInsertDto itemToInsert, string user);
        Task<Result<bool>> RemoveFlujoFormularioEtapa(int formularioEtapaId, string user);
        Task<Result<AdmFlujoFormularioEtapaDto>> UpdateFlujoFormularioEtapa(AdmFlujoFormularioEtapaUpdateDto itemToUpdate, string user);
    }
}
