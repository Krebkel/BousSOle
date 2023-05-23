using LSO.SSO.ProductivityContracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BousSOle.Postgres.Configurations;

public class PlanReportConfiguration : IEntityTypeConfiguration<PlanWork>
{
    /// <summary>
    /// Занесение экземпляра класса PlanWork в таблицу PlanWorks с первичным ключом Id
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<PlanWork> builder)
    {
        builder.ToTable("PlanWorks");
        
        builder.HasKey(entity => entity.Id);
    }
}