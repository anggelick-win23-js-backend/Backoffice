namespace Backoffice.Components.Models.GraphQL;

public class GraphQLMutationDelete
{
    public string query { get; set; } = null!;
    public DeleteVariables? variables { get; set; }
}