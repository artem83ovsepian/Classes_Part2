namespace HW.Entities.BAL
{
    public class CarBrief : CarDAL
    {
        public string EmissionStandart { get; set; }
        public string Color { get; set; }
        public decimal CapacityLiters { get; set; }
        public int ManufactureYear { get; set; }
    }
}
