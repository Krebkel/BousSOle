using Boussole.Institutions.Contracts;

namespace Boussole.LSO.Contracts.Structure;

/// <summary>
/// Линейный студенческий отряд
/// </summary>
public class Squad
{
    /// <summary>
    /// Название ЛСО (ССО "Агонь")
    /// </summary>
    public required string Name { get; set; }
    
    /// <summary>
    /// Регион, в котором находится штаб (г. Москва)
    /// </summary>
    public required string Region { get; set; }
    
    /// <summary>
    /// Ссылка на ВК отряда (https://vk.com/ssoagon)
    /// </summary>
    public required string VkUrl { get; set; }
    
    /// <summary>
    /// UID учебного заведения
    /// </summary>
    public required Institution Institution { get; set; }

    /// <summary>
    /// Направление отряда
    /// </summary>
    public SquadType SquadType { get; set; }
}