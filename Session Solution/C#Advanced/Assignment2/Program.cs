using Assignment2.Q2;

namespace Assignment2.Q1;
internal class Program
{
    private static void Main(string[] args)
    {
        #region Q1
        ///Scenario: You're developing a payment system for an online store.
        ///You need to add multiple payment options, such as CreditCardPayment, BankTransfer, and PayPal. Each payment option should have its own way to process the payment.
        ///Implement a system that allows users to choose one of these payment methods at checkout and process the payment accordingly.
        ///Hint: Design your solution in such a way that adding new payment methods in the future would be easy and would not require modifying the existing code.
        
            PaymentProcess paymentProcess = new PaymentProcess();
        
            System.Console.WriteLine("How would like to pay [1]{CreditCardPayment} [2]{BankTransfer} [3]{Paypal}");
        
            int choice;
            while(true)
                {
                    if(Int32.TryParse(Console.ReadLine(), out choice) && (choice >=1 && choice <=3))
                    {
                        break;
                    }
                     System.Console.WriteLine("Wrong Selection Enter 1 , 2 or 3");
                }
            switch (choice)
            {
                case 1:
                    paymentProcess.Process(new CreditCard(), 100);
                    break;
                case 2:
                    paymentProcess.Process(new BankTransfer(), 100);
                    break;
                case 3:
                    paymentProcess.Process(new PayPal(), 100);
                    break;
            }
    
        #endregion    
        
        #region Q2
        ///Define an interface named IShape with a property Area and a method DisplayShapeInfo.
        ///Create two interfaces, ICircle and IRectangle, that inherit from IShape. 
        ///Implement these interfaces in classes Circle and Rectangle. 
        ///Test your implementation by creating instances of both classes and displaying their shape information.
        
        IShape Circle1 = new Circle(5);
        Circle1.DisplayShapeInfo();
        IShape Rectangle1 = new Rectangle(10,20);
        Rectangle1.DisplayShapeInfo();

        #endregion
    
    }
}