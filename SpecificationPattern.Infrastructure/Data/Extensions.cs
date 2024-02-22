using Microsoft.EntityFrameworkCore;

namespace SpecificationPattern.Infrastructure.Data;

public static class Extensions
{
    public static IServiceCollection AddDbContextMsSql<TDbContext>(this IServiceCollection services, string conn,
        Action<IServiceCollection> doMoreActions = null)
        where TDbContext : DbContext, IDbFacadeResolver
    {

        services.AddDbContext<TDbContext>(builder =>
        {
            builder.UseSqlServer(conn, optionsBuilder => optionsBuilder.EnableRetryOnFailure());
        });
        services.AddScoped<IDbFacadeResolver>(provider => provider.GetService<TDbContext>());
        
        
        doMoreActions?.Invoke(services);
        return services;
    }
}