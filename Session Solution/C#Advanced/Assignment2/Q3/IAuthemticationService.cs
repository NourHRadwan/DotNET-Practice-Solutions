using System;
using System.Reflection.Metadata;

namespace Assignment2.Q3;

public interface IAuthemticationService
{
    public bool AuthenticateUser(string username, string password);
    
    public bool AuthorizeUser(string username, string role);

}
