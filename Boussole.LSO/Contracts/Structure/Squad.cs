using Boussole.DataContracts;
using Boussole.Shtabs.Contracts;

namespace Boussole.LSO.Contracts.Structure;

/// <summary>
/// Линейный студенческий отряд
/// </summary>
public class Squad : DatabaseEntity
{
    /// <summary>
    /// Название ЛСО (ССО "Агонь")
    /// </summary>
    public required string Name { get; set; }
    
    /// <summary>
    /// Штаб базирования
    /// </summary>
    public required Shtab Shtab { get; set; }
    
    /// <summary>
    /// Направление отряда
    /// </summary>
    public required ActivityField ActivityField { get; set; }
    
    /// <summary>
    /// Ссылка на ВК отряда (https://vk.com/ssoagon)
    /// </summary>
    public string? VkUrl { get; set; }
}