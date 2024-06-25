using FluentResults;
using PRAMS.Domain.Entities.SystemConfiguration.Dto;

namespace PRAMS.Application.Contract.SystemConfiguration
{
    public interface ICatalogsService
    {
        Task<Result<ICollection<AdmParametrosNivel0Dto>>> GetCatalogZero(int catalogId);
        Task<Result<ICollection<AdmParametrosNivel1Dto>>> GetCatalogOne(int catalogId);
        Task<Result<ICollection<AdmParametrosNivel2Dto>>> GetCatalogTwo(int catalogId);
        Task<Result<ICollection<AdmParametrosNivel3Dto>>> GetCatalogTree(int catalogId);
        Task<Result<AdmParametrosNivel0Dto>> InsertCatalog(AdmParametrosNivel0InsertDto itemToInsert, string user);
        Task<Result<bool>> RemoveCatalog(int paramterosID, string user);
        Task<Result<AdmParametrosNivel0Dto>> UpdateCatalog(AdmParametrosNivel0UpdateDto itemToUpdate, string user);
    }
}
