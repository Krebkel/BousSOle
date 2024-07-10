using Boussole.DataContracts;
using Boussole.LSO.Contracts.SSO;
using Boussole.LSO.Contracts.Structure;

namespace Boussole.Project.Contracts.Structure.SquadOnProject;

/// <summary>
/// Уччет выходов на работу бойцом отряда, участвующего в проекте
/// </summary>
public class SquadMemberWorkingDay : DatabaseEntity
{
    /// <summary>
    /// Боец отряда, работающий на проекте
    /// </summary>
    public required SquadMember SquadMember { get; set; }
    
    /// <summary>
    /// Рабочий день
    /// </summary>
    public required DateTimeOffset Date { get; set; }
    
    /// <summary>
    /// Статус работы 
    /// </summary>
    public required WorkerActivityStatus WorkerActivityStatus { get; set; }
    
    /// <summary>
    /// Отработано часов
    /// </summary>
    public required float WorkingHours { get; set; }
}