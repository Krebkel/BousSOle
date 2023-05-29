using LSO.Contracts.SSO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Boussole.Postgres.Data.Configurations;

internal class FactWorkConfiguration : IEntityTypeConfiguration<FactWork>
{
    /// <summary>
    /// Занесение экземпляра класса FactWork в таблицу FactWorks с первичным ключом Id
    /// </summary>
    public void Configure(EntityTypeBuilder<FactWork> builder)
    {
        builder.HasKey(f => f.Id);

        builder.HasOne(f => f.Squad).WithMany().IsRequired();
        builder.HasOne(f => f.ElementNorm).WithMany().IsRequired();
    }
}