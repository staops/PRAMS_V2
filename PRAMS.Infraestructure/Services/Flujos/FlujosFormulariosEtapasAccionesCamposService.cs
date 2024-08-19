using AutoMapper;
using FluentResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PRAMS.Application.Contract.People;
using PRAMS.Domain.Entities.People.Dto;
using PRAMS.Domain.Models.Flujos;
using PRAMS.Infraestructure.Data.SystemConfiguration;

namespace PRAMS.Infraestructure.Services.Flujos
{
    public class FlujosFormulariosEtapasAccionesCamposService : IFlujosFormulariosEtapasAccionesCamposService
    {
        private readonly AppConfigDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<IFlujosFormulariosEtapasAccionesCamposService> _logger;

        public FlujosFormulariosEtapasAccionesCamposService(AppConfigDbContext context, IMapper mapper, ILogger<IFlujosFormulariosEtapasAccionesCamposService> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Result<AdmFlujoFormularioEtapaAccionCampoDto>> CreateFlujoFormularioEtapaAccionCampo(AdmFlujoFormularioEtapaAccionCampoInsertDto itemToInsert, string user)
        {
            try
            {
                // Validate if the FormularioEtapaAccionId exists
                var formularioEtapaAccion = await _context.AdmFlujoFormularioEtapaAcciones.FindAsync(itemToInsert.FormularioEtapaAccionId);
                if (formularioEtapaAccion == null)
                {
                    return Result.Fail<AdmFlujoFormularioEtapaAccionCampoDto>(new Error($"The form with id {itemToInsert.FormularioEtapaAccionId} does not exist"));
                }

                var admFlujoFormularioEtapaAccionCampo = _mapper.Map<AdmFormularioEtapaAccioneCampo>(itemToInsert);

                await _context.AdmFormularioEtapaAccioneCampos.AddAsync(admFlujoFormularioEtapaAccionCampo);
                await _context.SaveChangesAsync();

                var admFlujoFormularioEtapaAccionCampoDto = _mapper.Map<AdmFlujoFormularioEtapaAccionCampoDto>(admFlujoFormularioEtapaAccionCampo);
                return Result.Ok(admFlujoFormularioEtapaAccionCampoDto);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error in the creation of the form flow: {error.Message}");
                return Result.Fail<AdmFlujoFormularioEtapaAccionCampoDto>(new Error($"Error in the creation of the form flow: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<AdmFlujoFormularioEtapaAccionCampoDto>> GetFlujoFormularioEtapaAccionCampo(int formularioEtapaAccionCampoId)
        {
            try
            {
                var query = _context.AdmFormularioEtapaAccioneCampos.Where(x => x.FormularioEtapaAccionCampoId == formularioEtapaAccionCampoId);
                var entity = await query.FirstOrDefaultAsync();
                if (entity == null)
                {
                    return Result.Fail<AdmFlujoFormularioEtapaAccionCampoDto>(new Error($"The form flow with id {formularioEtapaAccionCampoId} does not exist"));
                }

                var result = _mapper.Map<AdmFlujoFormularioEtapaAccionCampoDto>(entity);
                return Result.Ok(result);
            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error getting the form flow: {error.Message}");
                return Result.Fail<AdmFlujoFormularioEtapaAccionCampoDto>(new Error($"Error getting the form flow: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<ICollection<AdmFlujoFormularioEtapaAccionCampoDto>>> GetFlujoFormularioEtapaAccionCampoByFormularioEtapaAccionId(int formularioEtapaAccionId)
        {
            try
            {
                var query = await _context.AdmFormularioEtapaAccioneCampos
                    .Where(x => x.FormularioEtapaAccionId == formularioEtapaAccionId)
                    .ToListAsync();

                var result = _mapper.Map<ICollection<AdmFlujoFormularioEtapaAccionCampoDto>>(query);

                return Result.Ok(result);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error getting the form flow: {error.Message}");
                return Result.Fail<ICollection<AdmFlujoFormularioEtapaAccionCampoDto>>(new Error($"Error getting the form flow: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<ICollection<AdmFlujoFormularioEtapaAccionCampoDto>>> GetFlujosFormulariosEtapasAccionesCampos()
        {
            try
            {
                var query = await _context.AdmFormularioEtapaAccioneCampos
                    .ToListAsync();

                var result = _mapper.Map<ICollection<AdmFlujoFormularioEtapaAccionCampoDto>>(query);

                return Result.Ok(result);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error getting the form flow: {error.Message}");
                return Result.Fail<ICollection<AdmFlujoFormularioEtapaAccionCampoDto>>(new Error($"Error getting the form flow: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<AdmFlujoFormularioEtapaAccionCampoDto>> RemoveFlujoFormularioEtapaAccionCampo(int formularioEtapaAccionCampoId, string user)
        {
            try
            {
                var entity = await _context.AdmFormularioEtapaAccioneCampos
                    .Where(x => x.FormularioEtapaAccionCampoId == formularioEtapaAccionCampoId)
                    .FirstOrDefaultAsync();

                if (entity == null)
                {
                    return Result.Fail<AdmFlujoFormularioEtapaAccionCampoDto>(new Error($"The form flow with id {formularioEtapaAccionCampoId} does not exist"));
                }

                _context.AdmFormularioEtapaAccioneCampos.Remove(entity);
                await _context.SaveChangesAsync();

                var result = _mapper.Map<AdmFlujoFormularioEtapaAccionCampoDto>(entity);
                return Result.Ok(result);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error removing the form flow: {error.Message}");
                return Result.Fail<AdmFlujoFormularioEtapaAccionCampoDto>(new Error($"Error removing the form flow: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<AdmFlujoFormularioEtapaAccionCampoDto>> UpdateFlujoFormularioEtapaAccionCampo(AdmFlujoFormularioEtapaAccionCampoUpdateDto itemToUpdate, string user)
        {
            try
            {
                var entity = await _context.AdmFormularioEtapaAccioneCampos
                    .Where(x => x.FormularioEtapaAccionCampoId == itemToUpdate.FormularioEtapaAccionCampoId)
                    .FirstOrDefaultAsync();

                if (entity == null)
                {
                    return Result.Fail<AdmFlujoFormularioEtapaAccionCampoDto>(new Error($"The form flow with id {itemToUpdate.FormularioEtapaAccionCampoId} does not exist"));
                }

                entity = _mapper.Map(itemToUpdate, entity);

                await _context.SaveChangesAsync();

                var result = _mapper.Map<AdmFlujoFormularioEtapaAccionCampoDto>(entity);

                return Result.Ok(result);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error updating the form flow: {error.Message}");
                return Result.Fail<AdmFlujoFormularioEtapaAccionCampoDto>(new Error($"Error updating the form flow: {error.Message}")).WithError(error.Message);
            }
        }
    }
}
