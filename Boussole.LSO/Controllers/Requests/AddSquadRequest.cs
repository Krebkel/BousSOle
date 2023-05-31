using Boussole.LSO.Contracts.Structure;

namespace Boussole.LSO.Controllers.Requests;

public class AddSquadRequest
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Region { get; set; }
    public string VkUrl { get; set; }
    public int InstitutionId { get; set; }
    public SquadType SquadType { get; set; }
}