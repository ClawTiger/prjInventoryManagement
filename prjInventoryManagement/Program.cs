namespace prjInventoryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a list of products and adding new products
            List<Products> products = new List<Products>();
            products.Add(new Products { ID = 1, Name = "Milk", Quantity = 30, Price = 12.50});
            products.Add(new Products { ID = 2, Name = "Coffee", Quantity = 150, Price = 15.00 });
            products.Add(new Products { ID = 3, Name = "Tea", Quantity = 7, Price = 20.00 });
            products.Add(new Products { ID = 4, Name = "Water", Quantity = 10, Price = 100.00 });
            products.Add(new Products { ID = 5, Name = "Cookie", Quantity = 1000, Price = 1000.00 });

            // Calculating the total value of the products
            double total = ExtensionMethods.calcTotalValue(products);

            Console.WriteLine("Total price of products: R" + total);

            // Filtering the products that are low stock
            string filter = ExtensionMethods.lowStockFilter(products);

            Console.WriteLine("Prdoucts low on stock: " + filter);

            Console.WriteLine();

            // LINQ Query
            var namePriceQuery = from prod in products select new { prod.Name, prod.Price }; // (Microsoft, 2025)

            foreach (var query in namePriceQuery)
            {
                Console.WriteLine("Product Name: {0} \t Product Price: R{1}", query.Name, query.Price);
            }


        }
    }
}

/*
    Reference List: 
    Microsoft, 2025. Anonymous Types. [online]. Available at: <https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/anonymous-types> [Accessed 8 August 2025].
*/
