using Boussole.LSO.Contracts.Structure;

namespace Boussole.Project.Contracts.Structure;

public class SquadWorkProjectParticipation
{
    public required Squad Squad { get; set; }
    
    public required WorkProjectImp WorkProjectImp { get; set; }
    
    
}