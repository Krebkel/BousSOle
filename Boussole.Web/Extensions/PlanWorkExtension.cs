using Boussole.Core.Controllers.LSO.SSO.Requests;
using Boussole.LSO.Contracts.SSO;

namespace Boussole.Core.Extensions;

internal static class PlanWorkExtension
{
    internal static PlanWork ToPlanWork(this AddPlanWorkRequest request)
    {
        return new PlanWork
        {
            Date = request.Date,
            SquadMemberId = request.SquadMemberId,
            WorkerActivityStatus = request.WorkerActivityStatus,
            WorkHours = request.WorkHours
        };
    }

    internal static PlanWork ToUpdatePlanWork(this UpdatePlanWorkRequest request, PlanWork existingPlanWork)
    {
        existingPlanWork.Date = request.Date;
        existingPlanWork.WorkerActivityStatus = request.WorkerActivityStatus;
        existingPlanWork.WorkHours = request.WorkHours;

        return existingPlanWork;
    }
}