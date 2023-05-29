using LSO.StructureContracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BousSOle.Postgres.Configurations;

internal class InstitutionConfiguration : IEntityTypeConfiguration<Institution>
{
    /// <summary>
    /// Занесение экземпляра класса Institution в таблицу Institutions с первичным ключом Id
    /// </summary>
    public void Configure(EntityTypeBuilder<Institution> builder)
    {
        builder.HasKey(entity => entity.Id);
    }
}