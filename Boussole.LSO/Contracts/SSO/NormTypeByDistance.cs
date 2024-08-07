namespace Boussole.LSO.Contracts.SSO;


/// <summary>
/// Тип нормы по зависимости от дистанции
/// </summary>
public enum NormTypeByDistance
{
    /// <summary>
    /// Постоянная норма, не зависящая от дистанции
    /// </summary>
    Constant = 1,
    
    /// <summary>
    /// Норма, которая зависит от дистанции и считает BaseNorm на первые 10 метров и DistanceNorm на каждые следующие 10
    /// </summary>
    TenToTen,
    
    /// <summary>
    /// Норма, которая зависит от дистанции и считает BaseNorm на первые 30 метров и DistanceNorm на каждые следующие 10
    /// </summary>
    ThirtyToTen
}