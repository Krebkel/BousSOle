using Boussole.LSO.Contracts.SSO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Boussole.Data.Configurations;

internal class ElementNormConfiguration : IEntityTypeConfiguration<ElementNorm>
{
    /// <summary>
    /// Занесение экземпляра класса ElementNorm в таблицу ElementNorms с первичным ключом Id
    /// </summary>
    public void Configure(EntityTypeBuilder<ElementNorm> builder)
    {
        builder.HasKey(e => new { e.NormCollection, e.NormCode });
        builder.Property(e => e.NormTypeByDistance).HasConversion<string>();
    }
}