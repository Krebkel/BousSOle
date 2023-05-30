using Boussole.LSO.Contracts.Structure;

namespace Boussole.LSO.Services.Structure;

public interface ISquadMemberService
{
    SquadMember CreateSquadMember(SquadMember SquadMember);
    void UpdateSquadMember(SquadMember SquadMember);
}