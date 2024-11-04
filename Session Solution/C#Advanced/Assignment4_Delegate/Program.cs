using Assignment4_Delegate;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] Numbers = new int[] { 10, 20, 50, 3, 2, 1, 38, 4, 9, 8 };
        SortingAlgorithm.BubbleSort(Numbers, CompareFunctions.CompareGreater);
        foreach (var item in Numbers)
        {
            Console.WriteLine(item);
        }
        System.Console.WriteLine("=====================================");
        SortingAlgorithm.BubbleSort(Numbers, CompareFunctions.CompareSmaller);
        foreach (var item in Numbers)
        {
            Console.WriteLine(item);
        }
    }
}