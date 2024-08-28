using AutoMapper;
using FluentResults;
using Microsoft.Extensions.Logging;
using PRAMS.Application.Contract.Forms;
using PRAMS.Domain.Entities.Forms.Dto;
using PRAMS.Domain.Models.Forms;
using PRAMS.Infraestructure.Data.SystemConfiguration;

namespace PRAMS.Infraestructure.Services.Forms
{
    public class FormReferidoService : IFormReferidoService
    {
        private readonly AppConfigDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<IFormReferidoService> _logger;

        public FormReferidoService(AppConfigDbContext context, IMapper mapper, ILogger<IFormReferidoService> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Result<FormReferidoDto>> CreateFormReferido(FormReferidoInsertDto formReferidoInsertDto, string user)
        {
            try
            {
                var formReferido = _mapper.Map<FormReferido>(formReferidoInsertDto);

                await _context.FormReferidos.AddAsync(formReferido);
                await _context.SaveChangesAsync();

                var formReferidoDto = _mapper.Map<FormReferidoDto>(formReferido);
                return Result.Ok(formReferidoDto);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error in the form creation: {error.Message}");
                return Result.Fail<FormReferidoDto>(new Error($"Error in the form creation: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<FormReferidoDto>> GetFormReferido(int formReferidoId)
        {
            try
            {
                var formReferido = await _context.FormReferidos.FindAsync(formReferidoId);

                if (formReferido == null)
                {
                    return Result.Fail<FormReferidoDto>(new Error($"The form with id {formReferidoId} was not found"));
                }

                var formReferidoDto = _mapper.Map<FormReferidoDto>(formReferido);
                return Result.Ok(formReferidoDto);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error getting the form: {error.Message}");
                return Result.Fail<FormReferidoDto>(new Error($"Error getting the form: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<FormReferidoDto>> RemoveFormReferido(int formReferidoId, string user)
        {
            try
            {

                var formReferido = await _context.FormReferidos.FindAsync(formReferidoId);

                if (formReferido == null)
                {
                    return Result.Fail<FormReferidoDto>(new Error($"The form with id {formReferidoId} was not found"));
                }

                _context.FormReferidos.Remove(formReferido);
                await _context.SaveChangesAsync();

                var formReferidoDto = _mapper.Map<FormReferidoDto>(formReferido);
                return Result.Ok(formReferidoDto);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error removing the form: {error.Message}");
                return Result.Fail<FormReferidoDto>(new Error($"Error removing the form: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<FormReferidoDto>> UpdateFormReferido(FormReferidoUpdateDto formReferidoUpdateDto, string user)
        {
            try
            {
                var formReferido = await _context.FormReferidos.FindAsync(formReferidoUpdateDto.ReferidoId);

                if (formReferido == null)
                {
                    return Result.Fail<FormReferidoDto>(new Error($"The form with id {formReferidoUpdateDto.ReferidoId} was not found"));
                }

                _mapper.Map(formReferidoUpdateDto, formReferido);
                await _context.SaveChangesAsync();

                var formReferidoDto = _mapper.Map<FormReferidoDto>(formReferido);
                return Result.Ok(formReferidoDto);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error updating the form: {error.Message}");
                return Result.Fail<FormReferidoDto>(new Error($"Error updating the form: {error.Message}")).WithError(error.Message);


            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error updating the form: {error.Message}");
                return Result.Fail<FormReferidoDto>(new Error($"Error updating the form: {error.Message}")).WithError(error.Message);
            }
        }
    }
}
