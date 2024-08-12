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
    public class FlujosFormulariosService : IFlujosFormulariosService
    {
        private readonly AppConfigDbContext _appConfigDbContext;
        private readonly IMapper _mapper;
        private readonly ILogger<IFlujosFormulariosService> _logger;

        public FlujosFormulariosService(AppConfigDbContext appConfigDbContext, IMapper mapper, ILogger<IFlujosFormulariosService> logger)
        {
            _appConfigDbContext = appConfigDbContext;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Result<AdmFlujoFormularioDto>> GetFlujoFormulario(int formularioId)
        {
            try
            {
                var query = _appConfigDbContext.AdmFlujoFormularios.Where(x => x.FormularioId == formularioId);
                AdmFlujoFormularioDto? result = await _mapper.ProjectTo<AdmFlujoFormularioDto>(query).FirstOrDefaultAsync();
                if (result == null)
                {
                    return Result.Fail<AdmFlujoFormularioDto>("El flujo del formulario no existe");
                }

                return Result.Ok(result);
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al obtener el flujo del formulario");
                return Result.Fail<AdmFlujoFormularioDto>("Error al obtener el flujo del formulario");
            }
        }

        public async Task<Result<ICollection<AdmFlujoFormularioDto>>> GetFlujosFormularios()
        {
            try
            {
                var query = _appConfigDbContext.AdmFlujoFormularios;
                ICollection<AdmFlujoFormularioDto> result = await _mapper.ProjectTo<AdmFlujoFormularioDto>(query).ToListAsync();

                return Result.Ok(result);

            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al obtener los flujos de los formularios");
                return Result.Fail<ICollection<AdmFlujoFormularioDto>>("Error al obtener los flujos de los formularios");
            }
        }

        public async Task<Result<AdmFlujoFormularioDto>> CreateFlujoFormulario(AdmFlujoFormularioInsertDto itemToInsert, string user)
        {
            try
            {
                var admFlujoFormulario = _mapper.Map<AdmFlujoFormulario>(itemToInsert);

                await _appConfigDbContext.AdmFlujoFormularios.AddAsync(admFlujoFormulario);
                await _appConfigDbContext.SaveChangesAsync();

                var result = _mapper.Map<AdmFlujoFormularioDto>(admFlujoFormulario);

                return Result.Ok(result);
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al insertar el flujo del formulario");
                return Result.Fail<AdmFlujoFormularioDto>("Error al insertar el flujo del formulario");
            }
        }

        public async Task<Result<bool>> RemoveFlujoFormulario(int formularioId, string user)
        {
            try
            {
                var admFlujoFormulario = await _appConfigDbContext.AdmFlujoFormularios
                    .Where(x => x.FormularioId == formularioId)
                    .FirstOrDefaultAsync();

                if (admFlujoFormulario == null)
                {
                    return Result.Fail<bool>("El flujo del formulario no existe");
                }

                _appConfigDbContext.Remove(admFlujoFormulario);
                await _appConfigDbContext.SaveChangesAsync();

                return Result.Ok(true);

            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al eliminar el flujo del formulario");
                return Result.Fail<bool>("Error al eliminar el flujo del formulario");
            }
        }

        public async Task<Result<AdmFlujoFormularioDto>> UpdateFlujoFormulario(AdmFlujoFormularioUpdateDto itemToUpdate, string user)
        {
            try
            {
                var admFlujoFormulario = await _appConfigDbContext.AdmFlujoFormularios
                    .Where(x => x.FormularioId == itemToUpdate.FormularioId)
                    .FirstOrDefaultAsync();

                if (admFlujoFormulario == null)
                {
                    return Result.Fail<AdmFlujoFormularioDto>("El flujo del formulario no existe");
                }

                admFlujoFormulario = _mapper.Map(itemToUpdate, admFlujoFormulario);

                await _appConfigDbContext.SaveChangesAsync();

                var result = _mapper.Map<AdmFlujoFormularioDto>(admFlujoFormulario);

                return Result.Ok(result);

            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al actualizar el flujo del formulario");
                return Result.Fail<AdmFlujoFormularioDto>("Error al actualizar el flujo del formulario");
            }
        }
    }
}
