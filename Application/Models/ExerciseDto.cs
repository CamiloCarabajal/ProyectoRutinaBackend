using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class ExerciseDto
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public bool? UseMachine { get; set; }
    }
}
