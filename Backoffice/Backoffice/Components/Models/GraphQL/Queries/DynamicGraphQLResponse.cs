using System.Text.Json;
using System.Text.Json.Serialization;

namespace Backoffice.Components.Models.GraphQL;

public class DynamicGraphQLResponse
{
    [JsonPropertyName("data")]
    public Data? Data { get; set; }
}
