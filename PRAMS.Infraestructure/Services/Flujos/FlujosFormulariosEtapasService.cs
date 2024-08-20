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
    public class FlujosFormulariosEtapasService : IFlujosFormulariosEtapasService
    {
        private readonly AppConfigDbContext _appConfigDbContext;
        private readonly IMapper _mapper;
        private readonly ILogger<IFlujosFormulariosEtapasService> _logger;

        public FlujosFormulariosEtapasService(AppConfigDbContext appConfigDbContext, IMapper mapper, ILogger<IFlujosFormulariosEtapasService> logger)
        {
            _appConfigDbContext = appConfigDbContext;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Result<AdmFlujoFormularioEtapaDto>> CreateFlujoFormularioEtapa(AdmFlujoFormularioEtapaInsertDto itemToInsert, string user)
        {
            try
            {
                var entity = _mapper.Map<AdmFlujoFormularioEtapa>(itemToInsert);
                entity.CreateUser = user;
                entity.CreateDate = DateTime.Now;
                entity.Activo = true;

                // Validate if the FormularioId exist
                var ddmFlujoFormulario = await _appConfigDbContext.AdmFlujoFormularios.Where(w => w.FormularioId == entity.FormularioId).FirstOrDefaultAsync();
                if (ddmFlujoFormulario == null)
                {
                    return Result.Fail<AdmFlujoFormularioEtapaDto>($"The form {entity.FormularioId} does not exist");
                }

                // Validate if the start note exist
                if(entity.NotaEndId is not null)
                {
                    var ddmFlujoFormularioNota = await _appConfigDbContext.AdmFlujoFormularioNotas.Where(w => w.FormularioNotaId == entity.NotaEndId).FirstOrDefaultAsync();
                    if (ddmFlujoFormularioNota == null)
                    {
                        return Result.Fail<AdmFlujoFormularioEtapaDto>($"The start note {entity.NotaEndId} does not exist");
                    }
                }

                // Validate if the end note exist
                if (entity.NotaStartId is not null)
                {
                    var ddmFlujoFormularioNota = await _appConfigDbContext.AdmFlujoFormularioNotas.Where(w => w.FormularioNotaId == entity.NotaStartId).FirstOrDefaultAsync();
                    if (ddmFlujoFormularioNota == null)
                    {
                        return Result.Fail<AdmFlujoFormularioEtapaDto>($"The end note {entity.NotaStartId} does not exist");
                    }
                }


                await _appConfigDbContext.AdmFlujoFormularioEtapas.AddAsync(entity);
                await _appConfigDbContext.SaveChangesAsync();

                var result = _mapper.Map<AdmFlujoFormularioEtapaDto>(entity);

                return Result.Ok(result);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error al crear el flujo del formulario Error: {error.Message}");
                return Result.Fail<AdmFlujoFormularioEtapaDto>($"Error al crear el flujo del formulario Error: {error.Message}");
            }
        }

        public async Task<Result<AdmFlujoFormularioEtapaDto>> GetFlujoFormularioEtapa(int formularioEtapaId)
        {
            try
            {
                var query = _appConfigDbContext.AdmFlujoFormularioEtapas.Where(x => x.FormularioEtapaId == formularioEtapaId && x.Activo);
                AdmFlujoFormularioEtapaDto? result = await _mapper.ProjectTo<AdmFlujoFormularioEtapaDto>(query).FirstOrDefaultAsync();
                if (result == null)
                {
                    return Result.Fail<AdmFlujoFormularioEtapaDto>($"El flujo del formulario {formularioEtapaId} no existe");
                }

                return Result.Ok(result);
            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error al obtener el flujo del formulario {formularioEtapaId}");
                return Result.Fail<AdmFlujoFormularioEtapaDto>($"Error al obtener el flujo del formulario {formularioEtapaId}");
            }
        }

        public async Task<Result<ICollection<AdmFlujoFormularioEtapaDto>>> GetFlujosFormulariosEtapas()
        {
            try
            {
                var query = _appConfigDbContext.AdmFlujoFormularioEtapas.Where(x => x.Activo);
                ICollection<AdmFlujoFormularioEtapaDto> result = await _mapper.ProjectTo<AdmFlujoFormularioEtapaDto>(query).ToListAsync();

                return Result.Ok(result);

            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al obtener los flujos de los formularios");
                return Result.Fail<ICollection<AdmFlujoFormularioEtapaDto>>("Error al obtener los flujos de los formularios");
            }
        }

        public async Task<Result<bool>> RemoveFlujoFormularioEtapa(int formularioEtapaId, string user)
        {
            try
            {
                var entity = await _appConfigDbContext.AdmFlujoFormularioEtapas
                    .Where(x => x.FormularioEtapaId == formularioEtapaId && x.Activo)
                    .FirstOrDefaultAsync();

                if (entity == null)
                {
                    return Result.Fail<bool>($"El flujo del formulario {formularioEtapaId} no existe");
                }

                entity.Activo = false;
                entity.ModifiedUser = user;
                entity.ModifiedDate = DateTime.Now;

                await _appConfigDbContext.SaveChangesAsync();

                return Result.Ok(true);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error al eliminar el flujo del formulario {formularioEtapaId}");
                return Result.Fail<bool>($"Error al eliminar el flujo del formulario {formularioEtapaId}");
            }
        }

        public async Task<Result<AdmFlujoFormularioEtapaDto>> UpdateFlujoFormularioEtapa(AdmFlujoFormularioEtapaUpdateDto itemToUpdate, string user)
        {
            try
            {
                var entity = await _appConfigDbContext.AdmFlujoFormularioEtapas
                    .Where(x => x.FormularioEtapaId == itemToUpdate.FormularioEtapaId && x.Activo)
                    .FirstOrDefaultAsync();

                if (entity == null)
                {
                    return Result.Fail<AdmFlujoFormularioEtapaDto>($"La etapa del formulario {itemToUpdate.FormularioEtapaId} no existe");
                }

                // Validate if the FormularioId exist
                var ddmFlujoFormulario = await _appConfigDbContext.AdmFlujoFormularios.Where(w => w.FormularioId == itemToUpdate.FormularioId).FirstOrDefaultAsync();
                if (ddmFlujoFormulario == null)
                {
                    return Result.Fail<AdmFlujoFormularioEtapaDto>($"El formulario {itemToUpdate.FormularioId} no existe");
                }

                // Validate if the start note exist
                if (itemToUpdate.NotaEndId is not null)
                {
                    var ddmFlujoFormularioNota = await _appConfigDbContext.AdmFlujoFormularioNotas.Where(w => w.FormularioNotaId == itemToUpdate.NotaEndId).FirstOrDefaultAsync();
                    if (ddmFlujoFormularioNota == null)
                    {
                        return Result.Fail<AdmFlujoFormularioEtapaDto>($"The start note {itemToUpdate.NotaEndId} does not exist");
                    }
                }

                // Validate if the end note exist
                if (itemToUpdate.notaStartId is not null)
                {
                    var ddmFlujoFormularioNota = await _appConfigDbContext.AdmFlujoFormularioNotas.Where(w => w.FormularioNotaId == itemToUpdate.notaStartId).FirstOrDefaultAsync();
                    if (ddmFlujoFormularioNota == null)
                    {
                        return Result.Fail<AdmFlujoFormularioEtapaDto>($"The end note {itemToUpdate.notaStartId} does not exist");
                    }
                }


                entity = _mapper.Map(itemToUpdate, entity);
                entity.ModifiedUser = user;
                entity.ModifiedDate = DateTime.Now;

                await _appConfigDbContext.SaveChangesAsync();

                var result = _mapper.Map<AdmFlujoFormularioEtapaDto>(entity);

                return Result.Ok(result);


            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error al actualizar el flujo del formulario");
                return Result.Fail<AdmFlujoFormularioEtapaDto>("Error al actualizar el flujo del formulario");
            }
        }
    }
}
