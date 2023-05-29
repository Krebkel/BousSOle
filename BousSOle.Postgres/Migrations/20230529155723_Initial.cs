using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BousSOle.Postgres.Migrations
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
                    NormType = table.Column<string>(type: "text", nullable: false),
                    DistanceNorm = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElementNorms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Institutions",
                schema: "bousSOle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ShortName = table.Column<string>(type: "text", nullable: false),
                    FullName = table.Column<string>(type: "text", nullable: false),
                    AdministratorTitle = table.Column<string>(type: "text", nullable: false),
                    AdministratorName = table.Column<string>(type: "text", nullable: false),
                    StructWebsite = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Institutions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                schema: "bousSOle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Squads",
                schema: "bousSOle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Region = table.Column<string>(type: "text", nullable: false),
                    VkUrl = table.Column<string>(type: "text", nullable: false),
                    InstitutionId = table.Column<int>(type: "integer", nullable: false),
                    SquadType = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Squads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Squads_Institutions_InstitutionId",
                        column: x => x.InstitutionId,
                        principalSchema: "bousSOle",
                        principalTable: "Institutions",
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
                    Distance = table.Column<int>(type: "integer", nullable: true),
                    Quantity = table.Column<float>(type: "real", nullable: false)
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
                name: "PlanWorks",
                schema: "bousSOle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    SquadMemberId = table.Column<int>(type: "integer", nullable: false),
                    WorkerActivityStatus = table.Column<string>(type: "text", nullable: false),
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
                name: "IX_PlanWorks_SquadMemberId",
                schema: "bousSOle",
                table: "PlanWorks",
                column: "SquadMemberId");

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
                name: "IX_Squads_InstitutionId",
                schema: "bousSOle",
                table: "Squads",
                column: "InstitutionId");
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
