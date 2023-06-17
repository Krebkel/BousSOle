namespace Boussole.Persons;

public interface IPersonService
{
    /// <summary>
    /// Создать физлицо
    /// </summary>
    Task<Person> CreatePersonAsync(CreatePersonRequest person, CancellationToken cancellationToken);
    
    /// <summary>
    /// Обновить физлицо
    /// </summary>
    Task UpdatePersonAsync(UpdatePersonRequest person, CancellationToken ct);

    /// <summary>
    /// Поиск физлиц
    /// </summary>
    Task<Person[]> SearchPerson(SearchPersonRequest request);
}

public class SearchPersonRequest
{
}

public class UpdatePersonRequest
{
}

public class CreatePersonRequest
{
}