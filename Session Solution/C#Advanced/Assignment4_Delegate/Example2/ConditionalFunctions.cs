using System;

namespace Assignment4_Delegate.Example2;

public class ConditionalFunctions
{
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
