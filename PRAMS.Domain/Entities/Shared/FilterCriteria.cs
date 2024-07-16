using System.Text.Json.Serialization;

namespace PRAMS.Domain.Entities.Shared
{
    public class FilterCriteria
    {
        [JsonPropertyName("startDate")]
        public DateTime? StartDate { get; set; }

        [JsonPropertyName("endDate")]
        public DateTime? EndDate { get; set; }

        [JsonPropertyName("draw")]
        public int Draw { get; set; }

        [JsonPropertyName("columns")]
        public IList<Column> Columns { get; set; } = new List<Column>();

        [JsonPropertyName("order")]
        public IList<Order> Order { get; set; } = new List<Order>();

        [JsonPropertyName("start")]
        public int Start { get; set; }

        [JsonPropertyName("length")]
        public int Length { get; set; }

        [JsonPropertyName("search")]
        public Search? Search { get; set; }
    }

    public class Search
    {
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;

        [JsonPropertyName("regex")]
        public bool Regex { get; set; }

        [JsonPropertyName("_fixed")]
        public IList<object>? Fixed { get; set; }
    }

    public class Column
    {
        [JsonPropertyName("data")]
        public string Data { get; set; } = string.Empty;

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("searchable")]
        public bool Searchable { get; set; } = false;

        [JsonPropertyName("orderable")]
        public bool Orderable { get; set; } = false;

        [JsonPropertyName("search")]
        public SearchOne? Search { get; set; }
    }

    public class SearchOne
    {
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;

        [JsonPropertyName("regex")]
        public bool Regex { get; set; }

        [JsonPropertyName("_fixed")]
        public IList<object>? Fixed { get; set; }
    }

    public class Order
    {
        [JsonPropertyName("column")]
        public int Column { get; set; }

        [JsonPropertyName("dir")]
        public string Dir { get; set; } = string.Empty;

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
    }

}
