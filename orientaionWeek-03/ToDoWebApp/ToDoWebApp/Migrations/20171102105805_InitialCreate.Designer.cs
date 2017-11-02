using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ToDoWebApp.Entities;

namespace ToDoWebApp.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20171102105805_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "1.1.3");

            modelBuilder.Entity("ToDoWebApp.Models.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsDone");

                    b.Property<bool>("IsUrgent");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Todos");
                });
        }
    }
}
