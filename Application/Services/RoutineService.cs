using Domain.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using Application.Models.Request;
using Application.Models;

namespace Application.Services
{
    public class RoutineService : IRoutineService
    {
        private readonly IRoutineRepository _routineRepository;
        public RoutineService(IRoutineRepository routineRepository)
        {
            _routineRepository = routineRepository;
        }

        public List<RoutineDto> GetAll() 
        {
            var routines = _routineRepository.Get();
            var routineDtos = routines.Select(r => new RoutineDto
            {
                Name = r.Name,
                Difficulty = r.Difficulty,
                Duration = r.Duration,
                RoutineExercises = r.RoutineExercises.Select(re => new ExerciseDto
                {
                    Name = re.Exercise.Name,
                    Category = re.Exercise.Name,
                    UseMachine = re.Exercise.UseMachine

                }).ToList()
            }).ToList();
            return routineDtos;

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
            };

             _routineRepository.AddRoutine(routine);
            return routineDto;
        }
        public void UpdateRoutine(RequestRoutineDto routineDto) 
        {
            var routine = new Routine
            {
                Name = routineDto.Name,
                Difficulty = routineDto.Difficulty,
                Duration = routineDto.Duration,
            };
            _routineRepository.UpdateRoutine(routine);
            
        }
    }
}
