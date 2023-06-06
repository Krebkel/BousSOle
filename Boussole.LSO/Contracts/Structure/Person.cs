namespace Boussole.LSO.Contracts.Structure;

/// <summary>
/// Физическое лицо
/// </summary>
public class Person
{
    /// <summary>
    /// Первичный ключ физ.лица - ИНН
    /// </summary>
    public int PersonInn { get; set; }

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
    /// Телефон человека (+7 (999) 999-99-99)
    /// </summary>
    public string? PhoneNumber { get; set; }
    
    /// <summary>
    /// Почта человека 
    /// </summary>
    public string? EMail { get; set; }
}