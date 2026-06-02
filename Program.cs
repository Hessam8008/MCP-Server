var builder = Host.CreateApplicationBuilder(args);

builder.Logging.ClearProviders();

builder.Services.AddMcpServer().WithStdioServerTransport().WithToolsFromAssembly();

var app = builder.Build();

await app.RunAsync();
