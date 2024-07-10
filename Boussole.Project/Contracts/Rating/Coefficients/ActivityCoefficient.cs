using Boussole.DataContracts;
using Boussole.Project.Contracts.Structure;

namespace Boussole.Project.Contracts.Rating.Coefficients;

/// <summary>
/// Коэффициент активности (Разбалловка за места на мероприятиях)
/// </summary>
public class ActivityCoefficient : DatabaseEntity
{
    /// <summary>
    /// Проект, на котором устанавливается коэффициент активности
    /// </summary>
    public required WorkProjectImplementation WorkProjectImplementation { get; set; }
    
    /// <summary>
    /// Статус отряда-участника в мероприятии (1 место, участие и т.д.)
    /// </summary>
    public required string SquadActivityStatus { get; set; }
    
    /// <summary>
    /// Очки за статус
    /// </summary>
    public required float RatingPoints { get; set; }
}