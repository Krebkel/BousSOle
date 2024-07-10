using Boussole.DataContracts;
using Boussole.Project.Contracts.Structure;

namespace Boussole.Project.Contracts.Rating;

/// <summary>
/// Мероприятие, проводимое на проекте
/// </summary>
public class ProjectEvent : DatabaseEntity
{
    /// <summary>
    /// Проект, на котором проводится мероприятие
    /// </summary>
    public required WorkProjectImplementation WorkProjectImplementation { get; set; }
    
    /// <summary>
    /// Характер мероприятия
    /// </summary>
    public required ProjectEventType ProjectEventType { get; set; }
    
    /// <summary>
    /// Название мероприятия
    /// </summary>
    public required string Name { get; set; }
    
    /// <summary>
    /// Дата проведения мероприятия
    /// </summary>
    public required DateTimeOffset Date { get; set; }
}