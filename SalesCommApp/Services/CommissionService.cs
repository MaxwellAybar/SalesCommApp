namespace SalesCommApp.Services
{
    public class CommissionService
    {
        public decimal Calculate(string country, decimal sales, decimal discount)
        {
            decimal baseAmount = sales - discount;
            decimal rate = 0;

            switch (country)
            {
                case "India":
                    rate = 0.10m;
                    break;
                case "US":
                    rate = 0.15m;
                    break;
                case "UK":
                    rate = 0.12m;
                    break;
            }

            return baseAmount * rate;
        }
    }
}