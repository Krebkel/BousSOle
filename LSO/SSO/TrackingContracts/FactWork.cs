using LSO.StructureContracts;
using LSO.ProductivityContracts;

namespace LSO.SSO.Reports;

/// <summary>
/// Класс, описывающий список работ, выполненных отрядом в конкретный день
/// </summary>
public class FactWork
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
    public List<FactWorkEntity> WorkPerformedEntities { get; set; }
}