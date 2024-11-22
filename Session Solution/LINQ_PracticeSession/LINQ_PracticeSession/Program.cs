using System;
using System.Collections;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Linq;
using static LINQ_PracticeSession.ListGenerator;
//we used the word static ?

namespace LINQ_PracticeSession;

class Program
{
    static void Main(string[] args)
    {
        #region LINQ Syntax
        #region 1. Fluent Syntax
        ///1.1 Call LINQ operator as static method through "Enumarable" Class
        ///List<int> Numbers = Enumerable.Range(1, 100).ToList();
        ///foreach (int Number in Numbers)
        ///{
        ///    Console.Write($"{Number} ");
        ///}
        ///Console.WriteLine("\n============ Odd Numbers ===================================");
        ///var Odds = Enumerable.Where<int>(Numbers, (x) => x % 2 == 1);
        ///
        ///// 1.2 CAll LINQ operator as Extension Method
        ///Odds = Numbers.Where((N) => N % 2 == 1);

        #endregion

        #region 2. Query Syntax: Query Expression
        /// Starting with keyword "from"
        /// Introducing Range Variable (N): Represents each and every Element in the Input Sequence
        /// Ending with keyword "select" Or "group by"
        //Like SQL Server Style
        /*
         * ==> Same order as SQL Query
         * Select N  (3)
         * From Numbers N (1)
         * Where N % 2 = 1 (2)
         * 
         */

        ///Odds = from N in Numbers
        ///       where N % 2 == 1
        ///       select N;


        #endregion

        ///foreach (int odd in Odds)
        ///{
        ///    Console.Write($"{odd} ");
        ///}

        #endregion

        #region LINQ Execution Ways {interview Question}

        #region Deffered Excution
        // 1. Deffered Excution (Latest Version of Data) [10 out 13 Categories]
        //List<int> NumbersList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //var Result = NumbersList.Where((N) => N % 2 == 1);
        //NumbersList.AddRange(new int[] { 11, 12, 13, 14, 15 });
        //foreach (int Numbers in Result)
        //    Console.Write($"{Numbers} "); // 1 3 5 7 9 11 13 15
        #endregion

        #region Immediate Excution [ELement Operators, Casting Operator, Aggergate Operator]
        //2. Immediate Excution [3 out of 13 Category]

        //Casting Operator
        //Result = NumbersList.Where((N) => N % 2 == 1).ToList();

        //ELemenat Operator
        //var Results = NumbersList.Where((N) => N % 2 == 1).First();

        //Aggergate Operator
        //Results = NumbersList.Where((N) => N % 2 == 1).Count();



        #endregion


        #endregion

        #region Filtration Operators
        //Restriction Operator - Where
        ///var Result2 = ProductList.Where(P => P.UnitsInStock == 0 && P.Category == "Meat/Poultry");
        ///foreach (var Numbers in Result2)
        ///    Console.Write($"{Numbers}\n");
        ///Result2 = ProductList.Where(P => P.ProductName == "Tofu");
        ///foreach (var Numbers in Result2)
        ///    Console.Write($"{Numbers}\n");


        //Indexed Where
        //P --> Parameter
        //I ==> index ==> GET from the first 10 products, the products that are out of stock


        #region Transoframtion Operator - Select  | SelectMany

        #endregion
        #endregion

        #region Transoformation Operator [Select - SelectMany]
        //Select Operator
        #region Prodcut ID
        //Get Product ID
        //1.fluent Syntax
        //var Result2 = ProductList.Select(P => P.ProductID);
        //2. Query Syntax

        //Result2 = from P in ProductList
        //          select P.ProductID; 
        #endregion
        #region Customer Name

        //Get Customer Name
        //1.Fluent Syntax
        //var Result2 = CustomerList.Select(C => C.CustomerName);
        //
        ////2. Query Syntax
        //Result2 = from C in CustomerList
        //          select C.CustomerName;
        //

        #endregion

        #region SelectMany
        //SelectMany
        //get Orders from CustomerList
        //1. Fluent Syntax

        //var Result2 = CustomerList.SelectMany(C => C.Orders);

        //2. Query Syntax
        ///Result2 = from C in CustomerList
        ///          from O in C.Orders
        ///          select O; 
        #endregion

        #region Select Product Id and Product Name
        //Select Product ID and Product Name
        //1. Fluent Syntax using Anyoymous Type
        //var Result2 = ProductList.Select(P => new { P.ProductID, P.ProductName });
        //CLR will creat a class in Runtime and Override ToString() Method

        //Query Syntax
        //var Result3 = from P in ProductList
        //              select new
        //              {
        //                  P.ProductName,
        //                  P.ProductID
        //              };

        #endregion

        #region Select Product in Stock and Apply Discount 10 on it is Price
        // Fluent Syntax
        //var ProductsInStock = ProductList.Where(P => P.UnitsInStock > 0)
        //                                 .Select(P => new
        //                                 {
        //                                     P.ProductID,
        //                                     P.ProductName,
        //                                     P.UnitPrice,
        //                                     newPrice = P.UnitPrice - (P.UnitPrice * 0.1M)
        //                                 });
        //foreach (var Product in ProductsInStock)
        //    Console.WriteLine(Product);




        #endregion



        #endregion

        #region Ordering Operator
        //[Ascending Order , Descending, Reverse, ThenBy, ThenByDescending]

        #region Get Products Ordered By Price ASC
        //IOrderdEnumrable 
        //var Results2 = ProductList.OrderBy(P => P.UnitPrice);
        //
        //Results2 = from P in ProductList
        //           orderby P.UnitPrice
        //           select P;

        #endregion

        #region Order by Desc
        //var Results2 = ProductList.OrderByDescending(P => P.UnitPrice);
        //
        //Results2 = from P in ProductList
        //           orderby P.UnitPrice descending
        //           select P;
        //
        #endregion

        #region Get Products Ordered By Price ASC and Number of Items in Stock DEC
        //var Results2 = ProductList.OrderBy(P => P.UnitPrice).ThenByDescending(P => P.UnitsInStock);

        #endregion

        #region Elements Operators - Immadiate Excution
        //First, FirstOrDefault, Last, LastOrDefault, Single, SingleOrDefault, ElementAt, ElementAtOrDefault
        #region First, FirstOrDefault, Last, LastOrDefault
        //var Result = ProductList.First(); //Get First Element at sequance
        //Result = ProductList.Last(); //Get Last Element at sequance

        //Console.WriteLine(Result?.ProductName ?? "Not Found");
        //List<Product> EmptyList = new List<Product>();
        //Result = EmptyList.First(); // System.InvalidOperationException: 'Sequence contains no elements'
        //Result = EmptyList.FirstOrDefault(); //Return Null
        //Result = EmptyList.LastOrDefault();
        //First and Last will throw exception if the sequence is empty

        //FirstOrDefault() and LastOrDefault() will return null if the sequence is empty

        #region First and Last Overloads
        //var Result = ProductList.First(P => P.UnitsInStock == 0);
        // Get the first product that match the condition 
        //Result = ProductList.Last(P => P.UnitsInStock == 0);
        // Get the last product that match the condition
        // ** First and Last will throw exception if there is no matching conditions


        //var Result = ProductList.FirstOrDefault(P => P.UnitsInStock == 0);
        // if there is no matching elements ==> return the default (NULL)

        #endregion
        #endregion

        #region ElementsAt
        //var Result = ProductList.ElementAt(77);
        //Result = ProductList.ElementAtOrDefault(77);
        #endregion

        #region Single
        //var Result = ProductList.Single(P => P.ProductID == 1);
        //Return the only element that match the condition
        //If sequence contains only one element that match condition -> Return it
        //Else will throw expetion

        #endregion
        #endregion
        #endregion

        #region Casting Operator [ToList, ToArray, ToDictionary, ToHashSet, OfType]
        //ToList
        //List<Product> Result = ProductList.Where(P => P.UnitsInStock == 0).ToList();

        //ToArray
        //Product[] Result = ProductList.Where(P => P.UnitsInStock ==0).ToArray();

        //ToDictionary
        //Dictionary<long, string?> Result = ProductList.Where(P => P.UnitsInStock == 0)
        //                                               .ToDictionary(P => P.ProductID, P => P.ProductName);

        #endregion

        #region Generation Operators - Deffered Excution
        //1. Range
        //var Result = Enumerable.Range(1, 10);
        //Valid Only with fluent Syntax
        //The only way to call them is as static method from Enumerable Class

        //2. Repeat
        //var Result = Enumerable.Repeat(new Product(), 5);
        //// Return IEnumerable<Product> with 5 elements
        //foreach(var item in Result) {
        //    Console.WriteLine($"{item}");
        //}

        ////3. Empty
        //var ArrayResult = Enumerable.Empty<Product>().ToArray();
        //// Same result as
        //// Product[] ArrayResult = new Product[0];
        ////both of them will generate empty array of products


        //var List = Enumerable.Empty<Product>().ToList();
        ////List<Product> List = new List<Product>();
        #endregion

        #region Set Operators [Union Family] - Defferred Excution
        // Union, Intersect, Except, Distinct, Concat
        // using two sequences

        //var seq1 = Enumerable.Range(0,100); //0 .. 99
        //var seq2 = Enumerable.Range(50, 100); //50 .. 149

        ////Union - Combine two sequences and remove duplicates
        ////var Result = seq1.Union(seq2); //Calling as object member method
        ////var Result = Enumerable.Union(seq1, seq2); //Calling as static method from Enumerable Class


        ////Concat - Combine two sequenced with duplication
        //var Result = seq1.Concat(seq2);


        ////Distinct
        //Result = Result.Distinct(); // Remove the duplication

        ////intersect --  Return the elements the exist in seq1 and seq2
        //Result = seq1.Intersect(seq2);

        ////Except -- Return the elements that exist in seq1 but not in seq2
        //Result = seq1.Except(seq2);

        //foreach ( var item in seq1 ) 
        //    Console.Write($"{item} ");

        //Console.WriteLine("\n ==============================================");

        //foreach (var item in seq2)
        //    Console.Write($"{item} ");
        //Console.WriteLine("\n ==============================================");

        //foreach (var item in Result)
        //    Console.Write($"{item} ");

        #endregion

        #region Quentifier Operators - Deffered Excution
        // All, Any, Contains, SequenceEqual
        // Return Boolean Value
        #region Any
        //1. Any -  true if anyelement in the sequence match the condition
        // Overload 1 ==> if Sequence contains at least one element => Return True
        //var Result = ProductList.Any();

        // Overload 2 ==> if Sequence contains at least one element that match the condition => Return True
        //var Result = ProductList.Any(P => P.UnitsInStock > 1000); //False

        #endregion

        #region All
        //var Result = ProductList.All(P => P.UnitsInStock == 0);
        //IF all elements in sequence match the condition ==> True

        #endregion

        // SequenceEqual


        #endregion

        #region Zipping Operator - Deffered Excution
        // Zip
        //Produce a sequence 
        //string[] Names = { "Omar", "Amr", "Ahmed", "May" };
        //int[] Numbers = Enumerable.Range(1, 100).ToArray();
        //char[] Chars = { 'a', 'b', 'c' };

        //var Result = Names.Zip(Numbers);
        //(Omar, 1)(Amr, 2)(Ahmed, 3)(May, 4)

        //var Result = Names.Zip(Numbers, (Name, Number) => new { index = Number, Name });
        //{ index = 1, Name = Omar }
        //{ index = 2, Name = Amr }
        //{ index = 3, Name = Ahmed }
        //{ index = 4, Name = May }

        //var Result = Names.Zip (Numbers, Chars);
        //foreach (var c in Result)
        //{
        //    Console.Write($"{c}");
        //}
        #endregion

        #region Grouping Operator

        //Group By --Query syntax
        //Return a list of categories and how many products each has
        //var Result = from P in ProductList
        //             group P by P.Category;

        //Group By -- Fluent Syntax
        //var Result = ProductList.GroupBy(P => P.Category);


        //foreach (var Category in Result)
        //{
        //    Console.WriteLine($"{Category.Key}");
        //    foreach (var product in Category)
        //        Console.WriteLine($"              {product.ProductName} has {product.UnitsInStock} unit");
        //}


        //Group by Category for Products in Stock
        //var Result = ProductList.Where(P => P.UnitsInStock > 0)
        //                        .GroupBy(P => P.Category);

        //Group Produts in Stock Grouped by Category that Contains More than 10 Products
        //var Result = from P in ProductList
        //             where P.UnitsInStock > 0
        //             group P by P.Category
        //             into C
        //             where C.Count() > 10
        //             select C;

        //Fluent Syntax
        //var Result = ProductList.Where(P => P.UnitsInStock > 0)
        //                        .GroupBy(P => P.Category)
        //                        .Where(C => C.Count() > 10);

        //Get Category Name of Products in Stock that
        //Contains more than 10 Products and Number of Products in Each Category

        //Fluent Syntax
        //var Result = ProductList.Where(P => P.UnitsInStock > 0)
        //                        .GroupBy(P => P.Category)
        //                        .Where(C => C.Count() > 10)
        //                        .Select(X => new
        //                        {
        //                            CategoryName = X.Key,
        //                            Count = X.Count()
        //                        });


        //Query Syntax
        //var Result = from P in ProductList
        //             where P.UnitsInStock > 0
        //             group P by P.Category
        //             into C
        //             select new {
        //                 CategoryName = C.Key,
        //                 Count = C.Count()
        //             };


        #endregion

        #region Partitioning Operators

        //Divide the sequence into parts

        //Take : Take Number of Elements from First Only
        //var Result = ProductList.Take(10);
        //Result = ProductList.Where(P => P.UnitsInStock > 0).Take(5);


        //Skip : Skip Number of Elements from First and Get Rest of Elements
        //Result = ProductList.Where(P => P.UnitsInStock == 0).Skip(2);

        //2nd Ten
        //Result = ProductList.Skip(10).Take(10);

        //TakeLast : Take Number of Elements from Last Only
        //Result = ProductList.Where(P => P.UnitsInStock > 0).TakeLast(5);

        //SkipLast : Skip Number of Elements from Last and Get Rest of Elements
        //Result = ProductList.Where(P => P.UnitsInStock == 0).SkipLast(2);


        //TakeWhile : Take Elements from the first as long as the condition is true
        //int[] Numbers = { 5, 6, 7, 8, 9, 1, 2, 3, 4, 10 };

        //var Result = Numbers.TakeWhile(N => N < 8);

        //indexed TakeWhile
        //Result = Numbers.TakeWhile((N, index) => N > index);



        //SkipWhile : Skip Elements from the first as long as the condition is true
        //var Result = Numbers.SkipWhile(N => N < 8);

        //foreach (var Product in Result)
        //    Console.WriteLine(Product);

        #endregion

        #region Solving Questions on LINQ
        // 1. Sort a list of Products by name
        //var Result = ProductList.OrderBy(P => P.ProductName);

        //2. Find all products that are in stock and cost more than 3.00 per unit
        //var Result = ProductList.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3)
        //                        .OrderBy(n => n.UnitPrice);

        //3. Return digits whose name is shorter than their value
        //string[] names = {"zero", "one", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

        //var Result = names.Where((digit, index) => digit.Length < index);


        //4. Get First product out of stock
        //var Result = ProductList.Where(P => P.UnitsInStock == 0).First();

        //5. Return the first product whose price > 1000. unless there is no match
        //var Result = ProductList.FirstOrDefault(P => P.UnitPrice >  1000);

        //6. Retrive the secound number greater than 5
        //int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7 };
        //
        //var Result = arr.Where(P => P > 5).Skip(1).First();

        //7. Use Count to get the number of odd numbers in the array
        //int[] arr = {5,4,1,9,8,6,7,2,0 };
        //
        //var Result = arr.Count(P => P % 2 == 1);

        //8. Return a list of customers and how many orders each has.
        ///var Result = CustomerList.Select(C => new
        ///{
        ///    C.CustomerID,
        ///    C.CustomerName,
        ///    orders = C.Orders.Count()
        ///});


        //9. Return a list of categories and how many products each has
        //var Result = from P in ProductList
        //             group P by P.Category;



        //Console.WriteLine(Result);

        //foreach (var Category in Result)
        //{
        //    Console.WriteLine($"{Category.Key}");
        //    foreach (var product in Category)
        //        Console.WriteLine($"              {product.ProductName} has {product.UnitsInStock} unit");
        //}
        //Beverages
        //              Chai has 100
        //              Chang has 17
        //              Guaraná Fantástica has 20
        //              Sasquatch Ale has 111
        //              Steeleye Stout has 20
        //              Côte de Blaye has 17
        //              Chartreuse verte has 69
        //              Ipoh Coffee has 17
        //              Laughing Lumberjack Lager has 52
        //              Outback Lager has 15
        //              Rhönbräu Klosterbier has 125
        //              Lakkalikööri has 57
        //Condiments
        //              Aniseed Syrup has 13
        //              Chef Anton's Cajun Seasoning has 53
        //              Chef Anton's Gumbo Mix has 0
        //              Grandma's Boysenberry Spread has 120
        //              Northwoods Cranberry Sauce has 6
        //              Genen Shouyu has 39
        //              Gula Malacca has 27
        //              Sirop d'érable has 113
        //              Vegie - spread has 24
        //              Louisiana Fiery Hot Pepper Sauce has 76
        //              Louisiana Hot Spiced Okra has 4
        //              Original Frankfurter grüne Soße has 32


        #endregion

    }
}
