using System;

namespace Assignment4_Delegate.Assignmet4Question2;

public delegate void Func<T, Employee>(T t, Employee employee);
public class Utility2<T> 
{
    public static void SortEmployees(List<Employee> employees, Func<Employee, Employee, int> comparison)
    {

    }

}
