namespace Boussole.Project.Contracts.Structure;

/// <summary>
/// Уровень трудового проекта
/// </summary>
public enum ProjectTier
{
    /// <summary>
    /// Международный трудовой проект
    /// </summary>
    International,
    
    /// <summary>
    /// Всероссийский, Всебелорусский, и т.д.
    /// </summary>
    National,
    
    /// <summary>
    /// Межрегиональный
    /// </summary>
    Interregional,
    
    /// <summary>
    /// Окружной
    /// </summary>
    Regional,
    
    /// <summary>
    /// Местный / Зональный
    /// </summary>
    Local
}