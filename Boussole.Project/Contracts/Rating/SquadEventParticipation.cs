using Boussole.DataContracts;
using Boussole.Project.Contracts.Rating.Coefficients;
using Boussole.Project.Contracts.Structure.SquadOnProject;

namespace Boussole.Project.Contracts.Rating;

/// <summary>
/// Отряд, участвующий в мероприятии
/// </summary>
public class SquadEventParticipation : DatabaseEntity
{
    /// <summary>
    /// Отряд, участвующий в проекте
    /// </summary>
    public required SquadProjectParticipation SquadProjectParticipation { get; set; }
    
    /// <summary>
    /// Мероприятие, в котором участвует отряд
    /// </summary>
    public required ProjectEvent ProjectEvent { get; set; }
    
    /// <summary>
    /// Статус отряда
    /// </summary>
    public ActivityCoefficient? ActivityCoefficient { get; set; }
}