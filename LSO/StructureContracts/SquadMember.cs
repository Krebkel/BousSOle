namespace LSO.StructureContracts;

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
    /// Должность в отряде
    /// </summary>
    public MemberRank MemberRank { get; set; }
    
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
     /// История должностей бойца отряда
     /// </summary>
     public List<MemberRankHistory> MemberRankHistory { get; set; }
     
    /// <summary>
    /// UID отряда
    /// </summary>
    public int SquadID { get; set; }
    
    /// <summary>
    /// Отряд (ССО "Агонь")
    /// </summary>
    public Squad Squad { get; set; }
    
    /// <summary>
    /// UID бойца отряда
    /// </summary>
    public int Id { get;set; }
}
