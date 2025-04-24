var builder = Host.CreateApplicationBuilder(args);

builder.Logging
    .AddConsole(consoleLogOptions => 
        consoleLogOptions.LogToStandardErrorThreshold = LogLevel.Trace);

builder.Services
    .AddMcpServer()
    .WithStdioServerTransport()
    .WithToolsFromAssembly();

await builder.Build().RunAsync();