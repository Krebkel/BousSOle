using Boussole.LSO.Contracts.Structure;

namespace Boussole.LSO.Services.Structure;

public interface ISquadsService
{
    Squad CreateSquad(Squad squad);
    void UpdateSquad(Squad squad);
}
