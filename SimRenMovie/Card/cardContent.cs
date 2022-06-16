using System;
using System.Drawing;
using System.Windows.Forms;
using SimRenMovie.Card;

namespace SimRenMovie.Forms
{
    public partial class cardContent : UserControl, ICardItem
    {       
        private string filmName;
        private string genre;
        private string dateRealise;
        private string country;
        private int pG;
        private string filmLink;
        public string Price { get => labelPrice.Text; set => labelPrice.Text = $"{value}₽"; }
    
        public string FilmName { get => filmName; set => filmName = value; }
        public string FilmLink { get => filmLink; set => filmLink = value; }
        public string Genre { get => genre; set => genre = value; }
        public string DateRealise { get => dateRealise; set => dateRealise = value; }
        public string Country { get => country; set => country = value; }
        public int PG { get => pG; set => pG = value; }
        public bool Acquired { get; set; } = false;
        public Image PhotoCard { get => this.BackgroundImage; set => this.BackgroundImage = value; }
        public bool Inbasket { get; set; } = false;
        public int Id { get; set; }

        public cardContent()
        {
            InitializeComponent();                      
        }

        private void CardContent_Click(object sender, EventArgs e)
        {
            if (Acquired)
            {
                FilmForm filmForm = new FilmForm(FilmLink);
                filmForm.Show();
            }
        }
    }
}

