using EPA.Core.Configuration;
using EPA.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddSingleton<SqlConnectionFactory>(sp =>
{
    DatabaseSettings? settings = sp.GetRequiredService<IOptions<DatabaseSettings>>().Value;

    return new SqlConnectionFactory(settings.ConnectionString,settings.Timeout);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
