START TRANSACTION;

DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM pg_namespace WHERE nspname = 'boussole') THEN
CREATE SCHEMA "boussole";
END IF;
END $EF$;
    
CREATE TABLE IF NOT EXISTS boussole."__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL,
    CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId")
    );

CREATE TABLE boussole."ElementNorms" (
                                           "Id" integer GENERATED BY DEFAULT AS IDENTITY,
                                           "NormCollection" text NOT NULL,
                                           "NormCode" text NOT NULL,
                                           "NormName" text NOT NULL,
                                           "MeasurementUnit" text NOT NULL,
                                           "BaseNorm" real NOT NULL,
                                           "NormType" text NOT NULL,
                                           "DistanceNorm" real NULL,
                                           CONSTRAINT "PK_ElementNorms" PRIMARY KEY ("Id")
);

CREATE TABLE boussole."Institutions" (
                                           "Id" integer GENERATED BY DEFAULT AS IDENTITY,
                                           "ShortName" text NOT NULL,
                                           "FullName" text NOT NULL,
                                           "AdministratorTitle" text NOT NULL,
                                           "AdministratorName" text NOT NULL,
                                           "StructWebsite" text NOT NULL,
                                           CONSTRAINT "PK_Institutions" PRIMARY KEY ("Id")
);

CREATE TABLE boussole."Persons" (
                                      "Id" integer GENERATED BY DEFAULT AS IDENTITY,
                                      "Name" text NOT NULL,
                                      "PhoneNumber" text NOT NULL,
                                      CONSTRAINT "PK_Persons" PRIMARY KEY ("Id")
);

CREATE TABLE boussole."Squads" (
                                     "Id" integer GENERATED BY DEFAULT AS IDENTITY,
                                     "Name" text NOT NULL,
                                     "Region" text NOT NULL,
                                     "VkUrl" text NOT NULL,
                                     "InstitutionId" integer NOT NULL,
                                     "SquadType" text NOT NULL,
                                     CONSTRAINT "PK_Squads" PRIMARY KEY ("Id"),
                                     CONSTRAINT "FK_Squads_Institutions_InstitutionId" FOREIGN KEY ("InstitutionId") REFERENCES boussole."Institutions" ("Id") ON DELETE CASCADE
);

CREATE TABLE boussole."FactWorks" (
                                        "Id" integer GENERATED BY DEFAULT AS IDENTITY,
                                        "Date" timestamp with time zone NOT NULL,
                                        "SquadId" integer NOT NULL,
                                        "WorkName" text NOT NULL,
                                        "ElementNormId" integer NOT NULL,
                                        "Distance" integer NULL,
                                        "Quantity" real NOT NULL,
                                        CONSTRAINT "PK_FactWorks" PRIMARY KEY ("Id"),
                                        CONSTRAINT "FK_FactWorks_ElementNorms_ElementNormId" FOREIGN KEY ("ElementNormId") REFERENCES boussole."ElementNorms" ("Id") ON DELETE CASCADE,
                                        CONSTRAINT "FK_FactWorks_Squads_SquadId" FOREIGN KEY ("SquadId") REFERENCES boussole."Squads" ("Id") ON DELETE CASCADE
);

CREATE TABLE boussole."SquadMembers" (
                                           "Id" integer GENERATED BY DEFAULT AS IDENTITY,
                                           "PersonId" integer NOT NULL,
                                           "MemberRank" text NOT NULL,
                                           "YearEnlisted" integer NOT NULL,
                                           "IsActive" boolean NOT NULL,
                                           "SquadId" integer NOT NULL,
                                           CONSTRAINT "PK_SquadMembers" PRIMARY KEY ("Id"),
                                           CONSTRAINT "FK_SquadMembers_Persons_PersonId" FOREIGN KEY ("PersonId") REFERENCES boussole."Persons" ("Id") ON DELETE CASCADE,
                                           CONSTRAINT "FK_SquadMembers_Squads_SquadId" FOREIGN KEY ("SquadId") REFERENCES boussole."Squads" ("Id") ON DELETE CASCADE
);

CREATE TABLE boussole."PlanWorks" (
                                        "Id" integer GENERATED BY DEFAULT AS IDENTITY,
                                        "Date" timestamp with time zone NOT NULL,
                                        "SquadMemberId" integer NOT NULL,
                                        "WorkerActivityStatus" text NOT NULL,
                                        "WorkHours" real NOT NULL,
                                        CONSTRAINT "PK_PlanWorks" PRIMARY KEY ("Id"),
                                        CONSTRAINT "FK_PlanWorks_SquadMembers_SquadMemberId" FOREIGN KEY ("SquadMemberId") REFERENCES boussole."SquadMembers" ("Id") ON DELETE CASCADE
);

CREATE INDEX "IX_FactWorks_ElementNormId" ON boussole."FactWorks" ("ElementNormId");

CREATE INDEX "IX_FactWorks_SquadId" ON boussole."FactWorks" ("SquadId");

CREATE INDEX "IX_PlanWorks_SquadMemberId" ON boussole."PlanWorks" ("SquadMemberId");

CREATE INDEX "IX_SquadMembers_PersonId" ON boussole."SquadMembers" ("PersonId");

CREATE INDEX "IX_SquadMembers_SquadId" ON boussole."SquadMembers" ("SquadId");

CREATE INDEX "IX_Squads_InstitutionId" ON boussole."Squads" ("InstitutionId");

INSERT INTO boussole."__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20230529155723_Initial', '7.0.0');

COMMIT;
