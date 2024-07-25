namespace Backoffice.Components.Models.GraphQL.Mutations.Create;

public class GraphQLMutationCreate
{
    public string query { get; set; } = null!;
    public CreateVariables? variables { get; set; }
}