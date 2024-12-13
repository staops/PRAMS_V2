using AutoMapper;
using FluentResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using PRAMS.Application.Contract.Forms;
using PRAMS.Application.Contract.SystemConfiguration;
using PRAMS.Domain.Entities.Flujos.Dto;
using PRAMS.Domain.Entities.Forms.Dto;
using PRAMS.Domain.Entities.Forms.Entities;
using PRAMS.Domain.Entities.SystemConfiguration.Dto;
using PRAMS.Domain.Models.Flujos;
using PRAMS.Domain.Models.Forms;
using PRAMS.Infraestructure.Data.SystemConfiguration;
using PRAMS.Infraestructure.Shared;
using System;
using System.Drawing;
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
        private readonly ICatalogsService _catalogsService;

        public FormFlowBuilderService(AppConfigDbContext context, IMapper mapper, ILogger<IFormFlowBuilderService> logger, IFormReferidoService formReferidoService, IFlujosPantallasService flujosPantallas, IFormulariosFirmasService formulariosFirmasService, ICatalogsService catalogsService)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
            _formReferidoService = formReferidoService;
            _flujosPantallas = flujosPantallas;
            _formulariosFirmasService = formulariosFirmasService;
            _catalogsService = catalogsService;
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

                        // Get the previous FormularioEtapa to validate if the previous action is completed
                        formFlowBuilderResult.AdmFlujoFormularioEtapaAnterior = await GetPreviousFormularioEtapa(formFlowBuilderResult.AdmFlujoFormularioEtapa.OrdenEtapa, formFlowBuilder.FormularioId);
                        // Get the next FormularioEtapa
                        formFlowBuilderResult.AdmFlujoFormularioEtapaSiguiente = await GetNextFormularioEtapa(formFlowBuilderResult.AdmFlujoFormularioEtapa.OrdenEtapa, formFlowBuilder.FormularioId);


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

                                    if (formFlowBuilderResult.AdmFlujoFormularioEtapaAnterior is not null)
                                    {
                                        // Get the previous FormFlujoPantalla to validate if the previous action is completed
                                        FormFlujoPantalla? formFlujoPantallaAnterior = await _context.FormFlujoPantallas
                                            .Where(w => w.FormularioId == formFlowBuilder.FormularioId &&
                                                   w.FormaId == formFlowBuilder.FormaId &&
                                                   w.OrdenEtapa == formFlowBuilderResult.AdmFlujoFormularioEtapaAnterior.OrdenEtapa)
                                            .OrderByDescending(o => o.FlujoPantallaId)
                                            .FirstOrDefaultAsync();

                                        if (formFlujoPantallaAnterior is not null && formFlujoPantallaAnterior.EtapaCompletada)
                                        {
                                            formFlowBuilder.Fields.Add("ID_Usuario", user);
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

        // Get the previous FormularioEtapa to validate if the previous action is completed
        private async Task<AdmFlujoFormularioEtapaDto?> GetPreviousFormularioEtapa(int ordenEtapa, int formularioId)
        {
            AdmFlujoFormularioEtapa? admFlujoFormularioEtapaAnterior = await _context.AdmFlujoFormularioEtapas
                .Where(w => w.OrdenEtapa == (ordenEtapa - 1) && w.FormularioId == formularioId)
                .FirstOrDefaultAsync();

            return _mapper.Map<AdmFlujoFormularioEtapaDto>(admFlujoFormularioEtapaAnterior);
        }

        // Get the next FormularioEtapa
        private async Task<AdmFlujoFormularioEtapaDto?> GetNextFormularioEtapa(int ordenEtapa, int formularioId)
        {
            AdmFlujoFormularioEtapa? admFlujoFormularioEtapaSiguiente = await _context.AdmFlujoFormularioEtapas
                .Where(w => w.OrdenEtapa == (ordenEtapa + 1) && w.FormularioId == formularioId)
                .FirstOrDefaultAsync();

            return _mapper.Map<AdmFlujoFormularioEtapaDto>(admFlujoFormularioEtapaSiguiente);
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

                    formFlowBuilderResult.FormaId = formFlowBuilder.FormaId ?? 0;

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
                Result<object> result = new();

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
                                // Build the RMO
                                // La region es requerida para construir el RMO
                                formFlowBuilder.Fields.TryGetValue("region", out object? regionValue);
                                // El local es requerido para construir el RMO
                                formFlowBuilder.Fields.TryGetValue("local", out object? localValue);

                                // Get the region and local values to build the RMO
                                Result<AdmParametrosNivel0Dto> getDataRmo = await GetRmo(localValue?.ToString()!);

                                Result<string> rmoResult = await BuildRmo(regionValue?.ToString()!, localValue?.ToString()!);
                                if (rmoResult.IsSuccess && getDataRmo.IsSuccess)
                                {
                                    formFlowBuilder.Fields.Add("rmo", rmoResult.ValueOrDefault);
                                }
                                else
                                {
                                    errors.AddRange(rmoResult.Errors);
                                    errors.AddRange(getDataRmo.Errors);
                                }

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
                                Result<dynamic?> saveFormDataResult = await SaveFormFirmaData(formFlowBuilder.Fields, formFlowBuilder, validationRresult.Value, tableName, user, role);
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
                            Result<dynamic?> saveFormDataResult = await SaveFormFirmaData(formSignature.Fields, formSignature, validationRresult.Value, tableName, user, role);
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
                                RMO = formReferidoResult.Value.RMO,
                                NumeroCaso = null, // TODO: Get the NumeroCaso from the user
                                Persona = null, // TODO: Get the Persona from the user
                                //FlujoStatus = formFlow.AdmFlujoFormularioEtapaAccion?.NombreAccion,
                                FlujoStatus = formFlow.AdmFlujoFormularioEtapa?.TipoEtapa,
                                Notas = null, // TODO: Get the Notas from the user
                                Comentarios = null, // TODO: Get the Comentarios from the user
                                EtapaCompletada = formFlow.IsSectionCompleted,
                                Region = formFlowBuilder.Fields.TryGetValue("region", out object? regionValue) ? regionValue.ToString() : string.Empty,
                                Local = formFlowBuilder.Fields.TryGetValue("local", out object? localValue) ? localValue.ToString() : string.Empty
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
                                NumeroCaso = null, // TODO: Get the NumeroCaso from the user
                                Persona = null, // TODO: Get the Persona from the user
                                //FlujoStatus = formFlow.AdmFlujoFormularioEtapaAccion.NombreAccion,
                                FlujoStatus = formFlow.AdmFlujoFormularioEtapa?.TipoEtapa,
                                Notas = null, // TODO: Get the Notas from the user
                                Comentarios = null, // TODO: Get the Comentarios from the user
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
                if (formFlow is not null && formFlow.AdmFlujoFormularioEtapa is not null && formFlow.AdmFlujoFormulario is not null)
                {
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
                                FormReferidoUpdateDto? formReferidoUpdateDtoToMerge = JsonConvert.DeserializeObject<FormReferidoUpdateDto>(jsonFields);

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
                                        RMO = updateResult.Value.RMO,
                                        NumeroCaso = null,
                                        Persona = null, // TODO: Get the Persona from the user
                                        //FlujoStatus = formFlow.AdmFlujoFormularioEtapaAccion.NombreAccion,
                                        FlujoStatus = formFlow.AdmFlujoFormularioEtapa?.TipoEtapa,
                                        Notas = null, // TODO: Get the Notas from the user
                                        Comentarios = null, // TODO: Get the Comentarios from the user
                                        EtapaCompletada = formFlow.IsSectionCompleted,
                                        Region = updateResult.Value.Region,
                                        Local = updateResult.Value.Local,
                                    };

                                    // Get the last record in the table [FormFlujoPantallas]
                                    var getlastFlujoPantalla = await _flujosPantallas.GetFlujosPantallasByFormaId(formFlowBuilder.FormaId ?? 0, formFlowBuilder.FormularioId);
                                    FormFlujoPantallaDto? formFlujoPantallaDto = getlastFlujoPantalla.ValueOrDefault.LastOrDefault();


                                    // Just If the user if the user is not the same as the user that created the record then create a new record in the table [FormFlujoPantallas] or when the formFlujoPantallaDto o
                                    if (InsertNewFlujoPantalla(itemToInsert, formFlujoPantallaDto))
                                    {

                                        Result<FormFlujoPantallaDto> flujoPantalla = await _flujosPantallas.CreateFlujoPantalla(itemToInsert, user);
                                        if (flujoPantalla.IsSuccess)
                                        {
                                            // If the current FormFlujoPantallaInsertDto is completed then is required to create a new one with the next stage
                                            if (flujoPantalla.Value.EtapaCompletada && formFlow.AdmFlujoFormularioEtapaSiguiente is not null)
                                            {
                                                // Buil the next FormFlujoPantallaInsertDto
                                                FormFlujoPantallaInsertDto itemToInsertNext = new()
                                                {
                                                    FormularioId = formFlowBuilder.FormularioId,
                                                    FormaId = formReferidoResult.Value.ReferidoId,
                                                    OrdenEtapa = formFlow.AdmFlujoFormularioEtapaSiguiente.OrdenEtapa,
                                                    FlujoEtapa = formFlow.AdmFlujoFormularioEtapaSiguiente.NombreEtapa,
                                                    FechaFlujo = DateTime.Now,
                                                    UsuarioFlujoId = user,
                                                    RMO = updateResult.Value.RMO,
                                                    NumeroCaso = null,
                                                    Persona = null, // TODO: Get the Persona from the user
                                                    //FlujoStatus = formFlow.AdmFlujoFormularioEtapaAccion.NombreAccion,
                                                    FlujoStatus = formFlow.AdmFlujoFormularioEtapaSiguiente?.TipoEtapa,
                                                    Notas = null, // TODO: Get the Notas from the user
                                                    Comentarios = null, // TODO: Get the Comentarios from the user
                                                    EtapaCompletada = false,
                                                    Region = updateResult.Value.Region,
                                                    Local = updateResult.Value.Local,
                                                };

                                                // Create the next record in the table [FormFlujoPantallas]
                                                Result<FormFlujoPantallaDto> flujoPantallaNext = await _flujosPantallas.CreateFlujoPantalla(itemToInsertNext, user);

                                                if (flujoPantallaNext.IsSuccess)
                                                {
                                                    // Set the result to the response
                                                    FormFlowBuilderObjectResult<FormReferidoDto> formFlowBuilderObjectResultNext = new()
                                                    {
                                                        Object = updateResult.ValueOrDefault,
                                                        formFlujoPantallaInsertDto = flujoPantallaNext.ValueOrDefault,
                                                        CanContinue = true
                                                    };
                                                    return formFlowBuilderObjectResultNext;
                                                }
                                                else
                                                {
                                                    // Add the errors to the response
                                                    errors.AddRange(flujoPantallaNext.Errors);
                                                }

                                            }


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
                                    else
                                    {


                                        // Set the result to the response
                                        FormFlowBuilderObjectResult<FormReferidoDto> formFlowBuilderObjectResult = new()
                                        {
                                            Object = updateResult.ValueOrDefault,
                                            formFlujoPantallaInsertDto = getlastFlujoPantalla.ValueOrDefault.FirstOrDefault(),
                                            CanContinue = true
                                        };
                                        return formFlowBuilderObjectResult;
                                    }
                                }
                            }

                            break;
                        default:
                            errors.Add(new Error($"La tabla base {formFlow.AdmFlujoFormulario?.TablaBase} no es válida"));
                            break;
                    }
                }
                else
                {
                    errors.Add(new Error("No se encontraron datos para actualizar"));
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

        private bool InsertNewFlujoPantalla(FormFlujoPantallaInsertDto newFlujo, FormFlujoPantallaDto? oldFlujo)
        {
            if (oldFlujo is not null)
            {
                // If the user if the user is not the same as the user that created the record then create a new record in the table [FormFlujoPantallas]
                if (oldFlujo.UsuarioFlujoId != newFlujo.UsuarioFlujoId)
                {
                    return true;
                }
                // If the OrderEtapa is different then create a new record in the table [FormFlujoPantallas]
                if (oldFlujo.OrdenEtapa != newFlujo.OrdenEtapa)
                {
                    return true;
                }
                // If the EtapaCompletada is different then create a new record in the table [FormFlujoPantallas]
                if (oldFlujo.EtapaCompletada != newFlujo.EtapaCompletada)
                {
                    return true;
                }

            }
            return false;
        }

        private async Task<Result<object?>> SaveFormFirmaData(IDictionary<string, object> fields, FormFlowBuilder formFlowBuilder, FormFlowBuilderResult formFlow, string tableName, string user, string role)
        {
            try
            {
                Result<FormFlowBuilderObjectResult<object>> result = Result.Ok();
                List<IError> errors = [];

                // Create a new instance of FormReferidoInsertDto using reflection
                FormFormularioFirmaInsertDto? formFormularioFirmaDto = new();


                // Fields to Json objet
                string jsonFields = JsonConvert.SerializeObject(formFlowBuilder.Fields);
                formFormularioFirmaDto = JsonConvert.DeserializeObject<FormFormularioFirmaInsertDto>(jsonFields);

                int formularioId = formFlow.AdmFlujoFormulario?.FormularioId ?? 0;
                int formularioEtapaId = formFlow.AdmFlujoFormularioEtapa?.FormularioEtapaId ?? 0;
                int formaId = formFlowBuilder?.FormaId ?? 0;
                // Validate if the signature exists
                Result<FormFormularioFirmaDto> currentSign = await _formulariosFirmasService.GetFormularioFirmaByFormStageAndFormaId(formularioId, formularioEtapaId, formaId);

                if (currentSign.IsFailed)
                {

                    // Extra fields
                    //formFormularioFirmaDto.UsuarioId = user;
                    //formFormularioFirmaDto.UserTypeID = role;
                    //formFormularioFirmaDto.FechaFirma = DateTime.Now;
                    formFormularioFirmaDto.FormularioId = formularioId;
                    formFormularioFirmaDto.FormularioEtapaId = formularioEtapaId;
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
                            NumeroCaso = null, // TODO: Get the NumeroCaso from the user
                            Persona = null, // TODO: Get the Persona from the user
                                            //FlujoStatus = formFlow.AdmFlujoFormularioEtapaAccion.NombreAccion,
                            FlujoStatus = formFlow.AdmFlujoFormularioEtapa?.TipoEtapa,
                            Notas = null, // TODO: Get the Notas from the user
                            Comentarios = null, // TODO: Get the Comentarios from the user
                            EtapaCompletada = formFlow.IsSectionCompleted,
                            Region = formFormularioFirmaDto.Region,
                            Local = formFormularioFirmaDto.Local

                        };

                        // Get the last record in the table [FormFlujoPantallas]
                        var getlastFlujoPantalla = await _flujosPantallas.GetFlujosPantallasByFormaId(formFlowBuilder.FormaId ?? 0, formFlowBuilder.FormularioId);
                        FormFlujoPantallaDto? formFlujoPantallaDto = getlastFlujoPantalla.ValueOrDefault.LastOrDefault();


                        // Just If the user if the user is not the same as the user that created the record then create a new record in the table [FormFlujoPantallas] or when the formFlujoPantallaDto o
                        if (InsertNewFlujoPantalla(itemToInsert, formFlujoPantallaDto))
                        {

                            Result<FormFlujoPantallaDto> flujoPantalla = await _flujosPantallas.CreateFlujoPantalla(itemToInsert, user);
                            if (flujoPantalla.IsSuccess)
                            {

                                // If the current FormFlujoPantallaInsertDto is completed then is required to create a new one with the next stage
                                if (flujoPantalla.Value.EtapaCompletada && formFlow.AdmFlujoFormularioEtapaSiguiente is not null)
                                {
                                    // Buil the next FormFlujoPantallaInsertDto
                                    FormFlujoPantallaInsertDto itemToInsertNext = new()
                                    {
                                        FormularioId = formFlowBuilder.FormularioId,
                                        FormaId = formFlow.FormaId,
                                        OrdenEtapa = formFlow.AdmFlujoFormularioEtapaSiguiente.OrdenEtapa,
                                        FlujoEtapa = formFlow.AdmFlujoFormularioEtapaSiguiente.NombreEtapa,
                                        FechaFlujo = DateTime.Now,
                                        UsuarioFlujoId = user,
                                        RMO = formFormularioFirmaDto.Rmo, // TODO: Get the RMO from the user
                                        NumeroCaso = null,
                                        Persona = null, // TODO: Get the Persona from the user
                                                        //FlujoStatus = formFlow.AdmFlujoFormularioEtapaAccion.NombreAccion,
                                        FlujoStatus = formFlow.AdmFlujoFormularioEtapaSiguiente?.TipoEtapa,
                                        Notas = null, // TODO: Get the Notas from the user
                                        Comentarios = null, // TODO: Get the Comentarios from the user
                                        EtapaCompletada = false,
                                        Region = formFormularioFirmaDto.Region,
                                        Local = formFormularioFirmaDto.Local
                                    };

                                    // Create the next record in the table [FormFlujoPantallas]
                                    Result<FormFlujoPantallaDto> flujoPantallaNext = await _flujosPantallas.CreateFlujoPantalla(itemToInsertNext, user);

                                    if (flujoPantallaNext.IsSuccess)
                                    {
                                        // Set the result to the response
                                        FormFlowBuilderObjectResult<FormFormularioFirmaDto> formFlowBuilderObjectResultNext = new()
                                        {
                                            Object = formularioFirmaDtoResult.Value,
                                            formFlujoPantallaInsertDto = flujoPantallaNext.ValueOrDefault,
                                            CanContinue = true
                                        };
                                        return formFlowBuilderObjectResultNext;
                                    }
                                    else
                                    {
                                        // Add the errors to the response
                                        errors.AddRange(flujoPantallaNext.Errors);
                                    }

                                }

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

                            // Set the result to the response
                            FormFlowBuilderObjectResult<FormFormularioFirmaDto> formFlowBuilderObjectResult = new()
                            {
                                Object = formularioFirmaDtoResult.ValueOrDefault,
                                formFlujoPantallaInsertDto = getlastFlujoPantalla.ValueOrDefault.FirstOrDefault(),
                                CanContinue = true
                            };
                            return formFlowBuilderObjectResult;
                        }
                    }
                    else
                    {
                        // Add the errors to the response
                        errors.AddRange(formularioFirmaDtoResult.Errors);
                    }

                }
                else
                {
                    errors.Add(new Error("La firma ya existe"));
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

        private async Task<Result<string>> BuildRmo(string region, string local)
        {
            try
            {
                string rmo = string.Empty;
                region = region.PadLeft(2, '0');
                local = local.PadLeft(4, '0');

                // Get the count by region and local
                Result<int> countResult = await _flujosPantallas.GetCountByRegionAndLocal(region, local);
                if (countResult.IsSuccess)
                {
                    // Sample of RMO: 03-3801-10000
                    rmo = $"{region}-{local}-{countResult.Value + 10001}";

                    return Result.Ok(rmo);
                }
                else
                {
                    return Result.Fail<string>(countResult.Errors.ToArray());
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error al crear el RMO: {error.Message}");
                return Result.Fail<string>(new Error($"Error al crear el RMO: {error.Message}")).WithError(error.Message);
            }
        }

        private async Task<Result<AdmParametrosNivel0Dto>> GetRmo(string local)
        {
            try
            {
                // Search the region in the multitable service
                Result<ICollection<AdmParametrosNivel0Dto>> regionResult = await _catalogsService.GetCatalogZero(37);
                if (regionResult.IsSuccess)
                {
                    AdmParametrosNivel0Dto? itmCatRegion = regionResult.Value.Where(a => a.TX_FilterTwo == local).FirstOrDefault();
                    if (itmCatRegion is not null)
                    {
                        return Result.Ok(itmCatRegion);
                    }
                    else
                    {
                        return Result.Fail<AdmParametrosNivel0Dto>(new Error($"No se encontró la región para el local {local}"));
                    }
                }
                else
                {
                    return Result.Fail<AdmParametrosNivel0Dto>(regionResult.Errors.ToArray());
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error al obtener el RMO: {error.Message}");
                return Result.Fail<AdmParametrosNivel0Dto>(new Error($"Error al obtener el RMO: {error.Message}")).WithError(error.Message);
            }

        }

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

                var comparer = StringComparer.OrdinalIgnoreCase;
                var caseInsensitiveDictionary = new Dictionary<string, object>(comparer);

                foreach (var field in fields)
                {
                    caseInsensitiveDictionary.Add(field.Key, field.Value);
                }


                foreach (AdmFormularioEtapaAccioneCampo formField in formFields)
                {
                    switch (formField.TipoProcesoCampo)
                    {
                        case SD.TIENE_VALOR:

                            caseInsensitiveDictionary.TryGetValue(formField.CampoDBIDField, out object? value);
                            if (value is null)
                            {
                                errors.Add(new Error(formField.Resultado).WithMetadata("TIPO_PROCESO", value).WithMetadata("CAMPODBIDFIELD", formField.CampoDBIDField));
                            }
                            break;
                        case SD.LARGO_MINIMO:
                            caseInsensitiveDictionary.TryGetValue(formField.CampoDBIDField, out object? largeValue);
                            if (largeValue is null || !MinLength(largeValue.ToString() ?? string.Empty, formField.CampoDBLongitud))
                            {
                                errors.Add(new Error(formField.Resultado).WithMetadata("TIPO_PROCESO", largeValue).WithMetadata("CAMPODBIDFIELD", formField.CampoDBIDField));
                            }
                            break;
                        case SD.FIRMA_ST:
                            caseInsensitiveDictionary.TryGetValue(formField.CampoDBIDField, out object? firmaValue);
                            if (firmaValue is null || !FirmaTS(firmaValue.ToString() ?? string.Empty))
                            {
                                errors.Add(new Error(formField.Resultado).WithMetadata("TIPO_PROCESO", firmaValue).WithMetadata("CAMPODBIDFIELD", formField.CampoDBIDField));
                            }
                            break;
                        case SD.FIRMA_SUP:
                            caseInsensitiveDictionary.TryGetValue(formField.CampoDBIDField, out object? firmaSupValue);
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
                formFields = formFields.Where(w => w.TablaBase == tablaBase).ToList();
                // White list of fields that are not in the form
                IDictionary<string, string> whiteList = new Dictionary<string, string>
                {
                    { "region", "Form_Referidos" },
                    { "local", "Form_Referidos" }
                };

                switch (tablaBase.ToUpper())
                {

                    // Save the data in the table FORM_REFERIDOS
                    case SD.FORM_REFERIDOS:

                        // Create a new instance of FormReferidoInsertDto using reflection
                        FormReferidoInsertDto formReferidoInsertDto = new();

                        // Validate fields that are not in the form
                        foreach (var field in formFlowBuilder.Fields)
                        {

                            bool isWhiteList = whiteList.ContainsKey(field.Key) && whiteList[field.Key] == tablaBase;


                            if (!formFields.Any(a => a.CampoDBIDField == field.Key) && !isWhiteList)
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
