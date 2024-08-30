using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Core;
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class RoutineRepository : IRoutineRepository
    {
        private readonly ApplicationDbContext _context;
        public RoutineRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Routine> Get()
        {
            //  return _context.Routines.ToList();
            return _context.Routines
                        .Include(r => r.RoutineExercises)
                        .ThenInclude(re => re.Exercise)
                        .ToList();
                        }

        public Routine? GetById(int id) 
        {
            return _context.Routines.FirstOrDefault(u => u.Id == id);
        }

        public Routine AddRoutine(Routine routine) 
        {
            _context.Routines.Add(routine);
            _context.SaveChanges();
            return routine;
        }

        public void DeleteRoutine(int id) 
        {
             var routine= _context.Routines.Find(id);
            if (routine != null)
            {
                _context.Routines.Remove(routine);
                _context.SaveChanges();
            }
        }
        public void UpdateRoutine(Routine routine) 
        {
            _context.Routines.Update(routine);
            _context.SaveChanges();
        }
    }
}
