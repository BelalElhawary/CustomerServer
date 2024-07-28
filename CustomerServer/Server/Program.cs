using CustomerServer.Core.Domain.Repositories;
using CustomerServer.Core.Service.Abstractions;
using CustomerServer.Core.Services;
using CustomerServer.Infrastructure.Persistence;
using CustomerServer.Infrastructure.Persistence.Repositories;
using CustomerServer.Infrastructure.Presentation;
using CustomerServer.Middleware;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IServiceManager, ServiceManager>();
builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();

builder.Services.AddDbContextPool<RepositoryDbContext>(b =>
{
    var connectionString = builder.Configuration.GetConnectionString("Database");

    b.UseSqlServer(connectionString);
});

builder.Services.AddControllers()
    .AddApplicationPart(typeof(AssemblyReference).Assembly);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseMiddleware<ExceptionHandlingMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
