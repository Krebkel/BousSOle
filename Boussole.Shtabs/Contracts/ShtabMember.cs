using Boussole.DataContracts;
using Boussole.Persons;

namespace Boussole.Shtabs.Contracts;

public class ShtabMember : DatabaseEntity
{
    /// <summary>
    /// Физ. лицо
    /// </summary>
    public required Person Person { get; set; }
    
    /// <summary>
    /// Штаб прикрепления
    /// </summary>
    public required Shtab Shtab { get; set; }
    
    /// <summary>
    /// Должность в Штабе
    /// </summary>
    public required ShtabMemberRank ShtabMemberRank { get; set; }
    
    /// <summary>
    /// Специальность (e.g. Руководитель строительного направления)
    /// </summary>
    public string? Specialty { get; set; }

    /// <summary>
    /// Участие в действующем составе
    /// </summary>
    public required bool IsActive { get; set; }
}