namespace MMS.Models
{
    public class Mobile
    {
        public Guid  MobileId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public int StorageGB { get; set; }
        public int RamGB { get; set; }
        public string OperatingSystem { get; set; }
    }
}
