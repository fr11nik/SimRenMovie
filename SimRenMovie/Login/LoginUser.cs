
using SimRenMovie.Users;

namespace SimRenMovie.Login
{
    class LoginUser 
    {
        private static dynamic _Login;
      
        public bool  AuthorizationResult { get; set; }
        public LoginUser(ILogin login,User user)
        {
            _Login = login;
           AuthorizationResult = _Login.AuthorizationCheck(user);
        }

    }
}
