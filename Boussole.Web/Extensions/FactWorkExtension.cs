using Boussole.LSO.Contracts.SSO;
using Boussole.Web.Controllers.LSO.SSO.Requests;

namespace Boussole.Web.Extensions;

internal static class FactWorkExtension
{
    internal static FactWork ToFactWork(this AddFactWorkRequest request)
    {
        return new FactWork
        {
            Date = request.Date,
            Squad = request.Squad,
            WorkName = request.WorkName,
            ElementNorm = request.ElementNorm,
            Distance = request.Distance,
            Quantity = request.Quantity
        };
    }

    internal static FactWork ToUpdateFactWork(this UpdateFactWorkRequest request, FactWork existingFactWork)
    {
        existingFactWork.Date = request.Date;
        existingFactWork.WorkName = request.WorkName;
        existingFactWork.ElementNorm = request.ElementNorm;
        existingFactWork.Distance = request.Distance;
        existingFactWork.Quantity = request.Quantity;

        return existingFactWork;
    }
}