using SimRenMovie.Database;
using SimRenMovie.DatabaseLoader;
using SimRenMovie.Users;
using System.Data;

namespace SimRenMovie.Login
{
    class LoginSSQL : ILogin
    {
        public bool AuthorizationResult { get; set; } = false;
     
        public bool AuthorizationCheck(User user)
        {
            DataTable dataTable = new DataTable();

            OrderRepository orderRepository = new OrderRepository(new SSQLOrderRepository());
            dataTable = orderRepository.load($"select * from users where login='{user.login}' and password ='{user.password}'");           
            AuthorizationResult = dataTable.Rows.Count > 0 ? true : false;                                         
            return AuthorizationResult;          

        } 
    }
}
