var builder = WebApplication.CreateBuilder(args);

// Configure Services

var app = builder.Build();

// Configure HTTP pipeline

app.Run();
