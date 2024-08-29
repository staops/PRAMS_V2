using FluentResults;
using PRAMS.Domain.Entities.Forms.Dto;
using PRAMS.Domain.Entities.People.Dto;
using PRAMS.Domain.Entities.Shared;

namespace PRAMS.Application.Contract.Forms
{
    public interface IFormReferidoService
    {

        Task<Result<ICollection<FormReferidoDto>>> GetFormReferidos();
        Task<Result<DtResult<FormReferidoDto>>> ListFormReferidos(FilterCriteria filterCriteria);
        Task<Result<FormReferidoDto>> GetFormReferido(int formReferidoId);
        Task<Result<FormReferidoDto>> CreateFormReferido(FormReferidoInsertDto formReferidoInsertDto, string user);
        Task<Result<FormReferidoDto>> UpdateFormReferido(FormReferidoUpdateDto formReferidoUpdateDto, string user);
        Task<Result<FormReferidoDto>> RemoveFormReferido(int formReferidoId, string user);

    }
}
