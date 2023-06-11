using Microsoft.Extensions.DependencyInjection;

namespace Boussole.Users;

public static class DependencyRegistrations
{
    /// <summary>
    /// Зарегистрировать DbContext
    /// </summary>
    public static IServiceCollection AddUsers(this IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();
        return services;
    }
}