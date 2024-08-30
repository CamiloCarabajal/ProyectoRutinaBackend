using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ExerciseService : IExerciseService
    {
        private readonly IExerciseRepository _exerciseRepository;
        public ExerciseService(IExerciseRepository exerciseRepository) 
        {
            _exerciseRepository = exerciseRepository;
        }

        public List<Exercise> GetAll() 
        {
            return _exerciseRepository.Get();
        }
    }
}
