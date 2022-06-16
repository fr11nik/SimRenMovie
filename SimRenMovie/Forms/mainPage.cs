using SimRenMovie.ControlExtensions;
using SimRenMovie.CustomControls;
using SimRenMovie.Forms;
using SimRenMovie.Users;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace SimRenMovie
{
    public partial class mainPage : Form
    {

        private User User;
        private userMenu userMenu;
        
        public mainPage(User user)
        {
            
            InitializeComponent();
           
            User = user;
            SignUpToEvents();
            GetCardsData.TransferUserData(User.login);
            GetCardsData.TransferUserLibrary(User.userLibrary);
        }
        private void ButtonExit_Click(object sender, EventArgs e) => Application.Exit();

        private void ButtonMinimized_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;
       
        private void MainPage_Load(object sender, EventArgs e)
        {
            LoadDiscover();          
        }
        private void LoadDiscover()
        {
            flowLayoutPanelFilms.Controls.Clear();
            var fer = GetCardsData.GetCards(new List<purchaseFilmCard>(), "Genre", "%");
            flowLayoutPanelFilms.Controls.AddRange(fer);
        }
        private void CreateUserMenu()
        {
            userMenu = new userMenu();
            userMenu.user = User;          
            panel2.Controls.Add(userMenu);
            userMenu.Location = new Point(1577,70);
        }
        private void MainPage_Click(object sender, EventArgs e)
        {
            if (userMenu == null)
            {
                CreateUserMenu();
            }   
            if(userMenu.IsDisposed)
            CreateUserMenu();
        }           
        private void SignUpToEvents()
        {
            UserBascket userBascket = (headerMenu.Controls["UserBascket"] as UserBascket);           
            userBascket.Items = User.userBascket.ToList();
            userBascket.FillCountText();
            //TODO change invut vars in user bascket and userlogin to UserContriner
            headerMenu.UserLabel = User.login;
                          
            headerMenu.Controls[2].MouseHover += MainPage_Click;
            headerMenu.Controls[2].MouseLeave += MainPage_Click;
        }                  
    }
}

