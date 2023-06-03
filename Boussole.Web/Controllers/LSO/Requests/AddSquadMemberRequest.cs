using Boussole.LSO.Contracts.Structure;

namespace Boussole.Core.Controllers.LSO.Requests;

public class AddSquadMemberRequest
{
    public int SquadId { get; set; }
    public int PersonId { get; set; }
    public MemberRank MemberRank { get; set; }
    public int YearEnlisted { get; set; }
    public bool IsActive { get; set; }
}