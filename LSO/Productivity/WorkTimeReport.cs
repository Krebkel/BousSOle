namespace LSO.Productivity;

public class WorkTimeReport         // Учёт рабочего времени на день
{
    public DateTime Date { get; set; }                                 // Учётный день (11.05.2023)
    public Squad Squad { get; set; }                                   // Отряд (ССО "Агонь")
    public List<WorkedHours> WorkedHoursPerSquadMember { get; set; }   // Список бойцов для учёта времени

    public float GetTotalWorkedHoursForSquad()   // Метод для получения суммарного рабочего времени для отряда
    {
        // LINQ
        return WorkedHoursPerSquadMember.Where(workedHours => workedHours.WorkerActivityStatus == WorkerActivityStatus.DidWork).Sum(workedHours => workedHours.WorkHours);
    }
}