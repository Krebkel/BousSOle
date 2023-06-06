using Boussole.LSO.Contracts.Structure;

namespace Boussole.LSO.Services.Structure;

public interface ISquadService
{
    Task<Squad> CreateSquadAsync(Squad squad);

    Task UpdateSquadAsync(Squad squad);

    Task<Squad> GetSquadByIdAsync(int squadId);
}