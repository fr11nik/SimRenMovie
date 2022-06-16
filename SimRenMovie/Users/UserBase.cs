using SimRenMovie.Database;
using SimRenMovie.DatabaseLoader;
using SimRenMovie.DatabaseLoader.Users;
using SimRenMovie.Login;
using System.Data;
namespace SimRenMovie.Users
{
    public class UserBase : IUser
    {
        public string login { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string[] userLibrary { get; set; }

        public string[] userBascket { get; set; }
        public bool root { get; private set; } = false;
        public UserBase(string login,string password,string email)
        {
            this.login = login;
            this.password = password;
            this.email = email;          
        }
        public bool LoadLibrary()
        {
            DataTable dataTable = new DataTable();
            
            OrderRepository orderRepository = new OrderRepository(new SSQLOrderRepository());
            dataTable = orderRepository.load("select p.idFilm from purchases p " +
                $"where p.idUser = (select id from users where login = '{login}' and password='{password}')");
                      
                userLibrary = new string[dataTable.Rows.Count];
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    userLibrary[i] = dataTable.Rows[i]["idFilm"].ToString();
                }

            return dataTable.Rows.Count > 0;
        }
        public bool LoadBascket()
        {
            DataTable dataTable = new DataTable();
            OrderRepository orderRepository = new OrderRepository(new SSQLOrderRepository());
            dataTable = orderRepository.load("select ub.idFilm  from userbascket ub " +
                $"where ub.idUser = (select id from users where login = '{login}' and password='{password}')");
            
                userBascket = new string[dataTable.Rows.Count];
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    userBascket[i] = dataTable.Rows[i]["idFilm"].ToString();
                }
                return dataTable.Rows.Count > 0;
        }

    }
}
