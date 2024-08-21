using AutoMapper;
using FluentResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PRAMS.Application.Contract.Flujos;
using PRAMS.Domain.Entities.Flujos.Dto;
using PRAMS.Domain.Models.Flujos;
using PRAMS.Infraestructure.Data.SystemConfiguration;

namespace PRAMS.Infraestructure.Services.Flujos
{
    public class FlujosFormulariosEtapasAccionesService : IFlujosFormulariosEtapasAccionesService
    {
        private readonly AppConfigDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<IFlujosFormulariosEtapasAccionesService> _logger;

        public FlujosFormulariosEtapasAccionesService(AppConfigDbContext context, IMapper mapper, ILogger<IFlujosFormulariosEtapasAccionesService> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Result<AdmFlujoFormularioEtapaAccionDto>> CreateFlujoFormularioEtapaAccionItem(AdmFlujoFormularioEtapaAccionInsertDto admFlujoFormularioEtapaAccionInsertDto, string user)
        {
            try
            {
                // Validate if the FormularioEtapaId exists
                var formularioEtapa = await _context.AdmFlujoFormularioEtapas.FindAsync(admFlujoFormularioEtapaAccionInsertDto.FormularioEtapaId);
                if (formularioEtapa == null)
                {
                    return Result.Fail<AdmFlujoFormularioEtapaAccionDto>(new Error($"The form stage with id {admFlujoFormularioEtapaAccionInsertDto.FormularioEtapaId} does not exist"));
                }

                var admFlujoFormularioEtapaAccion = _mapper.Map<AdmFlujoFormularioEtapaAccion>(admFlujoFormularioEtapaAccionInsertDto);

                admFlujoFormularioEtapaAccion.CreateDate = DateTime.Now;
                admFlujoFormularioEtapaAccion.CreateUser = user;
                admFlujoFormularioEtapaAccion.Activo = true;

                await _context.AdmFlujoFormularioEtapaAcciones.AddAsync(admFlujoFormularioEtapaAccion);
                await _context.SaveChangesAsync();

                var admFlujoFormularioEtapaAccionDto = _mapper.Map<AdmFlujoFormularioEtapaAccionDto>(admFlujoFormularioEtapaAccion);
                return Result.Ok(admFlujoFormularioEtapaAccionDto);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error in the creation of the form flow: {error.Message}");
                return Result.Fail<AdmFlujoFormularioEtapaAccionDto>(new Error($"Error in the creation of the form flow: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<AdmFlujoFormularioEtapaAccionDto>> DeleteFlujoFormularioEtapaAccionItem(int formularioEtapaAccionId, string user)
        {
            try
            {
                var admFlujoFormularioEtapaAccion = await _context.AdmFlujoFormularioEtapaAcciones
                    .FirstOrDefaultAsync(x => x.FormularioEtapaAccionId == formularioEtapaAccionId && x.Activo);
                if (admFlujoFormularioEtapaAccion == null)
                {
                    return Result.Fail<AdmFlujoFormularioEtapaAccionDto>(new Error($"The form flow with id {formularioEtapaAccionId} does not exist"));
                }

                admFlujoFormularioEtapaAccion.Activo = false;
                admFlujoFormularioEtapaAccion.ModifiedDate = DateTime.Now;
                admFlujoFormularioEtapaAccion.ModifiedUser = user;

                _context.AdmFlujoFormularioEtapaAcciones.Update(admFlujoFormularioEtapaAccion);
                await _context.SaveChangesAsync();

                var admFlujoFormularioEtapaAccionDto = _mapper.Map<AdmFlujoFormularioEtapaAccionDto>(admFlujoFormularioEtapaAccion);
                return Result.Ok(admFlujoFormularioEtapaAccionDto);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error in the creation of the form flow: {error.Message}");
                return Result.Fail<AdmFlujoFormularioEtapaAccionDto>(new Error($"Error in the creation of the form flow: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<AdmFlujoFormularioEtapaAccionDto>> GetFlujoFormularioEtapaAccion(int formularioEtapaAccionId)
        {
            try
            {
                var admFlujoFormularioEtapaAccion = await _context.AdmFlujoFormularioEtapaAcciones
                    .FirstOrDefaultAsync(x => x.FormularioEtapaAccionId == formularioEtapaAccionId && x.Activo);
                if (admFlujoFormularioEtapaAccion == null)
                {
                    return Result.Fail<AdmFlujoFormularioEtapaAccionDto>(new Error($"The form flow with id {formularioEtapaAccionId} does not exist"));
                }

                var admFlujoFormularioEtapaAccionDto = _mapper.Map<AdmFlujoFormularioEtapaAccionDto>(admFlujoFormularioEtapaAccion);
                return Result.Ok(admFlujoFormularioEtapaAccionDto);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error in the creation of the form flow: {error.Message}");
                return Result.Fail<AdmFlujoFormularioEtapaAccionDto>(new Error($"Error in the creation of the form flow: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<ICollection<AdmFlujoFormularioEtapaAccionDto>>> GetFlujosFormulariosEtapasAccionesByFormularioEtapaId(int formularioEtapaId)
        {
            try
            {
                var admFlujoFormularioEtapaAcciones = await _context.AdmFlujoFormularioEtapaAcciones
                    .Where(x => x.FormularioEtapaId == formularioEtapaId && x.Activo)
                    .ToListAsync();
                var admFlujoFormularioEtapaAccionesDto = _mapper.Map<ICollection<AdmFlujoFormularioEtapaAccionDto>>(admFlujoFormularioEtapaAcciones);
                return Result.Ok(admFlujoFormularioEtapaAccionesDto);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error in the creation of the form flow: {error.Message}");
                return Result.Fail<ICollection<AdmFlujoFormularioEtapaAccionDto>>(new Error($"Error in the creation of the form flow: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<AdmFlujoFormularioEtapaAccionDto>> UpdateFlujoFormularioEtapaAccionItem(AdmFlujoFormularioEtapaAccionUpdateDto admFlujoFormularioEtapaAccionUpdateDto, string user)
        {
            try
            {
                var admFlujoFormularioEtapaAccion = await _context.AdmFlujoFormularioEtapaAcciones
                    .FirstOrDefaultAsync(x => x.FormularioEtapaAccionId == admFlujoFormularioEtapaAccionUpdateDto.FormularioEtapaAccionId && x.Activo);
                if (admFlujoFormularioEtapaAccion == null)
                {
                    return Result.Fail<AdmFlujoFormularioEtapaAccionDto>(new Error($"The form flow with id {admFlujoFormularioEtapaAccionUpdateDto.FormularioEtapaAccionId} does not exist"));
                }

                admFlujoFormularioEtapaAccion = _mapper.Map(admFlujoFormularioEtapaAccionUpdateDto, admFlujoFormularioEtapaAccion);
                admFlujoFormularioEtapaAccion.ModifiedDate = DateTime.Now;
                admFlujoFormularioEtapaAccion.ModifiedUser = user;

                _context.AdmFlujoFormularioEtapaAcciones.Update(admFlujoFormularioEtapaAccion);
                await _context.SaveChangesAsync();

                var admFlujoFormularioEtapaAccionDto = _mapper.Map<AdmFlujoFormularioEtapaAccionDto>(admFlujoFormularioEtapaAccion);
                return Result.Ok(admFlujoFormularioEtapaAccionDto);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error in the creation of the form flow: {error.Message}");
                return Result.Fail<AdmFlujoFormularioEtapaAccionDto>(new Error($"Error in the creation of the form flow: {error.Message}")).WithError(error.Message);
            }
        }
    }
}
