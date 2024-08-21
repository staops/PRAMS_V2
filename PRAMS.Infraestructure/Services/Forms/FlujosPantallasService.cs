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

    public class FlujosPantallasService : IFlujosPantallasService
    {
        private readonly AppConfigDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<IFlujosPantallasService> _logger;

        public FlujosPantallasService(AppConfigDbContext context, IMapper mapper, ILogger<IFlujosPantallasService> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Result<FormFlujoPantallaDto>> CreateFlujoPantalla(FormFlujoPantallaInsertDto itemToInsert, string user)
        {
            try
            {
                // Validate if the FormularioId exists
                var forma = await _context.AdmFlujoFormularios
                    .Where(w => w.FormularioId == itemToInsert.FormularioId)
                    .FirstOrDefaultAsync();

                if (forma == null)
                {
                    return Result.Fail<FormFlujoPantallaDto>(new Error($"The form with id {itemToInsert.FormularioId} does not exist"));
                }


                var admFlujoPantalla = _mapper.Map<FormFlujoPantalla>(itemToInsert);

                await _context.FormFlujoPantallas.AddAsync(admFlujoPantalla);
                await _context.SaveChangesAsync();

                var admFlujoPantallaDto = _mapper.Map<FormFlujoPantallaDto>(admFlujoPantalla);
                return Result.Ok(admFlujoPantallaDto);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error in the flow creation: {error.Message}");
                return Result.Fail<FormFlujoPantallaDto>(new Error($"Error in the flow creation: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<FormFlujoPantallaDto>> GetFlujoPantalla(int flujoPantallaId)
        {
            try
            {
                var query = _context.FormFlujoPantallas.Where(x => x.FlujoPantallaId == flujoPantallaId);
                FormFlujoPantallaDto? result = await _mapper.ProjectTo<FormFlujoPantallaDto>(query).FirstOrDefaultAsync();
                if (result == null)
                {
                    return Result.Fail<FormFlujoPantallaDto>(new Error("The flow does not exist"));
                }

                return Result.Ok(result);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error getting the flow: {error.Message}");
                return Result.Fail<FormFlujoPantallaDto>(new Error($"Error getting the flow: {error.Message}")).WithError(error.Message);
            }

        }

        public async Task<Result<ICollection<FormFlujoPantallaDto>>> GetFlujosPantallas()
        {
            try
            {
                var query = _context.FormFlujoPantallas;
                ICollection<FormFlujoPantallaDto> result = await _mapper.ProjectTo<FormFlujoPantallaDto>(query).ToListAsync();

                return Result.Ok(result);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error getting the flows: {error.Message}");
                return Result.Fail<ICollection<FormFlujoPantallaDto>>(new Error($"Error getting the flows: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<ICollection<FormFlujoPantallaDto>>> GetFlujosPantallasByFormaId(int formaId)
        {
            try
            {
                var query = _context.FormFlujoPantallas.Where(x => x.FormaId == formaId);
                ICollection<FormFlujoPantallaDto> result = await _mapper.ProjectTo<FormFlujoPantallaDto>(query).ToListAsync();

                return Result.Ok(result);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error getting the flows: {error.Message}");
                return Result.Fail<ICollection<FormFlujoPantallaDto>>(new Error($"Error getting the flows: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<ICollection<FormFlujoPantallaDto>>> GetFlujosPantallasByFormularioId(int formularioId)
        {
            try
            {
                var query = _context.FormFlujoPantallas.Where(x => x.FormularioId == formularioId);
                ICollection<FormFlujoPantallaDto> result = await _mapper.ProjectTo<FormFlujoPantallaDto>(query).ToListAsync();

                return Result.Ok(result);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error getting the flows: {error.Message}");
                return Result.Fail<ICollection<FormFlujoPantallaDto>>(new Error($"Error getting the flows: {error.Message}")).WithError(error.Message);

            }
        }

        public async Task<Result<FormFlujoPantallaDto>> RemoveFlujoPantalla(int flujoPantallaId, string user)
        {
            try
            {
                var entity = await _context.FormFlujoPantallas.FindAsync(flujoPantallaId);
                if (entity == null)
                {
                    return Result.Fail<FormFlujoPantallaDto>(new Error($"The flow with id {flujoPantallaId} does not exist"));
                }

                _context.FormFlujoPantallas.Remove(entity);
                await _context.SaveChangesAsync();

                var admFlujoPantallaDto = _mapper.Map<FormFlujoPantallaDto>(entity);
                return Result.Ok(admFlujoPantallaDto);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error deleting the flow: {error.Message}");
                return Result.Fail<FormFlujoPantallaDto>(new Error($"Error deleting the flow: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<FormFlujoPantallaDto>> UpdateFlujoPantalla(FormFlujoPantallaUpdateDto itemToUpdate, string user)
        {
            try
            {
                var entity = await _context.FormFlujoPantallas
                    .Where(x => x.FormularioId == itemToUpdate.FormularioId)
                    .FirstOrDefaultAsync();

                if (entity == null)
                {
                    return Result.Fail<FormFlujoPantallaDto>(new Error($"The flow with id {itemToUpdate.FormularioId} does not exist"));
                }

                entity = _mapper.Map(itemToUpdate, entity);

                await _context.SaveChangesAsync();

                var result = _mapper.Map<FormFlujoPantallaDto>(entity);
                return Result.Ok(result);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error updating the flow: {error.Message}");
                return Result.Fail<FormFlujoPantallaDto>(new Error($"Error updating the flow: {error.Message}")).WithError(error.Message);
            }
        }
    }
}
