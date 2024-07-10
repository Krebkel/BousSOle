using Boussole.DataContracts;

namespace Boussole.Shtabs.Contracts;

public class Region : DatabaseEntity
{
    /// <summary>
    /// Название региона
    /// </summary>
    public required string Name { get; set; }
    
    /// <summary>
    /// Округ
    /// </summary>
    public required Okrug Okrug { get; set; }
}