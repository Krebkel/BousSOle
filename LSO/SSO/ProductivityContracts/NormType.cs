namespace LSO.ProductivityContracts;

/// <summary>
/// Тип нормы по зависимости от дистанции
/// </summary>
public enum NormType
{
    /// <summary>
    /// Постоянная норма, не зависящая от дистанции
    /// </summary>
    Constant,
    
    /// <summary>
    /// Норма, которая зависит от дистанции и считает BaseNorm на первые 10 метров и DistanceNorm на каждые следующие 10
    /// </summary>
    TenToTen,
    
    /// <summary>
    /// Норма, которая зависит от дистанции и считает BaseNorm на первые 30 метров и DistanceNorm на каждые следующие 10
    /// </summary>
    ThirtyToTen
}