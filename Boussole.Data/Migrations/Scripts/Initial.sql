START TRANSACTION;

DO $EF$
BEGIN
        IF NOT EXISTS(SELECT 1 FROM pg_namespace WHERE nspname = 'bousSOle') THEN
CREATE SCHEMA "bousSOle";
END IF;
END $EF$;
CREATE TABLE IF NOT EXISTS "bousSOle"."__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL,
    CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId")
    );

DO $EF$
BEGIN
        IF NOT EXISTS(SELECT 1 FROM pg_namespace WHERE nspname = 'bousSOle') THEN
CREATE SCHEMA "bousSOle";
END IF;
END $EF$;

CREATE TABLE "bousSOle"."ElementNorms" (
                                           "NormCollection" text NOT NULL,
                                           "NormCode" text NOT NULL,
                                           "NormName" text NOT NULL,
                                           "MeasurementUnit" text NOT NULL,
                                           "BaseNorm" real NOT NULL,
                                           "NormTypeByDistance" text NOT NULL,
                                           "DistanceNorm" real NULL,
                                           CONSTRAINT "PK_ElementNorms" PRIMARY KEY ("NormCollection", "NormCode")
);

CREATE TABLE "bousSOle"."Institutions" (
                                           "FullName" text NOT NULL,
                                           "ShortName" text NOT NULL,
                                           "AdministratorTitle" text NOT NULL,
                                           "AdministratorSurname" text NOT NULL,
                                           "AdministratorName" text NOT NULL,
                                           "AdministratorPatronymic" text NOT NULL,
                                           "StructWebsite" text NOT NULL,
                                           CONSTRAINT "PK_Institutions" PRIMARY KEY ("FullName")
);

CREATE TABLE "bousSOle"."Persons" (
                                      "PersonInn" text NOT NULL,
                                      "Surname" text NOT NULL,
                                      "Name" text NOT NULL,
                                      "Patronymic" text NOT NULL,
                                      "PhoneNumber" text NOT NULL,
                                      "EMail" text NOT NULL,
                                      CONSTRAINT "PK_Persons" PRIMARY KEY ("PersonInn")
);

CREATE TABLE "bousSOle"."Squads" (
                                     "Name" text NOT NULL,
                                     "Region" text NOT NULL,
                                     "VkUrl" text NOT NULL,
                                     "InstitutionFullName" text NOT NULL,
                                     "SquadType" text NOT NULL,
                                     CONSTRAINT "PK_Squads" PRIMARY KEY ("Name"),
                                     CONSTRAINT "FK_Squads_Institutions_InstitutionFullName" FOREIGN KEY ("InstitutionFullName") REFERENCES "bousSOle"."Institutions" ("FullName") ON DELETE CASCADE
);

CREATE TABLE "bousSOle"."Users" (
                                    "PersonInn" text NOT NULL,
                                    "Password" text NOT NULL,
                                    CONSTRAINT "PK_Users" PRIMARY KEY ("PersonInn"),
                                    CONSTRAINT "FK_Users_Persons_PersonInn" FOREIGN KEY ("PersonInn") REFERENCES "bousSOle"."Persons" ("PersonInn") ON DELETE CASCADE
);

CREATE TABLE "bousSOle"."FactWorks" (
                                        "Date" timestamp with time zone NOT NULL,
                                        "SquadName" text NOT NULL,
                                        "NormCollection" text NOT NULL,
                                        "NormCode" text NOT NULL,
                                        "WorkName" text NOT NULL,
                                        "Distance" integer NULL,
                                        "Quantity" real NOT NULL,
                                        CONSTRAINT "PK_FactWorks" PRIMARY KEY ("Date", "SquadName", "NormCollection", "NormCode"),
                                        CONSTRAINT "FK_FactWorks_ElementNorms_NormCollection_NormCode" FOREIGN KEY ("NormCollection", "NormCode") REFERENCES "bousSOle"."ElementNorms" ("NormCollection", "NormCode") ON DELETE CASCADE,
                                        CONSTRAINT "FK_FactWorks_Squads_SquadName" FOREIGN KEY ("SquadName") REFERENCES "bousSOle"."Squads" ("Name") ON DELETE CASCADE
);

CREATE TABLE "bousSOle"."SquadMembers" (
                                           "PersonInn" text NOT NULL,
                                           "MemberRank" text NOT NULL,
                                           "YearEnlisted" integer NOT NULL,
                                           "IsActive" boolean NOT NULL,
                                           "SquadName" text NOT NULL,
                                           CONSTRAINT "PK_SquadMembers" PRIMARY KEY ("PersonInn"),
                                           CONSTRAINT "FK_SquadMembers_Persons_PersonInn" FOREIGN KEY ("PersonInn") REFERENCES "bousSOle"."Persons" ("PersonInn") ON DELETE CASCADE,
                                           CONSTRAINT "FK_SquadMembers_Squads_SquadName" FOREIGN KEY ("SquadName") REFERENCES "bousSOle"."Squads" ("Name") ON DELETE CASCADE
);

CREATE TABLE "bousSOle"."PlanWorks" (
                                        "Date" timestamp with time zone NOT NULL,
                                        "SquadMemberPersonInn" text NOT NULL,
                                        "WorkerActivityStatus" text NOT NULL,
                                        "WorkHours" real NOT NULL,
                                        CONSTRAINT "PK_PlanWorks" PRIMARY KEY ("Date", "SquadMemberPersonInn"),
                                        CONSTRAINT "FK_PlanWorks_SquadMembers_SquadMemberPersonInn" FOREIGN KEY ("SquadMemberPersonInn") REFERENCES "bousSOle"."SquadMembers" ("PersonInn") ON DELETE CASCADE
);

CREATE INDEX "IX_FactWorks_NormCollection_NormCode" ON "bousSOle"."FactWorks" ("NormCollection", "NormCode");

CREATE INDEX "IX_FactWorks_SquadName" ON "bousSOle"."FactWorks" ("SquadName");

CREATE INDEX "IX_PlanWorks_SquadMemberPersonInn" ON "bousSOle"."PlanWorks" ("SquadMemberPersonInn");

CREATE INDEX "IX_SquadMembers_SquadName" ON "bousSOle"."SquadMembers" ("SquadName");

CREATE INDEX "IX_Squads_InstitutionFullName" ON "bousSOle"."Squads" ("InstitutionFullName");

INSERT INTO "bousSOle"."__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20230611121736_Initial', '7.0.0');

COMMIT;
