
using SimRenMovie.Users;

namespace SimRenMovie.Login
{
    interface ILogin
    {
        bool  AuthorizationResult { get; set; }
        bool AuthorizationCheck(User user);
    }
}
