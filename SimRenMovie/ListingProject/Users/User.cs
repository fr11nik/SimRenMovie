using SimRenMovie.DatabaseLoader.Users;

namespace SimRenMovie.Users
{
   public class User
    {
        
        public string login { get; }
        public string password { get; }
        public string email { get; }
        public string[] userLibrary { get; set; }
        public string[] userBascket { get; set; }
        private static dynamic _User;
        public bool root { get=>_User.root; private set => root =_User.root; }
        public User(IUser user)
        {
         _User = user;
         login =  _User.login;
         password = _User.password;
         email = _User.email;
         
        }
        public bool LoadLibrary()
        {
            bool result = _User.LoadLibrary();
            userLibrary = _User.userLibrary;         
            if(_User is UserBase)
            {              
                _User.LoadBascket();
                userBascket = _User.userBascket;
            }          
            return result;
        }     
       
    }
}
