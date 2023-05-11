namespace LSO.Productivity;

public class WorkedHours            // Учёт рабочего времени для человека
{
    public SquadMember SquadMember { get; set; }                     // Боец отряда (Иванов Иван Иванович)
    public WorkerActivityStatus WorkerActivityStatus { get; set; }   // Статус (Работал/Выходной/...)
    public float WorkHours { get; set; }                             // Кол-во часов выработки (10)
}
