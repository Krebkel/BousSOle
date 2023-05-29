using LSO.StructureContracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BousSOle.Postgres.Configurations;

internal class SquadConfiguration : IEntityTypeConfiguration<Squad>
{
    /// <summary>
    /// Занесение экземпляра класса Squad в таблицу Squads с первичным ключом Id
    /// </summary>
    public void Configure(EntityTypeBuilder<Squad> builder)
    {
        builder.HasKey(entity => entity.Id);
        
        builder.Property(r => r.SquadType)
            .HasConversion(new EnumToStringConverter<SquadType>());

        builder.HasOne(s => s.Institution).WithMany().IsRequired();
    }
}