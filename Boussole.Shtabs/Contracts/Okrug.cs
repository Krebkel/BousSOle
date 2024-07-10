using Boussole.DataContracts;

namespace Boussole.Shtabs.Contracts;

public class Okrug : DatabaseEntity
{
    /// <summary>
    /// Название округа
    /// </summary>
    public required string Name { get; set; }
}