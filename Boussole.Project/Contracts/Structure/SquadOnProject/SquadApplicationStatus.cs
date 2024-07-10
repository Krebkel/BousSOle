namespace Boussole.Project.Contracts.Structure.SquadOnProject;

public enum SquadApplicationStatus
{
    /// <summary>
    /// Подал заявку
    /// </summary>
    Applied,
    
    /// <summary>
    /// Активный состав
    /// </summary>
    Active,
    
    /// <summary>
    /// Резерв
    /// </summary>
    Reserve,
    
    /// <summary>
    /// Отказано в участии
    /// </summary>
    Denied
}