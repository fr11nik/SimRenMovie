using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SimRenMovie.ControlExtensions;

namespace SimRenMovie.Forms
{
    public partial class CaruselContainer : UserControl
    {
        
        public string GenreText { get => labelGenreType.Text; set => labelGenreType.Text = value; }
        public CaruselContainer(string genre)
        {
            InitializeComponent();
            GenreText = genre;           
        }

        private void CaruselContainer_Load(object sender, EventArgs e)
        {
            var cards = GetCardsData.GetCards(new List<cardContent>(), "Genre", GenreText.Substring(0, 2).ToLower());
            cards.Shuffle();
            flowLayoutPanel1.Controls.AddRange(cards.ToArray());           
        }
    }
}
