namespace postgres_dotnet.Models
{
    public class OrderModel
    {
        public int id { get; set; }

        public int product_id { get; set; }

        public string user { get; set; } = string.Empty;

        public string user_address { get; set; } = string.Empty;

        public string user_phone { get; set; } = string.Empty;
    }
}