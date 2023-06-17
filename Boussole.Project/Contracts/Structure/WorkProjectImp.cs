namespace Boussole.Project.Contracts.Structure;

public class WorkProjectImp
{
    /// <summary>
    /// Трудовой проект
    /// </summary>
    public required WorkProject WorkProject { get; set; }
    
    /// <summary>
    /// Год проведения
    /// </summary>
    public required DateTimeOffset Year { get; set; }
    
    /// <summary>
    /// Сезон проведения
    /// </summary>
    public required Season Season { get; set; }
}