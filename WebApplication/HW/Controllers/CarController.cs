using Microsoft.AspNetCore.Mvc;
using HW.Repositories;
using HW.Entities.BAL;

namespace HW.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CarController : ControllerBase
    {

        private readonly ILogger<CarController> _logger;
        private readonly CarRepository _carRepository;

        public CarController(ILogger<CarController> logger)
        {
            _logger = logger;
            _carRepository = new CarRepository();
        }

        [HttpGet]
        public IEnumerable<CarBrief> GetCars()
        {
            return _carRepository.CarsGet();
        }

    }
}