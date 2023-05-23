using LSO.StructureContracts;

namespace LSO.SSO.ProductivityContracts;

/// <summary>
/// Учёт рабочего времени для отдельного бойца отряда
/// </summary>
public class PlanWork
{
    /// <summary>
    /// Учётный день (11.05.2023)
    /// </summary>
    public DateTime Date { get; set; }
    
    /// <summary>
    /// UID бойца
    /// </summary>
    public int SquadMemberId { get; set; }
    
    /// <summary>
    /// Боец отряда (Иванов Иван Иванович)
    /// </summary>
    public SquadMember SquadMember { get; set; }
    
    /// <summary>
    /// Статус (Работал/Выходной/...)
    /// </summary>
    public WorkerActivityStatus WorkerActivityStatus { get; set; }
    
    /// <summary>
    /// Кол-во часов выработки (10)
    /// </summary>
    public float WorkHours { get; set; }  
    
    /// <summary>
    /// UID
    /// </summary>
    public int Id { get;set; }                          
}