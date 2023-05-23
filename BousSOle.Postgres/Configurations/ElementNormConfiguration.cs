using LSO.SSO.ProductivityContracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BousSOle.Postgres.Configurations;

public class ElementNormConfiguration : IEntityTypeConfiguration<ElementNorm>
{
    /// <summary>
    /// Занесение экземпляра класса ElementNorm в таблицу ElementNorms с первичным ключом Id
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<ElementNorm> builder)
    {
        builder.ToTable("ElementNorms");
        
        builder.HasKey(entity => entity.Id);
    }
}