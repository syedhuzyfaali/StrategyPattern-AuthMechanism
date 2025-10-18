using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StrategyPattern_AuthMechanism_Assignment1
{
    internal class PasswordAuth : IAuthStrategy
    {
        public void Authenticate(User user)
        {
            Console.WriteLine("Authenticating using USERNAME and PASSWORD");
            Thread.Sleep(2500);
            Console.WriteLine($"Welcome!");
        }
    }
}
