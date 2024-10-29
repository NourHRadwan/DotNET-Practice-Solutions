using System;
using System.Collections;

namespace Assignment3;

public class ReverseArrayClass
{
    public static void ReverseArray(ArrayList array)
    {
        int left = 0, Right = array.Count-1;
        while(left < Right)
        {
            object temp = array[left];
            array[left] = array[Right];
            array[Right] = temp;
            left++;
            Right--;
        }
    }

}
