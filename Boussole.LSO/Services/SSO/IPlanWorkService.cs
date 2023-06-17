using Boussole.LSO.Contracts.SSO;

namespace Boussole.LSO.Services.SSO;

public interface IPlanWorkService
{
    Task<PlanWork> CreatePlanWorkAsync(PlanWork planWork);
    Task UpdatePlanWorkAsync(PlanWork planWork);
    Task<PlanWork> GetPlanWorkByIdAsync(int planWorkId);
}