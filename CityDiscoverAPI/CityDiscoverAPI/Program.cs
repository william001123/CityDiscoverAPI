using CityDiscoverAPI.Filtros;
using CityDiscoverApli.Interfaces;
using CityDiscoverApli.Servicios;
using CityDiscoverOper.Contextos;
using CityDiscoverOper.Operaciones;
using CityDiscoverDom.Interfaces.Base;
using CityDiscoverDom.Modelos;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

#region "Cors"

var misReglasCors = "ReglasCors";

builder.Services.AddCors(p => p.AddPolicy(misReglasCors, builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

builder.Configuration.AddJsonFile("appsettings.json");
var secretKey = builder.Configuration.GetSection("settings").GetSection("secretKey").ToString();
var keyBytes = Encoding.UTF8.GetBytes(secretKey);

builder.Services.AddAuthentication(config => {

    config.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    config.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(config => {
    config.RequireHttpsMetadata = false;
    config.SaveToken = false;
    config.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(keyBytes),
        ValidateIssuer = false,
        ValidateAudience = false
    };
});

#endregion

#region "Inyección de dependencias"

//Cadena de conexión
var connectionString = builder.Configuration.GetConnectionString("CityDiscover");
builder.Services.AddDbContext<CityDiscoverContexto>(x =>
{
    x.UseSqlServer(connectionString);
    x.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});

builder.Services.AddTransient<CityDiscoverContexto>();

//Inyección para las operaciones
builder.Services.AddTransient<IAutenticacion<clsAutenticacionModelo, string>, clsAutenticacionOpe>();
builder.Services.AddTransient<IBase<clsFotoAnexadaModelo, int>, clsFotoAnexadaOpe>();
builder.Services.AddTransient<IIntermedia<clsRol_AutenticacionModelo>, clsRol_AutenticacionOpe>();
builder.Services.AddTransient<IBase<clsRolModelo, int>, clsRolOpe>();
builder.Services.AddTransient<IBase<clsTipoLugarModelo, int>, clsTipoLugarOpe>();
builder.Services.AddTransient<IBase<clsUbicacionModelo, int>, clsUbicacionOpe>();

//Inyección para los servicios
builder.Services.AddTransient<IServicioAutenticacion<clsAutenticacionModelo, string>, clsAutenticacionServ>();
builder.Services.AddTransient<IServicioBase<clsFotoAnexadaModelo, int>, clsFotoAnexadaServ>();
builder.Services.AddTransient<IServicioIntermedia<clsRol_AutenticacionModelo>, clsRol_AutenticacionServ>();
builder.Services.AddTransient<IServicioBase<clsRolModelo, int>, clsRolServ>();
builder.Services.AddTransient<IServicioBase<clsTipoLugarModelo, int>, clsTipoLugarServ>();
builder.Services.AddTransient<IServicioBase<clsUbicacionModelo, int>, clsUbicacionServ>();

#endregion

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{

    //Configuarcion de la seguridad para swagger
    options.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.Models.OpenApiSecurityScheme()
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "JWT Token"
    });

    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
        new OpenApiSecurityScheme
        {
            Reference = new OpenApiReference
            {
                Type=ReferenceType.SecurityScheme,
                Id="Bearer"
            }
        },
        new string[]{}
        }
    });

    //Configuarcion de parametros por defecto en los end point para swagger
    options.OperationFilter<AcepteLenguajeHeader>();
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

//Se habilita los Cors
app.UseCors(misReglasCors);

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
