using System;
using System.Diagnostics;

namespace Assignment4_Delegate;
public delegate bool Compare<T>(T a, T b);

public class SortingAlgorithm<T>
{
    #region Non Generic BubbleSort
        //public static void BubbleSort(int[] array, Compare CompareFunctions)
        // {
        //     if (array is not null)
        //     {
        //         for (int i = 0; i < array.Length; i++)
        //         {
        //             for (int j = 0; j < array.Length - i - 1; j++)
        //             //if (array[j] > array[j + 1])
        //                 if(CompareFunctions.Invoke(array[j], array[j+1] ))
        //                     SWAP(ref array[j], ref array[j + 1]);
        //         }
        //     }
        // }
    #endregion

    #region Generic BubbleSort

      public static void BubbleSort(T[] array, Compare<T> CompareFunctions)
    {
        if (array is not null)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                //if (array[j] > array[j + 1])
                    if(CompareFunctions(array[j], array[j+1] ))
                        SWAP(ref array[j], ref array[j + 1]);
            }
        }
    }

    #endregion

    private static void SWAP(ref T v1, ref T v2)
    {
        T temp = v1;
        v1 = v2;
        v2 = temp;
    }
}
