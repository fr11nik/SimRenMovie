using System.Drawing;
using System.Data;
using System.Windows.Forms;
using SimRenMovie.Database;
using SimRenMovie.DatabaseLoader;
using System.Collections.Generic;
using System;

namespace SimRenMovie
{
    public partial class DGVUsersControl : UserControl
    {
        private string WhoIsLoad;
        private string CashValue = "";
        private string lastValueInCell;
        private int LastRowIndex;
        private string queryLoadData;
        public DGVUsersControl()
        {
            InitializeComponent();       
        }
       
        public void LoadUsersData(string whoIsLoad)
        {
            WhoIsLoad = whoIsLoad;
            //
            OrderRepository orderRepository = new OrderRepository(new SSQLOrderRepository());
            
            if (WhoIsLoad == "filmsData")
            {
                queryLoadData = "select fd.idFilm,FilmName, Genre ,DateRealise,Country, PG, Price, FilmLink,objectName,photoVariation from filmsdata fd LEFT JOIN imageSource i on fd.idFilm = i.idfilm";
            }
            else
            {
                queryLoadData = $"select * from {whoIsLoad}";
            }
            DataTable dataUsers = orderRepository.load(queryLoadData);

            
            dataGridViewUsers.DataSource = null; //because data in dgv will be reload
            dataGridViewUsers.ColumnCount = dataUsers.Columns.Count - 1;//because first column is empty  
            if (dataGridViewUsers.Rows.Count > 0) //if data in dgv is exist,then need to reload they
            {
                dataGridViewUsers.Rows.Clear();
            }
            dataGridViewUsers.Columns.Clear();

        dataGridViewUsers.DataSource = dataUsers;//reload data source
            dataGridViewUsers.Update();


            if ((dataGridViewUsers.Columns[dataGridViewUsers.ColumnCount - 1].Name == "photoVariation"))
            {
                (dataGridViewUsers.Columns[dataGridViewUsers.ColumnCount - 1] as DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Stretch;//resize image in cell
               
            }
            this.dataGridViewUsers.Columns[0].ReadOnly = true;//forbidden to changevalues in primarykey values


        }
        #region not used
        private void DataGridViewUsers_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           // MessageBox.Show(dataGridViewUsers.Columns[dataGridViewUsers.Columns.Count-1].CellTemplate.ToString());
            if (CashValue == "" && lastValueInCell!="" && lastValueInCell!=null &&
                dataGridViewUsers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null) //if value in cell didnt update 
            {
                if (dataGridViewUsers.CurrentCell.ValueType.Name != "Byte[]")
                {
                    CashValue = dataGridViewUsers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(); //remember new value
                    if (UpdataUserData(CashValue, e) == true) //if value update in database
                    {
                        MessageBox.Show("Данные успешно обновлены"); //true;
                        CashValue = "";
                    }
                    else
                    {
                        dataGridViewUsers.CurrentCell.Value = lastValueInCell;  //return previous value in cell
                        CashValue = "";
                    }
                }
            }
            if (newRow != null)
            {
                ////У дататейбла есть dataType оттуда можно узнать тип столбца для вставления данных в таблицу
                newRow.Add(SearchTypeOfCurrentColumn(e.ColumnIndex,
                    dataGridViewUsers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()));
                LastRowIndex = e.RowIndex-1;
            }
        }
      
        private bool UpdataUserData(string value,DataGridViewCellEventArgs e)
        {
            string queryUpdate = $"update {WhoIsLoad} set {dataGridViewUsers.Columns[e.ColumnIndex].Name} = '{value}' where {dataGridViewUsers.Columns[0].Name} = " +
                 $"{dataGridViewUsers.Rows[e.RowIndex].Cells[0].Value}";

            if (dataGridViewUsers.Columns[e.ColumnIndex].Name == "objectName")
            {
               queryUpdate = $"update imageSource set objectName = {SearchTypeOfCurrentColumn(e.ColumnIndex,value)} where idfilm = {dataGridViewUsers.Rows[e.RowIndex].Cells[0].Value}";
            }
            

            OrderRepository orderRepository = new OrderRepository(new SSQLOrderRepository());
            var updateResult = orderRepository.update(queryUpdate);
            
            return updateResult;           

        }
        
