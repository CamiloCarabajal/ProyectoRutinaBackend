using Domain.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using Application.Models.Request;

namespace Application.Services
{
    public class RoutineService : IRoutineService
    {
        private readonly IRoutineRepository _routineRepository;
        public RoutineService(IRoutineRepository routineRepository)
        {
            _routineRepository = routineRepository;
        }

        public List<Routine> GetAll() 
        {
            return _routineRepository.Get();
        }
        public Routine? GetById(int id) 
        {
            return _routineRepository.GetById(id);
        }
        public void DeleteById(int id) 
        {
            _routineRepository.DeleteRoutine(id);
        }
        public RequestRoutineDto AddRoutine(RequestRoutineDto routineDto) 
        {
            var routine = new Routine
            {
                Name = routineDto.Name,
                Difficulty = routineDto.Difficulty,
                Duration = routineDto.Duration,
                RoutineExercises = routineDto.ExerciseId.Select(id => new RoutineExercise
                {
                    ExerciseId = id
                }).ToList()
            };

             _routineRepository.AddRoutine(routine);
            return routineDto;
        }
        public void UpdateRoutine(Routine routine) 
        {
            _routineRepository.UpdateRoutine(routine);
        }
    }
}
