using Boussole.LSO.Contracts.Structure;

namespace Boussole.LSO.Controllers.Requests;

public class AddSquadMemberRequest
{
    public int Id { get; set; }
    public int SquadId { get; set; }
    public Person Person { get; set; }
    public MemberRank MemberRank { get; set; }
    public int YearEnlisted { get; set; }
    public bool IsActive { get; set; }
}