using LSO.Contracts.Structure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Boussole.Data.Configurations;

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