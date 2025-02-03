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
    public class FormAsignacionUsuarioService : IFormAsignacionUsuarioService
    {
        private readonly AppConfigDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<IFormAsignacionUsuarioService> _logger;

        public FormAsignacionUsuarioService(AppConfigDbContext context, IMapper mapper, ILogger<IFormAsignacionUsuarioService> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Result<FormAsignacionUsuariosDto>> CreateFormAsignacionUsuario(FormAsignacionUsuariosInsertDto formAsignacionUsuariosInsertDto, string user)
        {
            try
            {
                // Validate if the referido exist
                var formReferido = await _context.FormReferidos.FirstOrDefaultAsync(x => x.ReferidoId == formAsignacionUsuariosInsertDto.IdReferido);
                if (formReferido == null)
                {
                    return Result.Fail<FormAsignacionUsuariosDto>(new Error($"The referido with the IdReferido: {formAsignacionUsuariosInsertDto.IdReferido} does not exist"));
                }

                // Validate if exist an active assignment for the same referido
                var formAsignacionUsuario = await _context.formAsignacionUsuarios
                    .Where(w => w.Activo)
                    .FirstOrDefaultAsync(x => x.IdReferido == formAsignacionUsuariosInsertDto.IdReferido);
                // If exist an active assignment for the same referido, we need to update the assignment setting the PrincipalTS to false and setting the FechaEnd to the current date
                if (formAsignacionUsuario != null)
                {
                    formAsignacionUsuario.Activo = false;
                    formAsignacionUsuario.FechaEnd = DateTime.Now;
                    formAsignacionUsuario.PrincipalTS = false;
                    _context.formAsignacionUsuarios.Update(formAsignacionUsuario);
                    await _context.SaveChangesAsync();
                }

                // Add the new assignment
                var formAsignacionUsuarioNew = _mapper.Map<FormAsignacionUsuarios>(formAsignacionUsuariosInsertDto);
                formAsignacionUsuarioNew.FechaStart = DateTime.Now;
                formAsignacionUsuarioNew.Activo = true;
                formAsignacionUsuarioNew.IdUsuarioAsigna = user;
                formAsignacionUsuarioNew.FechaAsignacion = DateTime.Now;
                await _context.AddAsync(formAsignacionUsuarioNew);

                await _context.SaveChangesAsync();

                return Result.Ok(_mapper.Map<FormAsignacionUsuariosDto>(formAsignacionUsuarioNew));

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error in the creation of the flow: {error.Message}");
                return Result.Fail<FormAsignacionUsuariosDto>(new Error($"Error in the creation of the flow: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<FormAsignacionUsuariosDto>> GetByIdReferido(int IdReferido)
        {
            try
            {
                var formAsignacionUsuario = await _context.formAsignacionUsuarios.Where(w => w.Activo).FirstOrDefaultAsync(x => x.IdReferido == IdReferido);
                if (formAsignacionUsuario == null)
                {
                    return Result.Fail<FormAsignacionUsuariosDto>(new Error($"The flow with the IdReferido: {IdReferido} does not exist"));
                }
                return Result.Ok(_mapper.Map<FormAsignacionUsuariosDto>(formAsignacionUsuario));
            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error getting the flow: {error.Message}");
                return Result.Fail<FormAsignacionUsuariosDto>(new Error($"Error getting the flow: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<FormAsignacionUsuariosDto>> RemoveFormAsignacionUsuario(int IdAsignacionUsuario, string user)
        {
            try
            {
                var formAsignacionUsuario = await _context.formAsignacionUsuarios.FirstOrDefaultAsync(x => x.IdAsignacionUsuario == IdAsignacionUsuario);
                if (formAsignacionUsuario == null)
                {
                    return Result.Fail<FormAsignacionUsuariosDto>(new Error($"The flow with the IdAsignacionUsuario: {IdAsignacionUsuario} does not exist"));
                }
                formAsignacionUsuario.Activo = false;
                formAsignacionUsuario.PrincipalTS = false;
                formAsignacionUsuario.FechaEnd = DateTime.Now;
                _context.formAsignacionUsuarios.Update(formAsignacionUsuario);
                await _context.SaveChangesAsync();
                return Result.Ok(_mapper.Map<FormAsignacionUsuariosDto>(formAsignacionUsuario));

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error removing the flow: {error.Message}");
                return Result.Fail<FormAsignacionUsuariosDto>(new Error($"Error removing the flow: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<FormAsignacionUsuariosDto>> UpdateFormAsignacionUsuario(FormAsignacionUsuariosUpdateDto formAsignacionUsuariosInsertDto, string user)
        {
            try
            {
                var formAsignacionUsuario = await _context.formAsignacionUsuarios.FirstOrDefaultAsync(x => x.IdAsignacionUsuario == formAsignacionUsuariosInsertDto.IdAsignacionUsuario);
                if (formAsignacionUsuario == null)
                {
                    return Result.Fail<FormAsignacionUsuariosDto>(new Error($"The flow with the IdAsignacionUsuario: {formAsignacionUsuariosInsertDto.IdAsignacionUsuario} does not exist"));
                }

                formAsignacionUsuario = _mapper.Map(formAsignacionUsuariosInsertDto, formAsignacionUsuario);

                // If the assignment is not the principal, we need to set the FechaEnd to the current date
                if (!formAsignacionUsuario.PrincipalTS && formAsignacionUsuario.FechaEnd is null)
                {
                    formAsignacionUsuario.FechaEnd = DateTime.Now;
                }

                _context.formAsignacionUsuarios.Update(formAsignacionUsuario);
                await _context.SaveChangesAsync();

                return Result.Ok(_mapper.Map<FormAsignacionUsuariosDto>(formAsignacionUsuario));
            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error updating the flow: {error.Message}");
                return Result.Fail<FormAsignacionUsuariosDto>(new Error($"Error updating the flow: {error.Message}")).WithError(error.Message);
            }
        }
    }
}
