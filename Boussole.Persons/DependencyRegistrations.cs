using Microsoft.Extensions.DependencyInjection;

namespace Boussole.Persons;

public static class DependencyRegistrations
{
    /// <summary>
    /// Зарегистрировать DbContext
    /// </summary>
    public static IServiceCollection AddPersons(this IServiceCollection services)
    {
        services.AddScoped<IPersonService, PersonService>();
        
        return services;
    }
}