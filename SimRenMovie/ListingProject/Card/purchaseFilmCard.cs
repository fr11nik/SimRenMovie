using System;
using System.Drawing;
using System.Windows.Forms;
using SimRenMovie.Card;
using SimRenMovie.CustomControls;

namespace SimRenMovie.Forms
{
    public partial class purchaseFilmCard : UserControl,ICardItem
    {
        public string Price { get => labelPrice.Text; set => labelPrice.Text = $"{value}₽"; }

        public string FilmName { get => buttonFilmName.Text; set => buttonFilmName.Text = value; }
        public string FilmLink { get; set; }
        public string Genre { get => labelGenre.Text; set => labelGenre.Text = value; }
        public string DateRealise { get; set; }
        public string Country { get; set; }
        public int PG { get; set; }
        public Image PhotoCard { get => buttonImageContainer.BackgroundImage; set => buttonImageContainer.BackgroundImage = value; }
        public bool Acquired { get; set; } = false;

        public bool Inbasket { get; set; } = false;
        public int Id { get; set; }

        public purchaseFilmCard()
        {
            InitializeComponent();
            buttonImageContainer.Image = null;
        }
        private void ButtonImageContainer_Click(object sender, EventArgs e)
        {
            if (Acquired)
            {
                FilmForm filmForm = new FilmForm(FilmLink);
                filmForm.Show();
            }
            else
            {
                FlowLayoutPanel parentPanel = (this.Parent as FlowLayoutPanel);
                parentPanel.Controls.Clear();
                parentPanel.Controls.Add(new BuyPurchaseFilmCard(parentPanel.Parent.Controls["headerMenu"] as headerMenu)
                {
                    Id = this.Id,
                    FilmName = this.FilmName,
                    BackgroundImage = this.BackgroundImage,
                    Genre = this.Genre,
                    DateRealise = this.DateRealise,
                    PhotoCard = this.PhotoCard
                });
                
            }
        }
    }
}
