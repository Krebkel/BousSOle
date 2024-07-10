using Boussole.DataContracts;
using Boussole.Project.Contracts.Structure;

namespace Boussole.Project.Contracts.Rating.Coefficients;

/// <summary>
/// Производственный коэффициент, лишь одна запись на проект
/// </summary>
public class ProductivityCoefficient : DatabaseEntity
{
    /// <summary>
    /// Проект, на котором устанавливается производственный коэффициент
    /// </summary>
    public required WorkProjectImplementation WorkProjectImplementation { get; set; }
    
    /// <summary>
    /// Старт производственной недели
    /// </summary>
    public required DateTimeOffset ProizvodkaStartDate { get; set; }
    
    /// <summary>
    /// Максимальный производственный коэффициент
    /// </summary>
    public required int RatingPoints { get; set; }
}