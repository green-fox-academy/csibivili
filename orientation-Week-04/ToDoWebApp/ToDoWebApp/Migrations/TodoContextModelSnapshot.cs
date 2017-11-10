﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ToDoWebApp;

namespace ToDoWebApp.Migrations
{
    [DbContext(typeof(TodoContext))]
    partial class TodoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "1.1.3");

            modelBuilder.Entity("ToDoWebApp.Models.Todo", b =>
                {
                    b.Property<int?>("TodoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.Property<int?>("UserId");

                    b.HasKey("TodoId");

                    b.HasIndex("UserId");

                    b.ToTable("Todos");
                });

            modelBuilder.Entity("ToDoWebApp.Models.User", b =>
                {
                    b.Property<int?>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("UserName");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ToDoWebApp.Models.Todo", b =>
                {
                    b.HasOne("ToDoWebApp.Models.User", "User")
                        .WithMany("Todos")
                        .HasForeignKey("UserId");
                });
        }
    }
}
