using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// The actual Postgres model.

namespace postgres_dotnet.EFCore
{
    [Table("order")]
    public class Order
    {
        [Key, Required]
        public int id { get; set; }


        // The below foreign key reference automatically creates the foreign key ID
        public virtual Product Product { get; set; }

        public string user { get; set; } = string.Empty;

        public string user_address { get; set; } = string.Empty;

        public string user_phone { get; set; } = string.Empty;
    }
}
