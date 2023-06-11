using System;
using Microsoft.EntityFrameworkCore.Migrations;

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
                    table.PrimaryKey("PK_ElementNorms", x => new { x.NormCollection, x.NormCode });
                });

            migrationBuilder.CreateTable(
                name: "Institutions",
                schema: "bousSOle",
                columns: table => new
                {
                    FullName = table.Column<string>(type: "text", nullable: false),
                    ShortName = table.Column<string>(type: "text", nullable: false),
                    AdministratorTitle = table.Column<string>(type: "text", nullable: false),
                    AdministratorSurname = table.Column<string>(type: "text", nullable: false),
                    AdministratorName = table.Column<string>(type: "text", nullable: false),
                    AdministratorPatronymic = table.Column<string>(type: "text", nullable: false),
                    StructWebsite = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Institutions", x => x.FullName);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                schema: "bousSOle",
                columns: table => new
                {
                    PersonInn = table.Column<string>(type: "text", nullable: false),
                    Surname = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Patronymic = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    EMail = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.PersonInn);
                });

            migrationBuilder.CreateTable(
                name: "Squads",
                schema: "bousSOle",
                columns: table => new
                {
                    Name = table.Column<string>(type: "text", nullable: false),
                    Region = table.Column<string>(type: "text", nullable: false),
                    VkUrl = table.Column<string>(type: "text", nullable: false),
                    InstitutionFullName = table.Column<string>(type: "text", nullable: false),
                    SquadType = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Squads", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Squads_Institutions_InstitutionFullName",
                        column: x => x.InstitutionFullName,
                        principalSchema: "bousSOle",
                        principalTable: "Institutions",
                        principalColumn: "FullName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "bousSOle",
                columns: table => new
                {
                    PersonInn = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.PersonInn);
                    table.ForeignKey(
                        name: "FK_User_Persons_PersonInn",
                        column: x => x.PersonInn,
                        principalSchema: "bousSOle",
                        principalTable: "Persons",
                        principalColumn: "PersonInn",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FactWorks",
                schema: "bousSOle",
                columns: table => new
                {
                    Date = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    SquadName = table.Column<string>(type: "text", nullable: false),
                    NormCollection = table.Column<string>(type: "text", nullable: false),
                    NormCode = table.Column<string>(type: "text", nullable: false),
                    WorkName = table.Column<string>(type: "text", nullable: false),
                    Distance = table.Column<int>(type: "integer", nullable: true),
                    Quantity = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactWorks", x => new { x.Date, x.SquadName, x.NormCollection, x.NormCode });
                    table.ForeignKey(
                        name: "FK_FactWorks_ElementNorms_NormCollection_NormCode",
                        columns: x => new { x.NormCollection, x.NormCode },
                        principalSchema: "bousSOle",
                        principalTable: "ElementNorms",
                        principalColumns: new[] { "NormCollection", "NormCode" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FactWorks_Squads_SquadName",
                        column: x => x.SquadName,
                        principalSchema: "bousSOle",
                        principalTable: "Squads",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SquadMembers",
                schema: "bousSOle",
                columns: table => new
                {
                    PersonInn = table.Column<string>(type: "text", nullable: false),
                    MemberRank = table.Column<string>(type: "text", nullable: false),
                    YearEnlisted = table.Column<int>(type: "integer", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    SquadName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SquadMembers", x => x.PersonInn);
                    table.ForeignKey(
                        name: "FK_SquadMembers_Persons_PersonInn",
                        column: x => x.PersonInn,
                        principalSchema: "bousSOle",
                        principalTable: "Persons",
                        principalColumn: "PersonInn",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SquadMembers_Squads_SquadName",
                        column: x => x.SquadName,
                        principalSchema: "bousSOle",
                        principalTable: "Squads",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlanWorks",
                schema: "bousSOle",
                columns: table => new
                {
                    Date = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    SquadMemberPersonInn = table.Column<string>(type: "text", nullable: false),
                    WorkerActivityStatus = table.Column<string>(type: "text", nullable: false),
                    WorkHours = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanWorks", x => new { x.Date, x.SquadMemberPersonInn });
                    table.ForeignKey(
                        name: "FK_PlanWorks_SquadMembers_SquadMemberPersonInn",
                        column: x => x.SquadMemberPersonInn,
                        principalSchema: "bousSOle",
                        principalTable: "SquadMembers",
                        principalColumn: "PersonInn",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FactWorks_NormCollection_NormCode",
                schema: "bousSOle",
                table: "FactWorks",
                columns: new[] { "NormCollection", "NormCode" });

            migrationBuilder.CreateIndex(
                name: "IX_FactWorks_SquadName",
                schema: "bousSOle",
                table: "FactWorks",
                column: "SquadName");

            migrationBuilder.CreateIndex(
                name: "IX_PlanWorks_SquadMemberPersonInn",
                schema: "bousSOle",
                table: "PlanWorks",
                column: "SquadMemberPersonInn");

            migrationBuilder.CreateIndex(
                name: "IX_SquadMembers_SquadName",
                schema: "bousSOle",
                table: "SquadMembers",
                column: "SquadName");

            migrationBuilder.CreateIndex(
                name: "IX_Squads_InstitutionFullName",
                schema: "bousSOle",
                table: "Squads",
                column: "InstitutionFullName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FactWorks",
                schema: "bousSOle");

            migrationBuilder.DropTable(
                name: "PlanWorks",
                schema: "bousSOle");

            migrationBuilder.DropTable(
                name: "User",
                schema: "bousSOle");

            migrationBuilder.DropTable(
                name: "ElementNorms",
                schema: "bousSOle");

            migrationBuilder.DropTable(
                name: "SquadMembers",
                schema: "bousSOle");

            migrationBuilder.DropTable(
                name: "Persons",
                schema: "bousSOle");

            migrationBuilder.DropTable(
                name: "Squads",
                schema: "bousSOle");

            migrationBuilder.DropTable(
                name: "Institutions",
                schema: "bousSOle");
        }
    }
}
