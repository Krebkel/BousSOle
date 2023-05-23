namespace LSO.StructureContracts;

/// <summary>
/// Боец линейного студенческого отряда
/// </summary>
public class SquadMember
{
    /// <summary>
    /// UID бойца отряда
    /// </summary>
    public int Id { get;set; }
    
    /// <summary>
    /// Физическое лицо
    /// </summary>
    public Person Person { get; set; }
    
    /// <summary>
    /// Должность в отряде
    /// </summary>
    public MemberRank MemberRank { get; set; }
    
    /// <summary>
    /// Год набора
    /// </summary>
    public int YearEnlisted { get; set; }
    
    /// <summary>
    /// Участие в действующем составе
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// UID отряда
    /// </summary>
    public int SquadID { get; set; }
    
    /// <summary>
    /// Отряд (ССО "Агонь")
    /// </summary>
    public Squad Squad { get; set; }
}
