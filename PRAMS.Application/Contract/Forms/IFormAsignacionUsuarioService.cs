using FluentResults;
using PRAMS.Domain.Entities.Forms.Dto;

namespace PRAMS.Application.Contract.Forms
{
    public interface IFormAsignacionUsuarioService
    {
        Task<Result<FormAsignacionUsuariosDto>> GetByIdReferido(int IdReferido);
        Task<Result<FormAsignacionUsuariosDto>> CreateFormAsignacionUsuario(FormAsignacionUsuariosInsertDto formAsignacionUsuariosInsertDto, string user);
        Task<Result<FormAsignacionUsuariosDto>> UpdateFormAsignacionUsuario(FormAsignacionUsuariosUpdateDto formAsignacionUsuariosInsertDto, string user);
        Task<Result<FormAsignacionUsuariosDto>> RemoveFormAsignacionUsuario(int IdAsignacionUsuario, string user);
    }
}
