using Assignment4_Delegate;

internal class Program
{
    private static void Main(string[] args)
    {
        #region BubbleSort Non Generic Example
        int[] Numbers = new int[] { 10, 20, 50, 3, 2, 1, 38, 4, 9, 8 };
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
        string[] Names = { "Ahmed", "Mona", "Amr", "Kareem", "Maha"};
        SortingAlgorithm<string>.BubbleSort(Names, CompareFunctions<string>.SortAsce);
        foreach (var item in Names)
        {
            System.Console.WriteLine(item);
        }
        System.Console.WriteLine("=====================================");
        SortingAlgorithm<string>.BubbleSort(Names, CompareFunctions<string>.SortDesc);
        foreach (var item in Names)
        {
            System.Console.WriteLine(item);
        } 


        #endregion
    
    }
}