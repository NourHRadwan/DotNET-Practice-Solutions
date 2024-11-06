using System;

namespace Assignment4_Delegate.Example_3;


public class GenericConditionalFunctions<T>
{
    public static bool checkStringLength(string x)
    {
        return x?.Length > 4;
    }
    
}

