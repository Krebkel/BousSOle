using Boussole.Persons;

namespace Boussole.LSO.Contracts.Structure;

/// <summary>
/// Боец линейного студенческого отряда
/// </summary>
public class SquadMember
{
    /// <summary>
    /// Физическое лицо
    /// </summary>
    public required Person Person { get; set; }
    
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
    public required Squad Squad { get; set; }
}
