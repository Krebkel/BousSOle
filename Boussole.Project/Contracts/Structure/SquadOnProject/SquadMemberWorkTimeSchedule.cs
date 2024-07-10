using Boussole.DataContracts;
using Boussole.LSO.Contracts.Structure;

namespace Boussole.Project.Contracts.Structure.SquadOnProject;

/// <summary>
/// График работы отдельного бойца отряда
/// </summary>
public class SquadMemberWorkTimeSchedule : DatabaseEntity
{
    /// <summary>
    /// Боец отряда
    /// </summary>
    public required SquadMember SquadMember { get; set; }
    
    /// <summary>
    /// Дни работы
    /// </summary>
    public required float WorkDays { get; set; }
    
    /// <summary>
    /// Дни отдыха
    /// </summary>
    public required float ChillDays { get; set; }
    
    /// <summary>
    /// День начала работы
    /// </summary>
    public required DateTimeOffset WorkStartDay { get; set; }
}