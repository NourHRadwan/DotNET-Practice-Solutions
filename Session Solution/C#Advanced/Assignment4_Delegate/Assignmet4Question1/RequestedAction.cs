using System;

namespace Assignment4_Delegate.Assignmet_4_Question_1_;

public class RequestedAction
{

    public static void PrintCustomerDetails(Customer customer)
    {
        System.Console.WriteLine($"Name: {customer.name}, Mobile: {customer.mobile}, Email: {customer.email}");
    }
    public static void SendWelcomeEmail(Customer customer)
    {
        System.Console.WriteLine($"Welcome {customer.name}, we are glad to have you with us.");
    }

}
