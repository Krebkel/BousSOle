using Boussole.LSO.Contracts.Structure;

namespace Boussole.LSO.Repositories;

public interface IPersonRepository
{
    Task<Person> GetPersonById(int personInn);
}