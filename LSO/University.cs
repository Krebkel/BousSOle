namespace LSO;

public class Institution         // Учебное заведение
{
    public string ShortName { get; set; }           // Краткое название (ФГБОУ ВО МГТУ "СТАНКИН")
    public string FullName { get; set; }            // Полное название  (Федеральное государственное....)
    public string AdministratorTitle { get; set; }  // Должность руководителя (Ректор)
    public string AdministratorName { get; set; }   // ФИО руководителя (Серебренный Владимир Валерьевич)
    public string StructWebsite { get; set; }       // Сайт структуры учебного заведения (https://stankin.ru/sveden/employees)
}