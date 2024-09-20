using FluentResults;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using PRAMS.Application.Contract.Shared;
using System.Data;
using System.Data.SqlClient;

namespace PRAMS.Infraestructure.Services.Shared
{
    public class BaseSqlService<T> : IBaseSqlService<T> where T : class
    {
        private readonly ILogger<IBaseSqlService<T>> _logger;

        public BaseSqlService(ILogger<IBaseSqlService<T>> logger)
        {
            _logger = logger;
        }

        public async Task<Result<T>> ExecuteStoreProcedure(RequestSQLDto requestSQLDto)
        {
            Result<T> result = new();
            try
            {
                //if (!requestSQLDto.ConnectionString.Contains("Data Source"))
                //{
                //    requestSQLDto.ConnectionString = _encryptService.Decrypt(requestSQLDto.ConnectionString);
                //}

                if (string.IsNullOrEmpty(requestSQLDto.ConnectionString))
                {
                    throw new Exception("ConnectionString is empty");
                }

                using var connection = new SqlConnection(requestSQLDto.ConnectionString);
                using var command = new SqlCommand(requestSQLDto.StoreProcedureName, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 0;
                if (requestSQLDto.Parameters != null)
                {
                    foreach (var parameter in requestSQLDto.Parameters)
                    {
                        command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                    }
                }
                await connection.OpenAsync();
                using SqlDataAdapter Data = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                Data.Fill(dt);
                string stringDataTable = JsonConvert.SerializeObject(dt, Newtonsoft.Json.Formatting.Indented);
                var storeResponse = JsonConvert.DeserializeObject<T>(stringDataTable);

                result = (storeResponse is not null) ? Result.Ok(storeResponse) : Result.Fail(new Error($"Error in {requestSQLDto.StoreProcedureName}"));

                // Obfuscate the connection string
                //requestSQLDto.ConnectionString = StringObfuscate.Obfuscate(requestSQLDto.ConnectionString);
                //_logger.LogInformation("Request:{@Request} Response:{@Response}", requestSQLDto, result);

                return result;
            }
            catch (Exception error)
            {
                //childScope.Span.SetException(error);
                result = Result.Fail(new Error($"Error in ExecuteStoreProcedure {requestSQLDto.StoreProcedureName} - {error.Message}")
                .CausedBy(error));
                _logger.LogError("Error:{@Error} Request:{@Request}", error, requestSQLDto);
                return result;
            }
        }
    }
}
