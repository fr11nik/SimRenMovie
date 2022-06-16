using SimRenMovie.Database;
using SimRenMovie.DatabaseLoader;
using SimRenMovie.DatabaseLoader.Users;
using SimRenMovie.Registration.InputDataVerifier;

namespace SimRenMovie.Registration
{
    class SSQLSignUp : ISignUp
    {
        
        public bool RegisterResult { get; set; }
       public SSQLSignUp(IUser user)
        {
            RegistrationProcces(user);            
        }
        public void RegistrationProcces(IUser user)
        {     
            OrderRepository orderRepository = new OrderRepository(new SSQLOrderRepository());

            ISignUpDataVerifier mailDataVerifier = new SignUpDataVerifier(user);
            if (mailDataVerifier.IsCorrect)
            {                
                RegisterResult = orderRepository.
                    save($"insert into users(login,password,email) values('{user.login}','{user.password}','{user.email}')");
            }           
            RegisterResult = mailDataVerifier.IsCorrect;                      
        }
        
    }
}
