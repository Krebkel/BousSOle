namespace LSO;

/// <summary>
/// Боец линейного студенческого отряда
/// </summary>
public class SquadMember
{
    /// <summary>
    /// ФИО бойца (Иванов Иван Иванович)
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Телефон бойца (+7 (999) 999-99-99)
    /// </summary>
    public string PhoneNumber { get; set; }
    
    /// <summary>
    /// Год набора (2023)
    /// </summary>
    public int YearEnlisted { get; set; }
    
    /// <summary>
    /// Участие в действующем составе (True)
    /// </summary>
    public bool IsActive { get; set; }
    
    /// <summary>
    /// Отряд (ССО "Агонь")
    /// </summary>
    public Squad Squad { get; set; }
}
