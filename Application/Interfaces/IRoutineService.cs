using Application.Models;
using Application.Models.Request;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IRoutineService
    {
        public List<RoutineDto> GetAll();
        public Routine? GetById(int id);
        public void DeleteById(int id);
        public RequestRoutineDto AddRoutine(RequestRoutineDto routineDto);
        public void UpdateRoutine(Routine routine);
    }
}
