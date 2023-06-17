namespace Boussole.Command.Contracts;

public class Region
{
    /// <summary>
    /// UID региона
    /// </summary>
    public required int Id { get; set; }
    
    /// <summary>
    /// Название региона
    /// </summary>
    public required string Name { get; set; }
    
    /// <summary>
    /// Округ
    /// </summary>
    public required Okrug Okrug { get; set; }
}