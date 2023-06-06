using Boussole.LSO.Contracts.Structure;

namespace Boussole.Core.Controllers.LSO.Structure.Requests;

public class AddSquadMemberRequest
{
    public Squad Squad { get; set; }
    
    public Person Person { get; set; }
    
    public MemberRank MemberRank { get; set; }
    
    public int YearEnlisted { get; set; }
    
    public bool IsActive { get; set; }
}