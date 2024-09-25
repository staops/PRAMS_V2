using AutoMapper;
using FluentResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using PRAMS.Application.Contract.Forms;
using PRAMS.Domain.Entities.Flujos.Dto;
using PRAMS.Domain.Entities.Forms.Dto;
using PRAMS.Domain.Entities.Forms.Entities;
using PRAMS.Domain.Models.Flujos;
using PRAMS.Domain.Models.Forms;
using PRAMS.Infraestructure.Data.SystemConfiguration;
using PRAMS.Infraestructure.Shared;
using System.Reflection;

namespace PRAMS.Infraestructure.Services.Forms
{
    public class FormFlowBuilderService : IFormFlowBuilderService
    {
        private readonly AppConfigDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<IFormFlowBuilderService> _logger;
        private readonly IFormReferidoService _formReferidoService;
        private readonly IFlujosPantallasService _flujosPantallas;
        private readonly IFormulariosFirmasService _formulariosFirmasService;

        public FormFlowBuilderService(AppConfigDbContext context, IMapper mapper, ILogger<IFormFlowBuilderService> logger, IFormReferidoService formReferidoService, IFlujosPantallasService flujosPantallas, IFormulariosFirmasService formulariosFirmasService)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
            _formReferidoService = formReferidoService;
            _flujosPantallas = flujosPantallas;
            _formulariosFirmasService = formulariosFirmasService;
        }

