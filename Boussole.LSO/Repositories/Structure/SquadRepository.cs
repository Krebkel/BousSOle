using Boussole.LSO.Contracts.Structure;
using Microsoft.EntityFrameworkCore;

namespace Boussole.LSO.Repositories.Structure;

internal class SquadRepository : ISquadRepository
{
    private readonly DbContext _dbContext;

    public SquadRepository(DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Squad> GetSquadByIdAsync(int squadId)
    {
        // Ищем отряд по идентификатору в базе данных
        var squad = await _dbContext.Set<Squad>().FindAsync(squadId);

        // Возвращаем найденный отряд
        return squad;
    }
}