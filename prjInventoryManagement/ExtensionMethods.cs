namespace prjInventoryManagement
{
    public static class ExtensionMethods
    {

        public static double calcTotalValue(this List<Products> product)  // Extension method (Kalinda, 2025)
        {
            double total = 0;

            foreach (var item in product)
            {
                total += item.Price;
            }

            return total;
    
        }

        public static string lowStockFilter(this List<Products> product) // Extension method
        {
            string filter = "";

            foreach (var item in product)
            {

                // If there are less than 10 products left, add it to the list of low stock products
                if (item.Quantity <= 10)
                {
                    filter += item.Name + " ";
                }

            }

            return filter;
        }

    }
}

/*
    Reference List:
    Kalinda, C. 2025. C# Extension Methods (How It Works For Developers). [online]. Available at: <https://ironpdf.com/blog/net-help/csharp-extension-methods/> [Accessed 8 August 2025].

*/
