using Contracts;
using GlobalLogAPI.Extensions;
using LoggerService;
using NLog;
using GlobalLogAPI.CustomExceptionMiddleware;
using GlobalLogAPI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//var services = builder.Services;
//var env = builder.Environment;
// use sql server db in production and sqlite db in development
//if (env.IsProduction())
//    services.AddDbContext<DataContext>();
//else
//    services.AddDbContext<DataContext, SqliteDataContext>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ILoggerManager, LoggerManager>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// global cors policy
app.UseCors(x => x
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

////Log Error Global
//app.UseMiddleware<ExceptionMiddleware>();
// global error handler 
app.UseMiddleware<ErrorHandlerMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

