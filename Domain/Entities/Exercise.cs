using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Exercise
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
        // public Machine? MachineInUse { get; set; } // Relacion con Maquina
        public bool? UseMachine { get; set; }

        public ICollection<RoutineExercise> RoutineExercises { get; set; }
    }
}
