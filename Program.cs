using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using SportMonitorAPI.AppContext;
using SportMonitorAPI.Entities;
using SportMonitorAPI.Errors;
using SportMonitorAPI.Helpers;
using SportMonitorAPI.Middleware;
using SportMonitorAPI.Repositories.GamePermormanceRepository;
using SportMonitorAPI.Repositories.GameRepository;
using SportMonitorAPI.Repositories.MeasurementRepository;
using SportMonitorAPI.Repositories.MeasurementTakenRepository;
using SportMonitorAPI.Repositories.PlayerRepository;
using SportMonitorAPI.Repositories.TestRepository;
using SportMonitorAPI.Repositories.TestTakenRepository;
using SportMonitorAPI.Services;
using System.Text;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
var services = builder.Services;
services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();
services.AddSwaggerGen(c =>
{
    var jwtSecurityScheme = new OpenApiSecurityScheme
    {
        BearerFormat = "JWT",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = JwtBearerDefaults.AuthenticationScheme,
        Description = "Put Bearer + your token in the box below",
        Reference = new OpenApiReference
        {
            Id = JwtBearerDefaults.AuthenticationScheme,
            Type = ReferenceType.SecurityScheme
        }
    };
    c.AddSecurityDefinition(jwtSecurityScheme.Reference.Id, jwtSecurityScheme);
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            jwtSecurityScheme, Array.Empty<string>()
        }
    });
});
//register AutoMapper
services.AddAutoMapper(typeof(MappingProfiles));
// get connection string and register application context
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
services.AddDbContext<ApplicationContext>(options =>
                    options.UseSqlServer(connectionString));
//register repositories
services.AddScoped<IPlayerRepository, PlayerRepository>();
services.AddScoped<ITestRepository, TestRepository>();
services.AddScoped<IMeasurementRepository, MeasurementRepository>();
services.AddScoped<IGameRepository, GameRepository>();
services.AddScoped<IGamePerformanceRepository, GamePermormanceRepository>();
services.AddScoped<ITestTakenRepository, TestTakenRepository>();
services.AddScoped<IMeasurementTakenRepository, MeasurementTakenRepository>();

//override the ApiController behaviour, add errors, if exists, to ApiValidationErrorResponse 
services.Configure<ApiBehaviorOptions>(options =>
{
    options.InvalidModelStateResponseFactory = actionContext =>
    {
        var errors = actionContext.ModelState
            .Where(e => e.Value.Errors.Count > 0)
            .SelectMany(x => x.Value.Errors)
            .Select(x => x.ErrorMessage).ToArray();

        var errorResponse = new ApiValidationErrorResponse
        {
            Errors = errors
        };
        return new BadRequestObjectResult(errorResponse);
    };
});

services.AddCors();
// Identity configurations
services.AddIdentityCore<User>(opt =>
{
    opt.User.RequireUniqueEmail = true;
})
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationContext>();
services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Secret"]))
        };
    });
services.AddAuthorization();
services.AddScoped<TokenService>();

var app = builder.Build();

// migrate database when application start
using var scope = app.Services.CreateScope();
var context = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
try
{
    context.Database.Migrate();
}
catch (Exception ex)
{
    logger.LogError(ex, "Probleme in timpul migrarii datelor");
}

// Configure the HTTP request pipeline.
app.UseMiddleware<ExceptionMiddleware>();
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.ConfigObject.AdditionalItems.Add("persistAuthorization", "true");
});
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.UseCors(options =>
{
    options.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:3000");
    options.AllowCredentials().AllowAnyMethod().WithOrigins("http://localhost:3000");
});
//app.UseStatusCodePagesWithReExecute("/errors/{0}");

app.UseHttpsRedirection();
app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
