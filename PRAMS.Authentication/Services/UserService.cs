using AutoMapper;
using FluentResults;
using LinqKit;
using Microsoft.EntityFrameworkCore;
using PRAMS.Authentication.Data;
using PRAMS.Authentication.Models;
using PRAMS.Authentication.Models.Dto;
using PRAMS.Authentication.Services.IServices;
using PRAMS.Domain.Entities.Shared;
using System.Linq.Expressions;

namespace PRAMS.Authentication.Services
{

    public class UserService : IUserService
    {
        private readonly AppDbContext _db;
        private readonly IMapper _mapper;
        private readonly ILogger<UserService> _logger;

        public UserService(AppDbContext db, IMapper mapper, ILogger<UserService> logger)
        {
            _db = db;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Result<DtResult<UserDto>>> ListUsersPaged(FilterCriteria filterCriteria)
        {
            try
            {
                string searchBy = filterCriteria.Search?.Value ?? string.Empty;

                // if we have an empty search then just order the results by Id ascending
                string orderCriteria = "ID";
                bool orderAscendingDirection = true;

                if (filterCriteria.Order != null && filterCriteria.Order.Any())
                {
                    // in this example we just default sort on the 1st column
                    orderCriteria = filterCriteria.Columns[filterCriteria.Order[0].Column].Data;
                    orderAscendingDirection = filterCriteria.Order[0].Dir.ToString().Equals("asc", StringComparison.CurrentCultureIgnoreCase);
                }

                // Build the predicate based on the search criteria
                var predicate = PredicateBuilder.New<ApplicationUser>(true);

                if (!string.IsNullOrEmpty(searchBy))
                {
                    predicate = predicate.Or(x => x.Local != null && x.Local.Contains(searchBy));
                    predicate = predicate.Or(x => x.Region != null && x.Region.Contains(searchBy));
                    predicate = predicate.Or(x => x.FirstName != null && x.FirstName.Contains(searchBy));
                    predicate = predicate.Or(x => x.LastName != null && x.LastName.Contains(searchBy));
                    predicate = predicate.Or(x => x.UserRoles.Any(y => y.Role.Name != null && y.Role.Name.Contains(searchBy)));
                    predicate = predicate.Or(x => x.Email != null && x.Email.Contains(searchBy));
                }

                // Get the data for the current page
                IQueryable<ApplicationUser> result = _db.ApplicationUsers
                    .Where(predicate)
                    .Include(x => x.UserRoles)
                    .ThenInclude(x => x.Role)
                    .AsQueryable();

                // now just get the count of items (without the skip and take) - eg how many could be returned with filtering
                int filteredResultsCount = await result.CountAsync();
                int totalResultsCount = await _db.Users.CountAsync();

                IQueryable<UserDto> basicInfApplicantDtos = _mapper.Map<List<UserDto>>(result).AsQueryable();


                // Ordering using reflection 
                string command = orderAscendingDirection ? "OrderBy" : "OrderByDescending";
                var type = typeof(UserDto);
                var property = type.GetProperty(orderCriteria.ToUpper(), System.Reflection.BindingFlags.IgnoreCase | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
                var parameter = Expression.Parameter(type, "p");
                var propertyAccess = Expression.MakeMemberAccess(parameter, property);
                var orderByExpression = Expression.Lambda(propertyAccess, parameter);
                var resultExpression = Expression.Call(typeof(Queryable), command, [type, property.PropertyType], basicInfApplicantDtos.AsQueryable().Expression, Expression.Quote(orderByExpression));


                // Get the data for the current page
                List<UserDto> data = [.. basicInfApplicantDtos.Provider.CreateQuery<UserDto>(resultExpression)
                    .Skip(filterCriteria.Start)
                    .Take(filterCriteria.Length)];

                DtResult<UserDto> objectResult = new()
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
                _logger.LogError(error, "Error in ListPersonas");
                return Result.Fail(new Error($"Error in ListPersonas {error.Message}")).WithError(error.StackTrace);
            }
        }
    }
}
