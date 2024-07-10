using Boussole.DataContracts;

namespace Boussole.Project.Contracts.Structure;

/// <summary>
/// Имплементация трудового проекта
/// </summary>
public class WorkProjectImplementation : DatabaseEntity
{
    /// <summary>
    /// Трудовой проект
    /// </summary>
    public required WorkProject WorkProject { get; set; }
    
    /// <summary>
    /// Год проведения проекта
    /// </summary>
    public required int Year { get; set; }
    
    /// <summary>
    /// Сезон проведения
    /// </summary>
    public required Season Season { get; set; }
}