using Boussole.LSO.Contracts.SSO;
using Microsoft.EntityFrameworkCore;

namespace Boussole.LSO.Repositories.SSO;

internal class FactWorkRepository : IFactWorkRepository
{
    private readonly DbContext _dbContext;

    public FactWorkRepository(DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<FactWork> GetFactWorkByIdAsync(int factWorkId)
    {
        var factWork = await _dbContext.Set<FactWork>().FindAsync(factWorkId);
        return factWork;
    }
}