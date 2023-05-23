using LSO.SSO.ProductivityContracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BousSOle.Postgres.Configurations;

public class FactWorkEntityConfiguration : IEntityTypeConfiguration<FactWork>
{
    /// <summary>
    /// Занесение экземпляра класса FactWorkEntity в таблицу FactWorkEntities с первичным ключом Id
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<FactWork> builder)
    {
        builder.ToTable("FactWorkEntities");
        
        builder.HasKey(entity => entity.Id);
    }
}