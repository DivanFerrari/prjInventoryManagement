namespace prjInventoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>  
            {
                new Product { ID = 1, ProductName = "Laptop", Quantity = 10, Price = 1000 },
                new Product { ID = 2, ProductName = "Smartphone", Quantity = 25, Price = 600.00 },
                new Product { ID = 3, ProductName = "Tablet", Quantity = 5, Price = 250.00 },
                new Product { ID = 4, ProductName = "Headphones", Quantity = 50, Price = 100.00 },
                new Product { ID = 5, ProductName = "Gaming Console", Quantity = 2, Price = 12000.00 }
            };

            double totalValue = products.CalculateTotalValue();
            Console.WriteLine($"-----Total Inventory Value: R{totalValue}-----");

            Console.WriteLine();

            var lowStockProducts = products.LowStock(5);
            Console.WriteLine("-----Products with Low Stock (less or equal to 5)-----");

            foreach (var product in lowStockProducts)
            {
                Console.WriteLine($"- {product.ProductName} (Quantity: {product.Quantity})");
            }

            var selection = from p in products
                            where p.Price > 300
                            select p;

            Console.WriteLine();

            Console.WriteLine("-----Products with Price greater than R300-----");
            foreach (var product in selection)
            {
                Console.WriteLine($"{product.ProductName} with a Price of R{product.Price})");
            }

            Console.ReadLine();
        }
    }
}