        public async Task<Result<FormFlowBuilderResult>> ValidaFormulario(FormFlowBuilder formFlowBuilder, string user, string role)
        {
            try
            {
                FormFlowBuilderResult formFlowBuilderResult = new();
                Result<FormFlowBuilderResult> result = new Result<FormFlowBuilderResult>();
                List<ISuccess> successs = [];
                List<IError> errors = [];

                // Get the [Adm_FlujosFormularios]
                AdmFlujoFormulario? form = await _context.AdmFlujoFormularios
                    .Where(w => w.FormularioId == formFlowBuilder.FormularioId)
                    .FirstOrDefaultAsync();

                if (form is not null)
                {
                    formFlowBuilderResult.FormaId = formFlowBuilder.FormaId ?? 0;


                    formFlowBuilderResult.AdmFlujoFormulario = _mapper.Map<AdmFlujoFormularioDto>(form);
                    // Get the [Adm_FlujosFormulariosEtapas]
                    AdmFlujoFormularioEtapa? formFlow = await _context.AdmFlujoFormularioEtapas
                        .Where(w => w.FormularioEtapaId == formFlowBuilder.FormularioEtapaId && w.FormularioId == form.FormularioId && w.Activo)
                        .FirstOrDefaultAsync();

                    if (formFlow is not null)
                    {
                        formFlowBuilderResult.AdmFlujoFormularioEtapa = _mapper.Map<AdmFlujoFormularioEtapaDto>(formFlow);
                        // Get the [Adm_FlujosFormulariosEtapasAcciones]
                        AdmFlujoFormularioEtapaAccion? admFlujoFormularioEtapaAccion = await _context.AdmFlujoFormularioEtapaAcciones
                            .Where(w => w.FormularioEtapaId == formFlowBuilder.FormularioEtapaId && w.FormularioEtapaId == formFlow.FormularioEtapaId && w.Activo)
                            .FirstOrDefaultAsync();


                        if (admFlujoFormularioEtapaAccion is not null)
                        {
                            formFlowBuilderResult.AdmFlujoFormularioEtapaAccion = _mapper.Map<AdmFlujoFormularioEtapaAccionDto>(admFlujoFormularioEtapaAccion);
                            // Get all the fields of the form from [Adm_FlujosFormulariosEtapasAccionesCampos]
                            IList<AdmFormularioEtapaAccioneCampo> formFields = await _context.AdmFormularioEtapaAccioneCampos
                            .Where(w => w.FormularioEtapaAccionId == formFlowBuilder.FormularioEtapaAccionId && w.FormularioEtapaAccionId == admFlujoFormularioEtapaAccion.FormularioEtapaAccionId)
                            .OrderBy(o => o.OrdenAccion)
                            .ToListAsync();
                            if (formFields.Count > 0)
                            {
                                formFlowBuilderResult.AdmFormularioEtapaAccioneCampos = _mapper.Map<IList<AdmFlujoFormularioEtapaAccionCampoDto>>(formFields);


                                if (admFlujoFormularioEtapaAccion.TipoAccion == SD.TIPO_ACCION_VALIDACION_CAMPOS)
                                {
                                    // Execute the validation of the TipoProcesocampo
                                    Result<bool> tipoProcesoCampoResult = TipoProcesoCampoValidation(formFields, formFlowBuilder.Fields);
                                    errors.AddRange(tipoProcesoCampoResult.Errors);

                                    // Execute the validation of the TipoDatoCampo
                                    Result<bool> dataTypesResult = DataTypesValidation(formFields, formFlowBuilder);
                                    errors.AddRange(dataTypesResult.Errors);

                                    // Execute the validation of the InvalidFields
                                    Result<bool> invalidFieldsResult = InvalidFieldsValidation(formFlowBuilderResult.AdmFlujoFormulario.TablaBase, formFields, formFlowBuilder);
                                    errors.AddRange(invalidFieldsResult.Errors);

                                    formFlowBuilderResult.CanContinue = errors.Count == 0;
                                    formFlowBuilderResult.IsSectionCompleted = tipoProcesoCampoResult.IsSuccess;
                                }
                                else if (admFlujoFormularioEtapaAccion.TipoAccion == SD.TIPO_ACCION_SEGUIMIENTO_CAMPOS)
                                {
                                    // Execute the validation of the TipoDatoCampo
                                    Result<bool> dataTypesResult = DataTypesValidation(formFields, formFlowBuilder);
                                    errors.AddRange(dataTypesResult.Errors);

                                    // Execute the validation of the TipoProcesocampo
                                    Result<bool> tipoProcesoCampoResult = TipoProcesoCampoValidation(formFields, formFlowBuilder.Fields);

                                    formFlowBuilderResult.CanContinue = errors.Count == 0;
                                    formFlowBuilderResult.IsSectionCompleted = tipoProcesoCampoResult.IsSuccess;
                                }
                                else if (admFlujoFormularioEtapaAccion.TipoAccion == SD.TIPO_ACCION_FIRMAS_PERSONAL)
                                {
                                    // Get the previous FormularioEtapa to validate if the previous action is completed
                                    AdmFlujoFormularioEtapa? admFlujoFormularioEtapaAnterior = await _context.AdmFlujoFormularioEtapas
                                        .Where(w => w.OrdenEtapa == (formFlowBuilderResult.AdmFlujoFormularioEtapa.OrdenEtapa - 1) && w.FormularioId == formFlowBuilder.FormularioId)
                                        .FirstOrDefaultAsync();

                                    if (admFlujoFormularioEtapaAnterior is not null)
                                    {
                                        formFlowBuilderResult.AdmFlujoFormularioEtapaAnterior = _mapper.Map<AdmFlujoFormularioEtapaDto>(admFlujoFormularioEtapaAnterior);

                                        // Get the previous FormFlujoPantalla to validate if the previous action is completed
                                        FormFlujoPantalla? formFlujoPantallaAnterior = await _context.FormFlujoPantallas
                                            .Where(w => w.FormularioId == formFlowBuilder.FormularioId && w.FormaId == formFlowBuilder.FormaId &&
                                                   w.OrdenEtapa == admFlujoFormularioEtapaAnterior.OrdenEtapa)
                                            .OrderByDescending(o => o.FlujoPantallaId)
                                            .FirstOrDefaultAsync();

                                        if (formFlujoPantallaAnterior is not null && formFlujoPantallaAnterior.EtapaCompletada)
                                        {


                                            formFlowBuilder.Fields.Add("UsuarioId", user);
                                            formFlowBuilder.Fields.Add("UserTypeID", role);


                                            // Execute the validation of the TipoProcesocampo
                                            Result<bool> tipoProcesoCampoResult = TipoProcesoCampoValidation(formFields, formFlowBuilder.Fields);
                                            errors.AddRange(tipoProcesoCampoResult.Errors);

                                            formFlowBuilderResult.CanContinue = errors.Count == 0;
                                            formFlowBuilderResult.IsSectionCompleted = tipoProcesoCampoResult.IsSuccess;
                                        }
                                        else
                                        {
                                            formFlowBuilderResult.CanContinue = false;
                                            formFlowBuilderResult.IsSectionCompleted = false;
                                            errors.Add(new Error("No es posible continuar, la acción anterior no está completada"));
                                        }


                                    }
                                }


                            }
                            else
                            {
                                errors.Add(new Error($"No se encontraron campos para la etapa accion {formFlowBuilder.FormularioEtapaAccionId}"));
                            }
                        }
                        else
                        {
                            errors.Add(new Error($"La etapa accion {formFlowBuilder.FormularioEtapaAccionId} no existe en el formulario {form.TipoCaso}"));
                        }
                    }
                    else
                    {
                        errors.Add(new Error($"La etapa {formFlowBuilder.FormularioEtapaAccionId} no existe en el formulario {form.TipoCaso}"));
                    }
                }
                else
                {
                    errors.Add(new Error($"El formulario {formFlowBuilder.FormularioId} no existe"));
                }


                if (errors.Count > 0)
                {
                    formFlowBuilderResult.Errors = errors;

                }
                else
                {
                    result = Result.Ok(formFlowBuilderResult);
                }

                return result.WithErrors(errors);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error in the validation of the form: {error.Message}");
                return Result.Fail<FormFlowBuilderResult>(new Error($"Error in the validation of the form: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<FormFlowBuilderResult>> ValidaFormularioFirma(FormSignatureBuilder formFlowBuilder, string user, string role)
        {
            try
            {
                FormFlowBuilderResult formFlowBuilderResult = new();
                Result<FormFlowBuilderResult> result = new Result<FormFlowBuilderResult>();
                List<ISuccess> successs = [];
                List<IError> errors = [];

                // Get the [Adm_FlujosFormularios]
                AdmFlujoFormulario? form = await _context.AdmFlujoFormularios
                    .Where(w => w.FormularioId == formFlowBuilder.FormularioId)
                    .FirstOrDefaultAsync();

                if (form is not null)
                {

                    formFlowBuilderResult.AdmFlujoFormulario = _mapper.Map<AdmFlujoFormularioDto>(form);

                    formFlowBuilderResult.FormaId = formFlowBuilder.FormaId;

                    //// Get the previous FormularioEtapa to validate if the previous action is completed
                    //AdmFlujoFormularioEtapa? admFlujoFormularioEtapaAnterior = await _context.AdmFlujoFormularioEtapas
                    //    .Where(w => w.OrdenEtapa == (formFlowBuilderResult.AdmFlujoFormularioEtapa.OrdenEtapa - 1) && w.FormularioId == formFlowBuilder.FormularioId)
                    //    .FirstOrDefaultAsync();

                    //if (admFlujoFormularioEtapaAnterior is not null)
                    //formFlowBuilderResult.AdmFlujoFormularioEtapaAnterior = _mapper.Map<AdmFlujoFormularioEtapaDto>(admFlujoFormularioEtapaAnterior);

                    // Get the previous FormFlujoPantalla to validate if the previous action is completed
                    FormFlujoPantalla? formFlujoPantallaAnterior = await _context.FormFlujoPantallas
                        .Where(w => w.FormularioId == formFlowBuilder.FormularioId && w.FormaId == formFlowBuilder.FormaId)
                        .OrderByDescending(o => o.FlujoPantallaId)
                        .FirstOrDefaultAsync();

                    if (formFlujoPantallaAnterior is not null && formFlujoPantallaAnterior.EtapaCompletada)
                    {

                        // Get all the stages of the current form
                        ICollection<AdmFlujoFormularioEtapa> admFlujoFormularioEtapas = await _context.AdmFlujoFormularioEtapas
                            .Where(w => w.FormularioId == formFlowBuilder.FormularioId && w.Activo)
                            .OrderBy(o => o.OrdenEtapa)
                            .ToListAsync();

                        // Get the stage of the last action
                        AdmFlujoFormularioEtapa? lastFormularioEtapaStage = admFlujoFormularioEtapas.FirstOrDefault(f => f.OrdenEtapa == formFlujoPantallaAnterior.OrdenEtapa);
                        // Get the stage of the current action adding 1 to the last stage to know the next stage
                        AdmFlujoFormularioEtapa? currentFormularioEtapaStage = admFlujoFormularioEtapas.FirstOrDefault(f => f.OrdenEtapa == lastFormularioEtapaStage.OrdenEtapa + 1);

                        if (currentFormularioEtapaStage is not null)
                        {
                            formFlowBuilderResult.AdmFlujoFormularioEtapa = _mapper.Map<AdmFlujoFormularioEtapaDto>(currentFormularioEtapaStage);
                            // Get the [Adm_FlujosFormulariosEtapasAcciones]
                            AdmFlujoFormularioEtapaAccion? admFlujoFormularioEtapaAccion = await _context.AdmFlujoFormularioEtapaAcciones
                                .Where(w => w.FormularioEtapaId == currentFormularioEtapaStage.FormularioEtapaId && w.FormularioEtapaId == currentFormularioEtapaStage.FormularioEtapaId && w.Activo)
                                .FirstOrDefaultAsync();


                            if (admFlujoFormularioEtapaAccion is not null)
                            {
                                formFlowBuilderResult.AdmFlujoFormularioEtapaAccion = _mapper.Map<AdmFlujoFormularioEtapaAccionDto>(admFlujoFormularioEtapaAccion);

                                // Get all the fields of the form from [Adm_FlujosFormulariosEtapasAccionesCampos]
                                IList<AdmFormularioEtapaAccioneCampo> formFields = await _context.AdmFormularioEtapaAccioneCampos
                                .Where(w => w.FormularioEtapaAccionId == admFlujoFormularioEtapaAccion.FormularioEtapaAccionId && w.FormularioEtapaAccionId == admFlujoFormularioEtapaAccion.FormularioEtapaAccionId)
                                .OrderBy(o => o.OrdenAccion)
                                .ToListAsync();
                                if (formFields.Count > 0)
                                {
                                    formFlowBuilderResult.AdmFormularioEtapaAccioneCampos = _mapper.Map<IList<AdmFlujoFormularioEtapaAccionCampoDto>>(formFields);

                                    formFlowBuilder.Fields.Add("UsuarioId", user);
                                    formFlowBuilder.Fields.Add("UserTypeID", role);


                                    // Execute the validation of the TipoProcesocampo
                                    Result<bool> tipoProcesoCampoResult = TipoProcesoCampoValidation(formFields, formFlowBuilder.Fields);
                                    errors.AddRange(tipoProcesoCampoResult.Errors);

                                    formFlowBuilderResult.CanContinue = errors.Count == 0;
                                    formFlowBuilderResult.IsSectionCompleted = tipoProcesoCampoResult.IsSuccess;
                                }
                            }
                        }
                    }
                    else
                    {
                        formFlowBuilderResult.CanContinue = false;
                        formFlowBuilderResult.IsSectionCompleted = false;
                        errors.Add(new Error($"No es posible continuar, la acción anterior no está completada"));
                    }


                }



                if (errors.Count > 0)
                {
                    formFlowBuilderResult.Errors = errors;

                }
                else
                {
                    result = Result.Ok(formFlowBuilderResult);
                }

                return result.WithErrors(errors);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error in the validation of the form: {error.Message}");
                return Result.Fail<FormFlowBuilderResult>(new Error($"Error in the validation of the form: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<object>> CreaRegistrosFormulario(FormFlowBuilder formFlowBuilder, string user, string role)
        {
            try
            {
                Result<object> result = new Result<object>();

                List<ISuccess> successs = [];
                List<IError> errors = [];


                Result<FormFlowBuilderResult> validationRresult = await ValidaFormulario(formFlowBuilder, user, role);
                errors.AddRange(validationRresult.Errors);
                if (validationRresult.IsSuccess)
                {

                    // Get the distinct tables to fill from formularioEtapasAcciones
                    IList<string> tables = validationRresult.Value.AdmFormularioEtapaAccioneCampos?.Select(s => s.TablaBase).Distinct().ToList() ?? new List<string>();

                    foreach (string tableName in tables)
                    {
                        // Just save the data if the form is completed and can continue is true
                        if (validationRresult.Value.AdmFlujoFormularioEtapaAccion?.Completado == true && validationRresult.Value.CanContinue)
                        {


                            if (validationRresult.Value.AdmFlujoFormularioEtapaAccion.TipoAccion == SD.TIPO_ACCION_VALIDACION_CAMPOS)
                            {
                                // Save the data in the database
                                Result<dynamic?> saveFormDataResult = await SaveFormData(formFlowBuilder, validationRresult.Value, tableName, user, role);
                                if (saveFormDataResult.IsSuccess && saveFormDataResult.ValueOrDefault is not null)
                                {
                                    successs.Add(new Success("The form has been saved successfully"));

                                    result = saveFormDataResult.ValueOrDefault;
                                }
                                else
                                {
                                    errors.AddRange(saveFormDataResult.Errors);
                                }
                            }
                            else if (validationRresult.Value.AdmFlujoFormularioEtapaAccion.TipoAccion == SD.TIPO_ACCION_SEGUIMIENTO_CAMPOS)
                            {
                                if (formFlowBuilder.FormaId is not null && formFlowBuilder.FormaId > 0)
                                {
                                    // Update the data in the database
                                    Result<dynamic?> updateFormDataResult = await UpdateFormData(formFlowBuilder, validationRresult.Value, user);
                                    if (updateFormDataResult.IsSuccess && updateFormDataResult.ValueOrDefault is not null)
                                    {
                                        successs.Add(new Success("The form has been updated successfully"));

                                        result = updateFormDataResult.ValueOrDefault;
                                    }
                                    else
                                    {
                                        errors.AddRange(updateFormDataResult.Errors);
                                    }
                                }
                                else
                                {
                                    errors.Add(new Error("The form id is required to update the form"));
                                }
                            }
                            else if (validationRresult.Value.AdmFlujoFormularioEtapaAccion.TipoAccion == SD.TIPO_ACCION_FIRMAS_PERSONAL)
                            {

                                // Save the data in the database
                                Result<dynamic?> saveFormDataResult = await SaveFormFirmaData(formFlowBuilder.Fields, validationRresult.Value, tableName, user, role);
                                if (saveFormDataResult.IsSuccess && saveFormDataResult.ValueOrDefault is not null)
                                {
                                    successs.Add(new Success("The form has been saved successfully"));

                                    result = saveFormDataResult.ValueOrDefault;
                                }
                                else
                                {
                                    errors.AddRange(saveFormDataResult.Errors);
                                }


                            }
                        }

                    }

                }

                return result.WithErrors(errors);
            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error al crear el registro del formulario: {error.Message}");
                return Result.Fail<object>(new Error($"Error al crear el registro del formulario: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<object>> SignFormulario(FormSignatureBuilder formSignature, string user, string role)
        {
            try
            {
                Result<object> result = new Result<object>();

                List<ISuccess> successs = [];
                List<IError> errors = [];


                Result<FormFlowBuilderResult> validationRresult = await ValidaFormularioFirma(formSignature, user, role);
                errors.AddRange(validationRresult.Errors);
                if (validationRresult.IsSuccess)
                {
                    // Get the distinct tables to fill from formularioEtapasAcciones
                    IList<string> tables = validationRresult.Value.AdmFormularioEtapaAccioneCampos?.Select(s => s.TablaBase).Distinct().ToList() ?? new List<string>();

                    foreach (string tableName in tables)
                    {

                        if (validationRresult.Value.AdmFlujoFormularioEtapaAccion?.TipoAccion == SD.TIPO_ACCION_FIRMAS_PERSONAL)
                        {

                            // Save the data in the database
                            Result<dynamic?> saveFormDataResult = await SaveFormFirmaData(formSignature.Fields, validationRresult.Value, tableName, user, role);
                            if (saveFormDataResult.IsSuccess && saveFormDataResult.ValueOrDefault is not null)
                            {
                                successs.Add(new Success("The form has been saved successfully"));

                                result = saveFormDataResult.ValueOrDefault;
                            }
                            else
                            {
                                errors.AddRange(saveFormDataResult.Errors);
                            }


                        }
                    }

                }
                return result.WithErrors(errors);
            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error al crear el registro del formulario: {error.Message}");
                return Result.Fail<object>(new Error($"Error al crear el registro del formulario: {error.Message}")).WithError(error.Message);
            }
        }

        private async Task<Result<object?>> SaveFormData(FormFlowBuilder formFlowBuilder, FormFlowBuilderResult formFlow, string tableName, string user, string role)
        {
            try
            {
                Result<FormFlowBuilderObjectResult<object>> result = Result.Ok();
                List<IError> errors = [];




                switch (tableName.ToUpper())
                {

                    // Save the data in the table FORM_REFERIDOS
                    case SD.FORM_REFERIDOS:

                        // Create a new instance of FormReferidoInsertDto using reflection
                        FormReferidoInsertDto? formReferidoInsertDto = new();

                        // Fields to Json objet
                        string jsonFields = JsonConvert.SerializeObject(formFlowBuilder.Fields);
                        formReferidoInsertDto = JsonConvert.DeserializeObject<FormReferidoInsertDto>(jsonFields);


                        // Save the new record in the database
                        Result<FormReferidoDto> formReferidoResult = await _formReferidoService.CreateFormReferido(formReferidoInsertDto, user);
                        if (formReferidoResult.IsSuccess)
                        {
                            FormFlujoPantallaInsertDto itemToInsert = new()
                            {
                                FormularioId = formFlowBuilder.FormularioId,
                                FormaId = formReferidoResult.Value.ReferidoId,
                                OrdenEtapa = formFlow.AdmFlujoFormularioEtapa?.OrdenEtapa ?? 0,
                                FlujoEtapa = formFlow.AdmFlujoFormularioEtapa?.NombreEtapa ?? string.Empty,
                                FechaFlujo = DateTime.Now,
                                UsuarioFlujoId = user,
                                RMO = string.Empty, // TODO: Get the RMO from the user
                                NumeroCaso = string.Empty, // TODO: Get the NumeroCaso from the user
                                Persona = string.Empty, // TODO: Get the Persona from the user
                                //FlujoStatus = formFlow.AdmFlujoFormularioEtapaAccion?.NombreAccion,
                                FlujoStatus = formFlow.AdmFlujoFormularioEtapa?.TipoEtapa,
                                Notas = string.Empty, // TODO: Get the Notas from the user
                                Comentarios = string.Empty, // TODO: Get the Comentarios from the user
                                EtapaCompletada = formFlow.IsSectionCompleted,
                                Region = string.Empty, // TODO: Get the Region from the user
                                Local = string.Empty, // TODO: Get the Local from the user                                
                            };

                            Result<FormFlujoPantallaDto> flujoPantalla = await _flujosPantallas.CreateFlujoPantalla(itemToInsert, user);
                            if (flujoPantalla.IsSuccess)
                            {
                                // Set the result to the response

                                FormFlowBuilderObjectResult<FormReferidoDto> formFlowBuilderObjectResult = new()
                                {
                                    Object = formReferidoResult.Value,
                                    formFlujoPantallaInsertDto = flujoPantalla.ValueOrDefault,
                                    CanContinue = true
                                };
                                return formFlowBuilderObjectResult;
                            }
                            else
                            {
                                // Add the errors to the response
                                errors.AddRange(flujoPantalla.Errors);
                            }
                        }
                        else
                        {
                            // Add the errors to the response
                            errors.AddRange(formReferidoResult.Errors);
                        }
                        break;
                    case SD.FORM_FORMULARIOSFIRMAS:

                        // Create a new instance of FormFormularioFirmaInsertDto using reflection
                        FormFormularioFirmaInsertDto? formFormularioFirmaDto = new();

                        // Fields to Json objet
                        string jsonFieldsFirma = JsonConvert.SerializeObject(formFlowBuilder.Fields);
                        formFormularioFirmaDto = JsonConvert.DeserializeObject<FormFormularioFirmaInsertDto>(jsonFieldsFirma);

                        // Extra fields
                        //formFormularioFirmaDto.UsuarioId = user;
                        //formFormularioFirmaDto.UserTypeID = role;
                        //formFormularioFirmaDto.FechaFirma = DateTime.Now;
                        formFormularioFirmaDto.FormularioId = formFlowBuilder.FormularioId;
                        formFormularioFirmaDto.FormularioEtapaId = formFlowBuilder.FormularioEtapaId;
                        formFormularioFirmaDto.NumCaso = string.Empty;

                        // Save the new record in the database
                        Result<FormFormularioFirmaDto> formularioFirmaDtoResult = await _formulariosFirmasService.CreateFormularioFirma(formFormularioFirmaDto, user, role);
                        if (formularioFirmaDtoResult.IsSuccess)
                        {
                            FormFlujoPantallaInsertDto itemToInsert = new()
                            {
                                FormularioId = formFlowBuilder.FormularioId,
                                FormaId = formularioFirmaDtoResult.Value.FormularioId,
                                OrdenEtapa = formFlow.AdmFlujoFormularioEtapa.OrdenEtapa,
                                FlujoEtapa = formFlow.AdmFlujoFormularioEtapa.NombreEtapa,
                                FechaFlujo = DateTime.Now,
                                UsuarioFlujoId = user,
                                RMO = formFormularioFirmaDto.Rmo, // TODO: Get the RMO from the user
                                NumeroCaso = string.Empty, // TODO: Get the NumeroCaso from the user
                                Persona = string.Empty, // TODO: Get the Persona from the user
                                //FlujoStatus = formFlow.AdmFlujoFormularioEtapaAccion.NombreAccion,
                                FlujoStatus = formFlow.AdmFlujoFormularioEtapa?.TipoEtapa,
                                Notas = string.Empty, // TODO: Get the Notas from the user
                                Comentarios = string.Empty, // TODO: Get the Comentarios from the user
                                EtapaCompletada = formFlow.IsSectionCompleted,
                                Region = string.Empty, // TODO: Get the Region from the user
                                Local = string.Empty // TODO: Get the Local from the user
                            };

                            Result<FormFlujoPantallaDto> flujoPantalla = await _flujosPantallas.CreateFlujoPantalla(itemToInsert, user);
                            if (flujoPantalla.IsSuccess)
                            {
                                // Set the result to the response
                                FormFlowBuilderObjectResult<FormFormularioFirmaDto> formFlowBuilderObjectResult = new()
                                {
                                    Object = formularioFirmaDtoResult.Value,
                                    formFlujoPantallaInsertDto = flujoPantalla.ValueOrDefault,
                                    CanContinue = true
                                };
                                return formFlowBuilderObjectResult;
                            }
                            else
                            {
                                // Add the errors to the response
                                errors.AddRange(flujoPantalla.Errors);
                            }
                        }
                        else
                        {
                            // Add the errors to the response
                            errors.AddRange(formularioFirmaDtoResult.Errors);
                        }



                        break;
                    default:
                        errors.Add(new Error($"La tabla base {formFlow.AdmFlujoFormulario?.TablaBase} no es válida"));
                        break;
                }



                if (errors.Count > 0)
                {
                    return Result.Fail<object?>(errors.ToArray());
                }
                return result;

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error al guardar los datos del formulario: {error.Message}");
                return Result.Fail(new Error($"Error al guardar los datos del formulario: {error.Message}")).WithError(error.Message);
            }
        }

        private async Task<Result<dynamic?>> UpdateFormData(FormFlowBuilder formFlowBuilder, FormFlowBuilderResult formFlow, string user)
        {
            try
            {
                List<IError> errors = [];

                switch (formFlow.AdmFlujoFormulario?.TablaBase.ToUpper())
                {
                    // Update the data in the table FORM_REFERIDOS
                    case SD.FORM_REFERIDOS:

                        // Look for the record in the database
                        Result<FormReferidoDto> formReferidoResult = await _formReferidoService.GetFormReferido(formFlowBuilder.FormaId ?? 0);
                        errors.AddRange(formReferidoResult.Errors);
                        if (formReferidoResult.IsSuccess)
                        {
                            // Create a new instance of FormReferidoUpdateDto using reflection
                            FormReferidoUpdateDto? formReferidoUpdateDto = _mapper.Map<FormReferidoUpdateDto>(formReferidoResult.Value);

                            // Fields to Json objet
                            string jsonFields = JsonConvert.SerializeObject(formFlowBuilder.Fields);
                            FormReferidoUpdateDto formReferidoUpdateDtoToMerge = JsonConvert.DeserializeObject<FormReferidoUpdateDto>(jsonFields);

                            formReferidoUpdateDto = _mapper.Map(formReferidoUpdateDtoToMerge, formReferidoUpdateDto);

                            formReferidoUpdateDto.ReferidoId = formFlowBuilder.FormaId ?? 0;


                            Result<FormReferidoDto> updateResult = await _formReferidoService.UpdateFormReferido(formReferidoUpdateDto, user);
                            errors.AddRange(updateResult.Errors);
                            if (updateResult.IsSuccess)
                            {

                                FormFlujoPantallaInsertDto itemToInsert = new()
                                {
                                    FormularioId = formFlowBuilder.FormularioId,
                                    FormaId = formReferidoResult.Value.ReferidoId,
                                    OrdenEtapa = formFlow.AdmFlujoFormularioEtapa.OrdenEtapa,
                                    FlujoEtapa = formFlow.AdmFlujoFormularioEtapa.NombreEtapa,
                                    FechaFlujo = DateTime.Now,
                                    UsuarioFlujoId = user,
                                    RMO = formReferidoUpdateDto.RMO ?? string.Empty, // TODO: Get the RMO from the user
                                    NumeroCaso = string.Empty, // TODO: Get the NumeroCaso from the user
                                    Persona = string.Empty, // TODO: Get the Persona from the user
                                    //FlujoStatus = formFlow.AdmFlujoFormularioEtapaAccion.NombreAccion,
                                    FlujoStatus = formFlow.AdmFlujoFormularioEtapa?.TipoEtapa,
                                    Notas = string.Empty, // TODO: Get the Notas from the user
                                    Comentarios = string.Empty, // TODO: Get the Comentarios from the user
                                    EtapaCompletada = formFlow.IsSectionCompleted,
                                    Region = string.Empty, // TODO: Get the Region from the user
                                    Local = string.Empty // TODO: Get the Local from the user
                                };

                                Result<FormFlujoPantallaDto> flujoPantalla = await _flujosPantallas.CreateFlujoPantalla(itemToInsert, user);
                                if (flujoPantalla.IsSuccess)
                                {
                                    // Set the result to the response
                                    FormFlowBuilderObjectResult<FormReferidoDto> formFlowBuilderObjectResult = new()
                                    {
                                        Object = updateResult.ValueOrDefault,
                                        formFlujoPantallaInsertDto = flujoPantalla.ValueOrDefault,
                                        CanContinue = true
                                    };
                                    return formFlowBuilderObjectResult;
                                }
                                else
                                {
                                    // Add the errors to the response
                                    errors.AddRange(flujoPantalla.Errors);
                                }
                            }
                        }

                        break;
                    default:
                        errors.Add(new Error($"La tabla base {formFlow.AdmFlujoFormulario?.TablaBase} no es válida"));
                        break;
                }

                if (errors.Count > 0)
                {
                    return Result.Fail<dynamic?>(errors.ToArray());
                }
                else return Result.Ok<dynamic?>(null);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error al actualizar los datos del formulario: {error.Message}");
                return Result.Fail<dynamic?>(new Error($"Error al actualizar los datos del formulario: {error.Message}")).WithError(error.Message);
            }
        }

        private async Task<Result<object?>> SaveFormFirmaData(IDictionary<string, object> fields, FormFlowBuilderResult formFlow, string tableName, string user, string role)
        {
            try
            {
                Result<FormFlowBuilderObjectResult<object>> result = Result.Ok();
                List<IError> errors = [];


                // Create a new instance of FormFormularioFirmaInsertDto using reflection
                FormFormularioFirmaInsertDto formFormularioFirmaDto = new();
                foreach (var field in fields)
                {
                    PropertyInfo? property = formFormularioFirmaDto.GetType().GetProperty(field.Key, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
                    string? accioneCampo = field.Key;
                    if (accioneCampo is not null)
                    {
                        property?.SetValue(formFormularioFirmaDto, ParserValue(property, field.Value));
                    }
                }

                // Extra fields
                //formFormularioFirmaDto.UsuarioId = user;
                //formFormularioFirmaDto.UserTypeID = role;
                //formFormularioFirmaDto.FechaFirma = DateTime.Now;
                formFormularioFirmaDto.FormularioId = formFlow.AdmFlujoFormulario?.FormularioId ?? 0;
                formFormularioFirmaDto.FormularioEtapaId = formFlow.AdmFlujoFormularioEtapa?.FormularioEtapaId ?? 0;
                formFormularioFirmaDto.NumCaso = string.Empty;
                formFormularioFirmaDto.FormaId = formFlow.FormaId;
                formFormularioFirmaDto.Rmo ??= string.Empty;

                // Save the new record in the database
                Result<FormFormularioFirmaDto> formularioFirmaDtoResult = await _formulariosFirmasService.CreateFormularioFirma(formFormularioFirmaDto, user, role);
                if (formularioFirmaDtoResult.IsSuccess)
                {
                    FormFlujoPantallaInsertDto itemToInsert = new()
                    {
                        FormularioId = formFlow.AdmFlujoFormulario?.FormularioId ?? 0,
                        FormaId = formFlow.FormaId,
                        OrdenEtapa = formFlow.AdmFlujoFormularioEtapa.OrdenEtapa,
                        FlujoEtapa = formFlow.AdmFlujoFormularioEtapa.NombreEtapa,
                        //FechaFlujo = DateTime.Now,
                        //UsuarioFlujoId = user,
                        RMO = formFormularioFirmaDto.Rmo, // TODO: Get the RMO from the user
                        NumeroCaso = string.Empty, // TODO: Get the NumeroCaso from the user
                        Persona = string.Empty, // TODO: Get the Persona from the user
                        //FlujoStatus = formFlow.AdmFlujoFormularioEtapaAccion.NombreAccion,
                        FlujoStatus = formFlow.AdmFlujoFormularioEtapa?.TipoEtapa,
                        Notas = string.Empty, // TODO: Get the Notas from the user
                        Comentarios = string.Empty, // TODO: Get the Comentarios from the user
                        EtapaCompletada = formFlow.IsSectionCompleted,
                        Region = string.Empty, // TODO: Get the Region from the user
                        Local = string.Empty, // TODO: Get the Local from the user

                    };

                    Result<FormFlujoPantallaDto> flujoPantalla = await _flujosPantallas.CreateFlujoPantalla(itemToInsert, user);
                    if (flujoPantalla.IsSuccess)
                    {
                        // Set the result to the response
                        FormFlowBuilderObjectResult<FormFormularioFirmaDto> formFlowBuilderObjectResult = new()
                        {
                            Object = formularioFirmaDtoResult.Value,
                            formFlujoPantallaInsertDto = flujoPantalla.ValueOrDefault,
                            CanContinue = true
                        };
                        return formFlowBuilderObjectResult;
                    }
                    else
                    {
                        // Add the errors to the response
                        errors.AddRange(flujoPantalla.Errors);
                    }
                }
                else
                {
                    // Add the errors to the response
                    errors.AddRange(formularioFirmaDtoResult.Errors);
                }






                if (errors.Count > 0)
                {
                    return Result.Fail<object?>(errors.ToArray());
                }
                return result;

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error al guardar los datos del formulario: {error.Message}");
                return Result.Fail(new Error($"Error al guardar los datos del formulario: {error.Message}")).WithError(error.Message);
            }
        }


        #region Helper Methods

        private static object? ParserValue(AdmFlujoFormularioEtapaAccionCampoDto admFormularioEtapaAccione, object value)
        {
            try
            {
                switch (admFormularioEtapaAccione.CampoDBTipo)
                {
                    case SD.TIPO_DATO_INT:
                        return (int?)Convert.ChangeType(value, typeof(int));
                    case SD.TIPO_DATO_DECIMAL:
                        return (decimal?)Convert.ChangeType(value, typeof(decimal));
                    case SD.TIPO_DATO_BOOL:
                        return (bool?)Convert.ChangeType(value, typeof(bool));
                    case SD.TIPO_DATO_FECHA:
                        return (DateTime?)Convert.ChangeType(value, typeof(DateTime));
                    case SD.TIPO_DATO_TEXTO:
                        return (string?)Convert.ChangeType(value, typeof(string));
                    default:
                        return (string?)Convert.ChangeType(value, typeof(string));
                }
            }
            catch (Exception error)
            {
                return null;
            }

        }

        private static object? ParserValue(PropertyInfo info, object value)
        {
            try
            {
                switch (info.PropertyType.Name)
                {
                    case "Int32":
                        return (int?)Convert.ChangeType(value, typeof(int));
                    case "Decimal":
                        return (decimal?)Convert.ChangeType(value, typeof(decimal));
                    case "Boolean":
                        return (bool?)Convert.ChangeType(value, typeof(bool));
                    case "DateTime":
                        return (DateTime?)Convert.ChangeType(value, typeof(DateTime));
                    case "String":
                        return (string?)Convert.ChangeType(value, typeof(string));
                    default:
                        return (string?)Convert.ChangeType(value, typeof(string));
                }
            }
            catch (Exception error)
            {
                return null;
            }

        }

        /// <summary>
        /// Function to parse object to DateTime
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private DateTime? ParseDateTime(object value)
        {
            if (value is not null)
            {
                if (DateTime.TryParse(value.ToString(), out DateTime dateValue))
                {
                    return dateValue;
                }
            }

            return null;
        }

        /// <summary>
        /// Function to parse object to int
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private int? ParseInt(object value)
        {
            if (value is not null)
            {
                if (int.TryParse(value.ToString(), out int intValue))
                {
                    return intValue;
                }
            }

            return null;
        }

        // Function to parse object to decimal
        private decimal? ParseDecimal(object value)
        {
            if (value is not null)
            {
                if (decimal.TryParse(value.ToString(), out decimal decimalValue))
                {
                    return decimalValue;
                }
            }

            return null;
        }

        // Function to parse object to bool
        private bool? ParseBool(object value)
        {
            if (value is not null)
            {
                if (bool.TryParse(value.ToString(), out bool boolValue))
                {
                    return boolValue;
                }
            }

            return null;
        }

        // Function to parse object to string
        private string? ParseString(object value)
        {
            if (value is not null)
            {
                return value.ToString();
            }

            return null;
        }

        // Function to exec the validation in the TipoProcesocampo
        private Result<bool> TipoProcesoCampoValidation(IList<AdmFormularioEtapaAccioneCampo> formFields, IDictionary<string, object> fields)
        {
            try
            {
                IList<IError> errors = [];

                foreach (AdmFormularioEtapaAccioneCampo formField in formFields)
                {
                    switch (formField.TipoProcesoCampo)
                    {
                        case SD.TIENE_VALOR:

                            fields.TryGetValue(formField.CampoDBIDField, out object? value);
                            if (value is null)
                            {
                                errors.Add(new Error(formField.Resultado).WithMetadata("TIPO_PROCESO", value).WithMetadata("CAMPODBIDFIELD", formField.CampoDBIDField));
                            }
                            break;
                        case SD.LARGO_MINIMO:
                            fields.TryGetValue(formField.CampoDBIDField, out object? largeValue);
                            if (largeValue is null || !MinLength(largeValue.ToString() ?? string.Empty, formField.CampoDBLongitud))
                            {
                                errors.Add(new Error(formField.Resultado).WithMetadata("TIPO_PROCESO", largeValue).WithMetadata("CAMPODBIDFIELD", formField.CampoDBIDField));
                            }
                            break;
                        case SD.FIRMA_ST:
                            fields.TryGetValue(formField.CampoDBIDField, out object? firmaValue);
                            if (firmaValue is null || !FirmaTS(firmaValue.ToString() ?? string.Empty))
                            {
                                errors.Add(new Error(formField.Resultado).WithMetadata("TIPO_PROCESO", firmaValue).WithMetadata("CAMPODBIDFIELD", formField.CampoDBIDField));
                            }
                            break;
                        case SD.FIRMA_SUP:
                            fields.TryGetValue(formField.CampoDBIDField, out object? firmaSupValue);
                            if (firmaSupValue is null || !FirmaSup(firmaSupValue.ToString() ?? string.Empty))
                            {
                                errors.Add(new Error(formField.Resultado).WithMetadata("TIPO_PROCESO", firmaSupValue).WithMetadata("CAMPODBIDFIELD", formField.CampoDBIDField));
                            }
                            break;
                        default:
                            break;
                    }

                }

                if (errors.Count > 0)
                {
                    return Result.Fail<bool>(errors.ToArray());
                }

                return Result.Ok(true);
            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error en las validaciones del formulario: {error.Message}");
                return Result.Fail<bool>(new Error($"Error en las validaciones del formulario: {error.Message}")).WithError(error.Message);
            }
        }

        private Result<bool> DataTypesValidation(IList<AdmFormularioEtapaAccioneCampo> formFields, FormFlowBuilder formFlowBuilder)
        {
            try
            {
                IList<IError> errors = [];

                foreach (AdmFormularioEtapaAccioneCampo formField in formFields)
                {
                    formFlowBuilder.Fields.TryGetValue(formField.CampoDBIDField, out object? value);
                    if (value is not null)
                    {
                        switch (formField.CampoDBTipo)
                        {
                            case SD.TIPO_DATO_INT:
                                // Validate if the value is an integer
                                if (!int.TryParse(value.ToString(), out int intValue))
                                {
                                    errors.Add(new Error(formField.Resultado).WithMetadata("INVALID_DATA_TYPE", value).WithMetadata("CAMPODBIDFIELD", formField.CampoDBIDField));
                                }

                                break;
                            case SD.TIPO_DATO_DECIMAL:
                                // Validate if the value is a decimal
                                if (!decimal.TryParse(value.ToString(), out decimal decimalValue))
                                {
                                    errors.Add(new Error(formField.Resultado).WithMetadata("INVALID_DATA_TYPE", value).WithMetadata("CAMPODBIDFIELD", formField.CampoDBIDField));
                                }

                                break;
                            case SD.TIPO_DATO_BOOL:
                                // Validate if the value is a boolean
                                if (!bool.TryParse(value.ToString(), out bool boolValue))
                                {
                                    errors.Add(new Error(formField.Resultado).WithMetadata("INVALID_DATA_TYPE", value).WithMetadata("CAMPODBIDFIELD", formField.CampoDBIDField));
                                }

                                break;
                            case SD.TIPO_DATO_FECHA:
                                // Validate if the value is a date
                                if (!DateTime.TryParse(value.ToString(), out DateTime dateValue))
                                {
                                    errors.Add(new Error(formField.Resultado).WithMetadata("INVALID_DATA_TYPE", value).WithMetadata("CAMPODBIDFIELD", formField.CampoDBIDField));
                                }

                                break;
                            case SD.TIPO_DATO_TEXTO:
                                // Validate if the value is a string
                                if (value.GetType() != typeof(string))
                                {
                                    errors.Add(new Error(formField.Resultado).WithMetadata("INVALID_DATA_TYPE", value).WithMetadata("CAMPODBIDFIELD", formField.CampoDBIDField));
                                }

                                break;
                            default:
                                break;
                        }
                    }
                }

                if (errors.Count > 0)
                {
                    return Result.Fail<bool>(errors.ToArray());
                }

                return Result.Ok(true);
            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error en las validaciones del formulario: {error.Message}");
                return Result.Fail<bool>(new Error($"Error en las validaciones del formulario: {error.Message}")).WithError(error.Message);
            }
        }

        private Result<bool> InvalidFieldsValidation(string tablaBase, IList<AdmFormularioEtapaAccioneCampo> formFields, FormFlowBuilder formFlowBuilder)
        {
            try
            {
                IList<IError> errors = [];


                switch (tablaBase.ToUpper())
                {

                    // Save the data in the table FORM_REFERIDOS
                    case SD.FORM_REFERIDOS:

                        // Create a new instance of FormReferidoInsertDto using reflection
                        FormReferidoInsertDto formReferidoInsertDto = new();

                        // Validate fields that are not in the form
                        foreach (var field in formFlowBuilder.Fields)
                        {
                            if (!formFields.Any(a => a.CampoDBIDField == field.Key))
                            {
                                PropertyInfo? property = formReferidoInsertDto.GetType().GetProperty(field.Key, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
                                if (property is null)
                                {
                                    errors.Add(new Error($"El campo {field.Key} no pertenece al formulario").WithMetadata("INVALID_FORM_FIELD", field.Key));
                                }
                            }

                        }
                        break;
                    default:
                        // Validate fields that are not in the form
                        foreach (var field in formFlowBuilder.Fields)
                        {
                            errors.Add(new Error($"El campo {field.Key} no pertenece al formulario").WithMetadata("INVALID_FORM_FIELD", field.Key));
                        }
                        break;
                }


                if (errors.Count > 0)
                {
                    return Result.Fail<bool>(errors.ToArray());
                }

                return Result.Ok(true);
            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error en las validaciones del formulario: {error.Message}");
                return Result.Fail<bool>(new Error($"Error en las validaciones del formulario: {error.Message}")).WithError(error.Message);
            }
        }

        private static bool HasValue(object value)
        {
            return value is not null;
        }

        private static bool MinLength(string value, int length)
        {
            return value.Length >= length;
        }

        private static bool FirmaTS(string value)
        {
            return value is not null;
        }

        private static bool FirmaSup(string value)
        {
            return value is not null;
        }


        #endregion

    }
}
