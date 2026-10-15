using LINQ.DataSources;
using LINQ.Models;
using static LINQ.DataSources.Source;
namespace LINQ
{
    internal class Program
    {
        static void Main()
        {
            #region Ques01
            //var Seafood = ProductList.Where(P => P.Category == "Seafood");

            //foreach (var item in Seafood)
            //{
            //    Console.WriteLine($"{item.ProductName} - {item.UnitPrice}");
            //}
            #endregion


            #region Ques02
            //var Names = ProductList.Select(P => P.ProductName);

            //foreach (var item in Names)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region Ques03
            //var ByPrice = ProductList.OrderBy(P => P.UnitPrice);

            //foreach (var item in ByPrice)
            //{
            //    Console.WriteLine($"{item.ProductName} - {item.UnitPrice}");
            //}
            #endregion


            #region Ques04
            //var MidRange = ProductList.Where(P => P.UnitPrice >= 10 && P.UnitPrice <= 30);

            //foreach (var item in MidRange)
            //{
            //    Console.WriteLine($"{item.ProductName} - {item.UnitPrice}");
            //}
            #endregion


            #region Ques05
            //var InStockCondiments = ProductList.Where(P => P.UnitsInStock > 0 && P.Category == "Spices & Condiments");

            //foreach (var item in InStockCondiments)
            //{
            //    Console.WriteLine($"{item.ProductName} - {item.UnitsInStock}");
            //}
            #endregion


            #region Ques06
            //var StockInfo = ProductList.Select(P => new
            //{
            //    Name = P.ProductName,
            //    Price = P.UnitPrice,
            //    StockStatus = P.UnitsInStock > 0 ? "Available" : "Out of Stock"
            //});

            //foreach (var item in StockInfo)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region Ques07
            //var Numbered = ProductList.Select((P, I) => new { Position = I + 1, P.ProductName });

            //foreach (var item in Numbered)
            //{
            //    Console.WriteLine($"{item.Position}. {item.ProductName}");
            //}
            #endregion


            #region Ques08
            //var Sorted = ProductList.OrderBy(P => P.Category).ThenByDescending(P => P.UnitPrice);

            //foreach (var item in Sorted)
            //{
            //    Console.WriteLine($"{item.Category} - {item.ProductName} - {item.UnitPrice}");
            //}
            #endregion


            #region Ques09
            //var Beverages = ProductList
            //    .Where(P => P.Category == "Beverages")
            //    .OrderByDescending(P => P.UnitsInStock);

            //foreach (var item in Beverages)
            //{
            //    Console.WriteLine($"{item.ProductName} - {item.UnitsInStock}");
            //}
            #endregion


            #region Ques10
            //var RecentOrders = from C in CustomerList
            //                   from O in C.Orders
            //                   where O.OrderDate >= new DateTime(1997, 1, 1)
            //                   select new { C.CustomerID, O.OrderDate };

            //foreach (var item in RecentOrders)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region Ques11
            //var WithPosition = ProductList.Select((P, I) => $"{I + 1}. {P.ProductName}");

            //foreach (var item in WithPosition)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region Ques12
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var SortedWords = Arr
            //    .OrderBy(W => W.Length)
            //    .ThenBy(W => W, StringComparer.OrdinalIgnoreCase);

            //foreach (var item in SortedWords)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region Ques13
            //string[] Digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var SecondLetterI = Digits.Where(D => D[1] == 'i').Reverse().ToList();

            //foreach (var item in SecondLetterI)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
        }
    }
}