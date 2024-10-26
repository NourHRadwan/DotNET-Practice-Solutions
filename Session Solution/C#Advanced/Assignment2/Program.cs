using Assignment2.Q2;
using Assignment2.Q3;

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

        #region Q3
        ///In this example, we start by defining the IAuthenticationService interface with two methods: AuthenticateUser and AuthorizeUser. The BasicAuthenticationService class implements this interface and provides the specific implementation for these methods.
        ///In the BasicAuthenticationService class, 
                ///the AuthenticateUser method compares the provided username and password with the stored credentials. It returns true if the user is authenticated and false otherwise.
                ///The AuthorizeUser method checks if the user with the given username has the specified role. It returns true if the user is authorized and false otherwise.
        ///In the Main method, we create an instance of the BasicAuthenticationService class and assign it to the authService variable of type IAuthenticationService. We then call the AuthenticateUser and AuthorizeUser methods using this interface reference.
        ///This implementation allows you to switch the authentication service implementation easily by creating a new class that implements the IAuthenticationService interface and providing the desired logic for authentication and authorization.
        
        IAuthemticationService authService = new BasicAuthenticationService();
        
        if(authService.AuthenticateUser("Admin", "Password"))
        {
            System.Console.WriteLine("User Authenticated");
        }
        else
        {
            System.Console.WriteLine("User Not Authenticated");
        }

            
        
        #endregion
    
        
    }
}