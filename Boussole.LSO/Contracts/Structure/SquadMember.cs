using Boussole.DataContracts;
using Boussole.Persons;

namespace Boussole.LSO.Contracts.Structure;

/// <summary>
/// Боец линейного студенческого отряда
/// </summary>
public class SquadMember : DatabaseEntity
{
    /// <summary>
    /// Физическое лицо
    /// </summary>
    public required Person Person { get; set; }
    
    /// <summary>
    /// Должность в отряде
    /// </summary>
    public required MemberRank MemberRank { get; set; }
    
    /// <summary>
    /// Год набора
    /// </summary>
    public required int YearEnlisted { get; set; }
    
    /// <summary>
    /// Продлено ли членство
    /// </summary>
    public required bool IsActive { get; set; }

    /// <summary>
    /// Отряд
    /// </summary>
    public required Squad Squad { get; set; }
}
