using LSO.StructureContracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BousSOle.Postgres.Configurations;

public class InstitutionConfiguration : IEntityTypeConfiguration<Institution>
{
    /// <summary>
    /// Занесение экземпляра класса Institution в таблицу Institutions с первичным ключом Id
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<Institution> builder)
    {
        builder.ToTable("Institutions");
        
        builder.HasKey(entity => entity.Id);
    }
}