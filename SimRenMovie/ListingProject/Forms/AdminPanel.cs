
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimRenMovie
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
                     
            InitializeComponent();
            

        }
        #region buttonReaction
        private void ExitButton_Click(object sender, EventArgs e) => Application.Exit();
        private void ExitButton_MouseMove(object sender, MouseEventArgs e) => exitButton.ForeColor = Color.White;
        private void ExitButton_MouseLeave(object sender, EventArgs e) => exitButton.ForeColor = Color.Black;
        private void ButtonMinimized_MouseMove(object sender, MouseEventArgs e) => buttonMinimized.ForeColor = Color.White;
        private void ButtonMinimized_MouseLeave(object sender, EventArgs e) => buttonMinimized.ForeColor = Color.Black;
        private void ButtonMinimized_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;
        #endregion

       

        private void ButtonMainPage_Click(object sender, EventArgs e)
        {

            //TODO ButtonMainPage_Click

        }
        string typeLoadData;
        DGVUsersControl DGVUsersControl;
        
        private void ButtonAddTable_Click(object sender, EventArgs e)
        {
            string tableName = (sender as Button).Text;
            if (DGVUsersControl == null)
            {
                DGVUsersControl = new DGVUsersControl();
                flowLayoutPanelRight.Controls.Add(DGVUsersControl);
            }
            switch (tableName)
            {
                case "Пользователи":
                    typeLoadData = "users";
                    break;
                case "Список фильмов":
                    typeLoadData = "filmsData";
                    break;
            }

            DGVUsersControl.LoadUsersData(typeLoadData);
        }
        

        private void ButtonLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            (new LoginForm()).Show();
        }
    }
}
