namespace LSO.Structure;

/// <summary>
/// Учебное заведение
/// </summary>
public class Institution
{
    /// <summary>
    /// Краткое название (ФГБОУ ВО МГТУ "СТАНКИН")
    /// </summary>
    public string ShortName { get; set; }

    /// <summary>
    /// Полное название  (Федеральное государственное....)
    /// </summary>
    public string FullName { get; set; }

    /// <summary>
    /// Должность руководителя (Ректор)
    /// </summary>
    public string AdministratorTitle { get; set; }
    
    /// <summary>
    /// ФИО руководителя (Серебренный Владимир Валерьевич)
    /// </summary>
    public string AdministratorName { get; set; }

    /// <summary>
    /// Сайт структуры учебного заведения (https://stankin.ru/sveden/employees)
    /// </summary>
    public string StructWebsite { get; set; }
}