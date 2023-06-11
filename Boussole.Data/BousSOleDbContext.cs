using System.Reflection;
using Boussole.Institutions.Contracts;
using Boussole.LSO.Contracts.SSO;
using Boussole.LSO.Contracts.Structure;
using Boussole.Persons;
using Boussole.Users;
using Microsoft.EntityFrameworkCore;

namespace Boussole.Data;

#nullable disable

internal class BousSOleDbContext : DbContext
{
    internal const string ServiceSchema = "bousSOle";

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
    public DbSet<PlanWork> PlanWorks { get; set; }
    
    /// <summary>
    /// Набор сущностей для учёта каждой выполненной работы отряда
    /// </summary>
    public DbSet<FactWork> FactWorks { get; set; }
    
    /// <summary>
    /// Набор сущностей для учёта физ.лиц
    /// </summary>
    public DbSet<Person> Persons { get; set; }
    
    /// <summary>
    /// Пользователи сервиса
    /// </summary>
    public DbSet<User> Users { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        modelBuilder.HasDefaultSchema(ServiceSchema);
    }
}