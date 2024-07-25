namespace Backoffice.Components.Models.GraphQL;

public class GraphQLMutationUpdate
{
    public string query { get; set; } = null!;
    public UpdateVariables? variables { get; set; }
}