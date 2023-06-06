using Boussole.LSO.Contracts.SSO;
using Boussole.LSO.Repositories.SSO;
using Microsoft.EntityFrameworkCore;

namespace Boussole.LSO.Services.SSO;

internal class FactWorkService : IFactWorkService
{
    private readonly IFactWorkRepository _factWorkRepository;
    private readonly DbContext _dbContext;

    public FactWorkService(IFactWorkRepository factWorkRepository, DbContext dbContext)
    {
        _factWorkRepository = factWorkRepository;
        _dbContext = dbContext;
    }

    public async Task<FactWork> CreateFactWorkAsync(FactWork factWork)
    {
        await _dbContext.Set<FactWork>().AddAsync(factWork);
        await _dbContext.SaveChangesAsync();
        return factWork;
    }

    public async Task UpdateFactWorkAsync(FactWork factWork)
    {
        _dbContext.Set<FactWork>().Update(factWork);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<FactWork> GetFactWorkByIdAsync(int factWorkId)
    {
        var factWork = await _factWorkRepository.GetFactWorkByIdAsync(factWorkId);
        return factWork;
    }
}