using System;

namespace Assignment4_Delegate;

public class CompareFunctions<T>
{
    public static bool CompareGreater(int a, int b)
    {
        return a > b;
    }

      public static bool CompareSmaller(int a, int b)
    {
        return a < b;
    }

    public static bool SortAsce(string a, string b)
    {
        return a.Length > b.Length;
    }

    public static bool SortDesc(string a, string b)
    {
        return a.Length < b.Length;
    }
    
}
