using sgc.Identity.Api.Configuration;
using sgc.Identity.Api.Configurations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddIdentityConfiguration(builder.Configuration);
builder.Services.AddApiConfiguration();
builder.Services.AddSwaggerConfiguration();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