        private void DataGridViewUsers_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            lastValueInCell = dataGridViewUsers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();//remember last value in cell          
        }

        
        List<string> newRow;
        private void DataGridViewUsers_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            //////////////////////////////////INSERT THROUGH DATAGRIDVIEW TODO NEED CREATE MORE
            if(newRow == null)
            {
                newRow = new List<string>();
            }
            else if(newRow != null)
            {
                
                InsertDataInDataBase();             
            }
        }
        private void DataGridViewUsers_ImageUpdate(object sender, DataGridViewCellMouseEventArgs e)
        {
            MessageBox.Show("f");
        }

        private void InsertDataInDataBase()
        {
            OrderRepository orderRepository = new OrderRepository(new SSQLOrderRepository());
            string rowWhoNeedInsert;
            if (WhoIsLoad == "filmsData")
            {
                string typeObject = newRow[newRow.Count-1];
                newRow.RemoveAt(newRow.Count - 1);
                 rowWhoNeedInsert = string.Join(",", newRow);

                string queryString = $"insert into {WhoIsLoad} (FilmName,Genre,DateRealise,Country,PG,Price,FilmLink)" +
                    $"values({rowWhoNeedInsert})";                 
                // $"insert into imageSource(idfilm,objectName) values({})";
               bool resultInsert =  orderRepository.update(queryString);
                if (resultInsert)
                {
                    MessageBox.Show($"Строка успешно добавлена");
                    UpdateDGV();
                    var t = $"insert into imageSource (idfilm,objectName) values({dataGridViewUsers.Rows[LastRowIndex].Cells[0].Value},{typeObject})";
                    orderRepository.update(t);
                    UpdateDGV();
                }            
            }
            else
            {
                rowWhoNeedInsert = string.Join(",", newRow);
                string queryString = $"insert into {WhoIsLoad} (login,password,email) values ({rowWhoNeedInsert})";
                bool resultInsert = orderRepository.update(queryString);
                if (resultInsert)
                {
                    MessageBox.Show($"Строка успешно добавлена");
                    UpdateDGV();
                }
                
            }
            newRow = null;
        }
        #endregion
        private void UpdateDGV()
        {
            dataGridViewUsers.DataSource = null;
            OrderRepository orderRepository = new OrderRepository(new SSQLOrderRepository());
            dataGridViewUsers.DataSource = orderRepository.load(queryLoadData);
            dataGridViewUsers.Update();
            if ((dataGridViewUsers.Columns[dataGridViewUsers.ColumnCount - 1].Name == "photoVariation"))
            {
                (dataGridViewUsers.Columns[dataGridViewUsers.ColumnCount - 1] as DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Stretch;//resize image in cell
            }
        }
        
        private string SearchTypeOfCurrentColumn(int numColumn,string value)
        {
            //dataUsers.Columns[0].DataType.Name
            switch (dataGridViewUsers.Columns[numColumn].ValueType.Name)
            {
                case "Int32":
                    return value;
                case "String":
                    return $"'{value}'";

            }
            return value;
        }

        private string tableName = "";
        private void DataGridViewUsers_UserAddedRowTest(object sender, DataGridViewRowEventArgs e)
        {
           
            OrderRepository orderRepository = new OrderRepository(new SSQLOrderRepository());
                                 
            if(WhoIsLoad == "filmsData")
            {
                string queryString = $"insert into filmsdata(FilmName,Genre,DateRealise,Country,PG,Price,FilmLink) values ('{dataGridViewUsers.Rows[dataGridViewUsers.RowCount - 3].Cells[0].Value}','@Genre',10,'@Country',1,1,'@FilmLink')";

               orderRepository.update(queryString);
               UpdateDGV();
                ImageConverter imageConverter = new ImageConverter();
                queryString = $"insert into imageSource(idfilm,photoVariation,objectName) values ({dataGridViewUsers.Rows[dataGridViewUsers.RowCount - 2].Cells[0].Value}," +
                    $"CAST(0x0771a9b8 as varbinary(max)), '@objectName')";
                orderRepository.update(queryString);
                UpdateDGV();

            }
            if(WhoIsLoad == "users")
            {
                string queryString = $"insert into users(login,password,email) values('{dataGridViewUsers.Rows[dataGridViewUsers.RowCount - 3].Cells[0].Value}','@password','{dataGridViewUsers.Rows[dataGridViewUsers.RowCount - 3].Cells[0].Value}')";               
                orderRepository.update(queryString);
                UpdateDGV();
            }
        }           
        private void DataGridViewUsers_CellValueChangedTest(object sender, DataGridViewCellEventArgs e)
        {
            try
            {                
                OrderRepository orderRepository = new OrderRepository(new SSQLOrderRepository());
                if (dataGridViewUsers.CurrentCell.Value != null && dataGridViewUsers.CurrentCell.ValueType.Name != "Byte[]")
                {
                    string columnName = dataGridViewUsers.Columns[e.ColumnIndex].Name;

                    string idIndex = dataGridViewUsers.Rows[e.RowIndex].Cells[0].Value.ToString() == "" ? idIndex = "''"
                        : idIndex = dataGridViewUsers.Rows[e.RowIndex].Cells[0].Value.ToString();

                    tableName = (WhoIsLoad == "filmsData" || WhoIsLoad == "users") && columnName != "objectName"
                        ? tableName = WhoIsLoad
                        : tableName = "imageSource";

                    string queryForDataBase = $"update {tableName} set {columnName} = " +
                        $"{SearchTypeOfCurrentColumn(e.ColumnIndex, dataGridViewUsers.CurrentCell.Value.ToString())} WHERE {columnName} IS NULL " +
                        $"or {dataGridViewUsers.Columns[0].Name} = {idIndex}";
                    orderRepository.update(queryForDataBase);    
                    if(tableName == "imageSource")
                    {
                        queryForDataBase = $"update imageSource set idfilm = {dataGridViewUsers.CurrentRow.Cells[0].Value.ToString()} " +
                            $"WHERE idfilm IS NULL";
                        orderRepository.update(queryForDataBase);
                    }
                }
                
            }
            catch(Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
            
        }

        private void DataGridViewUsers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewUsers.Rows[e.RowIndex].Cells[e.ColumnIndex].ValueType.Name == "Byte[]" &&
                    dataGridViewUsers.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.Filter = "(*.png)|*.png";
                    if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                    {
                        string queryString = "UPDATE imageSource " +
                            $"SET {dataGridViewUsers.Columns[e.ColumnIndex].Name} = (SELECT BulkColumn FROM OPENROWSET(BULK '{openFileDialog.FileName}', SINGLE_BLOB) a) " +
                            $"WHERE {dataGridViewUsers.Columns[0].Name} = {dataGridViewUsers.Rows[e.RowIndex].Cells[0].Value} " +
                            $"and objectName = '{dataGridViewUsers.Rows[e.RowIndex].Cells["objectName"].Value}'";

                        OrderRepository orderRepository = new OrderRepository(new SSQLOrderRepository());
                        bool resultUpdate = orderRepository.update(queryString);
                        if (resultUpdate == true)
                        {
                            MessageBox.Show("Фотография успешно обновлена");
                            dataGridViewUsers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Image.FromFile(openFileDialog.FileName);
                        }
                    }
                }
                else if((string)dataGridViewUsers.Columns[e.ColumnIndex].Name == "photoVariation")
                {
                    MessageBox.Show("Чтобы вставить фотографию необходимо заполнить колонку objectName");
                }
            }
            catch (Exception) { }
        }

        private void DataGridViewUsers_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

          DialogResult dialogResult =  MessageBox.Show("Вы точно хотит удалить эту строку?", "подтверждение удаление строки", MessageBoxButtons.YesNo);
           
            if (dialogResult == DialogResult.Yes)
            {

                tableName = WhoIsLoad == "filmsData" || WhoIsLoad == "users"
                        ? tableName = WhoIsLoad
                        : tableName = "imageSource";
                string idIndex = dataGridViewUsers.Rows[e.RowIndex].Cells[0].Value.ToString() == "" ? idIndex = "''"
                    : idIndex = dataGridViewUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                OrderRepository orderRepository = new OrderRepository(new SSQLOrderRepository());
                string query = $"delete from {tableName} where {dataGridViewUsers.Columns[0].Name} = " +
                    $"{dataGridViewUsers.CurrentRow.Cells[0].Value}";
                bool result = orderRepository.delete(query);
                if (result)
                {
                    MessageBox.Show("Строка удалена успешно");
                    UpdateDGV();
                }
            }           
        }
        private void DataGridViewUsers_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //This even catch to exception with some errors in DGV 
            //Example: error convert image
        }
    }
}
          