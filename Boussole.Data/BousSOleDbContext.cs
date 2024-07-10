using Boussole.Docs.Contracts;
using Boussole.Institutions.Contracts;
using Boussole.LSO.Contracts.SSO;
using Boussole.LSO.Contracts.Structure;
using Boussole.Persons;
using Boussole.Project.Contracts.Rating;
using Boussole.Project.Contracts.Rating.Coefficients;
using Boussole.Project.Contracts.Structure;
using Boussole.Project.Contracts.Structure.SquadOnProject;
using Boussole.Shtabs.Contracts;
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
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.HasDefaultSchema(ServiceSchema);
        
        ConfigureEntities(builder);
    }

    private static void ConfigureEntities(ModelBuilder builder)
    {
        // Документы
        builder.Entity<Education>().Property(e => e.Course).HasConversion<string>();
        builder.Entity<Passport>();
        builder.Entity<PersonMerch>();
        builder.Entity<ProfessionalEducation>();

        // LSO
        builder.Entity<ElementNorm>().Property(n => n.NormTypeByDistance).HasConversion<string>();
        builder.Entity<FactWork>();
        builder.Entity<Person>();
        builder.Entity<PlanWork>();
        builder.Entity<Squad>().Property(s => s.ActivityField).HasConversion<string>();
        builder.Entity<SquadMember>().Property(s => s.MemberRank).HasConversion<string>();

        // Project -> Rating -> Коэффициенты
        builder.Entity<ActivityCoefficient>();
        builder.Entity<AdditionalCoefficient>();
        builder.Entity<DisciplineCoefficient>();
        builder.Entity<ProductivityCoefficient>();

        // Project -> Rating
        builder.Entity<CalculatedFactWork>();
        builder.Entity<ProjectEvent>().Property(p => p.ProjectEventType).HasConversion<string>();
        builder.Entity<SquadAdditionalCoefficientParticipation>();
        builder.Entity<SquadEventParticipation>();

        // Project -> Structure
        builder.Entity<SquadMemberWorkingDay>().Property(s => s.WorkerActivityStatus).HasConversion<string>();
        builder.Entity<SquadMemberWorkTimeSchedule>();
        builder.Entity<SquadProjectParticipation>().Property(s => s.SquadApplicationStatus).HasConversion<string>();
        builder.Entity<WorkProject>().Property(s => s.ActivityField).HasConversion<string>();
        builder.Entity<WorkProjectImplementation>().Property(s => s.Season).HasConversion<string>();

        // Shtabs
        builder.Entity<Shtab>().Property(s => s.ShtabRank).HasConversion<string>();
        builder.Entity<ShtabMember>().Property(sm => sm.ShtabMemberRank).HasConversion<string>();

        builder.Entity<Institution>();
        builder.Entity<Okrug>();
        builder.Entity<Region>();
        builder.Entity<User>();
    }
}