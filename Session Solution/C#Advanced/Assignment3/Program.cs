using Assignment3;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = [2, 5, 10, 9 , 4, 6, 3 , 1, 6, 8, 7];
        System.Console.WriteLine("Array before Sorting");
        foreach (var item in array)
        {
            System.Console.Write($"{item} ");
        }
        System.Console.WriteLine("\nArray after Sorting");
        OptimizedBubbleSort<int>.Sort(array);
        foreach (var item in array)
        {
            System.Console.Write($"{item} ");
        }
    }
}