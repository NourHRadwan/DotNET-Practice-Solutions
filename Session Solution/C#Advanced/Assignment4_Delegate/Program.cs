using Assignment4_Delegate;
using Assignment4_Delegate.Example2;
using Assignment4_Delegate.Example_3;

internal class Program
{
    private static void Main(string[] args)
    {
        #region BubbleSort Non Generic Example
        //int[] Numbers = new int[] { 10, 20, 50, 3, 2, 1, 38, 4, 9, 8 };
        // SortingAlgorithm.BubbleSort(Numbers, CompareFunctions.CompareGreater);
        // foreach (var item in Numbers)
        // {
        //     Console.WriteLine(item);
        // }
        // System.Console.WriteLine("=====================================");
        // SortingAlgorithm.BubbleSort(Numbers, CompareFunctions.CompareSmaller);
        // foreach (var item in Numbers)
        // {
        //     Console.WriteLine(item);
        #endregion

        #region BubbleSort Generic Example
        // string[] Names = { "Ahmed", "Mona", "Amr", "Kareem", "Maha" };
        // SortingAlgorithm<string>.BubbleSort(Names, CompareFunctions<string>.SortAsce);
        // foreach (var item in Names)
        // {
        //     System.Console.WriteLine(item);
        // }
        // System.Console.WriteLine("=====================================");
        // SortingAlgorithm<string>.BubbleSort(Names, CompareFunctions<string>.SortDesc);
        // foreach (var item in Names)
        // {
        //     System.Console.WriteLine(item);
        // }


        #endregion


        #region Delegate Example 2: Create a list of nummbers based on a condition

        ///List<int> Numbers = Enumerable.Range(1, 100).ToList();
        ///System.Console.WriteLine("Odd Numbers");
        ///List<int> oddNumbers = Helper.GetNumbers(Numbers, ConditionalFunctions.CheckOdd);
        ///foreach (var item in oddNumbers)
        ///{
        ///    System.Console.Write($"{item} ");
        ///}
        ///System.Console.WriteLine("\nEven Numbers");
///
        ///List<int> EvenNumbers = Helper.GetNumbers(Numbers, ConditionalFunctions.CheckEven);
        ///foreach (var item in EvenNumbers)
        ///{
        ///    System.Console.Write($"{item} ");
        ///}
        ///System.Console.WriteLine("\nDivisable by 7 Numbers");
///
        ///List<int> NumbersDivisableBy7 = Helper.GetNumbers(Numbers, ConditionalFunctions.CheckDivisableBy7);
        ///foreach (var item in NumbersDivisableBy7)
        ///{
        ///    System.Console.Write($"{item} ");
        ///}
        ///System.Console.WriteLine("\nDivisable by 10 Numbers");
///
        ///List<int> NumbersDivisableBy10 = Helper.GetNumbers(Numbers, ConditionalFunctions.CheckDivisableBy10);
        ///foreach (var item in NumbersDivisableBy10)
        ///{
        ///    System.Console.Write($"{item} ");
        ///}

        #endregion

        #region Delegate Example 3: Create a list of Generics based on a condition
        List<string> Names = new List<string>() { "Ahmed", "Omar", "May", "Kareem", "Manar" };

        List<string> Result  = Helper2.GetElementsBasedOnCondition<string>(Names, GenericConditionalFunctions<string>.checkStringLength);
        foreach (var item in Result)
        {
            System.Console.WriteLine(item);
        }

        #endregion

    }
}