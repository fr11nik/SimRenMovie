using System.Data;

namespace SimRenMovie.DatabaseLoader
{
    interface IOrderSource
    {
        DataTable load(string queryString);
        bool save(string queryString);
        bool update(string queryString);
        bool delete(string queryString);
    }
}
