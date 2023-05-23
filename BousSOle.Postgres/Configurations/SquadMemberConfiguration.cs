using LSO.StructureContracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BousSOle.Postgres.Configurations;

internal class SquadMemberConfiguration : IEntityTypeConfiguration<SquadMember>
{
    /// <summary>
    /// Занесение экземпляра класса SquadMember в таблицу SquadMembers с первичным ключом Id
    /// </summary>
    public void Configure(EntityTypeBuilder<SquadMember> builder)
    {
        builder.HasKey(entity => entity.Id);
        
        builder.Property(r => r.MemberRank)
            .HasConversion(new EnumToStringConverter<MemberRank>());
    }
}