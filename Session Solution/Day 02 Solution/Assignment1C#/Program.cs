namespace Assignment1C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region Q1
            //Write a program that allows the user to enter a number then print it.

            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"The number is {number}");

            #endregion

            #region Q2
            // Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen 
            string str = "Nour";
            //int num = int.Parse(str); //The console showed that the str is incorrect format to convert to int

            #endregion

            #region Q3
            //Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            float num1 = 5.5f;
            float num2 = 3.5f;
            float result = num1 % num2; 
            Console.WriteLine(result); //The console showed that the result is 1.9999999
            #endregion

            #region Q4
            //Write C# program that Extract a substring from a given string.
            

            #endregion
            #region Q5
            //Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            int x = 5;
            int y = x;
            x = 10;
            Console.WriteLine(y); //The console showed that the value of y is 5
            Console.WriteLine(x);

            #endregion
            #region Q6
            //Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            Point p1 = new Point();
            p1.x = 5;
            p1.y = 5;
            Point p2 = new Point(); 
            p2.x = 10;
            p2.y = 10;
            Console.WriteLine($"P1 is {p1.x} , {p1.y}"); //The console showed that the value of p1 is 5,5
            Console.WriteLine($"P2 is {p2.x} , {p2.y}"); //The console showed that the value of p2 is 10,10

            p1 = p2;
            Console.WriteLine($"P1 is {p1.x} , {p1.y}"); //The console showed that the value of p1 is 10,10
            Console.WriteLine($"P2 is {p2.x} , {p2.y}"); //The console showed that the value of p2 is 10,10

            #endregion

            #region Q7
            //Write C# program that take two string variables and print them as one variable 
            string Fname = "Nour";
            string Lname = "Hossam";
            string FullName = Fname + " " + Lname;
            Console.WriteLine(FullName);
            #endregion


            #region Q8
            //Which of the following statements is correct about the C#.NET code snippet given below?
            int d; 
            d = Convert.ToInt32(!(30 < 20));
            Console.WriteLine(d);  //The console showed that the value of d is 1

            // The expression !(30 < 20) will return false because 30 is greater than 20.
            // the ! operator will reverse the result to true.
            // The Convert.ToInt32() method will convert the true value to 1.
            //The value of d will be 1.

            #endregion

            #region Q9
            //Which of the following is the correct output for the C# code given below?
            Console.WriteLine(13 /2 + "  " + 13 % 2);
            // 13/2 = 6
            // 13%2 = 1
            // The output will be 6 1
            #endregion

            #region Q10
            //10-What will be the output of the C# code given below?
            int num = 1, z = 5;

            if(!(num <= 0))  //(1<=0) = false => !(false) = true
                Console.WriteLine( ++num + z++ + " " + ++z); //2 + 5   7 => 7  7
            else
                Console.WriteLine(--num + z-- + " " + --z);
            #endregion

        }
    }
}
