using LibLoginAuthenticator;
using System;

namespace ConLoginAuthenticator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoginAuthenticator authenticator = new LoginAuthenticator();
            bool authenticated = false;

            while (!authenticated)
            {
                Console.Write("Enter username: ");
                string username = Console.ReadLine();
                authenticator.Username = username == "" ? null : username;
                Console.Write("Enter password: ");
                string password = Console.ReadLine();
                authenticator.SetPassword(password == "" ? null : password);
                bool? result = authenticator.Authenticate();
                if (result == null)
                {
                    Console.WriteLine("Please enter both username and password.");
                }
                else if (result == true)
                {
                    Console.WriteLine("Authentication successful!");
                    authenticated = true;
                }
                else
                {
                    Console.WriteLine("Authentication failed. Please try again.");
                }
            }
        }
    }
}
