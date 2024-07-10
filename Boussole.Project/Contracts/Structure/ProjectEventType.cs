namespace Boussole.Project.Contracts.Structure;

/// <summary>
/// Характер мероприятия
/// </summary>
public enum ProjectEventType
{
    /// <summary>
    /// Рейтинговое мероприятие
    /// </summary>
    Rated,
    
    /// <summary>
    /// Организационное мероприятие
    /// </summary>
    Organizational,
    
    /// <summary>
    /// Развлекательное мероприятие
    /// </summary>
    Entertainment,
    
    /// <summary>
    /// Официальное мероприятие
    /// </summary>
    Official,
    
    /// <summary>
    /// Другое
    /// </summary>
    Other
}