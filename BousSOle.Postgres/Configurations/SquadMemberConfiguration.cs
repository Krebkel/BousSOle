using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using LSO.Structure;

namespace BousSOle.Postgres.Configurations;

public class SquadMemberConfiguration : IEntityTypeConfiguration<SquadMember>
{
    /// <summary>
    /// Занесение экземпляра класса SquadMember в таблицу SquadMembers с первичным ключом Id
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<SquadMember> builder)
    {
        builder.ToTable("SquadMembers");
        
        builder.HasKey(entity => entity.Id);
    }
}