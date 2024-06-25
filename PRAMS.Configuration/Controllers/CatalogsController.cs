using FluentResults;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PRAMS.Application.Contract.SystemConfiguration;
using PRAMS.Domain.Entities.Shared;
using PRAMS.Domain.Entities.SystemConfiguration.Dto;
using System.Net.Mime;
using System.Security.Claims;

namespace PRAMS.Configuration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogsController : ControllerBase
    {
        private readonly ICatalogsService _catalogsService;
        private readonly ILogger<CatalogsController> _logger;

        public CatalogsController(ICatalogsService catalogsService, ILogger<CatalogsController> logger)
        {
            _catalogsService = catalogsService;
            _logger = logger;
        }

        [HttpGet("GetCatalogs/{categoriaID}/0")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<ICollection<AdmParametrosNivel0Dto>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> GetCatalogZero(int categoriaID)
        {
            try
            {
                Result<ICollection<AdmParametrosNivel0Dto>> catalogsResult = await _catalogsService.GetCatalogZero(categoriaID);
                if (catalogsResult.IsSuccess)
                {
                    _logger.LogInformation("Success in GetCatalogZero Result:{@resut}", catalogsResult.Value);
                    return Ok(new ResponseDto<ICollection<AdmParametrosNivel0Dto>> { Result = catalogsResult.Value });
                }
                else
                {
                    _logger.LogError("Error in GetCatalogZero Error:{@error}", catalogsResult.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = catalogsResult.Errors.First().Message, Result = catalogsResult.Errors });
                }

            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in GetCatalogZero");
                throw;
            }
        }

        [HttpGet("GetCatalogs/{categoriaID}/1")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<ICollection<AdmParametrosNivel1Dto>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> GetCatalogOne(int categoriaID)
        {
            try
            {
                Result<ICollection<AdmParametrosNivel1Dto>> catalogsResult = await _catalogsService.GetCatalogOne(categoriaID);
                if (catalogsResult.IsSuccess)
                {
                    _logger.LogInformation("Success in GetCatalogOne Result:{@resut}", catalogsResult.Value);
                    return Ok(new ResponseDto<ICollection<AdmParametrosNivel1Dto>> { Result = catalogsResult.Value });
                }
                else
                {
                    _logger.LogError("Error in GetCatalogOne Error:{@error}", catalogsResult.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = catalogsResult.Errors.First().Message, Result = catalogsResult.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in GetCatalogOne");
                throw;
            }
        }

        [HttpGet("GetCatalogs/{categoriaID}/2")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<ICollection<AdmParametrosNivel2Dto>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> GetCatalogTwo(int categoriaID)
        {
            try
            {
                Result<ICollection<AdmParametrosNivel2Dto>> catalogsResult = await _catalogsService.GetCatalogTwo(categoriaID);
                if (catalogsResult.IsSuccess)
                {
                    _logger.LogInformation("Success in GetCatalogTwo Result:{@resut}", catalogsResult.Value);
                    return Ok(new ResponseDto<ICollection<AdmParametrosNivel2Dto>> { Result = catalogsResult.Value });
                }
                else
                {
                    _logger.LogError("Error in GetCatalogTwo Error:{@error}", catalogsResult.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = catalogsResult.Errors.First().Message, Result = catalogsResult.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in GetCatalogTwo");
                throw;
            }
        }

        [HttpGet("GetCatalogs/{categoriaID}/3")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<ICollection<AdmParametrosNivel3Dto>>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> GetCatalogTree(int categoriaID)
        {
            try
            {
                Result<ICollection<AdmParametrosNivel3Dto>> catalogsResult = await _catalogsService.GetCatalogTree(categoriaID);
                if (catalogsResult.IsSuccess)
                {
                    _logger.LogInformation("Success in GetCatalogTwo Result:{@resut}", catalogsResult.Value);
                    return Ok(new ResponseDto<ICollection<AdmParametrosNivel3Dto>> { Result = catalogsResult.Value });
                }
                else
                {
                    _logger.LogError("Error in GetCatalogTwo Error:{@error}", catalogsResult.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = catalogsResult.Errors.First().Message, Result = catalogsResult.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in GetCatalogTwo");
                throw;
            }
        }

        [HttpPost("InsertCatalog")]
        [Authorize]
        [Consumes(MediaTypeNames.Application.Json)]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<AdmParametrosNivel0InsertDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> InsertCatalog([FromBody] AdmParametrosNivel0InsertDto catalog)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;

                Result<AdmParametrosNivel0Dto> insertCatalog = await _catalogsService.InsertCatalog(catalog, user);
                if (insertCatalog.IsSuccess)
                {
                    _logger.LogInformation("Success in InsertCatalog Result:{@resut}", insertCatalog.Value);
                    return Ok(new ResponseDto<AdmParametrosNivel0Dto> { Result = insertCatalog.Value });
                }
                else
                {
                    _logger.LogError("Error in InsertCatalog Error:{@error}", insertCatalog.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = insertCatalog.Errors.First().Message, Result = insertCatalog.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in InsertCatalog");
                throw;
            }
        }

        [HttpPut("UpdateCatalog")]
        [Authorize]
        [Consumes(MediaTypeNames.Application.Json)]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<AdmParametrosNivel0UpdateDto>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> UpdateCatalog([FromBody] AdmParametrosNivel0UpdateDto catalog)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;

                Result<AdmParametrosNivel0Dto> updateCatalog = await _catalogsService.UpdateCatalog(catalog, user);
                if (updateCatalog.IsSuccess)
                {
                    _logger.LogInformation("Success in UpdateCatalog Result:{@resut}", updateCatalog.Value);
                    return Ok(new ResponseDto<AdmParametrosNivel0Dto> { Result = updateCatalog.Value });
                }
                else
                {
                    _logger.LogError("Error in UpdateCatalog Error:{@error}", updateCatalog.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = updateCatalog.Errors.First().Message, Result = updateCatalog.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in UpdateCatalog");
                throw;
            }
        }

        [HttpDelete("RemoveCatalog/{paramterosID}")]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(statusCode: 200, Type = typeof(ResponseDto<bool>))]
        [ProducesResponseType(statusCode: 400, Type = typeof(ErrorResponseDto<List<IError>>))]
        public async Task<IActionResult> RemoveCatalog(int paramterosID)
        {
            try
            {
                // Get the user id from the Authorize
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;

                Result<bool> removeCatalog = await _catalogsService.RemoveCatalog(paramterosID, user);
                if (removeCatalog.IsSuccess)
                {
                    _logger.LogInformation("Success in RemoveCatalog Result:{@resut}", removeCatalog.Value);
                    return Ok(new ResponseDto<bool> { Result = removeCatalog.Value });
                }
                else
                {
                    _logger.LogError("Error in RemoveCatalog Error:{@error}", removeCatalog.Errors);
                    return BadRequest(new ErrorResponseDto<List<IError>> { Message = removeCatalog.Errors.First().Message, Result = removeCatalog.Errors });
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, "Error in RemoveCatalog");
                throw;
            }
        }

    }
}
