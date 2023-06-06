using Boussole.LSO.Contracts.SSO;
using Microsoft.EntityFrameworkCore;

namespace Boussole.LSO.Repositories.SSO;

internal class PlanWorkRepository : IPlanWorkRepository
{
    private readonly DbContext _dbContext;

    public PlanWorkRepository(DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<PlanWork> GetPlanWorkByIdAsync(int planWorkId)
    {
        var planWork = await _dbContext.Set<PlanWork>().FindAsync(planWorkId);
        return planWork;
    }
}