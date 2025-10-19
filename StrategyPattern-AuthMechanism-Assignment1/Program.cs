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
            //AuthContext authContext = new AuthContext();
            //authContext.setAuthStrategy(new PasswordAuth());
            //authContext.login(new User("Ali bachey", "Mera naam ali bachey hai"));

            //Thread.Sleep(1000);

            //authContext.setAuthStrategy(new SmsOTPAuth());
            //authContext.login(new User(0320990060));

            //Thread.Sleep(1000);


            //authContext.setAuthStrategy(new EmailOTPAuth());
            //authContext.login(new User("admin@email.com"));

            //Thread.Sleep(1000);


            //authContext.setAuthStrategy(new BiometricAuth());
            //authContext.login(new User(19283045));


            AuthContext auth = new AuthContext();
            (User user, IAuthStrategy authStrategy) User_AuthType = MethodSelection();
            
            auth.setAuthStrategy(User_AuthType.authStrategy);
            auth.login(User_AuthType.user);



        }

        static (User user, IAuthStrategy authStrategy) MethodSelection()
        {
            Console.WriteLine("===================== WELCOME BACK ==================");
            Console.WriteLine(
                "\n1. lOGIN USING USERNAME/PASSWORD" +
                "\n2. LOGIN USING SMS OTP" +
                "\n3. LOGIN USING EMAIL OTP" +
                "\n4. LOGIN USING BIOMETRIC"
                );


            ConsoleKeyInfo keyInfo = Console.ReadKey();
            int userInput = int.Parse(keyInfo.KeyChar.ToString());
            if (userInput == 1)
            {
                return User_PassLogin();
            }
            else if (userInput == 2)
            {
                return SmsOTPLogin();
            }
            else if (userInput == 3)
            {
                return EmailOTPLogin();
            }
            else if (userInput == 4)
            {
                return BiometricLogin();
            }
            else 
            {
                return (null, null);
            }

        }

        static (User user, IAuthStrategy authStrategy) User_PassLogin()
        {
            Console.Write("\nEnter Username: ");
            string uname = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            return (new User(uname, password), new PasswordAuth());
        }

        static (User user, IAuthStrategy authStrategy) SmsOTPLogin()
        {
            Console.Write("\nEnter Number: ");
            int number = Convert.ToInt32(Console.ReadLine());

           return (new User(number), new SmsOTPAuth());
        }

        static (User user, IAuthStrategy authStrategy) EmailOTPLogin()
        {
            Console.Write("\nEnter Email: ");
            string email = Console.ReadLine();

            return (new User(email), new EmailOTPAuth());
        }

        static (User user, IAuthStrategy authStrategy) BiometricLogin()
        {
            Console.Write("\nScan Biometric: ");
            int number = Convert.ToInt32(Console.ReadLine());

            return (new User(number), new BiometricAuth());
        }
    }
}
