namespace LSO.ProductivityContracts;

/// <summary>
/// Учёт рабочего времени бойцов отряда в отдельный рабочий день
/// </summary>
public class SummarizeWorkHours
{
    /// <summary>
    /// Метод для получения суммарного рабочего времени для отряда
    /// </summary>
    public float GetTotalWorkedHoursForSquad(List<WorkHoursReport> WorkedHoursPerSquadMember)
    {
        return WorkedHoursPerSquadMember.Where(WorkedHours => WorkedHours.WorkerActivityStatus == WorkerActivityStatus.DidWork).Sum(WorkedHours => WorkedHours.WorkHours);
    }
    
}