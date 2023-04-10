using Microsoft.AspNetCore.Mvc;
using HW.Repositories;
using HW.Entities;

namespace HW.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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
        [Route("GetCars")]
        public IEnumerable<Car> Get()
        {
            return _carRepository.CarsGet();
        }

    }
}