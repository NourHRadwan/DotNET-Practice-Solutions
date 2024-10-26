using System;

namespace Assignment2.Q2;

public class Circle : ICircle
{
    public Circle(double radius)
    {
        Radius = radius;
    }

    public double Radius { 
        get; set; }
    public double Area { 
    get
    {
        return Math.PI * Radius;
    } }

    public void DisplayShapeInfo()
    {
       System.Console.WriteLine($"This Circle has Area of {Area} and Raduis of {Radius}");;
    }
}
