using Boussole.LSO.Contracts.SSO;
using Boussole.LSO.Repositories.SSO;
using Microsoft.EntityFrameworkCore;

namespace Boussole.LSO.Services.SSO;

internal class PlanWorkService : IPlanWorkService
{
    private readonly IPlanWorkRepository _planWorkRepository;
    private readonly DbContext _dbContext;

    public PlanWorkService(IPlanWorkRepository planWorkRepository, DbContext dbContext)
    {
        _planWorkRepository = planWorkRepository;
        _dbContext = dbContext;
    }

    public async Task<PlanWork> CreatePlanWorkAsync(PlanWork planWork)
    {
        await _dbContext.Set<PlanWork>().AddAsync(planWork);
        await _dbContext.SaveChangesAsync();
        return planWork;
    }

    public async Task UpdatePlanWorkAsync(PlanWork planWork)
    {
        _dbContext.Set<PlanWork>().Update(planWork);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<PlanWork> GetPlanWorkByIdAsync(int planWorkId)
    {
        var planWork = await _planWorkRepository.GetPlanWorkByIdAsync(planWorkId);
        return planWork;
    }
}