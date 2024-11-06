using System;

namespace Assignment2.Q1;

public class PayPal : IPaymentSystem
{
    public void PaymentProcess(decimal amount)
    {
        System.Console.WriteLine("Processing PayPal Payment ");;
    }
}
