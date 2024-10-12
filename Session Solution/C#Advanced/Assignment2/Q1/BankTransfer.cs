using System;

namespace Assignment2.Q1;

public class BankTransfer : IPaymentSystem
{
    public void PaymentProcess(decimal amount)
    {
        System.Console.WriteLine("Processing BankTransfer Payment ");;
    }
}
