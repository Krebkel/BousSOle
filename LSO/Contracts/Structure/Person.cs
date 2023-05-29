namespace LSO.Contracts.Structure;

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
    /// ФИО (Иванов Иван Иванович)
    /// </summary>
    public string Name { get; set; } = null!;
    
    /// <summary>
    /// Телефон бойца (+7 (999) 999-99-99)
    /// </summary>
    public string PhoneNumber { get; set; } = null!;
}