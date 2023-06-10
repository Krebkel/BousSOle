using Boussole.DataContracts;
using Microsoft.Extensions.Logging;

namespace Boussole.Persons;

internal class PersonService : IPersonService
{
    private readonly IRepository<Person> _personRepository;
    private readonly ILogger<PersonService> _logger;

    public PersonService(IRepository<Person> personRepository, ILogger<PersonService> logger)
    {
        _personRepository = personRepository;
        _logger = logger;
    }

    public async Task<Person> CreatePersonAsync(CreatePersonRequest request, CancellationToken cancellationToken)
    {
        var createdPerson = new Person
        {
            PersonInn = null,
            Surname = null,
            Name = null,
            Patronymic = null,
            PhoneNumber = null,
            EMail = null
        };
        
        _logger.LogInformation("Физическое лицо успешно добавлено: {@Person}", createdPerson);
        return createdPerson;
    }

    public async Task UpdatePersonAsync(UpdatePersonRequest request, CancellationToken ct)
    {
        _logger.LogInformation("Физическое лицо успешно обновлено: {@Person}", request);
    }
    
    public async Task<Person[]> SearchPerson(SearchPersonRequest request)
    {
        return Array.Empty<Person>();
    }
}