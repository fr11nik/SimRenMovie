using SimRenMovie.DatabaseLoader.Users;
using SimRenMovie.Login;

namespace SimRenMovie.Users
{
    class UserModerador : IUser
    {
        public string login { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string[] userLibrary { get; set; }
        public bool root { get; private set; } = true;

        public bool LoadLibrary()
        {
            return false;
        }     
    }
}
