using SimRenMovie.Components;
using SimRenMovie.ControlExtensions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SimRenMovie.Forms
{
    public partial class headerMenu : UserControl
    {
       
       
        public string UserLabel { get => buttonUserProfile.Text; set => buttonUserProfile.Text = value; }
        private SearchComponent SearchComponent;
        public headerMenu()
        {
            InitializeComponent();
            userBascket.Controls["buttonBascket"].Click += buttonUserBascket_Click;           
            InitFields();
        }

        private void TextBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBoxSearch.ForeColor != Color.WhiteSmoke)
            {             
                textBoxSearch.ForeColor = Color.WhiteSmoke;
            }
        }
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            SearchComponent = new SearchComponent((this.Parent.Controls["flowLayoutPanelFilms"] as FlowLayoutPanel));
            SearchComponent.ShowResult(textBoxSearch.Text);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void buttonUserBascket_Click(object sender, EventArgs e)
        {
            userBascket.Show();
        }
        private void InitFields()
        {
            // SearchComponent = new SearchComponent((this.Parent.Controls["flowLayoutPanelFilms"] as FlowLayoutPanel));
        }
    }
}
