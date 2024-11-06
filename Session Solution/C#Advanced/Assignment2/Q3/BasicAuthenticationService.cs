using System;

namespace Assignment2.Q3;

public class BasicAuthenticationService : IAuthemticationService
{
    public bool AuthenticateUser(string username, string password)
    {
        if(username == "Admin" && password == "Password")
        {
            return true;
        }
            return false;
    }

    public bool AuthorizeUser(string username, string role)
    {
        if(username == "Admin" && role == "Role")
        return true;

        return false;
    }
}
