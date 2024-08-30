using FluentResults;
using PRAMS.Domain.Entities.SystemConfiguration.Dto;

namespace PRAMS.Application.Contract.Flujos
{
    public interface IFlujoPantallaUserService
    {
        Task<Result<ICollection<AdmFlujoPantallaUserDto>>> GetFlujoPantallaUsers(int formularioEtapaId);
        Task<Result<AdmFlujoPantallaUserDto>> GetFlujoPantallaUser(int flujoUserID);
        Task<Result<AdmFlujoPantallaUserDto>> CreateFlujoPantallaUserItem(AdmFlujoPantallaUserInsertDto admFlujoPantallaUserInsertDto, string user);
        Task<Result<AdmFlujoPantallaUserDto>> UpdateFlujoPantallaUserItem(AdmFlujoPantallaUserUpdateDto admFlujoPantallaUserUpdateDto, string user);
        Task<Result<AdmFlujoPantallaUserDto>> DeleteFlujoPantallaUserItem(int flujoUserID, string user);
    }
}
