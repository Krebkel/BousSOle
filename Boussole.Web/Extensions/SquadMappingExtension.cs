using Boussole.Core.Controllers.LSO.Structure.Requests;
using Boussole.LSO.Contracts.Structure;

namespace Boussole.Core.Extensions;

internal static class SquadMappingExtensions
{
    public static Squad ToSquad(this AddSquadRequest request)
    {
        var squad = new Squad
        {
            Name = request.Name,
            Region = request.Region,
            VkUrl = request.VkUrl,
            Institution = request.Institution,
            SquadType = request.SquadType
        };

        return squad;
    }

    public static Squad ToUpdateSquad(this UpdateSquadRequest request, Squad existingSquad)
    {
        existingSquad.Name = request.Name;
        existingSquad.Region = request.Region;
        existingSquad.VkUrl = request.VkUrl;
        existingSquad.Institution = request.Institution;
        existingSquad.SquadType = request.SquadType;

        return existingSquad;
    }
}