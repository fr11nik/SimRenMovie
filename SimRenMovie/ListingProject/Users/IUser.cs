using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimRenMovie.DatabaseLoader.Users
{
  public interface IUser
    {
     string login { get; set; }
     string password { get; set; }

     string email { get; set; }       

     string[] userLibrary { get; set; }
    
     
     bool LoadLibrary();
    }
}
