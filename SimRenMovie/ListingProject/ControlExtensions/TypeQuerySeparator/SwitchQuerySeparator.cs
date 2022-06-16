using System.Linq;

namespace SimRenMovie.ControlExtensions.TypeQuerySeparator
{
    public static class  SwitchQuerySeparator
    {

        public static string whereCommandBuilder(string ColumnName,string typeLoad)
        {
            string t = "Genre,PG,FilmName,FilmLink,DataRealise,Country,Price";
            var typeOfColumn = t.Split(',').Where(elem => ColumnName == elem).FirstOrDefault();
                       
            t = $"{ColumnName} like'%{typeLoad}%'";

            if (ColumnName == "idFilm")
            {
                if (typeLoad == "")
                {
                    typeLoad = "-1";
                }
                t =  $"fd.{ColumnName} in({typeLoad})";
            }
            return t;                     
        }
       
    }
}
