using Company.Infrastructure.Persistence;
using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Company.Presentation.Extensions;

public static class ServiceExtension
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,
        string? connectionString)
    {
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseMySQL(connectionString!);
        });
        
        return services;
    }
}