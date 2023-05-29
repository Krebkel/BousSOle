using LSO.Contracts.Structure;

namespace LSO.Contracts.SSO;

/// <summary>
/// Учёт рабочего времени для отдельного бойца отряда
/// </summary>
public class PlanWork
{
    /// <summary>
    /// UID учетного дня
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Учётный день (11.05.2023)
    /// </summary>
    public DateTimeOffset Date { get; set; }
    
    /// <summary>
    /// UID бойца
    /// </summary>
    public int SquadMemberId { get; set; }
    
    /// <summary>
    /// Боец отряда (Иванов Иван Иванович)
    /// </summary>
    public SquadMember SquadMember { get; set; } = null!;
    
    /// <summary>
    /// Статус (Работал/Выходной/...)
    /// </summary>
    public WorkerActivityStatus WorkerActivityStatus { get; set; }
    
    /// <summary>
    /// Кол-во часов выработки (10)
    /// </summary>
    public float WorkHours { get; set; }
}