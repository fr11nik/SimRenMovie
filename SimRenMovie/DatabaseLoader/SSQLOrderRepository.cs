using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SimRenMovie.DatabaseLoader
{
    class SSQLOrderRepository : IOrderSource
    {
        
        #region connection parametrs
        private string connectionString = "Server=.\\SQLEXPRESS;Database=SimRenMovie;Integrated Security=true;";
        private SqlConnection connection;

        #endregion

        #region private elements 

        #endregion
        
        private void openConnection()
        {                   
            connection = new SqlConnection(connectionString);
            connection.Open();
        }
        private void closeConnection()
        {
            connection.Close();
            connection.Dispose();
        }
        public bool delete(string queryString)
        {
            //Поставить каскадное обновление и удаление
            openConnection();
            bool isDeleted = false;
            try
            {
                SqlCommand commandSave = new SqlCommand(queryString, connection);
                if (commandSave.ExecuteNonQuery() == 1) isDeleted = true;
                return isDeleted;

            }
            catch (SqlException msg)
            {
                MessageBox.Show(msg.Message);
            }
            closeConnection();
            return isDeleted;
        }
        
        public DataTable load(string queryString)
        {
            openConnection();
            SqlCommand commandLoad = new SqlCommand(queryString, connection);
            DataSet dataSet = new DataSet();
            try
            { //..если запрос не вернул ошибки в правильности построения запроса
                commandLoad.ExecuteNonQuery();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(commandLoad);                     
                sqlDataAdapter.Fill(dataSet);           
            }
            catch (SqlException msg) 
            {
                MessageBox.Show("Запрос не корректен ошибка:"+msg.Message);
                return null;
            }
            closeConnection();
            return dataSet.Tables[0];
        }
        public bool save(string queryString)
        {
            openConnection();
            bool isSaved = false;
            
            try
            {
                SqlCommand commandSave = new SqlCommand(queryString, connection);
                if (commandSave.ExecuteNonQuery() == 1) isSaved = true;
                return isSaved;

            }
            catch(SqlException msg)
            {
                MessageBox.Show(msg.Message);
            }
            closeConnection();
            return isSaved;      
        }
        public bool update(string queryString)
        {
            openConnection();
            bool isUpdated = false;
            try
            {
                SqlCommand commandSave = new SqlCommand(queryString, connection);
                if (commandSave.ExecuteNonQuery() == 1) isUpdated = true;
                return isUpdated;

            }
            catch (SqlException msg)
            {
                MessageBox.Show(msg.Message);
            }
            closeConnection();
            return isUpdated;
        }      
    }
}
