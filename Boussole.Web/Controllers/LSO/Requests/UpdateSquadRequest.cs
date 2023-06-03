using Boussole.LSO.Contracts.Structure;

namespace Boussole.Core.Controllers.LSO.Requests;

public class UpdateSquadRequest
{
    public string Name { get; set; }
    public string Region { get; set; }
    public string VkUrl { get; set; }
    public int InstitutionId { get; set; }
    public SquadType SquadType { get; set; }
}