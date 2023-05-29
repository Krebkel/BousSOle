namespace LSO.Contracts.SSO;


/// <summary>
/// Статус отдельного работника в рабочий день
/// </summary>
public enum WorkerActivityStatus 
{
    /// <summary>
    /// Работал (Р)
    /// </summary>
    DidWork,
    
    /// <summary>
    /// Выходной (В)
    /// </summary>
    DayOff,
    
    /// <summary>
    /// Невыход по болезни (Б)
    /// </summary>
    Sick,
    
    /// <summary>
    /// Отпуск без содержания (БС)
    /// </summary>
    UnpaidLeave,
    
    /// <summary>
    /// Прогул (Н)
    /// </summary>
    Absence
}