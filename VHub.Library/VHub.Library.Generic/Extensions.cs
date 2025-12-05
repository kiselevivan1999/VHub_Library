using Microsoft.Extensions.DependencyInjection;
using VHub.Library.Generic.Repository;

namespace VHub.Library.Generic;

public static class Extensions
{
    /// <summary>
    /// Регистрация GenericRepository
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static IServiceCollection AddGenericRepository(this IServiceCollection services)
    {
        if (services == null)
            throw new ArgumentNullException(nameof(services));

        //services.AddScoped<IUnitOfWork, EfUnitOfWork>();

        // Регистрируем универсальный репозиторий
        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

        return services;
    }
}
