using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ProjectMeasurement.Entities;

namespace ProjectMeasurement.Migrations
{
    [DbContext(typeof(ProjectMeasurementContext))]
    [Migration("20171113172053_FixRelationShips2")]
    partial class FixRelationShips2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjectMeasurement.Models.Project", b =>
                {
                    b.Property<long?>("ProjectId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("ProjectId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("ProjectMeasurement.Models.ProjectMember", b =>
                {
                    b.Property<long?>("MemberId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EmailAddress");

                    b.Property<long?>("ProjectId");

                    b.Property<long?>("ProjectId1");

                    b.HasKey("MemberId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("ProjectId1");

                    b.ToTable("ProjectMembers");
                });

            modelBuilder.Entity("ProjectMeasurement.Models.ProjectTask", b =>
                {
                    b.Property<long?>("TaskId")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("ProjectId");

                    b.Property<long?>("ProjectId1");

                    b.Property<long?>("ProjectMemberMemberId");

                    b.Property<string>("TaskName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("TaskId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("ProjectId1");

                    b.HasIndex("ProjectMemberMemberId");

                    b.ToTable("ProjectTasks");
                });

            modelBuilder.Entity("ProjectMeasurement.Models.ProjectMember", b =>
                {
                    b.HasOne("ProjectMeasurement.Models.Project", "Project")
                        .WithMany("ProjectMembers")
                        .HasForeignKey("ProjectId");

                    b.HasOne("ProjectMeasurement.Models.Project")
                        .WithMany()
                        .HasForeignKey("ProjectId1");
                });

            modelBuilder.Entity("ProjectMeasurement.Models.ProjectTask", b =>
                {
                    b.HasOne("ProjectMeasurement.Models.Project", "Project")
                        .WithMany("ProjectTasks")
                        .HasForeignKey("ProjectId");

                    b.HasOne("ProjectMeasurement.Models.Project")
                        .WithMany()
                        .HasForeignKey("ProjectId1");

                    b.HasOne("ProjectMeasurement.Models.ProjectMember", "ProjectMember")
                        .WithMany("ProjectTasks")
                        .HasForeignKey("ProjectMemberMemberId");
                });
        }
    }
}
