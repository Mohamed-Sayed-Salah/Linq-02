using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Intrinsics.X86;
using System.Collections;
using System.Text.RegularExpressions;

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

            #region 1. Find the unique Category names from Product List

            //var result = ListGenerator.ProductList.Select(p => p.Category).Distinct();
            //foreach (var category in result)
            //{
            //    Console.WriteLine(category);
            //}

            #endregion

            #region 2. Produce a Sequence containing the unique first letter from both product and customer names.

            //var result = ListGenerator.ProductList.Select(p => p.ProductName[0])
            //    .Union(ListGenerator.CustomerList.Select(c => c.CustomerName[0]));

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 3. Create one sequence that contains the common first letter from both product and customer names.

            //var result = ListGenerator.ProductList.Select(p => p.ProductName[0])
            //    .Intersect(ListGenerator.CustomerList.Select(c => c.CustomerName[0]));

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.

            //var result = ListGenerator.ProductList.Select(p => p.ProductName[0])
            //    .Except(ListGenerator.CustomerList.Select(c => c.CustomerName[0]));

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates

            //var result = ListGenerator.ProductList.Select(p => p.ProductName.Substring(p.ProductName.Length - 3))
            //   .Concat(ListGenerator.CustomerList.Select(c => c.CustomerName.Substring(c.CustomerName.Length - 3)));

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 1. Get the first 3 orders from customers in Washington

            //var result = ListGenerator.CustomerList
            //.Where(c => c.Region == "WA")
            // .SelectMany(c => c.Orders)
            //.Take(3);

            //foreach (var order in result)
            //{
            //    Console.WriteLine($"Order Id : {order.OrderID}   Order Date : {order.OrderDate}");
            //}


            #endregion

            #region 2. Get all but the first 2 orders from customers in Washington.

            //var result = ListGenerator.CustomerList
            //    .Where(c => c.Region == "WA")
            //    .SelectMany(c => c.Orders)
            //    .Skip(2);

            //foreach (var order in result)
            //{
            //    Console.WriteLine($"Order Id : {order.OrderID}   Order Date : {order.OrderDate}");
            //}

            #endregion

            #region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.TakeWhile((n, index) => n >= index);

            //foreach (var num in result)
            //{
            //    Console.WriteLine(num);
            //}

            #endregion

            #region 4.Get the elements of the array starting from the first element divisible by 3.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile(n => n % 3 != 0);

            //foreach (var num in result)
            //{
            //    Console.WriteLine(num);
            //}

            #endregion

            #region 5. Get the elements of the array starting from the first element less than its position.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile((n, index) => n >= index);

            //foreach (var num in result)
            //{
            //    Console.WriteLine(num);
            //}


            #endregion

            #region 1. Determine if any of the words in dictionary_english.txt  contain the substring 'ei'.

            //var words = File.ReadAllLines("dictionary_english.txt");
            //var result = words.Any(w => w.Contains("ei"));
            //Console.WriteLine(result);


            #endregion

            #region 2. Return a grouped a list of products only for categories that have at least one product that is out of stock.

            //var result = ListGenerator.ProductList.GroupBy(p => p.Category)
            //    .Where(g => g.Any(p => p.UnitsInStock == 0));
            //foreach (var group in result)
            //{
            //    Console.WriteLine(group.Key);
            //}
            #endregion

            #region 3. Return a grouped a list of products only for categories that have all of their products in stock.

            //var result = ListGenerator.ProductList.GroupBy(p => p.Category)
            //    .Where(g => g.All(p => p.UnitsInStock > 0));

            //foreach (var group in result)
            //{
            //    Console.WriteLine(group.Key);
            //}

            #endregion


            #region 1. Use group by to partition a list of numbers by their remainder when divided by 5

            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var result = numbers.GroupBy(n => n % 5);
            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Numbers with a remainder of {group.Key} when divid by 5 :");
            //    foreach (var number in group)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            #endregion

            #region 2. Uses group by to partition a list of words by their first letter.

            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var result = words.GroupBy(w => w[0]);
            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Words that start with the letter {group.Key} :");
            //    foreach (var word in group)
            //    {
            //        Console.WriteLine(word);
            //    }
            //}


            #endregion







        }
    }
}
