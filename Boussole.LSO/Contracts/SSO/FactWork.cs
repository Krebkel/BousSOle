using Boussole.LSO.Contracts.Structure;

namespace Boussole.LSO.Contracts.SSO;

/// <summary>
/// Выполненный вид работ
/// </summary>
public class FactWork
{
    /// <summary>
    /// UID работы
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Дата выполнения работы
    /// </summary>
    public DateTimeOffset Date { get; set; }

    /// <summary>
    /// Отряд, выполнивший работу
    /// </summary>
    public Squad Squad { get; set; } = null!;

    /// <summary>
    /// Наименование работы с уточнениями, заполняется отрядом
    /// </summary>
    public string WorkName { get; set; } = null!;
    
    /// <summary>
    /// Вид работы
    /// </summary>
    public ElementNorm ElementNorm { get; set; } = null!;

    /// <summary>
    /// Если норма учитывает дистанцию, то отряд обязан указать её.
    /// </summary>
    public int? Distance { get; set; }

    /// <summary>
    /// Количество выполненных работ в единицах измерения, описанных в сборнике элементных норм
    /// </summary>
    public float Quantity { get; set; }
}