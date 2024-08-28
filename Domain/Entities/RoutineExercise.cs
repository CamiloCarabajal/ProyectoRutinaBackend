using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class RoutineExercise
    {

        public int RoutineId { get; set; }

        [JsonIgnore]
        public Routine Routine { get; set; }
        public int ExerciseId { get; set; }

        [JsonIgnore]
        public Exercise Exercise { get; set; }
    }
}
