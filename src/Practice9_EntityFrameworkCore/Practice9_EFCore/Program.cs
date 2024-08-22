using Microsoft.EntityFrameworkCore;
using Practice9_EFCore.Domain;
using Practice9_EFCore.Domain.Repositories;
using Practice9_EFCore.Services;
using Practice9_EFCore.Infrastructure.Repositories;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var configuration = builder.Configuration;

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddDbContext<CompaniesDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString(nameof(CompaniesDbContext)));
            });

        builder.Services.AddScoped<IBuildingsService, BuildingsService>();
        builder.Services.AddScoped<IBuildingsRepository, BuildingsRepository>();

        builder.Services.AddScoped<ICompaniesService, CompaniesService>();
        builder.Services.AddScoped<ICompaniesRepository, CompaniesRepository>();

        builder.Services.AddScoped<IRubricsService, RubricsService>();
        builder.Services.AddScoped<IRubricsRepository, RubricsRepository>();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();
        app.Run();
    }
}