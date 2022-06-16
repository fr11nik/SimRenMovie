using SimRenMovie.DatabaseLoader.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimRenMovie.Registration
{
    class SignUp
    {
        public bool RegisterResult { get; set; }
        private static dynamic _SignUp;
        public SignUp(ISignUp signUp)
        {
            _SignUp = signUp;
            RegisterResult = _SignUp.RegisterResult;
        }
    }
}
