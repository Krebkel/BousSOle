using Boussole.LSO.Contracts.Structure;
using Microsoft.EntityFrameworkCore;

namespace Boussole.LSO.Repositories;

internal class PersonRepository : IPersonRepository
{
    private readonly DbContext _dbContext;

    public PersonRepository(DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Person> GetPersonById(int personInn)
    {
        return await _dbContext.Set<Person>().FirstOrDefaultAsync(p => p.PersonInn == personInn);
    }
}