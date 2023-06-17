using Boussole.LSO.Contracts.SSO;
using Boussole.LSO.Repositories.SSO;
using Microsoft.EntityFrameworkCore;

namespace Boussole.LSO.Services.SSO;

internal class ElementNormService : IElementNormService
{
    private readonly IElementNormRepository _elementNormRepository;
    private readonly DbContext _dbContext;

    public ElementNormService(IElementNormRepository elementNormRepository, DbContext dbContext)
    {
        _elementNormRepository = elementNormRepository;
        _dbContext = dbContext;
    }

    public async Task<ElementNorm> CreateElementNormAsync(ElementNorm elementNorm)
    {
        await _dbContext.Set<ElementNorm>().AddAsync(elementNorm);
        await _dbContext.SaveChangesAsync();
        return elementNorm;
    }

    public async Task UpdateElementNormAsync(ElementNorm elementNorm)
    {
        _dbContext.Set<ElementNorm>().Update(elementNorm);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<ElementNorm> GetElementNormByIdAsync(int elementNormId)
    {
        var elementNorm = await _elementNormRepository.GetElementNormByIdAsync(elementNormId);
        return elementNorm;
    }
}