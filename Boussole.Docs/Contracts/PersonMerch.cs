using Boussole.DataContracts;
using Boussole.Persons;

namespace Boussole.Docs.Contracts;

public class PersonMerch : DatabaseEntity
{
    /// <summary>
    /// Поле Person является первичным ключом
    /// </summary>
    public required Person Person { get; set; }
    
    /// <summary>
    /// Размер одежды (44, 46, ...)
    /// </summary>
    public int ClothesSize { get; set; }
    
    /// <summary>
    /// Рост человека в см
    /// </summary>
    public int PersonHeight { get; set; }
    
    /// <summary>
    /// Размер обуви (40, 41, ...)
    /// </summary>
    public int ShoeSize { get; set; }
}