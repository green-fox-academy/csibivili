using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ProjectMeasurement.Entities;

namespace ProjectMeasurement.Migrations
{
    [DbContext(typeof(MeasurementContext))]
    [Migration("20171115082517_RemoveVirtual")]
    partial class RemoveVirtual
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "1.1.3");

            modelBuilder.Entity("ProjectMeasurement.Models.Measurement", b =>
                {
                    b.Property<long>("MeasurementId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("End");

                    b.Property<string>("ProjectMemberEmailAddress");

                    b.Property<long?>("ProjectTaskTaskId");

                    b.Property<DateTime?>("Start");

                    b.HasKey("MeasurementId");

                    b.HasIndex("ProjectMemberEmailAddress");

                    b.HasIndex("ProjectTaskTaskId");

                    b.ToTable("Measurements");
                });

            modelBuilder.Entity("ProjectMeasurement.Models.Project", b =>
                {
                    b.Property<string>("ProjectName")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100);

                    b.HasKey("ProjectName");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("ProjectMeasurement.Models.ProjectMember", b =>
                {
                    b.Property<string>("EmailAddress")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ProjectName");

                    b.HasKey("EmailAddress");

                    b.HasIndex("ProjectName");

                    b.ToTable("ProjectMembers");
                });

            modelBuilder.Entity("ProjectMeasurement.Models.ProjectTask", b =>
                {
                    b.Property<long>("TaskId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ProjectMemberEmailAddress");

                    b.Property<string>("ProjectName");

                    b.Property<string>("TaskName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("TaskId");

                    b.HasIndex("ProjectMemberEmailAddress");

                    b.HasIndex("ProjectName");

                    b.ToTable("ProjectTasks");
                });

            modelBuilder.Entity("ProjectMeasurement.Models.Measurement", b =>
                {
                    b.HasOne("ProjectMeasurement.Models.ProjectMember", "ProjectMember")
                        .WithMany()
                        .HasForeignKey("ProjectMemberEmailAddress");

                    b.HasOne("ProjectMeasurement.Models.ProjectTask", "ProjectTask")
                        .WithMany()
                        .HasForeignKey("ProjectTaskTaskId");
                });

            modelBuilder.Entity("ProjectMeasurement.Models.ProjectMember", b =>
                {
                    b.HasOne("ProjectMeasurement.Models.Project", "Project")
                        .WithMany("ProjectMembers")
                        .HasForeignKey("ProjectName");
                });

            modelBuilder.Entity("ProjectMeasurement.Models.ProjectTask", b =>
                {
                    b.HasOne("ProjectMeasurement.Models.ProjectMember", "ProjectMember")
                        .WithMany("ProjectTasks")
                        .HasForeignKey("ProjectMemberEmailAddress");

                    b.HasOne("ProjectMeasurement.Models.Project", "Project")
                        .WithMany("ProjectTasks")
                        .HasForeignKey("ProjectName");
                });
        }
    }
}
