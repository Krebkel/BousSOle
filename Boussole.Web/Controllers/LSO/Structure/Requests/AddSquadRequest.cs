using Boussole.Shtabs.Contracts;
using Boussole.LSO.Contracts.Structure;

namespace Boussole.Web.Controllers.LSO.Structure.Requests;

public class AddSquadRequest
{
    public int SquadId { get; set; }

    public string Name { get; set; }
    
    public string Region { get; set; }
    
    public string VkUrl { get; set; }
    
    public Shtab Shtab { get; set; }
    
    public ActivityField ActivityField { get; set; }
}