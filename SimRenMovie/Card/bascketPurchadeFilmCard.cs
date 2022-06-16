using System.Drawing;
using System.Windows.Forms;
using SimRenMovie.Card;
using SimRenMovie.Forms;

namespace SimRenMovie.CustomControls
{
    public partial class bascketPurchadeFilmCard : UserControl,ICardItem
    {
        public bascketPurchadeFilmCard()
        {
            InitializeComponent();           
        }
        
        public int Id { get; set; }
        public string Price { get =>labelPrice.Text; set => labelPrice.Text = $"{value} ₽"; }
        public string FilmName { get => labelName.Text; set => labelName.Text = value; }
        public string FilmLink { get; set; }
        public string Genre { get => labelGenre.Text; set => labelGenre.Text = $"жанр:{value}\nстрана: {Country}\nгод выхода: {DateRealise}"; }
        public string DateRealise { get; set; }
        public string Country { get; set; }
        public int PG { get; set; }
        public bool Acquired { get; set; }
        public bool Inbasket { get; set; }
        public Image PhotoCard { get => pictureBox.Image; set => pictureBox.Image = value; }

        private void ButtonRemoveItem_Click(object sender, System.EventArgs e)
        {
            UserBascket userBascket = (this.Parent.Parent.Controls["headerMenu"].Controls["userBascket"] as UserBascket);
            string userName = (this.Parent.Parent.Controls["headerMenu"] as headerMenu).UserLabel;
            userBascket.Remove(this, userName);
            (this.Parent as FlowLayoutPanel).Controls.Remove(this); ;
            
            
        }
    }
}
