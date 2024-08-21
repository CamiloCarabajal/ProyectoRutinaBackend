using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoutineController : ControllerBase
    {
        private readonly IRoutineService _routineService;
        public RoutineController(IRoutineService routineService)
        {
           _routineService = routineService;
        }

        [HttpGet]
        public List<Routine> GetRoutines() 
        {
            var routines = _routineService.GetAll(); 
            return routines;
        }

        [HttpGet("id")]
        public Routine GetRoutine(int id) 
        {
            var routine= _routineService.GetById(id);
            return routine;
        }
        [HttpPost]
        public void PostRoutine(Routine routine) 
        {
            _routineService.AddRoutine(routine);
        }
        [HttpPut]
        public void PutRoutine(Routine routine) 
        {
            _routineService.AddRoutine(routine);
        }
        [HttpDelete]
        public void DeleteRoutine(int id) 
        {
            _routineService.DeleteById(id);
        }
    }
}
