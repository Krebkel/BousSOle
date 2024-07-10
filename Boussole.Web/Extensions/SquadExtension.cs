using Boussole.LSO.Contracts.Structure;
using Boussole.Web.Controllers.LSO.Structure.Requests;

namespace Boussole.Web.Extensions;

internal static class SquadMappingExtensions
{
    public static Squad ToSquad(this AddSquadRequest request)
    {
        var squad = new Squad
        {
            Name = request.Name,
            VkUrl = request.VkUrl,
            Shtab = request.Shtab,
            ActivityField = request.ActivityField
        };

        return squad;
    }

    public static Squad ToUpdateSquad(this UpdateSquadRequest request, Squad existingSquad)
    {
        existingSquad.Name = request.Name;
        existingSquad.Shtab = request.Shtab;
        existingSquad.VkUrl = request.VkUrl;
        existingSquad.ActivityField = request.ActivityField;

        return existingSquad;
    }
}