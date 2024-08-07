using Boussole.LSO.Contracts.SSO;
using Boussole.LSO.Contracts.Structure;

namespace Boussole.Web.Controllers.LSO.SSO.Requests;

/// <summary>
/// Запрос на добавление выполненной работы
/// </summary>
public class AddFactWorkRequest
{
    /// <summary>
    /// Дата выполнения работы
    /// </summary>
    public DateTimeOffset Date { get; set; }

    /// <summary>
    /// Отряд, выполнивший работу
    /// </summary>
    public Squad Squad { get; set; }

    /// <summary>
    /// Наименование работы с уточнениями
    /// </summary>
    public string WorkName { get; set; }

    /// <summary>
    /// Элементная норма, соответствующая виду работы
    /// </summary>
    public ElementNorm ElementNorm { get; set; }

    /// <summary>
    /// Если норма учитывает дистанцию, то указывается её значение
    /// </summary>
    public int? Distance { get; set; }

    /// <summary>
    /// Количество выполненных работ в единицах измерения, описанных в сборнике элементных норм
    /// </summary>
    public float Quantity { get; set; }
}