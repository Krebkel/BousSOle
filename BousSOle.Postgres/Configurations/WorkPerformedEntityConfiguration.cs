using LSO.ProductivityContracts;
using LSO.SSO.Reports;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BousSOle.Postgres.Configurations;

public class WorkPerformedEntityConfiguration : IEntityTypeConfiguration<WorkPerformedEntity>
{
    /// <summary>
    /// Занесение экземпляра класса WorkHoursEntity в таблицу WorkHoursEntities с первичным ключом Id
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<WorkPerformedEntity> builder)
    {
        builder.ToTable("WorkPerformedEntities");
        
        builder.HasKey(entity => entity.Id);
    }
}