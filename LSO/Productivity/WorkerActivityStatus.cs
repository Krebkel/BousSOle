namespace LSO.Productivity;

public enum WorkerActivityStatus    // Статус
{
    DidWork,                        // Работал                  (Р)
    DayOff,                         // Выходной                 (В)
    Sick,                           // Невыход по болезни       (Б)
    Furlough,                       // Отпуск без содержания    (БС)
    Truancy                         // Прогул                   (Н)
}