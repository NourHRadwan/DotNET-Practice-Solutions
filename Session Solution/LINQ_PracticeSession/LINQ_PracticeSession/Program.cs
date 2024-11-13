using System.Collections;


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
        List<int> NumbersList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var Result = NumbersList.Where((N) => N % 2 == 1);
        NumbersList.AddRange(new int[] { 11, 12, 13, 14, 15 });
        foreach (int Numbers in Result)
            Console.Write($"{Numbers} "); // 1 3 5 7 9 11 13 15
        #endregion

        #region Immediate Excution [ELement Operators, Casting Operator, Aggergate Operator]
        //2. Immediate Excution [3 out of 13 Category]

        //Casting Operator
        Result = NumbersList.Where((N) => N % 2 == 1).ToList();

        //ELemenat Operator
        var Results = NumbersList.Where((N) => N % 2 == 1).First();

        //Aggergate Operator
        Results = NumbersList.Where((N) => N % 2 == 1).Count();



        #endregion


        #endregion
    }
}
