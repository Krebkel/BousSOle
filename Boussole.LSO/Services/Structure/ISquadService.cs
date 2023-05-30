using Boussole.LSO.Contracts.Structure;

namespace Boussole.LSO.Services.Structure;

public interface ISquadService
{
    Squad CreateSquad(Squad squad);
    void UpdateSquad(Squad squad);
}
