using AutoMapper;
using FluentResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PRAMS.Application.Contract.Forms;
using PRAMS.Domain.Entities.Forms.Dto;
using PRAMS.Domain.Models.Forms;
using PRAMS.Infraestructure.Data.SystemConfiguration;

namespace PRAMS.Infraestructure.Services.Forms
{
    public class FormulariosFirmasService : IFormulariosFirmasService
    {
        private readonly AppConfigDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<IFormulariosFirmasService> _logger;

        public FormulariosFirmasService(AppConfigDbContext context, IMapper mapper, ILogger<IFormulariosFirmasService> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Result<FormFormularioFirmaDto>> CreateFormularioFirma(FormFormularioFirmaInsertDto itemToInsert, string user, string role)
        {
            try
            {
                var formFormularioFirma = _mapper.Map<FormFormularioFirma>(itemToInsert);

                // Validate if the FormularioEtapaId exist
                var formFormulario = await _context.AdmFlujoFormularioEtapas.Where(w => w.FormularioEtapaId == formFormularioFirma.FormularioEtapaId && w.Activo).FirstOrDefaultAsync();
                if (formFormulario == null)
                {
                    return Result.Fail<FormFormularioFirmaDto>($"The form stage with id {formFormularioFirma.FormularioEtapaId} does not exist");
                }


                formFormularioFirma.FechaFirma = DateTime.Now;
                formFormularioFirma.UsuarioId = user;
                formFormularioFirma.UserTypeID = role;


                await _context.FormFormularioFirmas.AddAsync(formFormularioFirma);
                await _context.SaveChangesAsync();

                var formFormularioFirmaDto = _mapper.Map<FormFormularioFirmaDto>(formFormularioFirma);
                return Result.Ok(formFormularioFirmaDto);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error in the creation of the form signature: {error.Message}");
                return Result.Fail<FormFormularioFirmaDto>($"Error in the creation of the form signature: {error.Message}");
            }
        }

        public async Task<Result<FormFormularioFirmaDto>> GetFormularioFirma(int formularioFirmaId)
        {
            try
            {
                var formFormularioFirma = await _context.FormFormularioFirmas.FindAsync(formularioFirmaId);

                if (formFormularioFirma == null)
                {
                    return Result.Fail<FormFormularioFirmaDto>($"The form signature with id {formularioFirmaId} does not exist");
                }

                var formFormularioFirmaDto = _mapper.Map<FormFormularioFirmaDto>(formFormularioFirma);
                return Result.Ok(formFormularioFirmaDto);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error in the search of the form signature: {error.Message}");
                return Result.Fail<FormFormularioFirmaDto>($"Error in the search of the form signature: {error.Message}");
            }
        }

        public async Task<Result<ICollection<FormFormularioFirmaDto>>> GetFormularioFirmaByFormularioEtapa(int formularioEtapaId)
        {
            try
            {
                var formFormularioFirmas = await _context.FormFormularioFirmas.Where(w => w.FormularioEtapaId == formularioEtapaId).ToListAsync();

                var formFormularioFirmasDto = _mapper.Map<ICollection<FormFormularioFirmaDto>>(formFormularioFirmas);
                return Result.Ok(formFormularioFirmasDto);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error in the search of the form signatures: {error.Message}");
                return Result.Fail<ICollection<FormFormularioFirmaDto>>($"Error in the search of the form signatures: {error.Message}");
            }
        }

        public async Task<Result<ICollection<FormFormularioFirmaDto>>> GetFormulariosFirmas()
        {
            try
            {
                var formFormularioFirmas = await _context.FormFormularioFirmas.ToListAsync();

                var formFormularioFirmasDto = _mapper.Map<ICollection<FormFormularioFirmaDto>>(formFormularioFirmas);
                return Result.Ok(formFormularioFirmasDto);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error in the search of the form signatures: {error.Message}");
                return Result.Fail<ICollection<FormFormularioFirmaDto>>($"Error in the search of the form signatures: {error.Message}");
            }
        }

        public async Task<Result<FormFormularioFirmaDto>> RemoveFormularioFirma(int formularioFirmaId, string user)
        {
            try
            {
                var formFormularioFirma = await _context.FormFormularioFirmas.FindAsync(formularioFirmaId);

                if (formFormularioFirma == null)
                {
                    return Result.Fail<FormFormularioFirmaDto>($"The form signature with id {formularioFirmaId} does not exist");
                }

                _context.FormFormularioFirmas.Remove(formFormularioFirma);
                await _context.SaveChangesAsync();

                var formFormularioFirmaDto = _mapper.Map<FormFormularioFirmaDto>(formFormularioFirma);
                return Result.Ok(formFormularioFirmaDto);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error in the removal of the form signature: {error.Message}");
                return Result.Fail<FormFormularioFirmaDto>($"Error in the removal of the form signature: {error.Message}");
            }
        }

        public async Task<Result<FormFormularioFirmaDto>> UpdateFormularioFirma(FormFormularioFirmaUpdateDto itemToUpdate, string user)
        {
            try
            {
                var formFormularioFirma = await _context.FormFormularioFirmas.FindAsync(itemToUpdate.FormularioFirmasId);

                if (formFormularioFirma == null)
                {
                    return Result.Fail<FormFormularioFirmaDto>($"The form signature with id {itemToUpdate.FormularioFirmasId} does not exist");
                }

                // Validate if the FormularioEtapaId exist
                var formFormulario = await _context.AdmFlujoFormularioEtapas.Where(w => w.FormularioEtapaId == itemToUpdate.FormularioEtapaId && w.Activo).FirstOrDefaultAsync();
                if (formFormulario == null)
                {
                    return Result.Fail<FormFormularioFirmaDto>($"The form stage with id {formFormularioFirma.FormularioEtapaId} does not exist");
                }

                formFormularioFirma = _mapper.Map(itemToUpdate, formFormularioFirma);

                _context.FormFormularioFirmas.Update(formFormularioFirma);
                await _context.SaveChangesAsync();

                var formFormularioFirmaDto = _mapper.Map<FormFormularioFirmaDto>(formFormularioFirma);
                return Result.Ok(formFormularioFirmaDto);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error in the update of the form signature: {error.Message}");
                return Result.Fail<FormFormularioFirmaDto>($"Error in the update of the form signature: {error.Message}");
            }
        }
    }
}
