namespace Day_02
{
    internal class Program
    {
        // Entry Point of the Program
        static void Main(string[] args)
        {
            #region Reference Type
            Point P1;
            /// declare for reference of type "Point", Refering to NULL
            /// This reference can refer to an object from type "Point" or another type "inherting from Point" 
            /// CLR will alocate 4 Bytes for the reference at STACK
            /// CLR will alocate 0 Bytes at the HEAP

            P1 = new Point();
            /// new: 
            ///1. Allocate Required Number of Bytes in HEAP (Object Size + CLR Overhead Variables) 
            ///2. Initalize allocated Bytes with Default Values of Its DataType
            ///3. Call User-Defined Constructor [If Exists]
            ///4. Assign the Allocated Object to the Reference 'P1'
            ///
            #region Object Size in C#
            /*
             When creating new object in C#, the Size of the object is determined by two factors:
            1. size of the object: This includes the size of the all the fields declared in the class
            2. Overhead variables by the CLR: The CLR add additional informations to each object like
            the type of the object and a reference to it is metadata. This informations is typically small 
            but it can add a bytes to the overall size of the object.
             */
            #endregion



            //Console.WriteLine(P1.x); // 0
            //Console.WriteLine(P1.y); // 0

            //Point P2;
            //P2 = new Point();

            //P2 = P1; 

            //P2.x = 5;
            //P2.y = 5;


            //Console.WriteLine(P1.x); // 5
            //Console.WriteLine(P1.y); // 5


            #endregion

            #region Fraction Numbers and Discard

            //float x = 3.5f;
            //double y = 3.5;
            //decimal z = 3.5m;

            //Discard Operator --> imporve readability
            //long Number = 123_456_789;
            #endregion

            #region Implicit Casting Vs Explicit Casting 

            ///Implicit Casting
            ///int x = 5;
            ///long y = x;

            ///Explicit Casting
            //long x = 5599449933991195;

            //Explicit Casting is Unsafe must use checked to prevent overflow

            //checked
            //{
            //    int Y = (int)x;
            //    unchecked
            //    {
            //        Console.WriteLine(Y); //Y is local Variable in the Stack
            //    }          
            //}

            //// another method to prevent overflow is to use the defence

            //int Y = x.GetType() == typeof(int) ? (int)x : 0; 


            #endregion

            #region convert

            //// Convert is a Class containing set of methods used for casting from one type to another
            //Console.WriteLine("Please Enter your name: ");
            //string name = Console.ReadLine() ?? "NA";
            ///// Readline return null if the user press Enter without typing anything
            ///// ?? is the null-coalescing operator
            ///// it returns the left-hand operand if the operand is not null; otherwise it returns the right hand operand
            ///// if the user press Enter without typing anything, the name will be "NA"
            ///// if the user type anything, the name will be the user input

            //Console.WriteLine("Please Enter your age: ");
            //int Age = Convert.ToInt32(Console.ReadLine());
            ///// Convert.ToInt32 is a method that convert the string to int


            //Console.WriteLine("Please Enter your salary");
            //Decimal Salary = Convert.ToDecimal(Console.ReadLine());

            //Console.Clear();
            //Console.Beep(324, 3000);

            //Console.WriteLine($"your Name is {name}" +
            //    $"\n your Age is {Age} " +
            //    $"\n your Salary is {Salary}");
            #endregion

            #region Parse
            ///parse is a method that convert the string to caller datatype

            //Console.WriteLine("Please Enter your name: ");
            //string name = Console.ReadLine() ?? "NA";


            //Console.WriteLine("Please Enter your age: ");
            //int Age = int.Parse(Console.ReadLine() ?? "0");
            ///// Convert.ToInt32 is a method that convert the string to int


            //Console.WriteLine("Please Enter your salary");
            //decimal Salary = decimal.Parse(Console.ReadLine() ?? "0");

            //Console.Clear();
            //Console.Beep(324, 3000);

            //Console.WriteLine($"your Name is {name}" +
            //    $"\n your Age is {Age} " +
            //    $"\n your Salary is {Salary}");


            #endregion

            #region Try Parse
            /// Try Parse is static method that attempts to convert a string 
            /// representation of a value to it's corresponding data types
            /// return a bool value indicating success or failure
            /// and the converted value if successful
            /// bool TryParse(string input, out dataType result);

            //string x = "10";
            //string z = "Ahmed";
            //int y;

            //bool flag = int.TryParse(x, out y);

            //Console.WriteLine(flag); //True
            //Console.WriteLine(y); //10

            //flag = int.TryParse(z, out y);
            //Console.WriteLine(flag); //False
            //Console.WriteLine(y); // 0 --> The default value of int

            #endregion

            #region Operators Priority [Precedence] and Asscoitivity
            /// 1. Unary Operators (Prefix)
            /// 2. Round Braces ()
            /// 3. * / %
            /// 4. + -

            //int Equation = 4 + 3 * 8;
            //Console.WriteLine(Equation);

            ///int a = 20;
            ///int b = 10;
            ///int c = 15;
            ///int d = 5;
            ///int e;
            ///
            ///e = (a + b) * c / d;
            ///Console.WriteLine(e); // (30 * 15) / 5 
            ///
            ///e = ((a + b) * c / d); // (30 * 15) / 5
            ///Console.WriteLine(e);
            ///
            ///e = (a + b) * (c / d);
            ///Console.WriteLine(e);
            ///
            ///e = a + (b * c / d);
            ///Console.WriteLine(e);
            ///
            #endregion

            #region Control Statments
            #region Looping

            #region For / Foreach

            int [] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /// For
            ///better for preformance than foreach
            /// it is used when we need to access the index of the element
            /// any change to the element will affect the original collection

            ///for(int i =0; i <Numbers.Length; i++)
            ///{
            ///   Console.WriteLine(Numbers[i]);
            ///}

            /// Foreach
            ///Datatypes must be Class that inhert from Interface IEnumerable
            ///for each element in the collection, the compiler will create a new variable to store the element
            ///this variable is read-only
            ///the scope of this variable is the loop only
            ///any change to this variable will not affect the original collection
            ///it is called for each iteration variable
            

            foreach (int number in Numbers)
            { 
                            Console.WriteLine(number);
            }
            #endregion

            #endregion
            #endregion
        }
    }
}
