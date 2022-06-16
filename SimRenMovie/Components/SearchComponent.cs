using SimRenMovie.ControlExtensions;
using SimRenMovie.Forms;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SimRenMovie.Components
{
    class SearchComponent
    {
        private FlowLayoutPanel FlowLayoutPanel;
        public SearchComponent(FlowLayoutPanel resultPanel)
        {
            FlowLayoutPanel = resultPanel;
        }
        public void ShowResult(string inputString)
        {          
            FlowLayoutPanel.Controls.Clear();
            FlowLayoutPanel.Controls.AddRange(GetCardsData.GetCards(new List<purchaseFilmCard>(), "FilmName", inputString.Trim()));
        }
       
    }
}
