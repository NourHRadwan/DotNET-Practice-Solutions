using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System;
using System.Text;
namespace Day_03_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String Builder
            ///The StringBuilder class in C# is a mutable string type that allows you to efficiently modify and build strings.
            ///Unlike the standard string type, which is immutable, StringBuilder allows you to change the contents of a string without 
            ///creating a new object each time. This makes it ideal for scenarios where you need to perform multiple string manipulations, such as:
            ///1. Concatenating strings: You can use the Append method to add strings to the end of a StringBuilder object.
            ///2. Inserting strings: You can use the Insert method to insert strings at a specific index within a StringBuilder object.
            ///3. Replacing strings: You can use the Replace method to replace all occurrences of a substring with another string.
            ///4. Removing strings: You can use the Remove method to remove a substring from a StringBuilder object.

            //StringBuilder sb = new StringBuilder();
            //Console.WriteLine(sb);

            //// Append some strings
            //sb.Append("Hi "); // Append to the same line
            //sb.AppendLine("Hello, world!"); // Append a new line

            //Console.WriteLine(sb);

            //sb.Clear();

            //// Insert a string at index 6
            //sb.Append("He is ");
            //sb.Insert(6, "beautiful ");
            //Console.WriteLine(sb);

            //// Replace a substring
            //sb.Replace("beautiful", "everyone");
            //Console.WriteLine(sb);


            //// Remove a substring
            //sb.Remove(0, 7); // Remove "everyone"


            //sb.Clear();
            //sb.Append("Hello, World!");

            ////Remove the last 2 characters of string
            //sb.Remove(sb.Length - 2, 2);
            //Console.WriteLine(sb);

            //sb.Clear();
            ////Remove all occurrences of a substring
            //sb.Append("Hi Hi Hello, World! Hello, World! Hello, World!");
            //sb.Replace("Hello, World!", "");
            //Console.WriteLine(sb);

            //// Convert the StringBuilder to a string
            //string result = sb.ToString();

            //// Print the result
            ////Console.WriteLine(result);

            #endregion

            #region Conditional Statments (if,switch)

            #region Ex: 1 Numric Values
            //Console.WriteLine("Enter a month number existed at First Quarter: ");
            // int month = int.Parse(Console.ReadLine());
            //if 
            ///if (month == 1)
            ///    Console.WriteLine("January");
            ///else if (month == 2)
            ///    Console.WriteLine("Feburary");
            ///else if (month == 3)
            ///    Console.WriteLine("March");
            ///else
            ///    Console.WriteLine("The Entered number is not valid month in the 1st Qurater");

            ///Switch
            /// Jump to the case which is equal to the month
            /// Jump table is created by the compiler CLR in during Compilation time
            /// Switch is faster than if else for numrical values because of jump table

            ///switch (month)
            ///    case 1:
            ///      Console.WriteLine("Month Janurary");
            ///      break;
            /// {
            ///  case 2:
            ///      Console.WriteLine("Month Feburary");
            ///      break;
            ///  case 3:
            ///      Console.WriteLine("Month March");
            ///      break;
            ///  default:
            ///      Console.WriteLine("The Entred Number is not Valid");
            ///      break;}


            #endregion

            #region EX 2: String value
            /// Console.WriteLine("Please Enter your name: ");
            /// string name = Console.ReadLine();
            // Name -- > Hello, Name

            /// if (name == "Aliaa")
            ///     Console.WriteLine("Hello, Aliaa");
            /// else if (name == "Ahmed")
            ///     Console.WriteLine("Hello Ahmed");
            /// else if (name == "Samy")
            ///     Console.WriteLine("Hello, Samy");

            ///Switch
            /// String is not supported in switch in C# 7.3 and earlier
            /// From C# 8.0 and later, you can use string in switch
            /// In case switch in String, the compiler will convert the string to a hash code and compare the hash code
            /// The compiler will not generate a jump table for string
            /// The compiler will generate a jump table for int, char, and enum
            /// If number of cases is more than 5, Prefer to use switch
            /// If the number of cases is less than 5, Prefer to use if else

            ///switch (name)
            ///{
            ///    case "Aliaa":
            ///    case "aliaa":
            ///        Console.WriteLine("Hello, Aliaa");
            ///        break;
            ///    case "Ahmed":
            ///        Console.WriteLine("Hello, Ahmed");
            ///        break;
            ///    case "Samy":
            ///        Console.WriteLine("Hello, Samy");
            ///        break;
            ///    default:
            ///        Console.WriteLine("Hello, " + name);
            ///        break;
            ///}


            #endregion

            #region EX 3: goto
            //goto is a keyword in C# that is used to transfer control to a different part of the program.

            ///Console.WriteLine("Please Enter your Budget: ");
            ///int Budget = int.Parse(Console.ReadLine());
            ///
            ///switch (Budget)
            ///{
            ///    case 1000:
            ///        Console.WriteLine("Option 1");
            ///        break;
            ///    case 2000:
            ///        Console.WriteLine("Option 2");
            ///        goto case 1000;
            ///    case 3000:
            ///        Console.WriteLine("Option 3");
            ///        goto case 2000;
            ///}
            ///



            #endregion


            #endregion

            #region Ovulation of Switch in C#

            #region Ex01 [Switch In C# 6.0]
            // in C# 6.0, you can use switch with comparison operator > < =
            // but not with logical operator && ||
            ///Console.WriteLine("Enter your age: ");
            ///int age = int.Parse(Console.ReadLine());
            ///
            ///switch (age)
            ///{
            ///    case > 22:
            ///        Console.WriteLine("You are over 22");
            ///        break;
            ///    case < 22:
            ///        Console.WriteLine("You are under 22");
            ///        break;
            ///    default:
            ///        Console.WriteLine("You are 22");
            ///        break;
            ///
            ///}
            ///
            #endregion

            #region MyRegion

            #endregion

            #endregion
        }
    }
}
