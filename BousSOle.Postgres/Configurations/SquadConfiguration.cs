using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using LSO.Structure;

namespace BousSOle.Postgres.Configurations;

public class SquadConfiguration : IEntityTypeConfiguration<Squad>
{
    /// <summary>
    /// Занесение экземпляра класса Squad в таблицу Squads с первичным ключом Id
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<Squad> builder)
    {
        builder.ToTable("Squads");
        
        builder.HasKey(entity => entity.Id);
    }
}