using Boussole.DataContracts;
using Boussole.LSO.Contracts.SSO;

namespace Boussole.Project.Contracts.Rating;

public class CalculatedFactWork : DatabaseEntity
{
    /// <summary>
    /// Сданный вид работы
    /// </summary>
    public required FactWork FactWork { get; set; }

    /// <summary>
    /// Количество выполненных работ в единицах измерения, описанных в сборнике элементных норм
    /// </summary>
    public required float Quantity { get; set; }

    /// <summary>
    /// Вид работы, который по факту может не совпадать с тем, что предложил мастер отряда (который лежит в FactWork)
    /// </summary>
    public ElementNorm? ElementNorm { get; set; }

    /// <summary>
    /// Если норма учитывает дистанцию, то отряд обязан указать её.
    /// </summary>
    public int? Distance { get; set; }
}