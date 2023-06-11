namespace Boussole.LSO.Contracts.Structure;

/// <summary>
/// Должности бойцов в отряде
/// </summary>
public enum MemberRank
{
    /// <summary>
    /// Командир
    /// </summary>
    Commander = 1,
    
    /// <summary>
    /// Комиссар
    /// </summary>
    Comissar,
    
    /// <summary>
    /// Мастер / Методист / Инженер
    /// </summary>
    Master,
    
    /// <summary>
    /// Боец
    /// </summary>
    Member,
    
    /// <summary>
    /// Кандидат
    /// </summary>
    Candidate,
    
    /// <summary>
    /// Старик / Ветеран
    /// </summary>
    Elder, 
    
    /// <summary>
    /// Не принимающий участие в жизни отряда боец
    /// </summary>
    Retired,
    
    /// <summary>
    /// Выбывший
    /// </summary>
    Dropout
}