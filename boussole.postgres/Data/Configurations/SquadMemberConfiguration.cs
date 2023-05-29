using LSO.Contracts.Structure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Boussole.Postgres.Data.Configurations;

internal class SquadMemberConfiguration : IEntityTypeConfiguration<SquadMember>
{
    /// <summary>
    /// Занесение экземпляра класса SquadMember в таблицу SquadMembers с первичным ключом Id
    /// </summary>
    public void Configure(EntityTypeBuilder<SquadMember> builder)
    {
        builder.HasKey(s => s.Id);
        
        builder.Property(s => s.MemberRank)
            .HasConversion(new EnumToStringConverter<MemberRank>());

        builder.HasOne(s => s.Person).WithMany().IsRequired();
        builder.HasOne(s => s.Squad).WithMany().IsRequired();
    }
}