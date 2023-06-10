namespace Boussole.DataContracts;

public interface IRepository<TEntity> where TEntity : class
{
    public IQueryable<TEntity> GetAll();

    public Task<RepositoryAddResult> AddAsync(TEntity entity, CancellationToken ct);

    public Task<RepositoryUpdateResult> UpdateAsync(TEntity entity, CancellationToken ct);

    public Task DeleteAsync(TEntity entity, CancellationToken ct);
}