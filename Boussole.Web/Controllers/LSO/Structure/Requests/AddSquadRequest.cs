using Boussole.Institutions.Contracts;
using Boussole.LSO.Contracts.Structure;

namespace Boussole.Web.Controllers.LSO.Structure.Requests;

public class AddSquadRequest
{
    public int SquadId { get; set; }

    public string Name { get; set; }
    
    public string Region { get; set; }
    
    public string VkUrl { get; set; }
    
    public Institution Institution { get; set; }
    
    public SquadType SquadType { get; set; }
}