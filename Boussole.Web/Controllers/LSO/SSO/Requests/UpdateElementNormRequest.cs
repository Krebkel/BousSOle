using Boussole.LSO.Contracts.SSO;

namespace Boussole.Core.Controllers.LSO.SSO.Requests;

public class UpdateElementNormRequest
{
    public int ElementNormId { get; set; }
    
    public string NormCollection { get; set; }
    
    public string NormCode { get; set; }
    
    public string NormName { get; set; }
    
    public string MeasurementUnit { get; set; }
    
    public float BaseNorm { get; set; }
    
    public NormType NormType { get; set; }
    
    public float? DistanceNorm { get; set; }
}