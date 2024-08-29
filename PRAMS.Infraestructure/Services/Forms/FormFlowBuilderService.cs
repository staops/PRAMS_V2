﻿using AutoMapper;
using FluentResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PRAMS.Application.Contract.Forms;
using PRAMS.Domain.Entities.Flujos.Dto;
using PRAMS.Domain.Entities.Forms.Dto;
using PRAMS.Domain.Entities.Forms.Entities;
using PRAMS.Domain.Models.Flujos;
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

        public FormFlowBuilderService(AppConfigDbContext context, IMapper mapper, ILogger<IFormFlowBuilderService> logger, IFormReferidoService formReferidoService)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
            _formReferidoService = formReferidoService;
        }

        public async Task<Result<FormFlowBuilderResult>> ValidaFormulario(FormFlowBuilder formFlowBuilder)
        {
            try
            {
                FormFlowBuilderResult formFlowBuilderResult = new();
                Result<FormFlowBuilderResult> result = Result.Ok(formFlowBuilderResult);
                List<ISuccess> successs = [];
                List<IError> errors = [];

                // Get the [Adm_FlujosFormularios]
                AdmFlujoFormulario? form = await _context.AdmFlujoFormularios
                    .Where(w => w.FormularioId == formFlowBuilder.FormularioId)
                    .FirstOrDefaultAsync();

                if (form is not null)
                {

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
                                    Result<bool> tipoProcesoCampoResult = TipoProcesoCampoValidation(formFields, formFlowBuilder);
                                    errors.AddRange(tipoProcesoCampoResult.Errors);

                                    // Execute the validation of the TipoDatoCampo
                                    Result<bool> dataTypesResult = DataTypesValidation(formFields, formFlowBuilder);
                                    errors.AddRange(dataTypesResult.Errors);

                                    // Execute the validation of the InvalidFields
                                    Result<bool> invalidFieldsResult = InvalidFieldsValidation(formFields, formFlowBuilder);
                                    errors.AddRange(invalidFieldsResult.Errors);


                                    formFlowBuilderResult.CanContinue = errors.Count == 0;

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

                return Result.Ok(formFlowBuilderResult).WithSuccesses(successs);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error in the validation of the form: {error.Message}");
                return Result.Fail<FormFlowBuilderResult>(new Error($"Error in the validation of the form: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<object>> CreaRegistrosFormulario(FormFlowBuilder formFlowBuilder, string user)
        {
            try
            {
                Result<object> result = Result.Ok();

                List<ISuccess> successs = [];
                List<IError> errors = [];


                Result<FormFlowBuilderResult> validationRresult = await ValidaFormulario(formFlowBuilder);
                if (result.IsSuccess)
                {


                    // Just save the data if the form is completed and can continue is true
                    if (validationRresult.Value.AdmFlujoFormularioEtapaAccion?.Completado == true && validationRresult.Value.CanContinue)
                    {
                        // Save the data in the database
                        Result<object> saveFormDataResult = await SaveFormData(formFlowBuilder, validationRresult.Value, user);
                        if (saveFormDataResult.IsSuccess)
                        {
                            successs.Add(new Success("The form has been saved successfully"));

                            result = Result.Ok(saveFormDataResult.Value);
                        }
                        else
                        {
                            errors.AddRange(saveFormDataResult.Errors);
                        }
                    }
                    else
                    {
                        result = Result.Ok(validationRresult);
                    }
                }




                if (errors.Count > 0)
                {
                    return Result.Fail<object>(errors.ToArray());
                }
                return result;
            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error al crear el registro del formulario: {error.Message}");
                return Result.Fail<FormFlowBuilderResult>(new Error($"Error al crear el registro del formulario: {error.Message}")).WithError(error.Message);
            }
        }

        private async Task<Result<object>> SaveFormData(FormFlowBuilder formFlowBuilder, FormFlowBuilderResult formFlow, string user)
        {
            try
            {
                Result<object> result = Result.Ok();
                List<IError> errors = [];

                switch (formFlow.AdmFlujoFormulario?.TablaBase.ToUpper())
                {
                    case SD.FORM_REFERIDOS:

                        // Create a new instance of FormReferidoInsertDto using reflection
                        FormReferidoInsertDto formReferidoInsertDto = new();
                        foreach (var field in formFlowBuilder.Fields)
                        {
                            PropertyInfo? property = formReferidoInsertDto.GetType().GetProperty(field.Key);
                            AdmFlujoFormularioEtapaAccionCampoDto? accioneCampo = formFlow.AdmFormularioEtapaAccioneCampos?.FirstOrDefault(f => f.CampoDBIDField == field.Key);
                            if (accioneCampo is not null)
                            {
                                property?.SetValue(formReferidoInsertDto, ParserValue(accioneCampo, field.Value));
                            }
                        }

                        // Save the new record in the database
                        Result<FormReferidoDto> formReferidoResult = await _formReferidoService.CreateFormReferido(formReferidoInsertDto, user);
                        if (formReferidoResult.IsSuccess)
                        {
                            // Set the result to the response

                            FormFlowBuilderObjectResult<FormReferidoDto> formFlowBuilderObjectResult = new()
                            {
                                AdmFlujoFormulario = formFlow.AdmFlujoFormulario,
                                AdmFlujoFormularioEtapa = formFlow.AdmFlujoFormularioEtapa,
                                AdmFlujoFormularioEtapaAccion = formFlow.AdmFlujoFormularioEtapaAccion,
                                AdmFormularioEtapaAccioneCampos = formFlow.AdmFormularioEtapaAccioneCampos,
                                Object = formReferidoResult.Value,
                                CanContinue = true
                            };

                            result = Result.Ok(formFlowBuilderObjectResult);
                        }
                        else
                        {
                            // Add the errors to the response
                            errors.AddRange(formReferidoResult.Errors);
                        }

                        break;
                    default:
                        errors.Add(new Error($"La tabla base {formFlow.AdmFlujoFormulario?.TablaBase} no es válida"));
                        break;
                }


                if (errors.Count > 0)
                {
                    return Result.Fail<object>(errors.ToArray());
                }
                return result;

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error al guardar los datos del formulario: {error.Message}");
                return Result.Fail<object>(new Error($"Error al guardar los datos del formulario: {error.Message}")).WithError(error.Message);
            }
        }

        private static object ParserValue(AdmFlujoFormularioEtapaAccionCampoDto admFormularioEtapaAccione, object value)
        {

            switch (admFormularioEtapaAccione.CampoDBTipo)
            {
                case SD.TIPO_DATO_INT:
                    return (int)Convert.ChangeType(value, typeof(int));
                case SD.TIPO_DATO_DECIMAL:
                    return (decimal)Convert.ChangeType(value, typeof(decimal));
                case SD.TIPO_DATO_BOOL:
                    return (bool)Convert.ChangeType(value, typeof(bool));
                case SD.TIPO_DATO_FECHA:
                    return (DateTime)Convert.ChangeType(value, typeof(DateTime));
                case SD.TIPO_DATO_TEXTO:
                    return (string)Convert.ChangeType(value, typeof(string));
                default:
                    return (string)Convert.ChangeType(value, typeof(string));

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
        private Result<bool> TipoProcesoCampoValidation(IList<AdmFormularioEtapaAccioneCampo> formFields, FormFlowBuilder formFlowBuilder)
        {
            try
            {
                IList<IError> errors = [];

                foreach (AdmFormularioEtapaAccioneCampo formField in formFields)
                {
                    switch (formField.TipoProcesoCampo)
                    {
                        case SD.TIENE_VALOR:

                            formFlowBuilder.Fields.TryGetValue(formField.CampoDBIDField, out object? value);
                            if (value is null)
                            {
                                errors.Add(new Error(formField.Resultado).WithMetadata("TIPO_PROCESO", value).WithMetadata("CAMPODBIDFIELD", formField.CampoDBIDField));
                            }
                            break;
                        case SD.LARGO_MINIMO:
                            formFlowBuilder.Fields.TryGetValue(formField.CampoDBIDField, out object? largeValue);
                            if (largeValue is null || !MinLength(largeValue.ToString() ?? string.Empty, formField.CampoDBLongitud))
                            {
                                errors.Add(new Error(formField.Resultado).WithMetadata("TIPO_PROCESO", largeValue).WithMetadata("CAMPODBIDFIELD", formField.CampoDBIDField));
                            }
                            break;
                        case SD.FIRMA_ST:
                            formFlowBuilder.Fields.TryGetValue(formField.CampoDBIDField, out object? firmaValue);
                            if (firmaValue is null || !FirmaTS(firmaValue.ToString() ?? string.Empty))
                            {
                                errors.Add(new Error(formField.Resultado).WithMetadata("TIPO_PROCESO", firmaValue).WithMetadata("CAMPODBIDFIELD", formField.CampoDBIDField));
                            }
                            break;
                        case SD.FIRMA_SUP:
                            formFlowBuilder.Fields.TryGetValue(formField.CampoDBIDField, out object? firmaSupValue);
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

        private Result<bool> InvalidFieldsValidation(IList<AdmFormularioEtapaAccioneCampo> formFields, FormFlowBuilder formFlowBuilder)
        {
            try
            {
                IList<IError> errors = [];

                // Validate fields that are not in the form
                foreach (var field in formFlowBuilder.Fields)
                {
                    if (!formFields.Any(a => a.CampoDBIDField == field.Key))
                    {
                        errors.Add(new Error($"El campo {field.Key} no pertenece al formulario").WithMetadata("INVALID_FORM_FIELD", field.Key));
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
            return value.Length == 8;
        }

        private static bool FirmaSup(string value)
        {
            return value.Length == 8;
        }

    }
}
