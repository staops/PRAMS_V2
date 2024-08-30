using AutoMapper;
using FluentResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PRAMS.Application.Contract.Flujos;
using PRAMS.Domain.Entities.SystemConfiguration.Dto;
using PRAMS.Domain.Models.Flujos;
using PRAMS.Infraestructure.Data.SystemConfiguration;

namespace PRAMS.Infraestructure.Services.Flujos
{
    public class FlujoPantallaUserService : IFlujoPantallaUserService
    {
        private readonly AppConfigDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<IFlujoPantallaUserService> _logger;

        public FlujoPantallaUserService(AppConfigDbContext context, IMapper mapper, ILogger<IFlujoPantallaUserService> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Result<AdmFlujoPantallaUserDto>> CreateFlujoPantallaUserItem(AdmFlujoPantallaUserInsertDto admFlujoPantallaUserInsertDto, string user)
        {
            try
            {
                // Validate if the PantallaId exists
                var pantalla = await _context.AdmFlujoPantallaUsers.FindAsync(admFlujoPantallaUserInsertDto.FormularioEtapaId);
                if (pantalla == null)
                {
                    return Result.Fail<AdmFlujoPantallaUserDto>(new Error($"The screen with id {admFlujoPantallaUserInsertDto.FormularioEtapaId} does not exist"));
                }

                var admFlujoPantallaUser = _mapper.Map<AdmFlujoPantallaUser>(admFlujoPantallaUserInsertDto);

                await _context.AdmFlujoPantallaUsers.AddAsync(admFlujoPantallaUser);
                await _context.SaveChangesAsync();

                var admFlujoPantallaUserDto = _mapper.Map<AdmFlujoPantallaUserDto>(admFlujoPantallaUser);
                return Result.Ok(admFlujoPantallaUserDto);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error in the creation of the form flow: {error.Message}");
                return Result.Fail<AdmFlujoPantallaUserDto>(new Error($"Error in the creation of the form flow: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<AdmFlujoPantallaUserDto>> DeleteFlujoPantallaUserItem(int flujoUserID, string user)
        {
            try
            {
                var admFlujoPantallaUser = await _context.AdmFlujoPantallaUsers
                    .Where(w => w.FlujoUserID == flujoUserID)
                    .FirstOrDefaultAsync();

                if (admFlujoPantallaUser == null)
                {
                    return Result.Fail<AdmFlujoPantallaUserDto>(new Error($"The form flow with id {flujoUserID} does not exist"));
                }

                _context.AdmFlujoPantallaUsers.Remove(admFlujoPantallaUser);
                await _context.SaveChangesAsync();

                var admFlujoPantallaUserDto = _mapper.Map<AdmFlujoPantallaUserDto>(admFlujoPantallaUser);
                return Result.Ok(admFlujoPantallaUserDto);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error deleting the form flow: {error.Message}");
                return Result.Fail<AdmFlujoPantallaUserDto>(new Error($"Error deleting the form flow: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<AdmFlujoPantallaUserDto>> GetFlujoPantallaUser(int flujoUserID)
        {
            try
            {
                var admFlujoPantallaUser = await _context.AdmFlujoPantallaUsers
                    .Where(w => w.FlujoUserID == flujoUserID)
                    .FirstOrDefaultAsync();

                if (admFlujoPantallaUser == null)
                {
                    return Result.Fail<AdmFlujoPantallaUserDto>(new Error($"The form flow with id {flujoUserID} does not exist"));
                }

                var admFlujoPantallaUserDto = _mapper.Map<AdmFlujoPantallaUserDto>(admFlujoPantallaUser);
                return Result.Ok(admFlujoPantallaUserDto);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error getting the form flow: {error.Message}");
                return Result.Fail<AdmFlujoPantallaUserDto>(new Error($"Error deleting the form flow: {error.Message}")).WithError(error.Message);
            }

        }

        public async Task<Result<ICollection<AdmFlujoPantallaUserDto>>> GetFlujoPantallaUsers(int formularioEtapaId)
        {
            try
            {
                var admFlujoPantallaUsers = await _context.AdmFlujoPantallaUsers
                    .Where(w => w.FormularioEtapaId == formularioEtapaId)
                    .ToListAsync();

                if (admFlujoPantallaUsers == null)
                {
                    return Result.Fail<ICollection<AdmFlujoPantallaUserDto>>(new Error($"The form flow with id {formularioEtapaId} does not exist"));
                }

                var admFlujoPantallaUsersDto = _mapper.Map<ICollection<AdmFlujoPantallaUserDto>>(admFlujoPantallaUsers);
                return Result.Ok(admFlujoPantallaUsersDto);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error getting the form flow: {error.Message}");
                return Result.Fail<ICollection<AdmFlujoPantallaUserDto>>(new Error($"Error getting the form flow: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<AdmFlujoPantallaUserDto>> UpdateFlujoPantallaUserItem(AdmFlujoPantallaUserUpdateDto admFlujoPantallaUserUpdateDto, string user)
        {
            try
            {
                var admFlujoPantallaUser = await _context.AdmFlujoPantallaUsers.FindAsync(admFlujoPantallaUserUpdateDto.FlujoUserID);
                if (admFlujoPantallaUser == null)
                {
                    return Result.Fail<AdmFlujoPantallaUserDto>(new Error($"The form flow with id {admFlujoPantallaUserUpdateDto.FlujoUserID} does not exist"));
                }

                _mapper.Map(admFlujoPantallaUserUpdateDto, admFlujoPantallaUser);
                await _context.SaveChangesAsync();

                var admFlujoPantallaUserDto = _mapper.Map<AdmFlujoPantallaUserDto>(admFlujoPantallaUser);
                return Result.Ok(admFlujoPantallaUserDto);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error updating the form flow: {error.Message}");
                return Result.Fail<AdmFlujoPantallaUserDto>(new Error($"Error updating the form flow: {error.Message}")).WithError(error.Message);
            }
        }
    }
}
