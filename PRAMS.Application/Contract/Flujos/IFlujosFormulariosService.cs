using FluentResults;
using PRAMS.Domain.Entities.Flujos.Dto;
using PRAMS.Domain.Entities.People.Dto;

namespace PRAMS.Application.Contract.Flujos
{
    public interface IFlujosFormulariosService
    {
        Task<Result<ICollection<AdmFlujoFormularioDto>>> GetFlujosFormularios();
        Task<Result<AdmFlujoFormularioDto>> GetFlujoFormulario(int formularioId);
        Task<Result<AdmFlujoFormularioDto>> CreateFlujoFormulario(AdmFlujoFormularioInsertDto itemToInsert, string user);
        Task<Result<AdmFlujoFormularioDto>> RemoveFlujoFormulario(int formularioId, string user);
        Task<Result<AdmFlujoFormularioDto>> UpdateFlujoFormulario(AdmFlujoFormularioUpdateDto itemToUpdate, string user);
    }
}
