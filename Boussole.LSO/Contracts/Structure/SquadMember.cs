using Boussole.Persons;

namespace Boussole.LSO.Contracts.Structure;

/// <summary>
/// Боец линейного студенческого отряда
/// </summary>
public class SquadMember
{
    /// <summary>
    /// Id бойца
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Физическое лицо
    /// </summary>
    public Person Person { get; set; } = null!;
    
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
    /// Отряд
    /// </summary>
    public Squad Squad { get; set; }
}
