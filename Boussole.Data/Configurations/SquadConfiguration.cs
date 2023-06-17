using Boussole.LSO.Contracts.Structure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Boussole.Data.Configurations;

internal class SquadConfiguration : IEntityTypeConfiguration<Squad>
{
    public void Configure(EntityTypeBuilder<Squad> builder)
    {
        builder.HasKey(s => s.Name);
        
        builder.Property(r => r.ActivityField).HasConversion<string>();
        builder.HasOne(s => s.Shtab).WithMany().IsRequired();
    }
}