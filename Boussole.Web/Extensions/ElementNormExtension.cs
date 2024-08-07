using Boussole.LSO.Contracts.SSO;
using Boussole.Web.Controllers.LSO.SSO.Requests;

namespace Boussole.Web.Extensions;

internal static class ElementNormExtension
{
    internal static ElementNorm ToElementNorm(this AddElementNormRequest request)
    {
        return new ElementNorm
        {
            NormCollection = request.NormCollection,
            NormCode = request.NormCode,
            NormName = request.NormName,
            MeasurementUnit = request.MeasurementUnit,
            BaseNorm = request.BaseNorm,
            NormTypeByDistance = request.NormTypeByDistance,
            DistanceNorm = request.DistanceNorm
        };
    }

    internal static ElementNorm ToUpdateElementNorm(this UpdateElementNormRequest request, ElementNorm existingElementNorm)
    {
        existingElementNorm.NormCollection = request.NormCollection;
        existingElementNorm.NormCode = request.NormCode;
        existingElementNorm.NormName = request.NormName;
        existingElementNorm.MeasurementUnit = request.MeasurementUnit;
        existingElementNorm.BaseNorm = request.BaseNorm;
        existingElementNorm.NormTypeByDistance = request.NormTypeByDistance;
        existingElementNorm.DistanceNorm = request.DistanceNorm;

        return existingElementNorm;
    }
}