using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IRoutineRepository
    {
       public List<Routine> Get();
       public Routine? GetById(int id);
       public Routine AddRoutine(Routine routine);
       public void DeleteRoutine(int id);
       public void UpdateRoutine(Routine routine);

    }
}
