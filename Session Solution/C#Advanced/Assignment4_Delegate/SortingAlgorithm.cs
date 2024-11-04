using System;
using System.Diagnostics;

namespace Assignment4_Delegate;

public class SortingAlgorithm
{
    public delegate bool Compare(int a, int b);
    public static void BubbleSort(int[] array, Compare CompareFunctions)
    {
        if (array is not null)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                //if (array[j] > array[j + 1])
                    if(CompareFunctions.Invoke(array[j], array[j+1] ))
                        SWAP(ref array[j], ref array[j + 1]);
            }
        }
    }

    private static void SWAP(ref int v1, ref int v2)
    {
        int temp = v1;
        v1 = v2;
        v2 = temp;
    }
}
