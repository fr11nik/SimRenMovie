using SimRenMovie.DatabaseLoader;
using System.Data;

namespace SimRenMovie.Database
{
    class OrderRepository
    {
        private static dynamic Source;
        
        public OrderRepository(IOrderSource source)
        {
            Source = source;          
        }
        public DataTable load(string queryString)
        {                      
            return Source.load(queryString);           
        }
        public bool save(string queryString)
        {
           return Source.save(queryString);  
        }
        public bool update(string queryString)
        {
            return Source.update(queryString);
        }
        public bool delete(string queryString)
        {
            return Source.delete(queryString);
        }
    }
}
