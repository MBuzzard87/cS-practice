using System;
using System.Collections.Generic;
using System.Text;

namespace practice
{
    class UserPractice
    {
        static string username;
        static string password;

        public static void Register()
        {
            Console.WriteLine("Create a username: ");
            username = Console.ReadLine();
            Console.WriteLine("Create a password: ");
            password = Console.ReadLine();
        }

        public static void Login()
        {
            Console.WriteLine("Please enter your username to login");
            if(username == Console.ReadLine())
            {
                Console.WriteLine("Please enter your password to login");
                if(password == Console.ReadLine())
                {
                    Console.WriteLine("Login Successful!!!");
                } else
                {
                    Console.WriteLine("Wrong password, restart program");
                }
            } else
            {
                Console.WriteLine("No such username exists, restart program");
            }
        }

       
    }
}
