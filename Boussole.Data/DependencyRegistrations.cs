using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Boussole.Data;

/// <summary>
/// Статический класс, содержащий методы для регистрации зависимостей в приложении.
/// Предоставляет метод AddPostgresDatabase, который регистрирует контекст базы данных
/// (BousSOleDbContext) для работы с базой данных PostgreSQL
/// </summary>
public static class DependencyRegistrations
{
    /// <summary>
    /// Зарегистрировать DbContext
    /// </summary>
    public static IServiceCollection AddPostgres(this IServiceCollection services)
    {
        services.AddDbContext<BousSOleDbContext>((provider, opt) =>
            opt.UseNpgsql(provider.GetRequiredService<IOptions<PostgresOptions>>().Value.ConnectionString, 
                builder => builder.MigrationsHistoryTable("__EFMigrationsHistory", BousSOleDbContext.ServiceSchema)));

        return services;
    }
}