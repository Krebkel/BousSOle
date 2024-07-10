using Boussole.DataContracts;
using Boussole.Project.Contracts.Structure;

namespace Boussole.Project.Contracts.Rating.Coefficients;

/// <summary>
/// Дисциплинарный коэффициент
/// </summary>
public class DisciplineCoefficient : DatabaseEntity
{
        /// <summary>
        /// Проект, на котором устанавливается дисциплинарный коэффициент
        /// </summary>
        public required WorkProjectImplementation WorkProjectImplementation { get; set; }
        
        /// <summary>
        /// Вид нарушения
        /// </summary>
        public required string ViolationType { get; set; }
        
        /// <summary>
        /// Понижающий коэффициент
        /// </summary>
        public required float PointsReduction { get; set; }
}