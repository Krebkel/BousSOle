using Boussole.LSO.Contracts.Structure;

namespace Boussole.Project.Contracts.Structure;

public class WorkProject
{
    /// <summary>
    /// Название проекта ("Мирный Атом - МБИР")
    /// </summary>
    public required string Name { get; set; }
    
    /// <summary>
    /// Направление деятельности (Строительный)
    /// </summary>
    public required ActivityField ActivityField { get; set; }
    
    /// <summary>
    /// Регион проведения
    /// </summary>
    public required string Region { get; set; }
}
