using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace StrategyPattern_AuthMechanism_Assignment1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            AuthContext authContext = new AuthContext();
            authContext.setAuthStrategy(new PasswordAuth());
            authContext.login(new User("Ali bachey", "Mera naam ali bachey hai"));

            Thread.Sleep(1000);

            authContext.setAuthStrategy(new SmsOTPAuth());
            authContext.login(new User(0320990060));

            Thread.Sleep(1000);


            authContext.setAuthStrategy(new EmailOTPAuth());
            authContext.login(new User("admin@email.com"));

            Thread.Sleep(1000);


            authContext.setAuthStrategy(new BiometricAuth());
            authContext.login(new User(19283045));

        }

        //static void MethodSelection()
        //{
        //    Console.WriteLine("===================== WELCOME BACK ==================");
        //    Console.WriteLine(
        //        "1. lOGIN USING USERNAME/PASSWORD" +
        //        "2. LOGIN USING SMS OTP" +
        //        "3. LOGIN USING EMAIL OTP" +
        //        "4. LOGIN USING BIOMETRIC"
        //        );

        //    int userinput = Convert.ToInt16(Console.ReadKey());

        //}

        //static void simpleLogin()
        //{

        //}
    }
}
