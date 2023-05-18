using LSO.ProductivityContracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BousSOle.Postgres.Configurations;

public class WorkPerformedReportConfiguration : IEntityTypeConfiguration<WorkPerformedReport>
{
    /// <summary>
    /// Занесение экземпляра класса WorkHoursReport в таблицу WorkHoursReports с первичным ключом Id
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<WorkPerformedReport> builder)
    {
        builder.ToTable("WorkPerformedReports");
        
        builder.HasKey(entity => entity.Id);
    }
}