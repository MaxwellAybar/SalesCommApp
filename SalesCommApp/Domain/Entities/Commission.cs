namespace SalesCommApp.Domain.Entities
{
    public class Commission
    {
        public decimal Sales { get; set; }
        public decimal Discount { get; set; }
        public string Country { get; set; }
    }
}