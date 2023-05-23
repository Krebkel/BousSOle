using LSO.ProductivityContracts;
using LSO.SSO.Reports;

namespace BousSOle.Postgres.Productivity;

/// <summary>
/// Сервис, получающий таблицу сделанных работ и возвращающий фактическую выработку в человекочасах
/// (Норма времени, помноженная на количество работ).
/// Скорее всего, данный сервис будет переделан. Как минимум, необходимо добавить обработку дистанции.
/// Как максимум, это должно происходить в рил-тайме на интерфейсе при каждом изменении строки WorkPerformedEntity
/// </summary>
public class FactWorkService
{
    private readonly BousSOleDbContext _dbContext;

    public FactWorkService(BousSOleDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task CalculateWorkFactualOutput(FactWork workPerformedReport)
    {
        foreach (var workPerformedItem in workPerformedReport.WorkPerformedEntities)
        {
            var elementNorm = await _dbContext.ElementNorms.FindAsync(workPerformedItem.ElementNorm.Id);
            if (elementNorm != null)
            {
                workPerformedItem.ElementNorm = elementNorm;

                float workFactualOutput = workPerformedItem.Quantity * elementNorm.BaseNorm;
            }
        }
    }
}