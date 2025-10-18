using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern_AuthMechanism_Assignment1
{
    internal interface IAuthStrategy
    {
        void Authenticate(User user);
    }
}
