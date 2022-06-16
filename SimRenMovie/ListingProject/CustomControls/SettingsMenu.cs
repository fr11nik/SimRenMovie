using System;
using System.Drawing;
using System.Windows.Forms;
using SimRenMovie.Users;
using SimRenMovie.Database;
using SimRenMovie.DatabaseLoader;

namespace SimRenMovie
{
    public partial class SettingsMenu : UserControl
    {
        User User;
        OrderRepository orderRepository;
        public SettingsMenu(User user)
        {
            InitializeComponent();
            User = user;
            textBoxLogin.Text = User.login;          
        }

        private void ButtonUpdatePassword_Click(object sender, EventArgs e)
        {
            #region DefaultFontState

            
            textBoxOldPassword.HintForeColor = Color.Gray;
            textBoxPassword.HintForeColor = Color.Gray;
            textBoxPassword_confirmation.HintForeColor = Color.Gray;
            #endregion

            if (textBoxOldPassword.Text == User.password)
            {
                
                if(textBoxPassword.Text == textBoxPassword_confirmation.Text && textBoxPassword.Text.Length > 5)
                {
                    orderRepository = new OrderRepository(new SSQLOrderRepository());
                   bool result = orderRepository.update($"update users set password = '{textBoxPassword.Text}' where login = '{User.login}'");
                    if (result) MessageBox.Show("Пароль успешно изменен");
                }
                else
                {
                    textBoxPassword.HintForeColor = Color.Red;
                    textBoxPassword_confirmation.HintForeColor = Color.Red;
                    textBoxPassword.Text = "";                   
                    textBoxPassword_confirmation.Text = "";
                } //Error confirm password (change font state)
            }
            else
            {
                textBoxOldPassword.Text = "";
                textBoxOldPassword.HintForeColor = Color.Red;
            } //Error old password (change font state)
        }

        private void ButtonUpdateLogin_Click(object sender, EventArgs e)
        {         
            if (textBoxLogin.Text.Length > 4)
            {
                orderRepository = new OrderRepository(new SSQLOrderRepository());
                bool result = orderRepository.update($"update users set login = '{textBoxLogin.Text}' where login = '{User.login}'");
                if (result) MessageBox.Show("Логин успешно изменен");
            }           
            else textBoxLogin.HintForeColor = Color.Red; //Error login change (change font state)
        }

        private void TextBoxOldPassword_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
    }
}
