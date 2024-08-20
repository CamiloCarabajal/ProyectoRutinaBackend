﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IRoutineService
    {
        public List<Routine> GetAll();
        public Routine? GetById(int id);
        public void DeleteById(int id);
        public Routine AddRoutine(Routine routine);
        public void UpdateRoutine(Routine routine);
    }
}
