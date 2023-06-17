using Boussole.LSO.Contracts.SSO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Boussole.Data.Configurations.LSO.SSO;

internal class PlanWorkConfiguration : IEntityTypeConfiguration<PlanWork>
{
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