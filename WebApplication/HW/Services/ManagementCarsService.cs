using HW.Interfaces;
using HW.Repositories;
using System.Text.Json;

namespace HW.Services
{
    public class ManagementCarsService : IManagementCars
    {
        private CarRepository _carRepository;

        public ManagementCarsService()
        {
            _carRepository = new CarRepository();
        }

        public string GetCarAge()
        {
            var ageJson = JsonSerializer.Serialize(_carRepository.CarAgeGet()); ;
            return ageJson;
        }

        public string GetCarEngine()
        {
            var engineJson = JsonSerializer.Serialize(_carRepository.CarEngineGet()); ;
            return engineJson;
        }

        public string GetCarName()
        {
            var nameJson = JsonSerializer.Serialize(_carRepository.CarNameGet()); ;
            return nameJson;
        }
    }
}
