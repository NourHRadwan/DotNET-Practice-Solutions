using System;

namespace Assignment3;
/// <summary>
/// The Bubble Sort algorithm has a time complexity of O(n^2) in its worst and average cases, 
/// which makes it inefficient for large datasets. How we can optimise the Bubble Sort algorithm 
/// And implement the code of this optimised bubble sort algorithm
/// O(n^2): Quadratic time complexity means the execution time grows proportionally to the square of the input size.
/// </summary>
/// <typeparam name="T"></typeparam>
public class OptimizedBubbleSort<T> where T : IComparable<T>
{
    public static void Sort(T[] array)
    {
        for(int i = 0; i < array.Length; i++)
        {
            bool flag = false;
            for(int j = 0; j < array.Length - i - 1; j++) 
            {
                //Short Bubble: The inner loop only iterates up to the second-to-last element in the unsorted portion of the array, as elements beyond that point are already in their correct positions.
                if(array[j].CompareTo(array[j+1]) > 0)
                {
                    (array[j], array[j+1]) = (array[j+1], array[j]);
                    flag = true;
                }
            }
            if(!flag)
            {
                //Early Termination: The outer loop terminates early if no swaps were made during an iteration, indicating the array is already sorted.
                break;
            }
        }
    }

}
