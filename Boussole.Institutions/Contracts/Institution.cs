using Boussole.DataContracts;
using Boussole.Shtabs.Contracts;

namespace Boussole.Institutions.Contracts;

/// <summary>
/// Учебное заведение
/// </summary>
public class Institution : DatabaseEntity
{
    /// <summary>
    /// Полное название (Федеральное государственное....)
    /// </summary>
    public required string FullName { get; set; }

    /// <summary>
    /// Краткое название (ФГБОУ ВО МГТУ "СТАНКИН")
    /// </summary>
    public required string ShortName { get; set; }
    
    /// <summary>
    /// Регион учебного заведения
    /// </summary>
    public required Shtab Shtab { get; set; }
    
    /// <summary>
    /// Должность руководителя (Ректор)
    /// </summary>
    public required string AdministratorTitle { get; set; }
    
    /// <summary>
    /// Фамилия руководителя (Серебренный)
    /// </summary>
    public required string AdministratorSurname { get; set; }
    
    /// <summary>
    /// Имя руководителя (Владимир)
    /// </summary>
    public required string AdministratorName { get; set; }
    
    /// <summary>
    /// Отчество руководителя (Валерьевич)
    /// </summary>
    public required string AdministratorPatronymic { get; set; }

    /// <summary>
    /// Сайт структуры учебного заведения (https://stankin.ru/sveden/employees)
    /// </summary>
    public required string StructWebsite { get; set; }
}