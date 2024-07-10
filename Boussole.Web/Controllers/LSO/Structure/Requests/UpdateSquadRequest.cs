using Boussole.Shtabs.Contracts;
using Boussole.LSO.Contracts.Structure;

namespace Boussole.Web.Controllers.LSO.Structure.Requests;

public class UpdateSquadRequest
{
    public int SquadId { get; set; }

    public string Name { get; set; }
    
    public string Region { get; set; }
    
    public string VkUrl { get; set; }
    
    public Shtabs.Contracts.Shtab Shtab { get; set; }
    
    public ActivityField ActivityField { get; set; }
}