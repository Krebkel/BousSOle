using Boussole.LSO.Contracts.SSO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Boussole.Data.Configurations.LSO.SSO;

internal class ElementNormConfiguration : IEntityTypeConfiguration<ElementNorm>
{
    public void Configure(EntityTypeBuilder<ElementNorm> builder)
    {
        builder.HasKey(e => new { e.NormCollection, e.NormCode });
        builder.Property(e => e.NormTypeByDistance).HasConversion<string>();
    }
}