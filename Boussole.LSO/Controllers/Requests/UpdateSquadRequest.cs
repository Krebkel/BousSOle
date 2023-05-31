using Boussole.Institutions.Contracts;
using Boussole.LSO.Contracts.Structure;

namespace Boussole.LSO.Controllers.Requests;

public class UpdateSquadRequest
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Region { get; set; }
    public string VkUrl { get; set; }
    public Institution Institution { get; set; }
    public SquadType SquadType { get; set; }
}