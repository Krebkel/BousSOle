using Boussole.LSO.Contracts.Structure;

namespace Boussole.LSO.Repositories;

public interface ISquadRepository
{
    Task<Squad> GetSquadByIdAsync(int squadId);
}
