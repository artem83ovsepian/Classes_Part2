using HW.Entities;
using HW.Entities.Enums;

namespace HW.Repositories
{
    public class CarRepository
    {
        public IEnumerable<Car> CarsGet()
        {
            return new List<Car>()
            {
                new Car()
                { 
                    Make  = "Ford", 
                    ComercialDescription = "Fusion",
                    ManufactureDate = DateTime.Parse("08/18/2018"),
                    Capacity = 2000,
                    EmissionStandart = (int)Emission.Euro3,
                    Mass = 1650,
                    Color = (int)Color.Green,
                    VIN = "DFLSKNL56KMLKSMVL"
                },
                new Car()
                {
                    Make  = "Toyota",
                    ComercialDescription = "Camry",
                    ManufactureDate = DateTime.Parse("10/28/2015"),
                    Capacity = 2500,
                    EmissionStandart = (int)Emission.Euro4,
                    Mass = 2150,
                    Color = (int)Color.White,
                    VIN = "WEF43543OOSCSE"
                },
                new Car()
                {
                    Make  = "Mercedes-Benz",
                    ComercialDescription = "B170",
                    ManufactureDate = DateTime.Parse("01/03/2023"),
                    Capacity = 1700,
                    EmissionStandart = (int)Emission.Euro5,
                    Mass = 1830,
                    Color = (int)Color.Yellow,
                    VIN = "SEEGR4534BDFV443"
                }
            };
        }
    }
}
