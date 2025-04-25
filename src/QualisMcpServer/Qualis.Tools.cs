namespace QualisMcpServer;

[McpServerToolType]
public static class QualisTool
{
    [McpServerTool, Description("Returns the classification of events for 2017-2020 - computer science")]
    public static string About() => Dataset.About;

    [McpServerTool, Description("Get the classification of events for 2017-2020 - computer science")]
    public static string AllQualis() => Dataset.Current.Content;

    [McpServerTool, Description("Get especific classification of events for 2017-2020 - computer science")]
    public static string Qualis(string sigla) => Dataset.Current.GetQualis(sigla);
}