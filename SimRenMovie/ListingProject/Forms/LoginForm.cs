using System;
using System.Drawing;
using System.Windows.Forms;
using SimRenMovie.Login;
using SimRenMovie.Users;
using SimRenMovie.ControlExtention;
using SimRenMovie.Registration;

namespace SimRenMovie
{


    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }              
        private void ButtonSignIn_Click(object sender, EventArgs e)
        {

            User user = new User(new UserBase($"{textBoxLogin.Text}", $"{textBoxPassword.Text}", $"fr11nik@mail.ru"));

            LoginUser loginUser = new LoginUser(new LoginSSQL(), user);

            if (!loginUser.AuthorizationResult)
            {
                ErrorSyntax();
            }
            else
            {
                ResetForeColorForm();
                this.Hide();
                if (user.login == "Admin")
                {
                    user = new User(new UserAdmin(user.login, user.password, user.email));                  
                    AdminPanel adminPanel = new AdminPanel();
                    adminPanel.Show();
                }
                else
                {
                    user.LoadLibrary();
                    mainPage mainPage = new mainPage(user);
                    mainPage.Show();
                }

            }

        }
        //textbox for register from email --------------</>
        TextBox textBoxEmail;
        //-----------
        private void ButtonRegister_Click(object sender, EventArgs e)
        {
                           
            if (textBoxEmail == null)
            {
                buttonSignIn.Hide();
                //change loc for signUp button
                buttonRegister.Location = new Point(330, 277);
                //teleport main textbox
                textBoxLogin.Location = new Point(259, 88);
                textBoxPassword.Location = new Point(259, 148);

                //create addition textbox for register
                textBoxEmail = textBoxLogin.Clone();
                textBoxEmail.Text = "Email";
                textBoxEmail.Location = new Point(259, 212);
                
            }
            else
            {
                SignUp signUp = new SignUp(new SSQLSignUp(new UserBase(textBoxLogin.Text.Trim(), textBoxPassword.Text.Trim(), textBoxEmail.Text.Trim())));
                if (signUp.RegisterResult)
                {
                    MessageBox.Show("Аккаунт создан успешно");
                    buttonRegister.Location = new Point(405, 277);
                    textBoxEmail.Dispose();
                    buttonSignIn.Show();
                }
                else MessageBox.Show("Провертье формат email адреса (длина логина должа быть больше 6 символов)");
            }                        
        }
        private void ErrorSyntax()
        {
            textBoxLogin.ForeColor = Color.Red;
            textBoxPassword.ForeColor = Color.Red;
            if (textBoxEmail != null)
                textBoxEmail.ForeColor = Color.Red;
        }
        private void ResetForeColorForm()
        {
            textBoxLogin.ForeColor = Color.Black;
            textBoxPassword.ForeColor = Color.Black;
            if (textBoxEmail != null)
                textBoxEmail.ForeColor = Color.Black;
        }
        #region buttonReaction
        private void ExitButton_Click(object sender, EventArgs e) => Application.Exit();
        private void ExitButton_MouseMove(object sender, MouseEventArgs e) => exitButton.ForeColor = Color.White;
        private void ExitButton_MouseLeave(object sender, EventArgs e) => exitButton.ForeColor = Color.Black;
        private void ButtonMinimized_MouseMove(object sender, MouseEventArgs e) => buttonMinimized.ForeColor = Color.White;
        private void ButtonMinimized_MouseLeave(object sender, EventArgs e) => buttonMinimized.ForeColor = Color.Black;
        private void ButtonMinimized_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;


        #endregion
       
    }
}
