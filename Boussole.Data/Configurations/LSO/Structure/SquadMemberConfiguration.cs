using Boussole.LSO.Contracts.Structure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Boussole.Data.Configurations.LSO.Structure;

internal class SquadMemberConfiguration : IEntityTypeConfiguration<SquadMember>
{
    public void Configure(EntityTypeBuilder<SquadMember> builder)
    {
        const string personColumnName = "PersonInn";
        
        builder.Property(s => s.MemberRank).HasConversion<string>();
        builder.HasOne(s => s.Squad).WithMany().IsRequired();
        builder.HasOne(s => s.Person).WithMany().HasForeignKey(personColumnName).IsRequired();
        builder.HasKey(personColumnName);
    }
}