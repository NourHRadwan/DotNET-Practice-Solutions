using System;
using System.Collections.Concurrent;
using System.Security.Cryptography.X509Certificates;
namespace FreeCodeCamp_Revision_Session;
//This is session to revise the basics of C# programming language from the FreeCodeCamp course.


class Program
{
    static void Main(string[] args)
    {
        // int age = 23;
        // System.Console.WriteLine(age);
        // System.Console.WriteLine(int.MaxValue);
        // System.Console.WriteLine(int.MinValue);

        // long bignum = 1234567890123456789L;
        // System.Console.WriteLine(bignum);
        // System.Console.WriteLine(long.MaxValue);
        // System.Console.WriteLine(long.MinValue);

        // int x = 10,
        //     y = 20,
        //     z = 30;

        // bool success = true;
        // while(success)
        // {
        //     System.Console.Write("Enter a number: ");
        //     string name = Console.ReadLine() ?? "";
        //     if(int.TryParse(name, out int number))
        //     {
        //         success = false;
        //         System.Console.WriteLine($"You entered {number}");
        //     }
        //     else
        //     {
        //         System.Console.WriteLine("Invalid number");
        //     }
        // }

        //Fizz Buzz game from 1 to X
        //Create a for loop that will iterate from 1 to X
        // 3 and 5 = FizzBuzz
        // 3 = Fizz
        // 5 = Buzz
        // else print the number

         bool success = true;
         while (success)
         {
             System.Console.Write("Enter a number: ");
             string numberInput = Console.ReadLine() ?? "";
             if (int.TryParse(numberInput, out int number))
             {
                 success = false;
                 for (int i = 1; i <= number; i++)
                 {
                    bool ThreeDiv = i % 3 == 0;
                    bool FiveDiv = i % 5 == 0;
                     if (FiveDiv && ThreeDiv)
                         System.Console.WriteLine("FizzBuzz");
                     else if (ThreeDiv)
                         System.Console.WriteLine("Fizz");
                     else if (FiveDiv)
                         System.Console.WriteLine("Buzz");
                     else
                         System.Console.WriteLine(i);
                 }
             }
             else
             {
                 System.Console.WriteLine("Invalid number");
             }
         }


    }
}
