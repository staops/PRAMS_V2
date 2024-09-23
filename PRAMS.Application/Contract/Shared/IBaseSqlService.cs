using FluentResults;

namespace PRAMS.Application.Contract.Shared
{
    public interface IBaseSqlService<T>
    {
        /// <summary>
        /// Execute a store procedure and return the result serialized in the specified type
        /// 
        /// </summary>
        /// <param name="requestSQLDto"></param>
        /// <returns></returns>
        Task<Result<T>> ExecuteStoreProcedure(RequestSQLDto requestSQLDto);
    }
}
