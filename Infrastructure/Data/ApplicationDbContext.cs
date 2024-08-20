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


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, bool isTestingEnvironment = false) : base(options)
        {
            this.isTestingEnvironment = isTestingEnvironment;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Routine>()
                .HasOne(o => o.Exercises)
                .WithMany()
                .HasForeignKey(l => l.ExerciseId);

            modelBuilder.Entity<Exercise>().HasData(
                new Exercise
                {
                    Name = "Press de pecho",
                    Category = "Alta",
                    UseMachine = true,
                },
                new Exercise
                {
                    Name = "Curl de biceps",
                    Category = "Baja",
                    UseMachine = false,
                },
                  new Exercise
                  {
                      Name = "Sentadillas",
                      Category = "Baja",
                      UseMachine = true,
                  },
                    new Exercise
                    {
                        Name = "Abdominales",
                        Category = "Media",
                        UseMachine = false,
                    }
                );


        }


    }
}
