using Boussole.LSO.Contracts.SSO;
using Boussole.LSO.Contracts.Structure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Boussole.Data.Configurations;

internal class PlanWorkConfiguration : IEntityTypeConfiguration<PlanWork>
{
    /// <summary>
    /// Занесение экземпляра класса PlanWork в таблицу PlanWorks с первичным ключом Id
    /// </summary>
    public void Configure(EntityTypeBuilder<PlanWork> builder)
    {
        const string squadMemeberColumnName = "SquadMemberPersonInn";
        
        builder.Property(p => p.WorkerActivityStatus).HasConversion<string>();
        builder.HasOne(p => p.SquadMember)
            .WithMany()
            .HasForeignKey(squadMemeberColumnName)
            .IsRequired();
        
        builder.HasKey("Date", squadMemeberColumnName);
    }
}