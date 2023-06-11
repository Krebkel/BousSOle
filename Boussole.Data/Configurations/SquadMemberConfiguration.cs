using Boussole.LSO.Contracts.Structure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Boussole.Data.Configurations;

internal class SquadMemberConfiguration : IEntityTypeConfiguration<SquadMember>
{
    /// <summary>
    /// Занесение экземпляра класса SquadMember в таблицу SquadMembers с первичным ключом Id
    /// </summary>
    public void Configure(EntityTypeBuilder<SquadMember> builder)
    {
        const string personColumnName = "PersonInn";
        
        builder.Property(s => s.MemberRank).HasConversion<string>();
        builder.HasOne(s => s.Squad).WithMany().IsRequired();
        builder.HasOne(s => s.Person).WithMany().HasForeignKey(personColumnName).IsRequired();
        builder.HasKey(personColumnName);
    }
}