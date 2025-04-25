

var builder = Host.CreateApplicationBuilder(args);

builder.Logging
    .AddConsole(consoleLogOptions => 
        consoleLogOptions.LogToStandardErrorThreshold = LogLevel.Trace);

builder.Services
    .AddMcpServer()
    //.WithStreamServerTransport()
    .WithStdioServerTransport()
    .WithToolsFromAssembly();

await builder.Build().RunAsync();