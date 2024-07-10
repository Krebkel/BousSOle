using Boussole.DataContracts;
using Boussole.Project.Contracts.Rating.Coefficients;
using Boussole.Project.Contracts.Structure.SquadOnProject;

namespace Boussole.Project.Contracts.Rating;

/// <summary>
/// Выставление баллов отряду за дополнительный коэффициент
/// </summary>
public class SquadAdditionalCoefficientParticipation : DatabaseEntity
{
    /// <summary>
    /// Отряд, участвующий в проекте
    /// </summary>
    public required SquadProjectParticipation SquadProjectParticipation { get; set; }
    
    /// <summary>
    /// Дополнительный коэффициент, за который отряд получает баллы
    /// </summary>
    public required AdditionalCoefficient AdditionalCoefficient { get; set; }
    
    /// <summary>
    /// Количество баллов, получаемых отрядом
    /// </summary>
    public required float RatingPoints { get; set; }
}