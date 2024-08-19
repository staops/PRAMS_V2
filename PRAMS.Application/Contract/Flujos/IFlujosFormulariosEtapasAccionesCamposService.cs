using FluentResults;
using PRAMS.Domain.Entities.Flujos.Dto;

namespace PRAMS.Application.Contract.Flujos
{
    public interface IFlujosFormulariosEtapasAccionesCamposService
    {
        Task<Result<ICollection<AdmFlujoFormularioEtapaAccionCampoDto>>> GetFlujosFormulariosEtapasAccionesCampos();
        Task<Result<AdmFlujoFormularioEtapaAccionCampoDto>> GetFlujoFormularioEtapaAccionCampo(int formularioEtapaAccionCampoId);
        Task<Result<ICollection<AdmFlujoFormularioEtapaAccionCampoDto>>> GetFlujoFormularioEtapaAccionCampoByFormularioEtapaAccionId(int formularioEtapaAccionId);
        Task<Result<AdmFlujoFormularioEtapaAccionCampoDto>> CreateFlujoFormularioEtapaAccionCampo(AdmFlujoFormularioEtapaAccionCampoInsertDto itemToInsert, string user);
        Task<Result<AdmFlujoFormularioEtapaAccionCampoDto>> RemoveFlujoFormularioEtapaAccionCampo(int formularioEtapaAccionCampoId, string user);
        Task<Result<AdmFlujoFormularioEtapaAccionCampoDto>> UpdateFlujoFormularioEtapaAccionCampo(AdmFlujoFormularioEtapaAccionCampoUpdateDto itemToUpdate, string user);
    }
}
