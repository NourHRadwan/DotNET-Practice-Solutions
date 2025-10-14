namespace OOP;
using MyClassLibrary;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        TypeA typeA = new TypeA();
        //typeA.X = 10; // unaccessible due to protection level
        //typeA.Y = 20; // unaccessible due to protection level
        typeA.Z = 30; // accessible

    }
}
