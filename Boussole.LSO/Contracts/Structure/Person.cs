namespace Boussole.LSO.Contracts.Structure;

/// <summary>
/// Физическое лицо
/// </summary>
public class Person
{
    /// <summary>
    /// UID физ.лица
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Фамилия (Иванов)
    /// </summary>
    public string Surname { get; set; } = null!;
    
    /// <summary>
    /// Имя (Иван)
    /// </summary>
    public string Name { get; set; } = null!;
    
    /// <summary>
    /// Отчество (Иванович)
    /// </summary>
    public string Patronymic { get; set; } = null!;
    
    /// <summary>
    /// Телефон бойца (+7 (999) 999-99-99)
    /// </summary>
    public string PhoneNumber { get; set; } = null!;
}