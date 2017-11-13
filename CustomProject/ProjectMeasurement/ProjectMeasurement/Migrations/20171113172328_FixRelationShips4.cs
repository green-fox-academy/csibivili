using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectMeasurement.Migrations
{
    public partial class FixRelationShips4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectMembers_Projects_ProjectId1",
                table: "ProjectMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTasks_Projects_ProjectId1",
                table: "ProjectTasks");

            migrationBuilder.DropIndex(
                name: "IX_ProjectTasks_ProjectId1",
                table: "ProjectTasks");

            migrationBuilder.DropIndex(
                name: "IX_ProjectMembers_ProjectId1",
                table: "ProjectMembers");

            migrationBuilder.DropColumn(
                name: "ProjectId1",
                table: "ProjectTasks");

            migrationBuilder.DropColumn(
                name: "ProjectId1",
                table: "ProjectMembers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ProjectId1",
                table: "ProjectTasks",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ProjectId1",
                table: "ProjectMembers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTasks_ProjectId1",
                table: "ProjectTasks",
                column: "ProjectId1");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectMembers_ProjectId1",
                table: "ProjectMembers",
                column: "ProjectId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectMembers_Projects_ProjectId1",
                table: "ProjectMembers",
                column: "ProjectId1",
                principalTable: "Projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectTasks_Projects_ProjectId1",
                table: "ProjectTasks",
                column: "ProjectId1",
                principalTable: "Projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
