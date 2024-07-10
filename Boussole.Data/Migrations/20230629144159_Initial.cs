using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Boussole.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "bousSOle");

            migrationBuilder.CreateTable(
                name: "ElementNorms",
                schema: "bousSOle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NormCollection = table.Column<string>(type: "text", nullable: false),
                    NormCode = table.Column<string>(type: "text", nullable: false),
                    NormName = table.Column<string>(type: "text", nullable: false),
                    MeasurementUnit = table.Column<string>(type: "text", nullable: false),
                    BaseNorm = table.Column<float>(type: "real", nullable: false),
                    NormTypeByDistance = table.Column<string>(type: "text", nullable: false),
                    DistanceNorm = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElementNorms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Okrug",
                schema: "bousSOle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Okrug", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                schema: "bousSOle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonInn = table.Column<string>(type: "text", nullable: false),
                    Surname = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Patronymic = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    EMail = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkProject",
                schema: "bousSOle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ActivityField = table.Column<string>(type: "text", nullable: false),
                    Region = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkProject", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Region",
                schema: "bousSOle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    OkrugId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Region", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Region_Okrug_OkrugId",
                        column: x => x.OkrugId,
                        principalSchema: "bousSOle",
                        principalTable: "Okrug",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Passport",
                schema: "bousSOle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonId = table.Column<int>(type: "integer", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    BirthPlace = table.Column<string>(type: "text", nullable: false),
                    Series = table.Column<string>(type: "text", nullable: false),
                    Number = table.Column<string>(type: "text", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IssuedBy = table.Column<string>(type: "text", nullable: false),
                    DivisionCode = table.Column<string>(type: "text", nullable: false),
                    RegistrationAddress = table.Column<string>(type: "text", nullable: false),
                    RegistrationIndex = table.Column<string>(type: "text", nullable: false),
                    SNILS = table.Column<string>(type: "text", nullable: false),
                    OMS = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Passport_Persons_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "bousSOle",
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonMerch",
                schema: "bousSOle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonId = table.Column<int>(type: "integer", nullable: false),
                    ClothesSize = table.Column<int>(type: "integer", nullable: false),
                    PersonHeight = table.Column<int>(type: "integer", nullable: false),
                    ShoeSize = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonMerch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonMerch_Persons_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "bousSOle",
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfessionalEducation",
                schema: "bousSOle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonId = table.Column<int>(type: "integer", nullable: false),
                    Profession = table.Column<string>(type: "text", nullable: false),
                    Category = table.Column<string>(type: "text", nullable: true),
                    CertificateNumber = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionalEducation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfessionalEducation_Persons_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "bousSOle",
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "bousSOle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonId = table.Column<int>(type: "integer", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Persons_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "bousSOle",
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkProjectImplementation",
                schema: "bousSOle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WorkProjectId = table.Column<int>(type: "integer", nullable: false),
                    Year = table.Column<int>(type: "integer", nullable: false),
                    Season = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkProjectImplementation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkProjectImplementation_WorkProject_WorkProjectId",
                        column: x => x.WorkProjectId,
                        principalSchema: "bousSOle",
                        principalTable: "WorkProject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shtab",
                schema: "bousSOle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ShtabRank = table.Column<string>(type: "text", nullable: false),
                    ParentShtabId = table.Column<int>(type: "integer", nullable: true),
                    RegionId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shtab", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shtab_Region_RegionId",
                        column: x => x.RegionId,
                        principalSchema: "bousSOle",
                        principalTable: "Region",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shtab_Shtab_ParentShtabId",
                        column: x => x.ParentShtabId,
                        principalSchema: "bousSOle",
                        principalTable: "Shtab",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ActivityCoefficient",
                schema: "bousSOle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WorkProjectImplementationId = table.Column<int>(type: "integer", nullable: false),
                    SquadActivityStatus = table.Column<string>(type: "text", nullable: false),
                    RatingPoints = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityCoefficient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivityCoefficient_WorkProjectImplementation_WorkProjectIm~",
                        column: x => x.WorkProjectImplementationId,
                        principalSchema: "bousSOle",
                        principalTable: "WorkProjectImplementation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdditionalCoefficient",
                schema: "bousSOle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WorkProjectImplementationId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Transcript = table.Column<string>(type: "text", nullable: false),
                    MaxPoints = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalCoefficient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdditionalCoefficient_WorkProjectImplementation_WorkProject~",
                        column: x => x.WorkProjectImplementationId,
                        principalSchema: "bousSOle",
                        principalTable: "WorkProjectImplementation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DisciplineCoefficient",
                schema: "bousSOle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WorkProjectImplementationId = table.Column<int>(type: "integer", nullable: false),
                    ViolationType = table.Column<string>(type: "text", nullable: false),
                    PointsReduction = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisciplineCoefficient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DisciplineCoefficient_WorkProjectImplementation_WorkProject~",
                        column: x => x.WorkProjectImplementationId,
                        principalSchema: "bousSOle",
                        principalTable: "WorkProjectImplementation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductivityCoefficient",
                schema: "bousSOle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WorkProjectImplementationId = table.Column<int>(type: "integer", nullable: false),
                    ProizvodkaStartDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    RatingPoints = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductivityCoefficient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductivityCoefficient_WorkProjectImplementation_WorkProje~",
                        column: x => x.WorkProjectImplementationId,
                        principalSchema: "bousSOle",
                        principalTable: "WorkProjectImplementation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectEvent",
                schema: "bousSOle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WorkProjectImplementationId = table.Column<int>(type: "integer", nullable: false),
                    ProjectEventType = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectEvent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectEvent_WorkProjectImplementation_WorkProjectImplement~",
                        column: x => x.WorkProjectImplementationId,
                        principalSchema: "bousSOle",
                        principalTable: "WorkProjectImplementation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Institutions",
                schema: "bousSOle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FullName = table.Column<string>(type: "text", nullable: false),
                    ShortName = table.Column<string>(type: "text", nullable: false),
                    ShtabId = table.Column<int>(type: "integer", nullable: false),
                    AdministratorTitle = table.Column<string>(type: "text", nullable: false),
                    AdministratorSurname = table.Column<string>(type: "text", nullable: false),
                    AdministratorName = table.Column<string>(type: "text", nullable: false),
                    AdministratorPatronymic = table.Column<string>(type: "text", nullable: false),
                    StructWebsite = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Institutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Institutions_Shtab_ShtabId",
                        column: x => x.ShtabId,
                        principalSchema: "bousSOle",
                        principalTable: "Shtab",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShtabMember",
                schema: "bousSOle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonId = table.Column<int>(type: "integer", nullable: false),
                    ShtabId = table.Column<int>(type: "integer", nullable: false),
                    ShtabMemberRank = table.Column<string>(type: "text", nullable: false),
                    Specialty = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShtabMember", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShtabMember_Persons_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "bousSOle",
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShtabMember_Shtab_ShtabId",
                        column: x => x.ShtabId,
                        principalSchema: "bousSOle",
                        principalTable: "Shtab",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Squads",
                schema: "bousSOle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ShtabId = table.Column<int>(type: "integer", nullable: false),
                    ActivityField = table.Column<string>(type: "text", nullable: false),
                    VkUrl = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Squads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Squads_Shtab_ShtabId",
                        column: x => x.ShtabId,
                        principalSchema: "bousSOle",
                        principalTable: "Shtab",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Education",
                schema: "bousSOle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonId = table.Column<int>(type: "integer", nullable: false),
                    InstitutionId = table.Column<int>(type: "integer", nullable: false),
                    Faculty = table.Column<string>(type: "text", nullable: false),
                    Specialization = table.Column<string>(type: "text", nullable: false),
                    Course = table.Column<string>(type: "text", nullable: false),
                    ExpectedGraduationYear = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Education", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Education_Institutions_InstitutionId",
                        column: x => x.InstitutionId,
                        principalSchema: "bousSOle",
                        principalTable: "Institutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Education_Persons_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "bousSOle",
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FactWorks",
                schema: "bousSOle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    SquadId = table.Column<int>(type: "integer", nullable: false),
                    WorkName = table.Column<string>(type: "text", nullable: false),
                    ElementNormId = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<float>(type: "real", nullable: false),
                    Distance = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactWorks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FactWorks_ElementNorms_ElementNormId",
                        column: x => x.ElementNormId,
                        principalSchema: "bousSOle",
                        principalTable: "ElementNorms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FactWorks_Squads_SquadId",
                        column: x => x.SquadId,
                        principalSchema: "bousSOle",
                        principalTable: "Squads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SquadMembers",
                schema: "bousSOle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonId = table.Column<int>(type: "integer", nullable: false),
                    MemberRank = table.Column<string>(type: "text", nullable: false),
                    YearEnlisted = table.Column<int>(type: "integer", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    SquadId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SquadMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SquadMembers_Persons_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "bousSOle",
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SquadMembers_Squads_SquadId",
                        column: x => x.SquadId,
                        principalSchema: "bousSOle",
                        principalTable: "Squads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SquadProjectParticipation",
                schema: "bousSOle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WorkProjectImplementationId = table.Column<int>(type: "integer", nullable: false),
                    SquadId = table.Column<int>(type: "integer", nullable: false),
                    SquadApplicationStatus = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SquadProjectParticipation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SquadProjectParticipation_Squads_SquadId",
                        column: x => x.SquadId,
                        principalSchema: "bousSOle",
                        principalTable: "Squads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SquadProjectParticipation_WorkProjectImplementation_WorkPro~",
                        column: x => x.WorkProjectImplementationId,
                        principalSchema: "bousSOle",
                        principalTable: "WorkProjectImplementation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CalculatedFactWork",
                schema: "bousSOle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FactWorkId = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<float>(type: "real", nullable: false),
                    ElementNormId = table.Column<int>(type: "integer", nullable: true),
                    Distance = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalculatedFactWork", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CalculatedFactWork_ElementNorms_ElementNormId",
                        column: x => x.ElementNormId,
                        principalSchema: "bousSOle",
                        principalTable: "ElementNorms",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CalculatedFactWork_FactWorks_FactWorkId",
                        column: x => x.FactWorkId,
                        principalSchema: "bousSOle",
                        principalTable: "FactWorks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlanWorks",
                schema: "bousSOle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    SquadMemberId = table.Column<int>(type: "integer", nullable: false),
                    WorkerActivityStatus = table.Column<int>(type: "integer", nullable: false),
                    WorkHours = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanWorks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanWorks_SquadMembers_SquadMemberId",
                        column: x => x.SquadMemberId,
                        principalSchema: "bousSOle",
                        principalTable: "SquadMembers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SquadMemberWorkingDay",
                schema: "bousSOle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SquadMemberId = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    WorkerActivityStatus = table.Column<string>(type: "text", nullable: false),
                    WorkingHours = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SquadMemberWorkingDay", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SquadMemberWorkingDay_SquadMembers_SquadMemberId",
                        column: x => x.SquadMemberId,
                        principalSchema: "bousSOle",
                        principalTable: "SquadMembers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SquadMemberWorkTimeSchedule",
                schema: "bousSOle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SquadMemberId = table.Column<int>(type: "integer", nullable: false),
                    WorkDays = table.Column<float>(type: "real", nullable: false),
                    ChillDays = table.Column<float>(type: "real", nullable: false),
                    WorkStartDay = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SquadMemberWorkTimeSchedule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SquadMemberWorkTimeSchedule_SquadMembers_SquadMemberId",
                        column: x => x.SquadMemberId,
                        principalSchema: "bousSOle",
                        principalTable: "SquadMembers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SquadAdditionalCoefficientParticipation",
                schema: "bousSOle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SquadProjectParticipationId = table.Column<int>(type: "integer", nullable: false),
                    AdditionalCoefficientId = table.Column<int>(type: "integer", nullable: false),
                    RatingPoints = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SquadAdditionalCoefficientParticipation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SquadAdditionalCoefficientParticipation_AdditionalCoefficie~",
                        column: x => x.AdditionalCoefficientId,
                        principalSchema: "bousSOle",
                        principalTable: "AdditionalCoefficient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SquadAdditionalCoefficientParticipation_SquadProjectPartici~",
                        column: x => x.SquadProjectParticipationId,
                        principalSchema: "bousSOle",
                        principalTable: "SquadProjectParticipation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SquadEventParticipation",
                schema: "bousSOle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SquadProjectParticipationId = table.Column<int>(type: "integer", nullable: false),
                    ProjectEventId = table.Column<int>(type: "integer", nullable: false),
                    ActivityCoefficientId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SquadEventParticipation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SquadEventParticipation_ActivityCoefficient_ActivityCoeffic~",
                        column: x => x.ActivityCoefficientId,
                        principalSchema: "bousSOle",
                        principalTable: "ActivityCoefficient",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SquadEventParticipation_ProjectEvent_ProjectEventId",
                        column: x => x.ProjectEventId,
                        principalSchema: "bousSOle",
                        principalTable: "ProjectEvent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SquadEventParticipation_SquadProjectParticipation_SquadProj~",
                        column: x => x.SquadProjectParticipationId,
                        principalSchema: "bousSOle",
                        principalTable: "SquadProjectParticipation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityCoefficient_WorkProjectImplementationId",
                schema: "bousSOle",
                table: "ActivityCoefficient",
                column: "WorkProjectImplementationId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalCoefficient_WorkProjectImplementationId",
                schema: "bousSOle",
                table: "AdditionalCoefficient",
                column: "WorkProjectImplementationId");

            migrationBuilder.CreateIndex(
                name: "IX_CalculatedFactWork_ElementNormId",
                schema: "bousSOle",
                table: "CalculatedFactWork",
                column: "ElementNormId");

            migrationBuilder.CreateIndex(
                name: "IX_CalculatedFactWork_FactWorkId",
                schema: "bousSOle",
                table: "CalculatedFactWork",
                column: "FactWorkId");

            migrationBuilder.CreateIndex(
                name: "IX_DisciplineCoefficient_WorkProjectImplementationId",
                schema: "bousSOle",
                table: "DisciplineCoefficient",
                column: "WorkProjectImplementationId");

            migrationBuilder.CreateIndex(
                name: "IX_Education_InstitutionId",
                schema: "bousSOle",
                table: "Education",
                column: "InstitutionId");

            migrationBuilder.CreateIndex(
                name: "IX_Education_PersonId",
                schema: "bousSOle",
                table: "Education",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_FactWorks_ElementNormId",
                schema: "bousSOle",
                table: "FactWorks",
                column: "ElementNormId");

            migrationBuilder.CreateIndex(
                name: "IX_FactWorks_SquadId",
                schema: "bousSOle",
                table: "FactWorks",
                column: "SquadId");

            migrationBuilder.CreateIndex(
                name: "IX_Institutions_ShtabId",
                schema: "bousSOle",
                table: "Institutions",
                column: "ShtabId");

            migrationBuilder.CreateIndex(
                name: "IX_Passport_PersonId",
                schema: "bousSOle",
                table: "Passport",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonMerch_PersonId",
                schema: "bousSOle",
                table: "PersonMerch",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanWorks_SquadMemberId",
                schema: "bousSOle",
                table: "PlanWorks",
                column: "SquadMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductivityCoefficient_WorkProjectImplementationId",
                schema: "bousSOle",
                table: "ProductivityCoefficient",
                column: "WorkProjectImplementationId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionalEducation_PersonId",
                schema: "bousSOle",
                table: "ProfessionalEducation",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectEvent_WorkProjectImplementationId",
                schema: "bousSOle",
                table: "ProjectEvent",
                column: "WorkProjectImplementationId");

            migrationBuilder.CreateIndex(
                name: "IX_Region_OkrugId",
                schema: "bousSOle",
                table: "Region",
                column: "OkrugId");

            migrationBuilder.CreateIndex(
                name: "IX_Shtab_ParentShtabId",
                schema: "bousSOle",
                table: "Shtab",
                column: "ParentShtabId");

            migrationBuilder.CreateIndex(
                name: "IX_Shtab_RegionId",
                schema: "bousSOle",
                table: "Shtab",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_ShtabMember_PersonId",
                schema: "bousSOle",
                table: "ShtabMember",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_ShtabMember_ShtabId",
                schema: "bousSOle",
                table: "ShtabMember",
                column: "ShtabId");

            migrationBuilder.CreateIndex(
                name: "IX_SquadAdditionalCoefficientParticipation_AdditionalCoefficie~",
                schema: "bousSOle",
                table: "SquadAdditionalCoefficientParticipation",
                column: "AdditionalCoefficientId");

            migrationBuilder.CreateIndex(
                name: "IX_SquadAdditionalCoefficientParticipation_SquadProjectPartici~",
                schema: "bousSOle",
                table: "SquadAdditionalCoefficientParticipation",
                column: "SquadProjectParticipationId");

            migrationBuilder.CreateIndex(
                name: "IX_SquadEventParticipation_ActivityCoefficientId",
                schema: "bousSOle",
                table: "SquadEventParticipation",
                column: "ActivityCoefficientId");

            migrationBuilder.CreateIndex(
                name: "IX_SquadEventParticipation_ProjectEventId",
                schema: "bousSOle",
                table: "SquadEventParticipation",
                column: "ProjectEventId");

            migrationBuilder.CreateIndex(
                name: "IX_SquadEventParticipation_SquadProjectParticipationId",
                schema: "bousSOle",
                table: "SquadEventParticipation",
                column: "SquadProjectParticipationId");

            migrationBuilder.CreateIndex(
                name: "IX_SquadMembers_PersonId",
                schema: "bousSOle",
                table: "SquadMembers",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_SquadMembers_SquadId",
                schema: "bousSOle",
                table: "SquadMembers",
                column: "SquadId");

            migrationBuilder.CreateIndex(
                name: "IX_SquadMemberWorkingDay_SquadMemberId",
                schema: "bousSOle",
                table: "SquadMemberWorkingDay",
                column: "SquadMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_SquadMemberWorkTimeSchedule_SquadMemberId",
                schema: "bousSOle",
                table: "SquadMemberWorkTimeSchedule",
                column: "SquadMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_SquadProjectParticipation_SquadId",
                schema: "bousSOle",
                table: "SquadProjectParticipation",
                column: "SquadId");

            migrationBuilder.CreateIndex(
                name: "IX_SquadProjectParticipation_WorkProjectImplementationId",
                schema: "bousSOle",
                table: "SquadProjectParticipation",
                column: "WorkProjectImplementationId");

            migrationBuilder.CreateIndex(
                name: "IX_Squads_ShtabId",
                schema: "bousSOle",
                table: "Squads",
                column: "ShtabId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PersonId",
                schema: "bousSOle",
                table: "Users",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkProjectImplementation_WorkProjectId",
                schema: "bousSOle",
                table: "WorkProjectImplementation",
                column: "WorkProjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CalculatedFactWork",
                schema: "bousSOle");

            migrationBuilder.DropTable(
                name: "DisciplineCoefficient",
                schema: "bousSOle");

            migrationBuilder.DropTable(
                name: "Education",
                schema: "bousSOle");

            migrationBuilder.DropTable(
                name: "Passport",
                schema: "bousSOle");

            migrationBuilder.DropTable(
                name: "PersonMerch",
                schema: "bousSOle");

            migrationBuilder.DropTable(
                name: "PlanWorks",
                schema: "bousSOle");

            migrationBuilder.DropTable(
                name: "ProductivityCoefficient",
                schema: "bousSOle");

            migrationBuilder.DropTable(
                name: "ProfessionalEducation",
                schema: "bousSOle");

            migrationBuilder.DropTable(
                name: "ShtabMember",
                schema: "bousSOle");

            migrationBuilder.DropTable(
                name: "SquadAdditionalCoefficientParticipation",
                schema: "bousSOle");

            migrationBuilder.DropTable(
                name: "SquadEventParticipation",
                schema: "bousSOle");

            migrationBuilder.DropTable(
                name: "SquadMemberWorkingDay",
                schema: "bousSOle");

            migrationBuilder.DropTable(
                name: "SquadMemberWorkTimeSchedule",
                schema: "bousSOle");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "bousSOle");

            migrationBuilder.DropTable(
                name: "FactWorks",
                schema: "bousSOle");

            migrationBuilder.DropTable(
                name: "Institutions",
                schema: "bousSOle");

            migrationBuilder.DropTable(
                name: "AdditionalCoefficient",
                schema: "bousSOle");

            migrationBuilder.DropTable(
                name: "ActivityCoefficient",
                schema: "bousSOle");

            migrationBuilder.DropTable(
                name: "ProjectEvent",
                schema: "bousSOle");

            migrationBuilder.DropTable(
                name: "SquadProjectParticipation",
                schema: "bousSOle");

            migrationBuilder.DropTable(
                name: "SquadMembers",
                schema: "bousSOle");

            migrationBuilder.DropTable(
                name: "ElementNorms",
                schema: "bousSOle");

            migrationBuilder.DropTable(
                name: "WorkProjectImplementation",
                schema: "bousSOle");

            migrationBuilder.DropTable(
                name: "Persons",
                schema: "bousSOle");

            migrationBuilder.DropTable(
                name: "Squads",
                schema: "bousSOle");

            migrationBuilder.DropTable(
                name: "WorkProject",
                schema: "bousSOle");

            migrationBuilder.DropTable(
                name: "Shtab",
                schema: "bousSOle");

            migrationBuilder.DropTable(
                name: "Region",
                schema: "bousSOle");

            migrationBuilder.DropTable(
                name: "Okrug",
                schema: "bousSOle");
        }
    }
}
