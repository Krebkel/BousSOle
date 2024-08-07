using Boussole.DataContracts;

namespace Boussole.Shtabs.Contracts;

public class Shtab : DatabaseEntity
{
    /// <summary>
    /// Название Штаба
    /// </summary>
    public required string Name { get; set; }
    
    /// <summary>
    /// Уровень Штаба в иерархии
    /// </summary>
    public required ShtabRank ShtabRank { get; set; }
    
    /// <summary>
    /// Штаб-родитель
    /// </summary>
    public Shtab? ParentShtab { get; set; }
    
    /// <summary>
    /// Регион базирования
    /// </summary>
    public required Region Region { get; set; }
}