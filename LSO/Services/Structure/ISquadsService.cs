using LSO.Contracts.Structure;

namespace LSO.Services.Structure;

public interface ISquadsService
{
    Squad CreateSquad(Squad squad);
    void UpdateSquad(Squad squad);
}
