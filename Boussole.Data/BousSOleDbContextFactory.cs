using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Boussole.Data;

/// <summary>
/// Фабрика DbContext'а для создания миграций.
/// В рантайме не используется, нужна только в момент создания миграций
/// </summary>
internal class BousSOleDbContextFactory : IDesignTimeDbContextFactory<BousSOleDbContext>
{
    public BousSOleDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<BousSOleDbContext>();
        optionsBuilder.UseNpgsql(
            "Host=***;Port=5432;Database=***;Username=***;Password=***;Pooling=true;Maximum Pool Size=10", 
            builder => builder.MigrationsHistoryTable("__EFMigrationsHistory", BousSOleDbContext.ServiceSchema));

        return new BousSOleDbContext(optionsBuilder.Options);
    }
}