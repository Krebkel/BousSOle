using Boussole.LSO.Contracts.Structure;
using Boussole.LSO.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Boussole.LSO.Services.Structure;

internal class PersonService : IPersonService
{
    private readonly IPersonRepository _personRepository;
    private readonly DbContext _dbContext;

    public PersonService(IPersonRepository personRepository, DbContext dbContext)
    {
        _personRepository = personRepository;
        _dbContext = dbContext;
    }

    public async Task<Person> CreatePersonAsync(Person person)
    {
        await _dbContext.Set<Person>().AddAsync(person);
        await _dbContext.SaveChangesAsync();
        return person;
    }

    public async Task UpdatePersonAsync(Person person)
    {
        _dbContext.Set<Person>().Update(person);
        await _dbContext.SaveChangesAsync();
    }
    
    public async Task<Person> GetPersonByIdAsync(int personInn)
    {
        // Ищем персону по идентификатору в базе данных
        var person = await _personRepository.GetPersonById(personInn);

        // Возвращаем найденную персону
        return person;
    }
}