using Boussole.LSO.Contracts.SSO;
using Boussole.Web.Controllers.LSO.SSO.Requests;

namespace Boussole.Web.Extensions;

internal static class PlanWorkExtension
{
    internal static PlanWork ToPlanWork(this AddPlanWorkRequest request)
    {
        return new PlanWork
        {
            Date = request.Date,
            WorkerActivityStatus = request.WorkerActivityStatus,
            WorkHours = request.WorkHours,
            SquadMember = null
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