using Boussole.LSO.Contracts.SSO;
using Microsoft.EntityFrameworkCore;

namespace Boussole.LSO.Repositories.SSO;

internal class ElementNormRepository : IElementNormRepository
{
    private readonly DbContext _dbContext;

    public ElementNormRepository(DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<ElementNorm> GetElementNormByIdAsync(int elementNormId)
    {
        var elementNorm = await _dbContext.Set<ElementNorm>().FindAsync(elementNormId);
        return elementNorm;
    }
}