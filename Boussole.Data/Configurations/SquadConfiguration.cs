using Boussole.LSO.Contracts.Structure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Boussole.Data.Configurations;

internal class SquadConfiguration : IEntityTypeConfiguration<Squad>
{
    public void Configure(EntityTypeBuilder<Squad> builder)
    {
        builder.HasKey(s => s.Name);
        
        builder.Property(r => r.SquadType).HasConversion<string>();
        builder.HasOne(s => s.Institution).WithMany().IsRequired();
    }
}