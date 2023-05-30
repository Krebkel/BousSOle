using Boussole.LSO.Contracts.Structure;

namespace Boussole.LSO.Services.Structure;

public class SquadsService : ISquadsService
{
    public Squad CreateSquad(Squad squad)
    {
        return squad;
    }

    public void UpdateSquad(Squad squad)
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
