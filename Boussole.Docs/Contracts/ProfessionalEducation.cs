using Boussole.Persons;

namespace Boussole.Docs.Contracts;

public class ProfessionalEducation
{
    /// <summary>
    /// Поле Person является первичным ключом
    /// </summary>
    public required Person Person { get; set; }
    
    /// <summary>
    /// Рабочая профессия
    /// </summary>
    public string? Profession { get; set; }
    
    /// <summary>
    /// Разряд рабочей профессии
    /// </summary>
    public string? Category { get; set; }
    
    /// <summary>
    /// Номер удостоверения или сертификата
    /// </summary>
    public string CertificateNumber { get; set; }
}