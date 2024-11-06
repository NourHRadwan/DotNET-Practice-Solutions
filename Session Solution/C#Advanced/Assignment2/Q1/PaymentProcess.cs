using System;

namespace Assignment2.Q1;

public class PaymentProcess
{
    public  void Process(IPaymentSystem paymentSystem,decimal amount)
    {
        paymentSystem.PaymentProcess(amount);
    }
}
