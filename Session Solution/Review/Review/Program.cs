namespace Review;

class Program
{
    static void Main(string[] args)
    {
        #region Example 1: Read Data from Console
        // Console.WriteLine("Enter your Data:");
        // Console.Write("Name: ");
        // string? name = Console.ReadLine();

        // //===============
        // Console.Write("Age: ");
        // int age = Convert.ToInt32(Console.ReadLine());
        // //===============
        // Console.Write("Salary: ");
        // decimal salary = Convert.ToDecimal(Console.ReadLine());
        // //===============


        // Console.Clear();

        // System.Console.WriteLine($"Name: {name}, Age: {age}, Salary: {salary}");
        #endregion

        #region Example 2: String Formating
        // String Interpolation
        // String Interpolation allows you to embed expressions directly within string using {} and ($) befor the string.

        //Equation : 10 + 5 = 15
        int x = 10, y = 5;
        int result = x + y;
        System.Console.WriteLine($"Equation : {x} + {y} = {result}");


        // String.Formt Method

        // Composite Formatting


        // String Concatenation (NoT Recommended) String Concatenation is the process of combining two or more strings together 
        // using the + operator. String Concatenation is not recommended because it can lead to performance issues, 
        // especially when concatenating multiple strings in a loop.

        #endregion

        #region Example 3: Conditional Statements

        Console.Write("Please Enter a month number in first quarter: ");
        int.TryParse(Console.ReadLine(), out int monthNumber); //handle invalid user input and avoid runtime exceptions

        if (monthNumber == 1)
        {
            Console.WriteLine("Hello January");
        }
        else if (monthNumber == 2)
        {
            Console.WriteLine("Hello February");
        }
        else if (monthNumber == 3)
        {
            Console.WriteLine("Hello March");
        }
        else
        {
            Console.WriteLine("Invalid month number");
        }

        Console.Read(); //keep the console window open until a key is pressed

        #endregion

        #region swtich case
        //Jump Table Implementation provide better performance than if-else-if ladder when dealing with multiple discrete values.
        //Improved Readability: switch-case statements can be more readable and easier to understand than
        //Jump Table must have unique case labels. Duplicate case labels will result in a compile-time error.
        switch (monthNumber)
        {
            case 1:
                Console.WriteLine("Hello January");
                break;
            case 2:
                Console.WriteLine("Hello February");
                break;
            case 3:
                Console.WriteLine("Hello March");
                break;
            default:
                Console.WriteLine("Invalid month number");
                break;
        }

        #endregion

    }
}
