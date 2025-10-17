using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjInventoryManagement
{
    public static class ProductExtensions
    {
        public static double CalculateTotalValue(this List<Product> products)
        {
            return products.Sum(p => p.Quantity * p.Price);
        }

        public static List<Product> LowStock(this List<Product> products, int minQuantity)
        {
            return products.Where(p => p.Quantity < minQuantity).ToList();
        }
    }
}
