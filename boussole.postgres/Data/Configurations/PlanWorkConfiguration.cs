using LSO.Contracts.SSO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Boussole.Postgres.Data.Configurations;

internal class PlanWorkConfiguration : IEntityTypeConfiguration<PlanWork>
{
    /// <summary>
    /// Занесение экземпляра класса PlanWork в таблицу PlanWorks с первичным ключом Id
    /// </summary>
    public void Configure(EntityTypeBuilder<PlanWork> builder)
    {
        builder.HasKey(p => p.Id);
        
        builder.Property(p => p.WorkerActivityStatus)
            .HasConversion(new EnumToStringConverter<WorkerActivityStatus>());

        builder.HasOne(p => p.SquadMember).WithMany().IsRequired();
    }
}