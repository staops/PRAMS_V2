using FluentResults;
using PRAMS.Domain.Entities.People.Dto;

namespace PRAMS.Application.Contract.People
{
    public interface IFlujosFormulariosEtapasAccionesService
    {
        Task<Result<ICollection<AdmFlujoFormularioEtapaAccionDto>>> GetFlujosFormulariosEtapasAccionesByFormularioEtapaId(int formularioEtapaId);
        Task<Result<AdmFlujoFormularioEtapaAccionDto>> GetFlujoFormularioEtapaAccion(int formularioEtapaAccionId);
        Task<Result<AdmFlujoFormularioEtapaAccionDto>> CreateFlujoFormularioEtapaAccionItem(AdmFlujoFormularioEtapaAccionInsertDto admFlujoFormularioEtapaAccionInsertDto, string user);
        Task<Result<AdmFlujoFormularioEtapaAccionDto>> UpdateFlujoFormularioEtapaAccionItem(AdmFlujoFormularioEtapaAccionUpdateDto admFlujoFormularioEtapaAccionUpdateDto, string user);
        Task<Result<AdmFlujoFormularioEtapaAccionDto>> DeleteFlujoFormularioEtapaAccionItem(int formularioEtapaAccionId, string user);
    }
}
