using System.Text;

namespace Day_02
{
    internal class Program
    {
        // Entry Point of the Program
        static void Main(string[] args)
        {
            #region Reference Type
            //Point P1;
            /// declare for reference of type "Point", Refering to NULL
            /// This reference can refer to an object from type "Point" or another type "inherting from Point" 
            /// CLR will alocate 4 Bytes for the reference at STACK
            /// CLR will alocate 0 Bytes at the HEAP

            //P1 = new Point();
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

            //int [] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /// For
            ///better for preformance than foreach
            /// it is used when we need to access the index of the element
            /// any change to the element will affect the original collection
            /// in For you can access the index of the element
            /// in For you can change the element value
            /// in For you can access the element by index
            /// in For you can control the execution of the loop by continue or break

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
            ///less preformance as it create a copy of the element in each iteration

            ///foreach (int number in Numbers)
            ///{ 
            ///                Console.WriteLine(number);
            ///}

            #endregion

            #region While - DoWhile


            #region Do While
            // Do While
            ///int Number;
            ///bool flag;
            ///do
            ///{
            ///    Console.WriteLine("Enter an Even number: ");
            ///    //Number = int.Parse(Console.ReadLine());   --> Exception if the user enter a non-integer value
            ///    flag = int.TryParse(Console.ReadLine(), out Number); // --> TryParse return a bool value indicating success or failure
            ///    // 10 => True --> Number = 10
            ///    // "Ahmed" => False --> Number = 0
            ///}
            ///while (Number % 2 == 1 || !flag);
            ///// The operator || is short circuit if the first condition is true, the second condition will not be evaluated
            ///// only if the user enter a non-integer value, the second condition will be evaluated
            ///// if the user enter an odd number, the second condition will not be evaluated
            ///Console.WriteLine($"{Number} Is an Even Number");


            #endregion

            #region While
            ///int x = 2;
            ///bool flag = true;
            ///while (x % 2 == 0 || !flag)
            ///{
            ///    Console.WriteLine("Sorry your Number is even, Enter an odd Number: ");
            ///    flag = int.TryParse(Console.ReadLine(), out x);
            ///    // 10 --> Try Parse = True --> x =10
            ///
            ///    // 5 --> Try Parse = False --> x = 5
            ///
            ///    // "Ahmed" --> Try Parse = False --> x = 0
            ///}
            ///
            #endregion

            #endregion
            #endregion
            #endregion

            #region String vs String Builder

            #region String
            /// String is a reference type, Works as Value Type
            /// String is immutable Datatype [Value can't be changed]
            /// String internally is an array of char
            /// Nour -> N O U R
            ///
            ///string Name;
            /// Declare a reference of type string, refering to NULL
            /// CLR will alocate 4 Bytes for the reference at STACK
            /// CLR will alocate 0 Bytes at the HEAP
            ///
            ///Name = new string("Ahmed");
            /// CLR will allocate 10 Bytes at the HEAP (5 char * 2 Bytes)
            /// initialize the allocated Bytes with the default value of char datatype ' '
            /// call the user-defined constructor --> ("Ahmed") To initialize the allocated Bytes with the value of the string
            /// Assign reference to alocated Object to the reference 'Name'
            ///  Name = "Ahmed" --> is Syntax Sugar for Name = new string("Ahmed")
            ///
            ///string Name2 = "Ahmed";
            ///string Name3 = "Ahmed";
            ///
            ///Console.WriteLine($"Name 2 is {Name2}");
            ///Console.WriteLine($"Name 2 HashCode  is {Name2.GetHashCode()}"); // Same HashCode as Name3
            ///
            ///Console.WriteLine($"Name 3 is {Name3}");
            ///Console.WriteLine($"Name 3 HashCode  is {Name3.GetHashCode()}"); // Same HashCode as Name2
            ///
            /// Name2 and Name3 are refering to the same object in the HEAP
            /// because Ldstr IL instruction is used to load the string from the string pool

            #region EX 1:
            ///string Name2 = "Ahmed";
            ///string Name3 = "Omar";
            ///
            ///Console.WriteLine($"Name 2 is {Name2}");
            ///Console.WriteLine($"Name 2 HashCode  is {Name2.GetHashCode()}"); // Same HashCode as Name3
            ///
            ///Console.WriteLine($"Name 3 is {Name3}");
            ///Console.WriteLine($"Name 3 HashCode  is {Name3.GetHashCode()}"); // Same HashCode as Name2
            ///
            ///Name2 = Name3; // Name2 refer to "Omar" and Name3 refer to "Omar"
            /// "Ahmed" is not refered by any reference, it will be collected by the GC
            /// "Ahmed" is now unreachable object beacuse no reference is refering to it
            /// "Omar" is refered by two references Name2 and Name3

            ///Console.WriteLine($"Name 2 is {Name2}");
            ///Console.WriteLine($"Name 2 HashCode  is {Name2.GetHashCode()}");
            ///
            ///Console.WriteLine($"Name 3 is {Name3}");
            ///Console.WriteLine($"Name 3 HashCode  is {Name3.GetHashCode()}");
            ///
            ///Name3 = "Ali";
            /// Name2 refer to "Omar" and Name3 refer to "Ali"
            /// Name3 created a new object in the HEAP with the value "Ali"
            /// "Omar" is not refered by any reference, it will be collected by the GC
            /// beacuse string is immutable, the value of the object in the HEAP can't be changed
            /// 
            ///Console.WriteLine($"Name 2 is {Name2}");
            ///Console.WriteLine($"Name 2 HashCode  is {Name2.GetHashCode()}");
            ///
            ///Console.WriteLine($"Name 3 is {Name3}");
            ///Console.WriteLine($"Name 3 HashCode  is {Name3.GetHashCode()}");


            #endregion


            #endregion

            #region String Builder
            /// String Builder is a reference Type
            /// Is Mutable Datatype [Value Can be Changed]
            /// Internally is A LinkedList of Chars
            /// 

            ///StringBuilder Massege;
            /// Declare a reference of type string, refering to NULL
            /// CLR will alocate 4 Bytes for the reference at STACK
            /// CLR will alocate 0 Bytes at the HEAP

            ///Massege = new StringBuilder("Hello");
            /// CLR will allocate 10 Bytes at the HEAP (5 char * 2 Bytes)
            /// initialize the allocated Bytes with the default value of char datatype ' '
            /// call the user-defined constructor --> ("Hello") To initialize the allocated Bytes with the value of the string
            /// Assign reference to alocated Object to the reference 'Massege'
            /// No syntax Sugar for String Builder

            ///Console.WriteLine($"Massege is {Massege}");
            ///Console.WriteLine($"Massage Hash code is {Massege.GetHashCode()}");
            ///Massage Hash code is 43942917


            // Append
            ///Massege.Append(" Nour");
            ///Console.WriteLine($"Massege is {Massege}");
            ///Console.WriteLine($"Massage Hash code is {Massege.GetHashCode()}");
            ///Massage Hash code is 43942917

            /// The same Hash code means the same object
            /// in StringBuilder you can modify the object size because it is a LinkedList
            /// in StringBuilder you can modify the object value
            /// Stringbuilder is class representing a mutable string of characters
            /// StringBuilder is internally a LinkedList of blocks each of which hold a chuck of the string

            #region StringBuilder Methods
            /// Append
            /// after the Append, the cursor will not move to the next line
            ///StringBuilder Massege = new StringBuilder("Hello");
            ///Massege.Append(" to");
            ///Console.WriteLine($"Massege is {Massege}");

            ///AppendLine
            /// After the AppendLine, the cursor will move to the next line
            ///Massege.AppendLine(" Nour");
            ///Console.WriteLine($"Massege is {Massege}");

            ///Remove
            /// Remove a specified substring from the StringBuilder
            /// 
            ///Massege.Remove(0, 5);
            ///Console.WriteLine($"Massege is {Massege}");

            ///Insert
            /// Insert a specified substring at a specified index
            ///Massege.Insert(0, "Hi");
            ///Console.WriteLine($"Massege is {Massege}");

            ///AppendFormat
            /// Append a formatted string to the StringBuilder
            ///int Age = 30;
            ///Massege.AppendFormat(" My Age is {0} \n", Age);

            ///AppendJoin
            /// Append a set of strings to the StringBuilder
            
            ///Massege.AppendJoin(" ", "I", "Love", "You"); // I Love You
            ///Console.WriteLine($"Massege is {Massege}");

            ///Interview Question:
            ///When to use String and when to use StringBuilder
            /// Use String when you are sure that the value of the string will not be changed
           
            #endregion

            #endregion



            #endregion
        }
    }
}
