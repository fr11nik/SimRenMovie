using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SimRenMovie.Components;
using SimRenMovie.ControlExtensions;
using SimRenMovie.Users;

namespace SimRenMovie.Forms
{
    public partial class userMenu : UserControl
    {
       public User user;
       private FlowLayoutPanel parentlayoutPanel;
        public userMenu()
        {
            InitializeComponent();           
        }
        private void Control_MouseLeave(object sender, EventArgs e)
        {            
            this.Dispose();                    
        }
        private void ButtonPurchases_Click(object sender, EventArgs e)
        {
            UserLibrary userLibrary = new UserLibrary(user.userLibrary);
            userLibrary.Parent = parentlayoutPanel;           
            userLibrary.Show();
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            parentlayoutPanel.Controls.Clear();
            parentlayoutPanel.Controls.Add(new SettingsMenu(user));
        }

        private void ButtonTape_Click(object sender, EventArgs e)
        {
            
            var fer = GetCardsData.GetCards(new List<purchaseFilmCard>(), "Genre", "%");
            parentlayoutPanel.Controls.Clear();
            parentlayoutPanel.Controls.AddRange(fer);
        }

        private void UserMenu_Load(object sender, EventArgs e)
        {
            parentlayoutPanel = (this.Parent.Controls["flowLayoutPanelFilms"] as FlowLayoutPanel);
        }

        private void ButtonLogOut_Click(object sender, EventArgs e)
        {
            (this.Parent.Parent as Form).Close();
            (new LoginForm()).Show();
        }
    }
}
