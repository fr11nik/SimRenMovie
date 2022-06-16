using SimRenMovie.DatabaseLoader.Users;

namespace SimRenMovie.Users
{
    class UserAdmin : IUser
    {
        public string login { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string[] userLibrary { get; set; }
        public bool root { get; private set; } = true;

        public UserAdmin(string login, string password, string email)
        {
            this.login = login;
            this.password = password;
            this.email = email;
        }
        public bool LoadLibrary()
        {
            return false;
        }      
    }
}
