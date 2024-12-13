﻿using FluentResults;
using PRAMS.Domain.Entities.Forms.Dto;

namespace PRAMS.Application.Contract.Forms
{
    public interface IFormulariosFirmasService
    {
        Task<Result<ICollection<FormFormularioFirmaDto>>> GetFormulariosFirmas();
        Task<Result<FormFormularioFirmaDto>> GetFormularioFirma(int formularioFirmaId);
        Task<Result<FormFormularioFirmaDto>> GetFormularioFirmaByFormStageAndFormaId(int formularioId, int formularioEtapaId, int formaId);
        Task<Result<ICollection<FormFormularioFirmaDto>>> GetFormularioFirmaByFormularioEtapa(int formularioEtapaId);
        Task<Result<FormFormularioFirmaDto>> CreateFormularioFirma(FormFormularioFirmaInsertDto itemToInsert, string user, string role);
        Task<Result<FormFormularioFirmaDto>> RemoveFormularioFirma(int formularioFirmaId, string user);
        Task<Result<FormFormularioFirmaDto>> UpdateFormularioFirma(FormFormularioFirmaUpdateDto itemToUpdate, string user);
    }
}
