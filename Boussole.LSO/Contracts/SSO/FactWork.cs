using Boussole.LSO.Contracts.Structure;

namespace Boussole.LSO.Contracts.SSO;

/// <summary>
/// Выполненный вид работ
/// </summary>
public class FactWork
{
    /// <summary>
    /// Дата выполнения работы
    /// </summary>
    public DateTimeOffset Date { get; set; }

    /// <summary>
    /// Отряд, выполнивший работу
    /// </summary>
    public required Squad Squad { get; set; }

    /// <summary>
    /// Наименование работы с уточнениями, заполняется отрядом
    /// </summary>
    public required string WorkName { get; set; }
    
    /// <summary>
    /// Вид работы
    /// </summary>
    public required ElementNorm ElementNorm { get; set; }

    /// <summary>
    /// Если норма учитывает дистанцию, то отряд обязан указать её.
    /// </summary>
    public int? Distance { get; set; }

    /// <summary>
    /// Количество выполненных работ в единицах измерения, описанных в сборнике элементных норм
    /// </summary>
    public float Quantity { get; set; }
}