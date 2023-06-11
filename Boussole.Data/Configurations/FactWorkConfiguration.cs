using Boussole.LSO.Contracts.SSO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Boussole.Data.Configurations;

internal class FactWorkConfiguration : IEntityTypeConfiguration<FactWork>
{
    /// <summary>
    /// Занесение экземпляра класса FactWork в таблицу FactWorks с первичным ключом Id
    /// </summary>
    public void Configure(EntityTypeBuilder<FactWork> builder)
    {
        const string squadColumnName = "SquadName";
        const string normCollectionColumnName = "NormCollection";
        const string normCodeColumnName = "NormCode";
        
        builder.HasOne(f => f.Squad)
            .WithMany()
            .HasForeignKey(squadColumnName)
            .IsRequired();
       
        builder.HasOne(f => f.ElementNorm)
            .WithMany()
            .HasForeignKey(normCollectionColumnName, normCodeColumnName)
            .IsRequired();
        
        builder.HasKey("Date", squadColumnName, normCollectionColumnName, normCodeColumnName);
    }
}