using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using LSO.StructureContracts;

namespace BousSOle.Postgres.Configurations;

public class MemberRankHistoryConfiguration : IEntityTypeConfiguration<MemberRankHistory>
{
    public void Configure(EntityTypeBuilder<MemberRankHistory> builder)
    {
        builder.ToTable("MemberRankHistories");

        builder.HasKey(entity => new { entity.Year, entity.SquadMemberId });

        // Определение связи с классом SquadMember
        builder.HasOne(entity => entity.SquadMember)
            .WithMany(s => s.MemberRankHistory)
            .HasForeignKey(e => e.SquadMemberId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(entity => entity.Year).IsRequired();
        builder.Property(entity => entity.MemberRank).IsRequired();
    }
}


