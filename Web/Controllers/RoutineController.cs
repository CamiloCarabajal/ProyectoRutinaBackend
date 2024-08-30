using Application.Interfaces;
using Application.Models;
using Application.Models.Request;
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
        public ActionResult<ICollection<RoutineDto>> GetRoutines() 
        {
            var routinesDto = _routineService.GetAll(); 
            return routinesDto;
        }

        [HttpGet("id")]
        public Routine GetRoutine(int id) 
        {
            var routine= _routineService.GetById(id);
            return routine;
        }
        [HttpPost]
        public void PostRoutine(RequestRoutineDto routineDto) 
        {

            _routineService.AddRoutine(routineDto);
        }
        [HttpPut]
        public void PutRoutine(Routine routine) 
        {
            _routineService.UpdateRoutine(routine);
        }
        [HttpDelete]
        public void DeleteRoutine(int id) 
        {
            _routineService.DeleteById(id);
        }
    }
}
