using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Travel_Booking_Platform.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationDbContext(this IServiceCollection serviceCollection,
        IConfiguration configuration)
    {
        serviceCollection.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"])
                .EnableSensitiveDataLogging();
        });
        return serviceCollection;
    }
}