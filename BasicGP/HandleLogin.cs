using System;

namespace BasicGP
{
    class HandleLogin
    {

        public static bool Authenticate(string username, string password)
        {

            Console.WriteLine($"Username: {username}, Password: {password}");

            if (username == "ryan" && password == "ryan")
            {
                Console.WriteLine("User Authenticated");
                return true;
            } else
            {
                Console.WriteLine("User Authentication Failed!");
                return false;
            }

        }

    }
}
