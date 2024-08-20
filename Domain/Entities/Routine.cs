﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Routine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Difficulty { get; set; }
        public string Duration { get; set; }

        [ForeignKey("ExerciseId")]
        public int ExerciseId { get; set; }
        public ICollection<Exercise> Exercises { get; set; } // Relacion con Ejercicio
    }
}
