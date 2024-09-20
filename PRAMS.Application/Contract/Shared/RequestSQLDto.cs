namespace PRAMS.Application.Contract.Shared
{
    public class RequestSQLDto
    {
        public string ConnectionString { get; set; } = string.Empty;
        public string StoreProcedureName { get; set; } = "";
        public IDictionary<string, object>? Parameters { get; set; }

    }
}
