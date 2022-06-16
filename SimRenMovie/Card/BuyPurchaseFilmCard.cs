using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SimRenMovie.Card;
using SimRenMovie.Components;
using SimRenMovie.Database;
using SimRenMovie.DatabaseLoader;
using SimRenMovie.Forms;

namespace SimRenMovie.CustomControls
{
    public partial class BuyPurchaseFilmCard : UserControl,ICardItem
    {
        #region ICardIItemProp

      
        public string Price { get; set; }

        public string FilmName { get => labelFilmName.Text; set => labelFilmName.Text = value; }
        public string FilmLink { get; set; }
        public string Genre { get => labelGenre.Text; set => labelGenre.Text =  value; }
        public string DateRealise { get => labelGenre.Text; set => labelGenre.Text = $"{value},"+ Genre; }
        public string Country { get; set; }
        public int PG { get; set; }
        public Image PhotoCard { get => pictureBoxImagePhoto.Image; set => pictureBoxImagePhoto.Image = value; }
        public bool Acquired { get; set; } = false;

        public bool Inbasket { get; set; } = false;
        public int Id { get; set; }
        #endregion
        private headerMenu HeaderMenu;
        
        public BuyPurchaseFilmCard(headerMenu headerMenu)
        {           
            InitializeComponent();
            HeaderMenu = headerMenu;
        }

        private void ButtonBuy_Click(object sender, EventArgs e)
        {
           // (this.Parent.Parent as mainPage).
           
        }

        private void ButtonAddtoBag_Click(object sender, EventArgs e)
        {

            UserBascket userBascket = (HeaderMenu.Controls["UserBascket"] as UserBascket);          
            //TODO  
            userBascket.Add(this,HeaderMenu.UserLabel);
             
        }
    }
}
