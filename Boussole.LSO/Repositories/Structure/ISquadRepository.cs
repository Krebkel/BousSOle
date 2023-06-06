using Boussole.LSO.Contracts.Structure;

namespace Boussole.LSO.Repositories.Structure;

public interface ISquadRepository
{
    Task<Squad> GetSquadByIdAsync(int squadId);
}
