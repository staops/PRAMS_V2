using FluentResults;
using PRAMS.Authentication.Models.Dto;
using PRAMS.Domain.Entities.Shared;

namespace PRAMS.Authentication.Services.IServices
{
    public interface IUserService
    {
        Task<Result<DtResult<UserDto>>> ListUsersPaged(FilterCriteria filterCriteria);
    }
}
