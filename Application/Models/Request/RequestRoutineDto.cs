using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Request
{
    public class RequestRoutineDto
    {
        public string Name { get; set; }
        public string Difficulty { get; set; }
        public string Duration { get; set; }

        public List<int> ExerciseId { get; set; }
    }
}
