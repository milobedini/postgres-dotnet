using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace postgres_dotnet.EFCore
{
    [Table("order")]
    public class Order
    {
        [Key, Required]
        public int id { get; set; }

        // Foreign Key for product
        public int product_id { get; set; }

        public virtual Product Product { get; set; }

        public string user { get; set; } = string.Empty;

        public string user_address { get; set; } = string.Empty;

        public string user_phone { get; set; } = string.Empty;
    }
}
