using System;

namespace Assignment4_Delegate.Example2;

public delegate bool ConditionalFunctionalDelegate(int x);
public static class Helper
{
    public static List<int> GetNumbers(List<int> Numbers, ConditionalFunctionalDelegate condition)
    {
        List<int> Result = new List<int>();
        if(Numbers is not null && condition is not null)
            for(int i = 0; i < Numbers.Count; i++)
                if(condition(Numbers[i]))
                    Result.Add(Numbers[i]);
                
        return Result;
    }
}
