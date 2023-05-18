using LSO.ProductivityContracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BousSOle.Postgres.Configurations;

public class WorkHoursReportConfiguration : IEntityTypeConfiguration<WorkHoursReport>
{
    /// <summary>
    /// Занесение экземпляра класса WorkHoursReport в таблицу WorkHoursReports с первичным ключом Id
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<WorkHoursReport> builder)
    {
        builder.ToTable("WorkHoursReports");
        
        builder.HasKey(entity => entity.Id);
    }
}