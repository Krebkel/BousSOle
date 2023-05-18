using LSO.StructureContracts;

namespace LSO.ProductivityContracts;

/// <summary>
/// Класс, описывающий список работ, выполненных отрядом в конкретный день
/// </summary>
public class WorkPerformedReport
{
    /// <summary>
    /// Дата выполнения работы
    /// </summary>
    public DateTime Date { get; set; }
    
    /// <summary>
    /// UID отряда, выполнивший работу
    /// </summary>
    public int SquadId { get; set; }
    
    /// <summary>
    /// Отряд, выполнивший работу
    /// </summary>
    public Squad Squad { get; set; }

    /// <summary>
    /// Список выполненных видов работ
    /// </summary>
    public List<WorkPerformedEntity> WorkPerformedEntities { get; set; }
    
    /// <summary>
    /// Уникальный идентификатор
    /// </summary>
    public int Id { get; set; }

}