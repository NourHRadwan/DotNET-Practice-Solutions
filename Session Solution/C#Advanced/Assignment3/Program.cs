using Assignment3;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Q1 Bubble Sort
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
        #endregion

        #region Q2 Generic Range

        Range<int> StringRange = new Range<int>(5, 10);
        System.Console.WriteLine(StringRange.IsInRange(6));
        System.Console.WriteLine(StringRange.Length());
               
        #endregion

        #region Q3 Reverse Array
         

        #endregion
    }
}