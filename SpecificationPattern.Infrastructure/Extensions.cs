using SpecificationPattern.Infrastructure.Data;
using SpecificationPattern.Infrastructure.Data.Context;
using SpecificationPattern.Infrastructure.Data.Internal;

namespace SpecificationPattern.Infrastructure;

public static class Extensions
{
    public static IServiceCollection AddCore(this IServiceCollection services, IConfiguration config )
    {
        services.AddHostedService<DbContextMigratorHostedService>();
        
        services.AddDbContextMsSql<AppDbContext>(config.GetConnectionString("db"));
        
        
        
        return services;
    }

    public static IApplicationBuilder UseCore(this WebApplication app, IWebHostEnvironment env)
    {
        
        
        return app;
    }
    
}