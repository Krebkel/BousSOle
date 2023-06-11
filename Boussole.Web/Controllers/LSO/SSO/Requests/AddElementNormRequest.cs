using Boussole.LSO.Contracts.SSO;

namespace Boussole.Core.Controllers.LSO.SSO.Requests;

/// <summary>
/// Добавление элементной нормы из сборника
/// </summary>
public class AddElementNormRequest
{
    public string NormCollection { get; set; }
    
    public string NormCode { get; set; }
    
    public string NormName { get; set; }
    
    public string MeasurementUnit { get; set; }
    
    public float BaseNorm { get; set; }
    
    public NormTypeByDistance NormTypeByDistance { get; set; }
    
    public float? DistanceNorm { get; set; }
}