namespace LSO.Productivity;

/// <summary>
/// Учёт рабочего времени бойцов отряда в отдельный рабочий день
/// </summary>
public class WorkTimeReport
{
    /// <summary>
    /// Список бойцов для учёта времени
    /// </summary>
    public List<WorkedHours> WorkedHoursPerSquadMember { get; set; }

    /// <summary>
    /// Метод для получения суммарного рабочего времени для отряда
    /// </summary>
    public float GetTotalWorkedHoursForSquad()
    {
        return WorkedHoursPerSquadMember.Where(workedHours => workedHours.WorkerActivityStatus == WorkerActivityStatus.DidWork).Sum(workedHours => workedHours.WorkHours);
    }
    
}