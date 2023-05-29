using LSO.SSO.ProductivityContracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BousSOle.Postgres.Configurations;

internal class ElementNormConfiguration : IEntityTypeConfiguration<ElementNorm>
{
    /// <summary>
    /// Занесение экземпляра класса ElementNorm в таблицу ElementNorms с первичным ключом Id
    /// </summary>
    public void Configure(EntityTypeBuilder<ElementNorm> builder)
    {
        builder.HasKey(entity => entity.Id);
        
        builder.Property(r => r.NormType)
            .HasConversion(new EnumToStringConverter<NormType>());
    }
}