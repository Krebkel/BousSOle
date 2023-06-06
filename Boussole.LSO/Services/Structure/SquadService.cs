using Boussole.LSO.Contracts.Structure;
using Boussole.LSO.Repositories;
using Boussole.LSO.Repositories.Structure;
using Microsoft.EntityFrameworkCore;

namespace Boussole.LSO.Services.Structure;

internal class SquadService : ISquadService
{
    private readonly ISquadRepository _squadRepository;
    private readonly DbContext _dbContext;

    public SquadService(ISquadRepository squadRepository, DbContext dbContext)
    {
        _squadRepository = squadRepository;
        _dbContext = dbContext;
    }

    public async Task<Squad> CreateSquadAsync(Squad squad)
    {
        await _dbContext.Set<Squad>().AddAsync(squad);
        await _dbContext.SaveChangesAsync();
        return squad;
    }

    public async Task UpdateSquadAsync(Squad squad)
    {
        _dbContext.Set<Squad>().Update(squad);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<Squad> GetSquadByIdAsync(int squadId)
    {
        // Ищем отряд по идентификатору в базе данных
        var squad = await _squadRepository.GetSquadByIdAsync(squadId);

        // Возвращаем найденный отряд
        return squad;
    }
}