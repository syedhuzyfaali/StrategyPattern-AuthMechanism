using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace StrategyPattern_AuthMechanism_Assignment1
{
    internal class SmsOTPAuth : IAuthStrategy
    {
        public void Authenticate(User user)
        {
            Console.WriteLine("Authenticating using SMS OTP");
            Thread.Sleep(2500);
            Console.WriteLine($"Welcome!");
        }
    }
}
