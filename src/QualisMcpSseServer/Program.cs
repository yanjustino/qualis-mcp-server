using QualisMcpSseServer;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddMcpServer()
    .WithHttpTransport()
    .WithTools<QualisTool>();

var app = builder.Build();

app.MapMcp();
app.Run();

