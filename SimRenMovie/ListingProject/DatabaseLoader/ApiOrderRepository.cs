using System.Data;
using System.Windows.Forms;

namespace SimRenMovie.DatabaseLoader
{
    class ApiOrderRepository : IOrderSource
    {
        public bool delete(string queryString)
        {
            return true;
        }

        public DataTable load(string queryString)
        {
            MessageBox.Show(queryString+" Nice api");

            return null;
        }

        public bool save(string queryString)
        {
            return true;
        }

        public bool update(string queryString)
        {
            return true;  
        }
    }
}
