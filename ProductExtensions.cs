using System;
using System.Collections.Generic;
using System.Linq;

namespace prjInventoryManagement
{
    public static class ProductExtensions
    {
        // Extension Method: calculates total inventory value
        public static double CalculateTotalValue(this List<Product> products)
        {
            return products.Sum(p => p.Quantity * p.Price); // LINQ Sum used here
        }

        // Extension Method: filters products that are low in stock
        public static List<Product> LowStock(this List<Product> products, int minQuantity)
        {
            return products.Where(p => p.Quantity < minQuantity).ToList(); // LINQ Where used here
        }
    }
}
