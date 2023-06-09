namespace Boussole.LSO.Contracts.SSO;

/// <summary>
/// Сметные нормативные документы (ЕНиР, ГЭСН, ФЕР, ...)
/// </summary>
public class ElementNorm
{
    /// <summary>
    /// UID норматива
    /// </summary>
    public int Id { get;set; }

    /// <summary>
    /// ЕНиР, ГЭСН, ФЕР или др.
    /// </summary>
    public string NormCollection { get; set; } = null!;
    
    /// <summary>
    /// Специфический код для каждого сборника (§E1-19-3, 01-01-062-01, ...)
    /// </summary>
    public string NormCode { get; set; } = null!;
    
    /// <summary>
    /// Наименование работы
    /// </summary>
    public string NormName { get; set; } = null!;
    
    /// <summary>
    /// Единица измерения (1 м2, 100 м2, 1 шт., 1 м3, и т.д.)
    /// </summary>
    public string MeasurementUnit { get; set; } = null!;

    /// <summary>
    /// Норма времени на одну единицу измерения выполненной работы, в человекочасах / на первые 10|30 метров 
    /// </summary>
    public float BaseNorm { get; set; }
    
    /// <summary>
    /// Зависит ли расчёт по этой статье от дистанции и каким образом
    /// </summary>
    public NormType NormType { get; set; }

    /// <summary>
    /// Норма времени на каждые следующие 10 метров ЕСЛИ норма зависит от дистанции
    /// </summary>
    public float? DistanceNorm { get; set; }
}