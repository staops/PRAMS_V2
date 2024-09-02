using FluentResults;
using PRAMS.Domain.Entities.Forms.Dto;
using PRAMS.Domain.Entities.Shared;

namespace PRAMS.Application.Contract.Forms
{
    public interface IFlujosPantallasService
    {
        Task<Result<ICollection<FormFlujoPantallaDto>>> GetFlujosPantallas();
        Task<Result<FormFlujoPantallaDto>> GetFlujoPantalla(int flujoPantallaId);
        Task<Result<ICollection<FormFlujoPantallaDto>>> GetFlujosPantallasByFormularioId(int formularioId);
        Task<Result<ICollection<FormFlujoPantallaDto>>> GetFlujosPantallasByFormaId(int formaId);
        Task<Result<FormFlujoPantallaDto>> CreateFlujoPantalla(FormFlujoPantallaInsertDto itemToInsert, string user);
        Task<Result<FormFlujoPantallaDto>> RemoveFlujoPantalla(int flujoPantallaId, string user);
        Task<Result<FormFlujoPantallaDto>> UpdateFlujoPantalla(FormFlujoPantallaUpdateDto itemToUpdate, string user);
        Task<Result<DtResult<FormFlujoPantallaDto>>> ListFlujosPantallass(FilterCriteria filterCriteria);

    }
}
