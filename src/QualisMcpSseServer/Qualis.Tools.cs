using System.ComponentModel;
using ModelContextProtocol.Server;

namespace QualisMcpSseServer;

[McpServerToolType]
public class QualisTool
{
    [McpServerTool, Description("Informations about dataset")]
    public static string About() => Dataset.About;

    [McpServerTool, Description("Get all qualis classification for 2017-2020 - computer science")]
    public static string AllQualis() => Dataset.Current.Content;

    [McpServerTool, Description("Search qualis classification and event name by sigla")]
    public static string Qualis(string sigla) => Dataset.Current.GetQualis(sigla);
}