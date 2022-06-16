using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using SimRenMovie.ControlExtensions;

namespace SimRenMovie.Forms
{
    public partial class leftMenuContainer : UserControl
    {
        private FlowLayoutPanel parentflowlayoutPanel { get; set; }
        public leftMenuContainer()
        {
            InitializeComponent();
        }
        private void ButtonGenreType_Click(object sender, EventArgs e)
        {
            parentflowlayoutPanel.Controls.Clear();
            parentflowlayoutPanel.Controls.Add(new CaruselContainer((sender as BunifuFlatButton).Text));
        }

        private void LeftMenuContainer_Load(object sender, EventArgs e)
        {
            parentflowlayoutPanel = (this.Parent.Controls["flowLayoutPanelFilms"] as FlowLayoutPanel);
        }

        private void ButtonDiscover_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel flowLayoutPanel = (this.Parent.Parent.Controls["panel2"].Controls["flowLayoutPanelFilms"] as FlowLayoutPanel);

            flowLayoutPanel.Controls.Clear();

            flowLayoutPanel.Controls.AddRange(GetCardsData.GetCards(new List<purchaseFilmCard>(), "Genre", "%"));
        }
    }
}
