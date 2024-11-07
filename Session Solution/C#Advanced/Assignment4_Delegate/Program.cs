using Assignment4_Delegate;
using Assignment4_Delegate.Assignmet_4_Question_1_;
using Assignment4_Delegate.Example2;
using Assignment4_Delegate.Example_3;
using System.Security.Cryptography.X509Certificates;


internal class Program
{
        private static void Main(string[] args)
        {
                #region BubbleSort Non Generic Example
                //int[] Numbers = new int[] { 10, 20, 50, 3, 2, 1, 38, 4, 9, 8 };
                // SortingAlgorithm.BubbleSort(Numbers, CompareFunctions.CompareGreater);
                // foreach (var item in Numbers)
                // {
                //     Console.WriteLine(item);
                // }
                // System.Console.WriteLine("=====================================");
                // SortingAlgorithm.BubbleSort(Numbers, CompareFunctions.CompareSmaller);
                // foreach (var item in Numbers)
                // {
                //     Console.WriteLine(item);
                #endregion

                #region BubbleSort Generic Example
                // string[] Names = { "Ahmed", "Mona", "Amr", "Kareem", "Maha" };
                // SortingAlgorithm<string>.BubbleSort(Names, CompareFunctions<string>.SortAsce);
                // foreach (var item in Names)
                // {
                //     System.Console.WriteLine(item);
                // }
                // System.Console.WriteLine("=====================================");
                // SortingAlgorithm<string>.BubbleSort(Names, CompareFunctions<string>.SortDesc);
                // foreach (var item in Names)
                // {
                //     System.Console.WriteLine(item);
                // }


                #endregion


                #region Delegate Example 2: Create a list of nummbers based on a condition

                ///List<int> Numbers = Enumerable.Range(1, 100).ToList();
                ///System.Console.WriteLine("Odd Numbers");
                ///List<int> oddNumbers = Helper.GetNumbers(Numbers, ConditionalFunctions.CheckOdd);
                ///foreach (var item in oddNumbers)
                ///{
                ///    System.Console.Write($"{item} ");
                ///}
                ///System.Console.WriteLine("\nEven Numbers");
                ///
                ///List<int> EvenNumbers = Helper.GetNumbers(Numbers, ConditionalFunctions.CheckEven);
                ///foreach (var item in EvenNumbers)
                ///{
                ///    System.Console.Write($"{item} ");
                ///}
                ///System.Console.WriteLine("\nDivisable by 7 Numbers");
                ///
                ///List<int> NumbersDivisableBy7 = Helper.GetNumbers(Numbers, ConditionalFunctions.CheckDivisableBy7);
                ///foreach (var item in NumbersDivisableBy7)
                ///{
                ///    System.Console.Write($"{item} ");
                ///}
                ///System.Console.WriteLine("\nDivisable by 10 Numbers");
                ///
                ///List<int> NumbersDivisableBy10 = Helper.GetNumbers(Numbers, ConditionalFunctions.CheckDivisableBy10);
                ///foreach (var item in NumbersDivisableBy10)
                ///{
                ///    System.Console.Write($"{item} ");
                ///}

                #endregion

                #region Delegate Example 3: Create a list of Generics based on a condition
                ///List<string> Names = new List<string>() { "Ahmed", "Omar", "May", "Kareem", "Manar" };
                ///
                ///List<string> Result  = Helper2.GetElementsBasedOnCondition<string>(Names, GenericConditionalFunctions<string>.checkStringLength);
                ///foreach (var item in Result)
                ///{
                ///    System.Console.WriteLine(item);
                ///} 
                ///
                /////Using the same class to get numbers
                ///List<int> Numbers = Enumerable.Range(1, 100).ToList();
                ///System.Console.WriteLine("Odd Numbers");
                ///List<int> oddNumbers = Helper2.GetElementsBasedOnCondition<int>(Numbers, GenericConditionalFunctions<int>.CheckOdd);
                ///foreach (var item in oddNumbers)
                ///{
                ///    System.Console.Write($"{item} ");
                ///}
                ///System.Console.WriteLine("\nEven Numbers");
                ///
                ///List<int> EvenNumbers = Helper2.GetElementsBasedOnCondition<int>(Numbers, GenericConditionalFunctions<int>.CheckEven);
                ///foreach (var item in EvenNumbers)
                ///{
                ///    System.Console.Write($"{item} ");
                ///}
                ///System.Console.WriteLine("\nDivisable by 7 Numbers");
                ///
                ///List<int> NumbersDivisableBy7 = Helper2.GetElementsBasedOnCondition<int>(Numbers, GenericConditionalFunctions<int>.CheckDivisableBy7);
                ///foreach (var item in NumbersDivisableBy7)
                ///{
                ///    System.Console.Write($"{item} ");
                ///}
                ///System.Console.WriteLine("\nDivisable by 10 Numbers");
                ///
                ///List<int> NumbersDivisableBy10 = Helper2.GetElementsBasedOnCondition<int>(Numbers, GenericConditionalFunctions<int>.CheckDivisableBy10);
                ///foreach (var item in NumbersDivisableBy10)
                ///{
                ///    System.Console.Write($"{item} ");
                ///}
                #endregion

                #region Assignmet 4 Question 1
                ///Assignment 1:
                ///Write an application that stores data about some clients. Each client has a name, mobile and an email.
                ///Write a method PerformActionOnCustomers(List<Customer> customers, Action<Customer> action) that takes an action delegate and performs the given action on all customers.
                ///Use this method to:
                ///Print customer details.
                ///Send a welcome email.

                List<Customer> customers = new List<Customer>()
                {
                    new Customer {name = "Nour Radwan", mobile = 01000000000, email = "NourRadwan@Gmail.com"},
                    new Customer {name = "Mohamed Hassan", mobile = 01022000000, email = "MohamedHassa@Gmail.com"},
                    new Customer {name = "HossamEldin Ali", mobile = 01000023400, email = "HossamEldinAlidwan@Gmail.com"},
                };
                Action<Customer> PrintCustomerDetails = (customers) =>
                {
                        System.Console.WriteLine($"Name: {customers.name}, Mobile: {customers.mobile}, Email: {customers.email}");
                };

                Action<Customer> SendWelcomeEmail = (customers) =>
                {
                        System.Console.WriteLine($"Welcome {customers.name}, we are glad to have you with us.");
                };

                Utility.PerformActionOnCustomers<Customer>(customers, PrintCustomerDetails);
                Utility.PerformActionOnCustomers<Customer>(customers, SendWelcomeEmail);

                ///Name: Nour Radwan, Mobile: 1000000000, Email: NourRadwan@Gmail.com
                ///Name: Mohamed Hassan, Mobile: 1022000000, Email: MohamedHassa@Gmail.com
                ///Name: HossamEldin Ali, Mobile: 1000023400, Email: HossamEldinAlidwan@Gmail.com
                ///Welcome Nour Radwan, we are glad to have you with us.
                ///Welcome Mohamed Hassan, we are glad to have you with us.
                ///Welcome HossamEldin Ali, we are glad to have you with us.
                #endregion

                #region  Assignmet 4 Question 2
                ///Write an application that stores data about some employees.Each employee has a name, years of experience and salary.
                ///Write a method that takes a delegate as a parameter to define custom sorting criteria SortEmployees(List<Employee>, Func<Employee, Employee, int> comparison).
                ///Write a method CalculateBonus(List<Employee> employees, Func<Employee, double> bonusCalculator) that calculates a bonus for each employee using a delegate.Calculate bonuses based on different criteria(e.g., experience, salary).




                #endregion

                #region Built in Delegates with Lambda Expressions and var
                //1. Predicate
                // Take 1 parameter (Generic) and return a boolean

                //Predicate<int> predicate;
                //predicate = (x) => x == 0;
                var Predicate = (int x) => x == 0;
                //System.Console.WriteLine(predicate(10)); //False
                //
                ////2. Func ==> Take 1 or more parameters and return a value
                //Func<int, int> func; //Alaway the last parameter is the return type
                //func = x => x * 2;
                var Func = (int x) => x * 2;
                //System.Console.WriteLine(func(10)); //20
                //
                //Func<int, string> func2;
                //func2 = x => x.ToString();
                //System.Console.WriteLine(func2(10)); //10
                //
                //
                ////3. Action ==> Take 1 or more parameters and return void
                //Action<int> action;
                //action = x => Console.WriteLine(x * 2);
                var Action = (int x) => System.Console.WriteLine(x * 2); //using var to avoid writing the type
                //action(10); //20
                #endregion
        }
}