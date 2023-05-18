namespace LSO.ProductivityContracts;

/// <summary>
/// Выполненный вид работ
/// </summary>
public class WorkPerformedEntity
{
    /// <summary>
    /// UID вида работ
    /// </summary>
    public int ElementNormId { get; set; }
    
    /// <summary>
    /// Вид работы
    /// </summary>
    public ElementNorm ElementNorm { get; set; }

    /// <summary>
    /// Количество выполненных работ в единицах измерения, описанных в сборнике элементных норм
    /// </summary>
    public float Quantity { get; set; }
}


