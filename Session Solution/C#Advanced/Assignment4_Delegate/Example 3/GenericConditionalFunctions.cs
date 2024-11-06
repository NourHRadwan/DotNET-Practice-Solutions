using System;

namespace Assignment4_Delegate.Example_3;


public class GenericConditionalFunctions<T>
{
    public static bool checkStringLength(string x)
    {
        return x?.Length > 4;
    }
    public static bool CheckOdd(int x)
    {
        return x % 2 == 1;
    }
    public static bool CheckEven(int x)
    {
        return x % 2 == 0;
    }
    public static bool CheckDivisableBy7(int x)
    {
        return x % 7 == 0;
    }
    public static bool CheckDivisableBy10(int x)
    {
        return x % 10 == 0;
    }
}

