using System;

namespace Assignment4_Delegate.Example_3;

public delegate bool CheckCondition<T>(T x);
public class Helper2
{
    public static List<T> GetElementsBasedOnCondition<T>(List<T> list, CheckCondition<T> condition)
    {
        List<T> Result = new List<T>();
        if(list is not null)
        {
            for(int i = 0; i < list.Count; i++)
            {
                if(condition(list[i]))
                {
                    Result.Add(list[i]);
                }
            }
        }
        return Result;
    }

}
