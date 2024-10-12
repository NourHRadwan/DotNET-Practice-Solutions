namespace Assignment2.Q1;
internal class Program
{
    private static void Main(string[] args)
    {
        #region Q1
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
        
        #endregion
    
    }
}