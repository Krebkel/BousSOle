namespace Boussole.Institutions.Contracts;

/// <summary>
/// Учебное заведение
/// </summary>
public class Institution
{
    /// <summary>
    /// UID учебного заведения
    /// </summary>
    public int Id { get;set; }
    
    /// <summary>
    /// Краткое название (ФГБОУ ВО МГТУ "СТАНКИН")
    /// </summary>
    public string ShortName { get; set; } = null!;

    /// <summary>
    /// Полное название  (Федеральное государственное....)
    /// </summary>
    public string FullName { get; set; } = null!;

    /// <summary>
    /// Должность руководителя (Ректор)
    /// </summary>
    public string AdministratorTitle { get; set; } = null!;
    
    /// <summary>
    /// Фамилия руководителя (Серебренный)
    /// </summary>
    public string AdministratorSurname { get; set; } = null!;
    
    /// <summary>
    /// Имя руководителя (Владимир)
    /// </summary>
    public string AdministratorName { get; set; } = null!;
    
    /// <summary>
    /// Отчество руководителя (Валерьевич)
    /// </summary>
    public string AdministratorPatronymic { get; set; } = null!;

    /// <summary>
    /// Сайт структуры учебного заведения (https://stankin.ru/sveden/employees)
    /// </summary>
    public string StructWebsite { get; set; } = null!;
}