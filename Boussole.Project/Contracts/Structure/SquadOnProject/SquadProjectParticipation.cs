using Boussole.DataContracts;
using Boussole.LSO.Contracts.Structure;

namespace Boussole.Project.Contracts.Structure.SquadOnProject;

/// <summary>
/// Заявка на проект от отряда
/// </summary>
public class SquadProjectParticipation : DatabaseEntity
{
    /// <summary>
    /// Проект, на который отряд подает заявку
    /// </summary>
    public required WorkProjectImplementation WorkProjectImplementation { get; set; }
    
    /// <summary>
    /// Отряд, который подаёт заявку
    /// </summary>
    public required Squad Squad { get; set; }
    
    /// <summary>
    /// Статус заявки на участие
    /// </summary>
    public required SquadApplicationStatus SquadApplicationStatus { get; set; }
}