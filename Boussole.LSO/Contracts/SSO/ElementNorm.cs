using Boussole.DataContracts;

namespace Boussole.LSO.Contracts.SSO;

/// <summary>
/// Сметные нормативные документы (ЕНиР, ГЭСН, ФЕР, ...)
/// </summary>
public class ElementNorm : DatabaseEntity
{
    /// <summary>
    /// ЕНиР, ГЭСН, ФЕР или др.
    /// </summary>
    public required string NormCollection { get; set; }
    
    /// <summary>
    /// Специфический код для каждого сборника (§E1-19-3, 01-01-062-01, ...)
    /// </summary>
    public required string NormCode { get; set; }
    
    /// <summary>
    /// Наименование работы
    /// </summary>
    public required string NormName { get; set; }
    
    /// <summary>
    /// Единица измерения (1 м2, 100 м2, 1 шт., 1 м3, и т.д.)
    /// </summary>
    public required string MeasurementUnit { get; set; }

    /// <summary>
    /// Норма времени на одну единицу измерения выполненной работы, в человекочасах / на первые 10|30 метров 
    /// </summary>
    public required float BaseNorm { get; set; }
    
    /// <summary>
    /// Зависит ли расчёт по этой статье от дистанции и каким образом
    /// </summary>
    public required NormTypeByDistance NormTypeByDistance { get; set; }

    /// <summary>
    /// Норма времени на каждые следующие 10 метров ЕСЛИ норма зависит от дистанции
    /// </summary>
    public float? DistanceNorm { get; set; }
}