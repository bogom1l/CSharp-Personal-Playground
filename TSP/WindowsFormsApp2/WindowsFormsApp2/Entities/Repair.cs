namespace WindowsFormsApp2.Entities
{
    public class Repair
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int ClientId { get; set; }
        public string DateOfStartingRepair { get; set; }
        public string DateOfFinishingRepair { get; set; }
        public bool IsPaid { get; set; }
        public bool IsReturned { get; set; }
    }
}