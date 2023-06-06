using Boussole.LSO.Contracts.Structure;

namespace Boussole.LSO.Services.Structure;

public interface IPersonService
{
    Task<Person> CreatePersonAsync(Person person);
    
    Task UpdatePersonAsync(Person person);
    
    Task<Person> GetPersonByIdAsync(int personId);
}