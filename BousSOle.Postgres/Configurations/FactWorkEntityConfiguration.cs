using LSO.ProductivityContracts;
using LSO.SSO.Reports;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BousSOle.Postgres.Configurations;

public class FactWorkEntityConfiguration : IEntityTypeConfiguration<FactWorkEntity>
{
    /// <summary>
    /// Занесение экземпляра класса FactWorkEntity в таблицу FactWorkEntities с первичным ключом Id
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<FactWorkEntity> builder)
    {
        builder.ToTable("FactWorkEntities");
        
        builder.HasKey(entity => entity.Id);
    }
}