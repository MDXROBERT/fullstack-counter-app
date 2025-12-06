using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CounterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class F1CarsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public F1CarsController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<List<F1Car>> GetAllCars()
        {
            var cars = _context.F1Cars.ToList();
            return cars;
        }

        [HttpPut]
        p

    }
}
