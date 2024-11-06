using System;
using System.Diagnostics.CodeAnalysis;

namespace Assignment3;

public class Range<T> where T : IComparable<T>
{
    #region Properties
    
    public T Min;
    public T Max;

    #endregion

    #region Constractor
    public Range(T min, T max)
    {
        Min = min;
        Max = max;
    }
    #endregion

    #region Methods

    public bool IsInRange(T value)
    {
        return (value.CompareTo(Max) <= 0 && value.CompareTo(Min) >= 0);

    }
    public T Length()
    {
        dynamic x = Max;
        dynamic y = Min;
        return x - y;
    }

    #endregion
}
