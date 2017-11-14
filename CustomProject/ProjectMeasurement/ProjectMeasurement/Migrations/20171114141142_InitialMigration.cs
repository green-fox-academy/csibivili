using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProjectMeasurement.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectName);
                });

            migrationBuilder.CreateTable(
                name: "ProjectMembers",
                columns: table => new
                {
                    EmailAddress = table.Column<string>(nullable: false),
                    ProjectName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectMembers", x => x.EmailAddress);
                    table.ForeignKey(
                        name: "FK_ProjectMembers_Projects_ProjectName",
                        column: x => x.ProjectName,
                        principalTable: "Projects",
                        principalColumn: "ProjectName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTasks",
                columns: table => new
                {
                    TaskId = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ProjectMemberEmailAddress = table.Column<string>(nullable: true),
                    ProjectName = table.Column<string>(nullable: true),
                    TaskName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTasks", x => x.TaskId);
                    table.ForeignKey(
                        name: "FK_ProjectTasks_ProjectMembers_ProjectMemberEmailAddress",
                        column: x => x.ProjectMemberEmailAddress,
                        principalTable: "ProjectMembers",
                        principalColumn: "EmailAddress",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectTasks_Projects_ProjectName",
                        column: x => x.ProjectName,
                        principalTable: "Projects",
                        principalColumn: "ProjectName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Measurements",
                columns: table => new
                {
                    MeasurementId = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    End = table.Column<DateTime>(nullable: true),
                    ProjectMemberEmailAddress = table.Column<string>(nullable: true),
                    ProjectTaskTaskId = table.Column<long>(nullable: true),
                    Start = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Measurements", x => x.MeasurementId);
                    table.ForeignKey(
                        name: "FK_Measurements_ProjectMembers_ProjectMemberEmailAddress",
                        column: x => x.ProjectMemberEmailAddress,
                        principalTable: "ProjectMembers",
                        principalColumn: "EmailAddress",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Measurements_ProjectTasks_ProjectTaskTaskId",
                        column: x => x.ProjectTaskTaskId,
                        principalTable: "ProjectTasks",
                        principalColumn: "TaskId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Measurements_ProjectMemberEmailAddress",
                table: "Measurements",
                column: "ProjectMemberEmailAddress");

            migrationBuilder.CreateIndex(
                name: "IX_Measurements_ProjectTaskTaskId",
                table: "Measurements",
                column: "ProjectTaskTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectMembers_ProjectName",
                table: "ProjectMembers",
                column: "ProjectName");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTasks_ProjectMemberEmailAddress",
                table: "ProjectTasks",
                column: "ProjectMemberEmailAddress");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTasks_ProjectName",
                table: "ProjectTasks",
                column: "ProjectName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Measurements");

            migrationBuilder.DropTable(
                name: "ProjectTasks");

            migrationBuilder.DropTable(
                name: "ProjectMembers");

            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
