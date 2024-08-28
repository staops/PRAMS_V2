using AutoMapper;
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

        public FormFlowBuilderService(AppConfigDbContext context, IMapper mapper, ILogger<IFormFlowBuilderService> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }



        public async Task<Result<FormFlowBuilderResult>> ValidaFormulario(FormFlowBuilder formFlowBuilder)
        {
            try
            {
                FormFlowBuilderResult formFlowBuilderResult = new();
                List<ISuccess> successs = [];
                List<IError> errors = [];

                // Get the [Adm_FlujosFormularios]
                AdmFlujoFormulario? form = await _context.AdmFlujoFormularios
                    .Where(w => w.FormularioId == formFlowBuilder.FormularioId)
                    .FirstOrDefaultAsync();

                if (form is not null)
                {

                    // Get the [Adm_FlujosFormulariosEtapas]
                    AdmFlujoFormularioEtapa? formFlow = await _context.AdmFlujoFormularioEtapas
                        .Where(w => w.FormularioEtapaId == formFlowBuilder.FormularioEtapaId && w.FormularioId == form.FormularioId && w.Activo)
                        .FirstOrDefaultAsync();

                    if (formFlow is not null)
                    {
                        // Get the [Adm_FlujosFormulariosEtapasAcciones]
                        AdmFlujoFormularioEtapaAccion? admFlujoFormularioEtapaAccion = await _context.AdmFlujoFormularioEtapaAcciones
                            .Where(w => w.FormularioEtapaId == formFlowBuilder.FormularioEtapaId && w.FormularioEtapaId == formFlow.FormularioEtapaId && w.Activo)
                            .FirstOrDefaultAsync();


                        if (admFlujoFormularioEtapaAccion is not null)
                        {
                            // Get all the fields of the form from [Adm_FlujosFormulariosEtapasAccionesCampos]
                            IList<AdmFormularioEtapaAccioneCampo> formFields = await _context.AdmFormularioEtapaAccioneCampos
                            .Where(w => w.FormularioEtapaAccionId == formFlowBuilder.FormularioEtapaAccionId && w.FormularioEtapaAccionId == admFlujoFormularioEtapaAccion.FormularioEtapaAccionId)
                            .OrderBy(o => o.OrdenAccion)
                            .ToListAsync();
                            if (formFields.Count > 0)
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



                                formFlowBuilderResult.admFlujoFormulario = _mapper.Map<AdmFlujoFormularioDto>(form);
                                formFlowBuilderResult.admFlujoFormularioEtapa = _mapper.Map<AdmFlujoFormularioEtapaDto>(formFlow);
                                formFlowBuilderResult.admFlujoFormularioEtapaAccion = _mapper.Map<AdmFlujoFormularioEtapaAccionDto>(admFlujoFormularioEtapaAccion);
                                formFlowBuilderResult.admFormularioEtapaAccioneCampos = _mapper.Map<IList<AdmFlujoFormularioEtapaAccionCampoDto>>(formFields);



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
                    return Result.Fail<FormFlowBuilderResult>(errors.ToArray());
                }
                else
                {
                    successs.Add(new Success("The form has been validated successfully"));

                }

                return Result.Ok(formFlowBuilderResult).WithSuccesses(successs);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error in the validation of the form: {error.Message}");
                return Result.Fail<FormFlowBuilderResult>(new Error($"Error in the validation of the form: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<object>> CreaRegistrosFormulario(FormFlowBuilder formFlowBuilder)
        {
            try
            {
                List<ISuccess> successs = [];
                List<IError> errors = [];


                Result<FormFlowBuilderResult> result = await ValidaFormulario(formFlowBuilder);
                if (result.IsSuccess)
                {

                    switch (result.Value.admFlujoFormulario?.TablaBase.ToUpper())
                    {
                        case SD.FORM_REFERIDOS:

                            // Create a new instance of FormReferidoInsertDto using reflection
                            FormReferidoInsertDto formReferidoInsertDto = new();
                            foreach (var field in formFlowBuilder.Fields)
                            {
                                PropertyInfo? property = formReferidoInsertDto.GetType().GetProperty(field.Key);
                                if (property is not null)
                                {
                                    property.SetValue(formReferidoInsertDto, field.Value);
                                }
                            }

                            // Save the new record in the database



                            break;
                        default:
                            break;
                    }

                }

                return Result.Ok().WithSuccesses(successs).WithErrors(errors);



            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error al crear el registro del formulario: {error.Message}");
                return Result.Fail<FormFlowBuilderResult>(new Error($"Error al crear el registro del formulario: {error.Message}")).WithError(error.Message);
            }
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
