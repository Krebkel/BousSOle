using LSO.SSO.ProductivityContracts;

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
        /* Раньше в FactWork был лист FactWorks. Требует изменения.
         foreach (var factWorkItem in workPerformedReport.FactWorks)
        {
            var elementNorm = await _dbContext.ElementNorms.FindAsync(factWorkItem.ElementNorm.Id);
            if (elementNorm != null)
            {
                factWorkItem.ElementNorm = elementNorm;

                float workFactualOutput = factWorkItem.Quantity * elementNorm.BaseNorm;
            }
        }*/
    }
}