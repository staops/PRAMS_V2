﻿using AutoMapper;
using FluentResults;
using LinqKit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PRAMS.Application.Contract.Forms;
using PRAMS.Domain.Entities.Forms.Dto;
using PRAMS.Domain.Entities.Shared;
using PRAMS.Domain.Models.Forms;
using PRAMS.Infraestructure.Data.SystemConfiguration;
using System.Linq.Expressions;

namespace PRAMS.Infraestructure.Services.Forms
{
    public class FormReferidoService : IFormReferidoService
    {
        private readonly AppConfigDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<IFormReferidoService> _logger;

        public FormReferidoService(AppConfigDbContext context, IMapper mapper, ILogger<IFormReferidoService> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Result<FormReferidoDto>> CreateFormReferido(FormReferidoInsertDto formReferidoInsertDto, string user)
        {
            try
            {
                var formReferido = _mapper.Map<FormReferido>(formReferidoInsertDto);
                formReferido.CreateUser = user;
                formReferido.CreateDate = DateTime.Now;

                await _context.FormReferidos.AddAsync(formReferido);
                await _context.SaveChangesAsync();

                var formReferidoDto = _mapper.Map<FormReferidoDto>(formReferido);
                return Result.Ok(formReferidoDto);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error in the form creation: {error.Message}");
                return Result.Fail<FormReferidoDto>(new Error($"Error in the form creation: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<FormReferidoDto>> GetFormReferido(int formReferidoId)
        {
            try
            {
                var formReferido = await _context.FormReferidos.FindAsync(formReferidoId);

                if (formReferido == null)
                {
                    return Result.Fail<FormReferidoDto>(new Error($"The form with id {formReferidoId} was not found"));
                }

                var formReferidoDto = _mapper.Map<FormReferidoDto>(formReferido);
                return Result.Ok(formReferidoDto);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error getting the form: {error.Message}");
                return Result.Fail<FormReferidoDto>(new Error($"Error getting the form: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<ICollection<FormReferidoDto>>> GetFormReferidos()
        {
            try
            {
                var formReferidos = await _context.FormReferidos.Where(w => w.Activo).ToListAsync();
                var formReferidosDto = _mapper.Map<List<FormReferidoDto>>(formReferidos);
                return Result.Ok<ICollection<FormReferidoDto>>(formReferidosDto);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error getting the forms: {error.Message}");
                return Result.Fail<ICollection<FormReferidoDto>>(new Error($"Error getting the forms: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<DtResult<FormReferidoDto>>> ListFormReferidos(FilterCriteria filterCriteria)
        {
            try
            {
                string searchBy = filterCriteria.Search?.Value ?? string.Empty;

                // if we have an empty search then just order the results by Id ascending
                string orderCriteria = "referidoId";
                bool orderAscendingDirection = true;

                if (filterCriteria.Order != null && filterCriteria.Order.Any())
                {
                    // in this example we just default sort on the 1st column
                    orderCriteria = filterCriteria.Columns[filterCriteria.Order[0].Column].Data;
                    orderAscendingDirection = filterCriteria.Order[0].Dir.ToString().Equals("asc", StringComparison.CurrentCultureIgnoreCase);
                }

                // Build the predicate based on the search criteria
                var predicate = PredicateBuilder.New<FormReferido>(true);

                if (!string.IsNullOrEmpty(searchBy))
                {
                    predicate = predicate.Or(x => x.RMO != null && x.RMO.Contains(searchBy));
                    predicate = predicate.Or(x => x.TipoReferido != null && x.TipoReferido.Contains(searchBy));
                    predicate = predicate.Or(x => x.AccionTomada != null && x.AccionTomada.Contains(searchBy));
                    predicate = predicate.Or(x => x.Narrativa_Situacion != null && x.Narrativa_Situacion.Contains(searchBy));
                }

                // Get the data for the current page
                IQueryable<FormReferido> result = _context.FormReferidos.Where(predicate)
                    .AsQueryable();

                // now just get the count of items (without the skip and take) - eg how many could be returned with filtering
                int filteredResultsCount = await result.CountAsync();
                int totalResultsCount = await _context.FormReferidos.CountAsync();

                IQueryable<FormReferidoDto> basicInfApplicantDtos = _mapper.Map<List<FormReferidoDto>>(result).AsQueryable();


                // Ordering using reflection 
                string command = orderAscendingDirection ? "OrderBy" : "OrderByDescending";
                var type = typeof(FormReferidoDto);
                var property = type.GetProperty(orderCriteria.ToUpper(), System.Reflection.BindingFlags.IgnoreCase | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
                var parameter = Expression.Parameter(type, "p");
                var propertyAccess = Expression.MakeMemberAccess(parameter, property);
                var orderByExpression = Expression.Lambda(propertyAccess, parameter);
                var resultExpression = Expression.Call(typeof(Queryable), command, [type, property.PropertyType], basicInfApplicantDtos.AsQueryable().Expression, Expression.Quote(orderByExpression));


                // Get the data for the current page
                List<FormReferidoDto> data = [.. basicInfApplicantDtos.Provider.CreateQuery<FormReferidoDto>(resultExpression)
                    .Skip(filterCriteria.Start)
                    .Take(filterCriteria.Length)];

                DtResult<FormReferidoDto> objectResult = new()
                {
                    Draw = filterCriteria.Draw,
                    RecordsTotal = filteredResultsCount,
                    RecordsFiltered = filteredResultsCount,
                    Data = data
                };

                return Result.Ok(objectResult);
            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error listing the referidos: {error.Message}");
                return Result.Fail<DtResult<FormReferidoDto>>(new Error($"Error listing the referidos: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<FormReferidoDto>> RemoveFormReferido(int formReferidoId, string user)
        {
            try
            {

                var formReferido = await _context.FormReferidos.FindAsync(formReferidoId);

                if (formReferido == null)
                {
                    return Result.Fail<FormReferidoDto>(new Error($"The form with id {formReferidoId} was not found"));
                }

                _context.FormReferidos.Remove(formReferido);
                await _context.SaveChangesAsync();

                var formReferidoDto = _mapper.Map<FormReferidoDto>(formReferido);
                return Result.Ok(formReferidoDto);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error removing the form: {error.Message}");
                return Result.Fail<FormReferidoDto>(new Error($"Error removing the form: {error.Message}")).WithError(error.Message);
            }
        }

        public async Task<Result<FormReferidoDto>> UpdateFormReferido(FormReferidoUpdateDto formReferidoUpdateDto, string user)
        {
            try
            {
                var formReferido = await _context.FormReferidos.FindAsync(formReferidoUpdateDto.ReferidoId);

                if (formReferido == null)
                {
                    return Result.Fail<FormReferidoDto>(new Error($"The form with id {formReferidoUpdateDto.ReferidoId} was not found"));
                }

                _mapper.Map(formReferidoUpdateDto, formReferido);
                await _context.SaveChangesAsync();

                var formReferidoDto = _mapper.Map<FormReferidoDto>(formReferido);
                return Result.Ok(formReferidoDto);

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error updating the form: {error.Message}");
                return Result.Fail<FormReferidoDto>(new Error($"Error updating the form: {error.Message}")).WithError(error.Message);
            }
        }
    }
}
