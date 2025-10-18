using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern_AuthMechanism_Assignment1
{
    internal class AuthContext
    {
        private IAuthStrategy _authStrategy;

        public void setAuthStrategy(IAuthStrategy authStrategy) { _authStrategy = authStrategy; }

        public void login(User user)
        {
            _authStrategy.Authenticate(user);
        }

    }
}
