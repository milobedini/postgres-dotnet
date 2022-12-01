namespace postgres_dotnet.Models
{

    // The API model to be used by controllers.
    public class OrderModel
    {
        public int id { get; set; }

        public int product_id { get; set; }

        public string user { get; set; } = string.Empty;

        public string user_address { get; set; } = string.Empty;

        public string user_phone { get; set; } = string.Empty;
    }
}