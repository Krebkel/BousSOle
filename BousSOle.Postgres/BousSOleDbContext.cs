using Microsoft.EntityFrameworkCore;
using LSO.Productivity;
using LSO.Structure;

namespace BousSOle.Postgres;

#nullable disable

/// <summary>
/// Класс представляет собой контекст базы данных, который используется для взаимодействия с PostgreSQL через Entity Framework Core.
/// Он объединяет наборы сущностей и конфигурации модели базы данных для обеспечения доступа к данным.
/// </summary>
public class BousSOleDbContext : DbContext
{
    /// <summary>
    /// Внутреннее поле, которое определяет схему базы данных для таблиц.
    /// </summary>
    internal const string ServiceSchema = "bousSOle";

    /// <summary>
    /// Конструктор класса "BousSOleDbContext", используется для создания экземпляра контекста базы данных.
    /// Принимает настройки контекста базы данных и передает их базовому классу DbContext для инициализации.
    /// Это позволяет создать экземпляр контекста базы данных, который будет использоваться для взаимодействия с PostgreSQL.
    /// </summary>
    /// <param name="options"></param>
    public BousSOleDbContext(DbContextOptions<BousSOleDbContext> options) : base(options)
    {}

    /// <summary>
    /// Набор сущностей учебных заведений
    /// </summary>
    public DbSet<Institution> Institutions { get; set; }

    /// <summary>
    /// Набор сущностей отрядов
    /// </summary>
    public DbSet<Squad> Squads { get; set; }
    
    /// <summary>
    /// Набор сущностей бойцов отряда
    /// </summary>
    public DbSet<SquadMember> SquadMembers { get; set; }
    
    /// <summary>
    /// Набор сущностей сборников элементных норм
    /// </summary>
    public DbSet<ElementNorm> ElementNorms { get; set; }
    
    /// <summary>
    /// Набор сущностей рабочих часов по дням
    /// </summary>
    public DbSet<WorkHoursReport> WorkHoursReports { get; set; }
}