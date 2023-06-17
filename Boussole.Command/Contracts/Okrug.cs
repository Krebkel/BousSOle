namespace Boussole.Command.Contracts;

public class Okrug
{
    /// <summary>
    /// UID округа
    /// </summary>
    public required int Id { get; set; }
    
    /// <summary>
    /// Название округа
    /// </summary>
    public required string Name { get; set; }
}