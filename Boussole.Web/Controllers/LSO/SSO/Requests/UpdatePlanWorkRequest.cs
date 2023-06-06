using Boussole.LSO.Contracts.SSO;

namespace Boussole.Core.Controllers.LSO.SSO.Requests;

/// <summary>
/// Запрос на обновление учета рабочего времени
/// </summary>
public class UpdatePlanWorkRequest
{
    /// <summary>
    /// Идентификатор учетного дня
    /// </summary>
    public int PlanWorkId { get; set; }

    /// <summary>
    /// Учётный день
    /// </summary>
    public DateTimeOffset Date { get; set; }

    /// <summary>
    /// Статус (Работал/Выходной/...)
    /// </summary>
    public WorkerActivityStatus WorkerActivityStatus { get; set; }

    /// <summary>
    /// Количество часов выработки
    /// </summary>
    public float WorkHours { get; set; }
}