using Boussole.LSO.Contracts.SSO;

namespace Boussole.LSO.Repositories.SSO;

public interface IPlanWorkRepository
{
    Task<PlanWork> GetPlanWorkByIdAsync(int planWorkId);
}