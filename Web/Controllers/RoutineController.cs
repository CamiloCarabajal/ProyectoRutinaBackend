using Application.Interfaces;
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
        public ActionResult List<Routine> GetAll()
        {
            return Ok(_routineService.GetAll());
        }
    }
}
