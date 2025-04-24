namespace QualisMcpServer;

[McpServerToolType]
public static class QualisTool
{
    [McpServerTool, Description("Returns the classification of events for 2017-2020 - computer science")]
    public static string About()
        => """
           CLASSIFICATION OF EVENTS FOR 2017-2020 – COMPUTER SCIENCE
           The Qualis, Qualis-Journals or Qualis/CAPES is a Brazilian system for evaluating journals, maintained by the
           Coordination for the Improvement of Higher Education Personnel (CAPES), which relates and classifies the
           vehicles used for the dissemination of the intellectual production of postgraduate programs of the type "stricto
           sensu" (master's and doctoral), regarding the scope of circulation (local, national or international) and quality
           (A, B, C), by area of evaluation.
           """;

    [McpServerTool, Description("Get the classification of events for 2017-2020 - computer science")]
    public static string AllQualis()
        => ToolsDataSet.Content;

    [McpServerTool, Description("Get the classification of events for 2017-2020 - computer science")]
    public static string Qualis(string sigla)
        => ToolsDataSet.Content.Split('\n').FirstOrDefault(line => line.Contains(sigla)) ?? "Qualis not found";
}