using SimRenMovie.ControlExtensions;
using SimRenMovie.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SimRenMovie.Components
{
    class UserLibrary
    {
        private List<string> Items { get; set; }
        public FlowLayoutPanel Parent;
        public UserLibrary(string[] items)
        {
            Items = items.ToList();
        }
        public void Show()
        {
            Parent.Controls.Clear();
            if (Items.Count > 0)
            {
                Parent.Controls.AddRange(GetCardsData.GetCards(new List<cardContent>(),
                    "idFilm", $"{string.Join(",", Items)}"));
            }
            else
            {
                MessageBox.Show("Список покупок пуст");
            }
        }
        public string[] GetLibrary()
        {
            return Items.ToArray();
        }
    }
}
