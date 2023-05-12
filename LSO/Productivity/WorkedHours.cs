namespace LSO.Productivity;
/// <summary>
/// Учёт рабочего времени для отдельного бойца отряда
/// </summary>
public class WorkedHours
{
    
    /// <summary>
    /// Учётный день (11.05.2023)
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// Отряд (ССО "Агонь")
    /// </summary>
    public Squad Squad { get; set; }
    
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
}
