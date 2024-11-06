using System;

namespace Assignment4_Delegate.Assignmet_4_Question_1_;

public delegate void Action<T>(T x);
public class Utility
{
    public static void PerformActionOnCustomers<T>(List<Customer> customers, Action<Customer> action)
    {
        foreach (var item in customers)
            action(item);
    }
}