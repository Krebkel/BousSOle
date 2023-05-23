using LSO.SSO.ProductivityContracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BousSOle.Postgres.Configurations;

internal class FactWorkConfiguration : IEntityTypeConfiguration<FactWork>
{
    /// <summary>
    /// Занесение экземпляра класса FactWork в таблицу FactWorks с первичным ключом Id
    /// </summary>
    public void Configure(EntityTypeBuilder<FactWork> builder)
    {
        builder.HasKey(entity => entity.Id);
    }
}