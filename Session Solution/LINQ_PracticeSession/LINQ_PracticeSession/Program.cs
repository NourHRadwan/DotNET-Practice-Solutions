using System.Collections;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
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
        var Result3 = from P in ProductList
                      select new
                      {
                          P.ProductName,
                          P.ProductID
                      };

        #endregion

        #region Select Product in Stock and Apply Discount 10 on it is Price
        // Fluent Syntax
        var ProductsInStock = ProductList.Where(P => P.UnitsInStock > 0)
                                         .Select(P => new
                                         {
                                             P.ProductID,
                                             P.ProductName,
                                             P.UnitPrice,
                                             newPrice = P.UnitPrice - (P.UnitPrice * 0.1M)
                                         });
        foreach (var Product in ProductsInStock)
            Console.WriteLine(Product);




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
        var Result = ProductList.Single(P => P.ProductID == 1);
        //Return the only element that match the condition
        //If sequence contains only one element that match condition -> Return it
        //Else will throw expetion

        #endregion
        #endregion
        #endregion

    }
}
