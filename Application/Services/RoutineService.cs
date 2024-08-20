using Domain.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class RoutineService
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
        public Routine AddRoutine(Routine routine) 
        {
            return _routineRepository.AddRoutine(routine);
        }
        public void UpdateRoutine(Routine routine) 
        {
            _routineRepository.UpdateRoutine(routine);
        }
    }
}
