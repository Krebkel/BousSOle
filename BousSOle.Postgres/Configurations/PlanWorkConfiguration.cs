using LSO.SSO.ProductivityContracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BousSOle.Postgres.Configurations;

internal class PlanWorkConfiguration : IEntityTypeConfiguration<PlanWork>
{
    /// <summary>
    /// Занесение экземпляра класса PlanWork в таблицу PlanWorks с первичным ключом Id
    /// </summary>
    public void Configure(EntityTypeBuilder<PlanWork> builder)
    {
        builder.HasKey(entity => entity.Id);
        
        builder.Property(r => r.WorkerActivityStatus)
            .HasConversion(new EnumToStringConverter<WorkerActivityStatus>());
    }
}