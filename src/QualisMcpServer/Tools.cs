namespace QualisMcpServer;

[McpServerToolType]
public static class QualisTool
{
    [McpServerTool, Description("Retorna informações sobre a classificação de eventos para 2017-2020.")]
    public static string Sobre() =>
        """
        CLASSIFICAÇÃO DE EVENTOS PARA 2017-2020 – CIÊNCIA DA COMPUTAÇÃO

        Esta lista foi utilizada para classificar os artigos publicados de 2017 até 2020 pelos programas de 
        pós-graduação da Área. A presente lista foi elaborada para avaliação de programas de pós-graduação 
        (conjunto de pesquisadores) e não de pesquisadores individualmente. Diversos outros eventos poderiam 
        ter sido incluídos nesta lista caso algum pesquisador de programa de pós-graduação da Área tivesse 
        publicado algum artigo no referido evento, no período de 2017 a 2020 que corresponde à quadrienal, 
        desde que cumprissem os requisitos da Área. 		
        """;

    [McpServerTool, Description("Recupera a classificação de um evento específico.")]
    public static string Qualis(string sigla) => ToolsDataSet.Content;
}
