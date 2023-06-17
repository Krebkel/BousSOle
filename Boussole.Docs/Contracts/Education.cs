using Boussole.Institutions.Contracts;
using Boussole.Persons;

namespace Boussole.Docs.Contracts;

public class Education
{
    /// <summary>
    /// Поле Person является первичным ключом
    /// </summary>
    public required Person Person { get; set; }

    /// <summary>
    /// ВУЗ обучения
    /// </summary>
    public Institution Institution { get; set; }

    /// <summary>
    /// Факультет обучения
    /// </summary>
    public string Faculty { get; set; }

    /// <summary>
    /// Специальность
    /// </summary>
    public string Specialization { get; set; }

    /// <summary>
    /// Курс
    /// </summary>
    public int Course { get; set; }

    /// <summary>
    /// Предполагаемый год завершения обучения
    /// </summary>
    public int ExpectedGraduationYear { get; set; }
}