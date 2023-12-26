namespace WindowsFormsApp2.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public string LicensePlate { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public int Seats { get; set; }
        public double PriceForRepairing { get; set; }
    }
}