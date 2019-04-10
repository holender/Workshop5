﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Work3.Infrastructure;

namespace Work3.Infrastructure.Migrations
{
    [DbContext(typeof(StudentContext))]
    [Migration("20190403111121_AddStudentTable")]
    partial class AddStudentTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Work3.Core.Entities.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<Guid?>("SubjectId");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("Work3.Core.Entities.Subject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("SubjectName");

                    b.Property<Guid?>("TeacherId");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("Work3.Core.Entities.Teacher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TeacherName");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Work3.Core.Entities.Student", b =>
                {
                    b.HasOne("Work3.Core.Entities.Subject")
                        .WithMany("Students")
                        .HasForeignKey("SubjectId");
                });

            modelBuilder.Entity("Work3.Core.Entities.Subject", b =>
                {
                    b.HasOne("Work3.Core.Entities.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId");
                });
#pragma warning restore 612, 618
        }
    }
}