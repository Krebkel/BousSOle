using Boussole.DataContracts;
using Boussole.LSO.Contracts.Structure;

namespace Boussole.LSO.Contracts.SSO;

/// <summary>
/// Учёт рабочего времени для отдельного бойца отряда
/// </summary>
public class PlanWork : DatabaseEntity
{
    /// <summary>
    /// Учётный день (11.05.2023)
    /// </summary>
    public required DateTimeOffset Date { get; set; }

    /// <summary>
    /// Боец отряда (Иванов Иван Иванович)
    /// </summary>
    public required SquadMember SquadMember { get; set; }
    
    /// <summary>
    /// Статус (Работал/Выходной/...)
    /// </summary>
    public required WorkerActivityStatus WorkerActivityStatus { get; set; }
    
    /// <summary>
    /// Кол-во часов выработки (10)
    /// </summary>
    public required float WorkHours { get; set; }
}