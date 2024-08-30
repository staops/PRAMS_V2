using FluentResults;
using PRAMS.Domain.Entities.Forms.Entities;

namespace PRAMS.Application.Contract.Forms
{
    public interface IFormFlowBuilderService
    {
        Task<Result<FormFlowBuilderResult>> ValidaFormulario(FormFlowBuilder formFlowBuilder);
        Task<Result<object>> CreaRegistrosFormulario(FormFlowBuilder formFlowBuilder, string user);

    }
}
