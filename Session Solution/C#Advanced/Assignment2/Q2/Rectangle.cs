using System;

namespace Assignment2.Q2;

public class Rectangle : IRectangle
{
    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public double Length { get; set; }
    public double Width { get; set; }
    public double Area { get 
    {
        return Length * Width;
    }}
    public void DisplayShapeInfo()
    {
        System.Console.WriteLine($"This rectangle has width {Width} and Length {Length} and Area of {Area}");
    }
}
