using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BousSOle.Postgres;

/// <summary>
/// Статический класс, содержащий методы для регистрации зависимостей в приложении.
/// Предоставляет метод AddPostgresDatabase, который регистрирует контекст базы данных (BousSOleDbContext) для работы с базой данных PostgreSQL
/// </summary>
public static class DependencyRegistrations
{
    /// <summary>
    /// Зарегистрировать DbContext
    /// </summary>
    public static IServiceCollection AddPostgresDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<BousSOleDbContext>(opt =>
            opt.UseNpgsql(configuration.GetConnectionString("Postgres"), builder => 
                builder.MigrationsHistoryTable("__EFMigrationsHistory", BousSOleDbContext.ServiceSchema)));

        return services;
    }
}