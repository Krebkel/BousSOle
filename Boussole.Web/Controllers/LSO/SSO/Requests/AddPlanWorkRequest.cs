using Boussole.LSO.Contracts.SSO;

namespace Boussole.Core.Controllers.LSO.SSO.Requests;

// <summary>
/// Запрос на добавление учета рабочего времени
/// </summary>
public class AddPlanWorkRequest
{
    /// <summary>
    /// Учётный день
    /// </summary>
    public DateTimeOffset Date { get; set; }

    /// <summary>
    /// UID бойца
    /// </summary>
    public int SquadMemberId { get; set; }

    /// <summary>
    /// Статус (Работал/Выходной/...)
    /// </summary>
    public WorkerActivityStatus WorkerActivityStatus { get; set; }

    /// <summary>
    /// Количество часов выработки
    /// </summary>
    public float WorkHours { get; set; }
}