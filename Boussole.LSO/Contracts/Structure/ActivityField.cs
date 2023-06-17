// ReSharper disable InconsistentNaming
namespace Boussole.LSO.Contracts.Structure;

/// <summary>
/// Направление отряда
/// </summary>
public enum ActivityField
{
    /// <summary>
    /// Студенческий строительный отряд (ССО)
    /// </summary>
    SSO = 1,
    
    /// <summary>
    /// Студенческий педагогический отряд (СПО)
    /// </summary>
    SPO,
    
    /// <summary>
    /// Студенческий сервисный отряд (ССервО)
    /// </summary>
    SServO,
    
    /// <summary>
    /// Студенческий медицинский отряд (СМО)
    /// </summary>
    SMO,
    
    /// <summary>
    /// Студенческий отряд проводников (СОП) 
    /// </summary>
    SOP,
    
    /// <summary>
    /// Студенческий сельскохозяйственый отряд (ССхО)
    /// </summary>
    SShO,
  
    /// <summary>
    /// Профильный студенческий отряд (ПСО: СПуО, СЭО и др.)
    /// </summary>
    PSO,
    
    /// <summary>
    /// Трудовой отряд подростков (ТОП)
    /// </summary>
    TOP
}