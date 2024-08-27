﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("Domain.Entities.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("UseMachine")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Exercises");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Alta",
                            Name = "Press de pecho",
                            UseMachine = true
                        },
                        new
                        {
                            Id = 2,
                            Category = "Baja",
                            Name = "Curl de biceps",
                            UseMachine = false
                        },
                        new
                        {
                            Id = 3,
                            Category = "Baja",
                            Name = "Sentadillas",
                            UseMachine = true
                        },
                        new
                        {
                            Id = 4,
                            Category = "Media",
                            Name = "Abdominales",
                            UseMachine = false
                        });
                });

            modelBuilder.Entity("Domain.Entities.Machine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Machines");
                });

            modelBuilder.Entity("Domain.Entities.Routine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Difficulty")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Routines");
                });

            modelBuilder.Entity("Domain.Entities.RoutineExercise", b =>
                {
                    b.Property<int>("RoutineId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ExerciseId")
                        .HasColumnType("INTEGER");

                    b.HasKey("RoutineId", "ExerciseId");

                    b.HasIndex("ExerciseId");

                    b.ToTable("RoutineExercises");
                });

            modelBuilder.Entity("Domain.Entities.RoutineExercise", b =>
                {
                    b.HasOne("Domain.Entities.Exercise", "Exercise")
                        .WithMany("RoutineExercises")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Routine", "Routine")
                        .WithMany("RoutineExercises")
                        .HasForeignKey("RoutineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise");

                    b.Navigation("Routine");
                });

            modelBuilder.Entity("Domain.Entities.Exercise", b =>
                {
                    b.Navigation("RoutineExercises");
                });

            modelBuilder.Entity("Domain.Entities.Routine", b =>
                {
                    b.Navigation("RoutineExercises");
                });
#pragma warning restore 612, 618
        }
    }
}
