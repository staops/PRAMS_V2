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
    public class FlujoFormularioNotasService : IFlujoFormularioNotasService
    {
        private readonly AppConfigDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<IFlujoFormularioNotasService> _logger;

        public FlujoFormularioNotasService(AppConfigDbContext context, IMapper mapper, ILogger<IFlujoFormularioNotasService> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Result<AdmFlujoFormularioNotaDto>> CreateFlujoFormularioNotaItem(AdmFlujoFormularioNotaInsertDto admFlujoFormularioNotaInsertDto, string user)
        {
            try
            {
                // Validate if the FormularioId exists
                var formulario = await _context.AdmFlujoFormularios.FindAsync(admFlujoFormularioNotaInsertDto.FormularioId);
                if (formulario == null)
                {
                    return Result.Fail<AdmFlujoFormularioNotaDto>(new Error($"The form with id {admFlujoFormularioNotaInsertDto.FormularioId} does not exist"));
                }

                var admFlujoFormularioNota = _mapper.Map<AdmFlujoFormularioNota>(admFlujoFormularioNotaInsertDto);

                await _context.AdmFlujoFormularioNotas.AddAsync(admFlujoFormularioNota);
                await _context.SaveChangesAsync();

                var admFlujoFormularioNotaDto = _mapper.Map<AdmFlujoFormularioNotaDto>(admFlujoFormularioNota);
                return Result.Ok(admFlujoFormularioNotaDto);

            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in the creation of the form flow");
                return Result.Fail<AdmFlujoFormularioNotaDto>(new Error($"Error in the creation of the form flow: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<AdmFlujoFormularioNotaDto>> DeleteFlujoFormularioNotaItem(int formularioNotaId, string user)
        {
            try
            {
                var admFlujoFormularioNota = await _context.AdmFlujoFormularioNotas.FindAsync(formularioNotaId);
                if (admFlujoFormularioNota == null)
                {
                    return Result.Fail<AdmFlujoFormularioNotaDto>(new Error($"The form flow with id {formularioNotaId} does not exist"));
                }

                _context.AdmFlujoFormularioNotas.Remove(admFlujoFormularioNota);
                await _context.SaveChangesAsync();

                var admFlujoFormularioNotaDto = _mapper.Map<AdmFlujoFormularioNotaDto>(admFlujoFormularioNota);
                return Result.Ok(admFlujoFormularioNotaDto);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error in the deletion of the form flow: {error.Message}");
                return Result.Fail<AdmFlujoFormularioNotaDto>(new Error($"Error in the deletion of the form flow: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<AdmFlujoFormularioNotaDto>> GetFlujoFormularioNota(int formularioNotaId)
        {
            try
            {
                var admFlujoFormularioNota = await _context.AdmFlujoFormularioNotas.FindAsync(formularioNotaId);
                if (admFlujoFormularioNota == null)
                {
                    return Result.Fail<AdmFlujoFormularioNotaDto>(new Error($"The form flow with id {formularioNotaId} does not exist"));
                }

                var admFlujoFormularioNotaDto = _mapper.Map<AdmFlujoFormularioNotaDto>(admFlujoFormularioNota);
                return Result.Ok(admFlujoFormularioNotaDto);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error in obtaining the form flow: {error.Message}");
                return Result.Fail<AdmFlujoFormularioNotaDto>(new Error($"Error in obtaining the form flow: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<ICollection<AdmFlujoFormularioNotaDto>>> GetFlujoFormularioNotas(int formularioId)
        {
            try
            {
                var admFlujoFormularioNotas = await _context.AdmFlujoFormularioNotas.Where(x => x.FormularioId == formularioId).ToListAsync();
                if (admFlujoFormularioNotas == null)
                {
                    return Result.Fail<ICollection<AdmFlujoFormularioNotaDto>>(new Error($"The form flow with id {formularioId} does not exist"));
                }

                var admFlujoFormularioNotasDto = _mapper.Map<ICollection<AdmFlujoFormularioNotaDto>>(admFlujoFormularioNotas);
                return Result.Ok(admFlujoFormularioNotasDto);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error in obtaining the form flow: {error.Message}");
                return Result.Fail<ICollection<AdmFlujoFormularioNotaDto>>(new Error($"Error in obtaining the form flow: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<AdmFlujoFormularioNotaDto>> UpdateFlujoFormularioNotaItem(AdmFlujoFormularioNotaUpdateDto admFlujoFormularioNotaUpdateDto, string user)
        {
            try
            {
                var admFlujoFormularioNota = await _context.AdmFlujoFormularioNotas.FindAsync(admFlujoFormularioNotaUpdateDto.FormularioNotaId);
                if (admFlujoFormularioNota == null)
                {
                    return Result.Fail<AdmFlujoFormularioNotaDto>(new Error($"The form flow with id {admFlujoFormularioNotaUpdateDto.FormularioNotaId} does not exist"));
                }

                admFlujoFormularioNota = _mapper.Map(admFlujoFormularioNotaUpdateDto, admFlujoFormularioNota);
                _context.AdmFlujoFormularioNotas.Update(admFlujoFormularioNota);
                await _context.SaveChangesAsync();

                var admFlujoFormularioNotaDto = _mapper.Map<AdmFlujoFormularioNotaDto>(admFlujoFormularioNota);
                return Result.Ok(admFlujoFormularioNotaDto);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error in the update of the form flow: {error.Message}");
                return Result.Fail<AdmFlujoFormularioNotaDto>(new Error($"Error in the update of the form flow: {error.Message}")).WithError(error.Message);
            }
        }
    }
}
