using Microsoft.EntityFrameworkCore;
using TDDSI.CENSOMUNICIPAL.BACKEND.Api.Middlewares;
using TDDSI.CENSOMUNICIPAL.BACKEND.Application.Extensions;
using TDDSI.CENSOMUNICIPAL.BACKEND.Application.Messaging;
using TDDSI.CENSOMUNICIPAL.BACKEND.Application.Services;
using TDDSI.CENSOMUNICIPAL.BACKEND.Domain.Interfaces;
using TDDSI.CENSOMUNICIPAL.BACKEND.Infrastructure;
using TDDSI.CENSOMUNICIPAL.BACKEND.Infrastructure.PostgreSql.Extensions;
using TDDSI.CENSOMUNICIPAL.BACKEND.Infrastructure.Repositories;

WebApplicationBuilder builder = WebApplication
    .CreateBuilder( args );

builder.Configuration
    .AddJsonFile( "appsettings.json", optional: false, reloadOnChange: true )
    .AddJsonFile( $"appsettings.{builder.Environment.EnvironmentName}.json", optional: true )
    .AddEnvironmentVariables();

builder.Services
    .AddApplication( builder.Configuration )
    .AddDomainService()
    .AddInfrastructurePostgreSql( builder.Configuration );

builder.Services.AddDbContext<AppBContext>( options =>
    options.UseNpgsql( builder.Configuration.GetConnectionString( "DefaultConnection" ) ) );

builder.Services.AddTransient<IDispatch, Dispatch>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpContextAccessor();

builder.Services.AddScoped<ICitizenRepository, CitizenRepository>();
builder.Services.AddScoped<CitizenService>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger( options => {
        options.SerializeAsV2 = true;
    } );
    app.UseSwaggerUI();
}

app.UseMiddleware<ExceptionMiddleware>();
app.UseHttpsRedirection();
app.UseAuthorization();
app.UseSwagger();
app.UseSwaggerUI();
app.UseRouting();
app.MapControllers();
app.Run();
