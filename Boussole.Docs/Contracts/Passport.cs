using Boussole.Persons;

namespace Boussole.Docs.Contracts;

public class Passport
{
    /// <summary>
    /// Поле Person является первичным ключом
    /// </summary>
    public required Person Person { get; set; }

    /// <summary>
    /// Дата рождения
    /// </summary>
    public DateTime BirthDate { get; set; }

    /// <summary>
    /// Место рождения
    /// </summary>
    public string BirthPlace { get; set; }

    /// <summary>
    /// Серия паспорта
    /// </summary>
    public string Series { get; set; }

    /// <summary>
    /// Номер паспорта
    /// </summary>
    public string Number { get; set; }

    /// <summary>
    /// Дата выдачи паспорта
    /// </summary>
    public DateTime IssueDate { get; set; }

    /// <summary>
    /// Кем выдан паспорт
    /// </summary>
    public string IssuedBy { get; set; }

    /// <summary>
    /// Код подразделения паспорта
    /// </summary>
    public string DivisionCode { get; set; }

    /// <summary>
    /// Адрес регистрации
    /// </summary>
    public string RegistrationAddress { get; set; }

    /// <summary>
    /// Индекс адреса регистрации
    /// </summary>
    public string RegistrationIndex { get; set; }

    /// <summary>
    /// СНИЛС
    /// </summary>
    public string SNILS { get; set; }

    /// <summary>
    /// Полис ОМС
    /// </summary>
    public string OMS { get; set; }
}