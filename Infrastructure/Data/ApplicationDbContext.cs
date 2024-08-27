using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        private readonly bool isTestingEnvironment;
        public DbSet<Routine> Routines { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Machine> Machines { get; set; }
        public DbSet<RoutineExercise> RoutineExercises { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, bool isTestingEnvironment = false) : base(options)
        {
            this.isTestingEnvironment = isTestingEnvironment;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<RoutineExercise>()
                .HasKey(re => new { re.RoutineId, re.ExerciseId });
            modelBuilder.Entity<RoutineExercise>()
                .HasOne(re => re.Routine)
                .WithMany(r => r.RoutineExercises)
                .HasForeignKey(re => re.RoutineId);
            modelBuilder.Entity<RoutineExercise>()
                .HasOne(re => re.Exercise)
                .WithMany(e => e.RoutineExercises)
                .HasForeignKey(re => re.ExerciseId);

            //Enttidad intermedai exercisemachine
            //
            //Maquina Si se usa o no

            modelBuilder.Entity<Exercise>().HasData(
                new Exercise
                {
                    Id=1,
                    Name = "Press de pecho",
                    Category = "Alta",
                    UseMachine = true,
                },
                new Exercise
                {
                    Id=2,
                    Name = "Curl de biceps",
                    Category = "Baja",
                    UseMachine = false,
                },
                  new Exercise
                  {
                      Id=3,
                      Name = "Sentadillas",
                      Category = "Baja",
                      UseMachine = true,
                  },
                    new Exercise
                    {
                        Id=4,
                        Name = "Abdominales",
                        Category = "Media",
                        UseMachine = false,
                    }
                );


        }


    }
}
