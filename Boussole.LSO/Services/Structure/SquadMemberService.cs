using Boussole.LSO.Contracts.Structure;

namespace Boussole.LSO.Services.Structure;

public class SquadMemberService : ISquadMemberService
{
    public SquadMember CreateSquadMember(SquadMember SquadMember)
    {
        return SquadMember;
    }

    public void UpdateSquadMember(SquadMember SquadMember)
    {
        
    }

    private int GenerateUniqueId()
    {
        var now = DateTimeOffset.UtcNow;
        var ticks = now.Ticks;
        var uniqueId = (int)(ticks & 0x00000000FFFFFFFF);

        return uniqueId;
    }
}