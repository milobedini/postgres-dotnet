using postgres_dotnet.EFCore;

namespace postgres_dotnet.Models
{
    public class DBHelper
    {
        private EFDataContext _context;
        public DBHelper(EFDataContext context)
        {
            _context = context;
        }
        // GET
        public List<ProductModel> GetProducts()
        {
            List<ProductModel> response = new List<ProductModel>();
            var dataList = _context.Products.ToList();
            dataList.ForEach(row => response.Add(new ProductModel()
            {
                brand = row.brand,
                id = row.id,
                name = row.name,
                price = row.price,
                size = row.size,
            }));
            return response;
        }

        // POST, PUT, PATCH
        public void SaveOrder(OrderModel orderModel)
        {
            Order dbTable = new Order();
            if (orderModel.id > 0)
            {
                // PUT
                dbTable = _context.Orders.Where(d => d.id.Equals(orderModel.id)).FirstOrDefault();
                if (dbTable != null)
                {
                    dbTable.user_phone = orderModel.user_phone;
                    dbTable.user_address = orderModel.user_address;
                }
                else
                {
                    // POST
                    dbTable.user_phone = orderModel.user_phone;
                    dbTable.user_address = orderModel.user_address;
                    dbTable.user = orderModel.user;
                    dbTable.Product = _context.Products.Where(f => f.id.Equals(orderModel.product_id)).FirstOrDefault();
                    _context.Orders.Add(dbTable);
                }
            }
        }

    }
}