using Boussole.DataContracts;

namespace Boussole.Persons;

/// <summary>
/// Физическое лицо
/// </summary>
public class Person : DatabaseEntity
{
    /// <summary>
    /// ИНН физлица
    /// </summary>
    public required string PersonInn { get; set; }

    /// <summary>
    /// Фамилия
    /// </summary>
    public required string Surname { get; set; }
    
    /// <summary>
    /// Имя
    /// </summary>
    public required string Name { get; set; }
    
    /// <summary>
    /// Отчество
    /// </summary>
    public required string Patronymic { get; set; }
    
    /// <summary>
    /// Телефон
    /// </summary>
    public required string PhoneNumber { get; set; }
    
    /// <summary>
    /// Почта
    /// </summary>
    public required string EMail { get; set; }
}