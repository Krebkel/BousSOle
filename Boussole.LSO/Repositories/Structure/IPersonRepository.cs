using Boussole.LSO.Contracts.Structure;

namespace Boussole.LSO.Repositories.Structure;

public interface IPersonRepository
{
    Task<Person> GetPersonById(int personInn);
}