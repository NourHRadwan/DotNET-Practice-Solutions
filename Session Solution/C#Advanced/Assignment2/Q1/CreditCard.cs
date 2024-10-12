using System;

namespace Assignment2.Q1;

public class CreditCard : IPaymentSystem
{
    public void PaymentProcess(decimal amount)
    {
        System.Console.WriteLine("Processing CreditCard Payment ");;
    }
}
