using Boussole.DataContracts;
using Boussole.Project.Contracts.Structure;

namespace Boussole.Project.Contracts.Rating.Coefficients;

/// <summary>
/// Дополнительный коэффициент
/// </summary>
public class AdditionalCoefficient : DatabaseEntity
{
    /// <summary>
    /// Проект, на котором устанавливается дополнительный коэффициент
    /// </summary>
    public required WorkProjectImplementation WorkProjectImplementation { get; set; }
    
    /// <summary>
    /// Название коэффициента (Кп)
    /// </summary>
    public required string Name { get; set; }
    
    /// <summary>
    /// Расшифровка (Производственный коэффициент)
    /// </summary>
    public required string Transcript { get; set; }
    
    /// <summary>
    /// Максимальное количество баллов
    /// </summary>
    public required float MaxPoints { get; set; }
}