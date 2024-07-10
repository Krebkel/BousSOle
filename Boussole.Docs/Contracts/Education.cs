using Boussole.DataContracts;
using Boussole.Institutions.Contracts;
using Boussole.Persons;

namespace Boussole.Docs.Contracts;

public class Education : DatabaseEntity
{
    /// <summary>
    /// Поле Person является первичным ключом
    /// </summary>
    public required Person Person { get; set; }

    /// <summary>
    /// ВУЗ обучения
    /// </summary>
    public required Institution Institution { get; set; }

    /// <summary>
    /// Факультет обучения
    /// </summary>
    public required string Faculty { get; set; }

    /// <summary>
    /// Специальность
    /// </summary>
    public required string Specialization { get; set; }

    /// <summary>
    /// Курс
    /// </summary>
    public required EducationCourse Course { get; set; }

    /// <summary>
    /// Предполагаемый год завершения обучения
    /// </summary>
    public required int ExpectedGraduationYear { get; set; }
}