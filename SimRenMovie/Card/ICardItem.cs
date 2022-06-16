using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimRenMovie.Card
{
    public interface ICardItem
    {
        int Id { get; set; }
        string Price { get; set; }
         string FilmName { get; set; }
         string FilmLink { get; set; }
         string Genre { get; set; }
         string DateRealise { get; set; }
         string Country { get; set; }
         int PG { get; set; }
        bool Acquired { get; set; } 
        bool Inbasket { get; set; }

         Image PhotoCard { get; set; }

       
    }
}
