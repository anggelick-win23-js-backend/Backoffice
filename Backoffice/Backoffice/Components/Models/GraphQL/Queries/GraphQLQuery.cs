namespace Backoffice.Components.Models.GraphQL;

public class GraphQLQuery
{
    public string Query { get; set; } = null!;
    public QueryVariables? Variables { get; set; }
}

public class QueryVariables
{
    public int Id { get; set; }
}