using CodingChallenge.InventoryManagement;
using CodingChallenge.Logger;

Console.WriteLine(@"------------Coding challenge---------------

1.- Logger
2.- Inventory Management

----------------------------------------------");
string opt = Console.ReadLine();
Console.WriteLine(opt);

switch (opt) {
    case "1":
        {
            Console.WriteLine("Logger");
            Logger.log_message("application.log", "User logged in", Severity.INFO);
            Logger.log_message("application.log", "Failed login attempt", Severity.WARNING);
            Logger.log_message("application.log", "User is blocked", Severity.CRITICAL);
        }
        break;
    case "2":
        {
            Console.WriteLine("Inventory Management");
            var products = new List<Product>
            {
                new Product { Name = "Product A", Price = 100, Stock = 5 },
                new Product { Name = "Product B", Price = 200, Stock = 3 },
                new Product { Name = "Product C", Price = 50, Stock = 10 }
            };

            var sortedProducts = Inventory.SortProducts(products, "name", false);

            foreach (var product in sortedProducts)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
            }
            break;
        }
    



}