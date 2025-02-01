namespace Linq_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Get first Product out of Stock 

            //var product = ListGenerator.ProductList.FirstOrDefault(p => p.UnitsInStock == 0);
            //Console.WriteLine(product);

            #endregion

            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //var product = ListGenerator.ProductList.FirstOrDefault(p => p.UnitPrice > 1000);
            //Console.WriteLine(product);

            #endregion

            #region 3. Retrieve the second number greater than 5 

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var num = Arr.Where(n => n > 5).ElementAt(1);
            //Console.WriteLine(num);
            #endregion

            #region 1. Uses Count to get the number of odd numbers in the array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var oddCount = Arr.Count(n => n % 2 != 0);
            //Console.WriteLine(oddCount);

            #endregion

            #region 2. Return a list of customers and how many orders each has.

            //var customers = ListGenerator.CustomerList
            //    .Select(c => new
            //    {
            //        CustomerId = c.CustomerID,
            //        OrderCount = c.Orders.Length
            //    });

            //foreach (var customer in customers)
            //{
            //    Console.WriteLine($"Customer: {customer.CustomerId}, Orders: {customer.OrderCount}");
            //}

            #endregion

            #region 3. Return a list of categories and how many products each has

            //var categories = ListGenerator.ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        ProductCount = g.Count()
            //    });

            //foreach (var category in categories)
            //{
            //    Console.WriteLine($"Category: {category.Category}, Products: {category.ProductCount}");
            //}


            #endregion

            #region 4. Get the total of the numbers in an array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var total = Arr.Sum();
            //Console.WriteLine(total);

            #endregion

            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var totalCharacters = words.Sum(word => word.Length);
            //Console.WriteLine($"Total number of characters: {totalCharacters}");



            #endregion

            #region 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var shortestWordLength = words.Min(word => word.Length);
            //Console.WriteLine($"Length of the shortest word: {shortestWordLength}");


            #endregion

            #region 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var longestWordLength = words.Max(word => word.Length);
            //Console.WriteLine($"Length of the longest word: {longestWordLength}");

            #endregion

            #region 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var averageWordLength = words.Average(word => word.Length);
            //Console.WriteLine($"Average length of the words: {averageWordLength}");

            #endregion

            #region 9. Get the total units in stock for each product category.

            //var categories = ListGenerator.ProductList.GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        TotalUnitsInStock = g.Sum(p => p.UnitsInStock)
            //    });

            //foreach (var category in categories)
            //{
            //    Console.WriteLine($"Category: {category.Category}, Total Units in Stock: {category.TotalUnitsInStock}");
            //}

            #endregion

            #region 10. Get the cheapest price among each category's products

            //var categories = ListGenerator.ProductList.GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        CheapestPrice = g.Min(p => p.UnitPrice)
            //    });

            //foreach (var category in categories)
            //{
            //    Console.WriteLine($"Category: {category.Category}, Cheapest Price: {category.CheapestPrice}");
            //}


            #endregion

            #region 11. Get the products with the cheapest price in each category (Use Let)

            //var categories = ListGenerator.ProductList.GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        CheapestProducts = g.Where(p => p.UnitPrice == g.Min(p => p.UnitPrice))
            //    });

            //foreach (var category in categories)
            //{
            //    Console.WriteLine($"Category: {category.Category}");
            //    foreach (var product in category.CheapestProducts)
            //    {
            //        Console.WriteLine($"Product: {product.ProductName}, Price: {product.UnitPrice}");
            //    }
            //}

            #endregion

            #region 12. Get the most expensive price among each category's products.

            //var categories = ListGenerator.ProductList.GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        MostExpensivePrice = g.Max(p => p.UnitPrice)
            //    });

            //foreach (var category in categories)
            //{
            //    Console.WriteLine($"Category: {category.Category}, Most Expensive Price: {category.MostExpensivePrice}");
            //}


            #endregion

            #region 13. Get the products with the most expensive price in each category.

            //var categories = ListGenerator.ProductList.GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        MostExpensiveProducts = g.Where(p => p.UnitPrice == g.Max(p => p.UnitPrice))
            //    });

            //foreach (var category in categories)
            //{
            //    Console.WriteLine($"Category: {category.Category}");
            //    foreach (var product in category.MostExpensiveProducts)
            //    {
            //        Console.WriteLine($"Product: {product.ProductName}, Price: {product.UnitPrice}");
            //    }
            //}

            #endregion

            #region 14. Get the average price of each category's products.

            //var categories = ListGenerator.ProductList.GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        AveragePrice = g.Average(p => p.UnitPrice)
            //    });

            //foreach (var category in categories)
            //{
            //    Console.WriteLine($"Category: {category.Category}, Average Price: {category.AveragePrice}");
            //}

            #endregion



        }
    }
}
