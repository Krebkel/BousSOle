using Boussole.DataContracts;
using Boussole.Persons;

namespace Boussole.Docs.Contracts;

public class ProfessionalEducation : DatabaseEntity
{
    /// <summary>
    /// Поле Person является первичным ключом
    /// </summary>
    public required Person Person { get; set; }
    
    /// <summary>
    /// Рабочая профессия
    /// </summary>
    public required string Profession { get; set; }
    
    /// <summary>
    /// Разряд рабочей профессии
    /// </summary>
    public string? Category { get; set; }
    
    /// <summary>
    /// Номер удостоверения или сертификата
    /// </summary>
    public required string CertificateNumber { get; set; }
}