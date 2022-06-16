using SimRenMovie.Card;
using SimRenMovie.ControlExtensions.TypeQuerySeparator;
using SimRenMovie.Database;
using SimRenMovie.DatabaseLoader;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;

namespace SimRenMovie.ControlExtensions
{
    public static class GetCardsData
    {
        private static string UserLogin;
        private static string[] UserLibrary;

        #region oldRealisation
        /*
         public static cardContent[] GetCardBy(string ColumnName,string value)
         {

             string queryString1 = "select FilmName, Genre ,DateRealise,Country, PG, Price, FilmLink,photoVariation, objectName " +
                 "from filmsdata fd " +
                 "INNER JOIN imageSource i on fd.idFilm = i.idfilm " +
                $"where {SwitchQuerySeparator.whereCommandBuilder(ColumnName,value)} and objectName = 'cardContent'";


             return cards.CardsFiller(queryString1);
         }
         public static purchaseFilmCard[] GetPurchasedCardBy(string ColumnName,string value)
         {
             string queryString1 = "select   FilmName, Genre ,DateRealise,Country, PG, Price, FilmLink,photoVariation, objectName " +
                 "from filmsdata fd " +
                 "INNER JOIN imageSource i on fd.idFilm = i.idfilm " +
                $"where {SwitchQuerySeparator.whereCommandBuilder(ColumnName, value)} and objectName = 'purchaseFilmCard'";


             return purchaseFilms.CardsFiller(queryString1);
         }


         private static T[] CardsFiller<T>(this T[] cardArr, string query)
             where T : ICardItem
         {
             OrderRepository orderRepository = new OrderRepository(new SSQLOrderRepository());
             DataTable dataTable = orderRepository.load(query);
             cardArr = new T[dataTable.Rows.Count];

             for (int i = 0; i < cardArr.Length; i++)
             {
                 //not null atribute
                 cardArr[i] = GetInstance<T>();
                 cardArr[i].FilmName = (string)dataTable.Rows[i]["FilmName"];
                 cardArr[i].Genre = (string)dataTable.Rows[i]["Genre"];
                 cardArr[i].Country = (string)dataTable.Rows[i]["Country"];
                 cardArr[i].PG = (int)dataTable.Rows[i]["PG"];               
                 cardArr[i].Price = dataTable.Rows[i]["Price"].ToString();
                 cardArr[i].DateRealise = dataTable.Rows[i]["DateRealise"].ToString();

                 //be must null
                 if(dataTable.Rows[i]["FilmLink"] != null)
                 cardArr[i].FilmLink = (string)dataTable.Rows[i]["FilmLink"];


                 if(dataTable.Rows[i]["photoVariation"]!=null)
                 cardArr[i].BackgroundImage = Image.FromStream(new MemoryStream((byte[])dataTable.Rows[i]["photoVariation"]));

             }
             dataTable.Dispose();
             return cardArr;
         }


         public static cardContent[] GetCardsByFilmsId(string[] IDs)
         {

             string enumIds = "";
             for (int i = 0; i < IDs.Length; i++)
             {
                 enumIds += IDs[i] + ",";
             }
             enumIds = enumIds.Remove(enumIds.Length - 1, 1);
             string queryByFilmsId = $"select* from filmsdata where idFilm in({enumIds})";

             return cards.CardsFiller(queryByFilmsId);
         }
         */
        #endregion
        private static Image GetImage(byte[] rowImage)
        {
            MemoryStream mem = new MemoryStream(rowImage);
            Image img = Image.FromStream(mem);
            mem.Close();
            mem.Dispose();
            return img;
        }
      
        private static T GetInstance<T>()
        {
            return (T)Activator.CreateInstance(typeof(T));
        }
        #region realize
        /*
       private static void CardsFiller(string query)
       {
           OrderRepository orderRepository = new OrderRepository(new SSQLOrderRepository());
           DataTable dataTable = orderRepository.load(query);
           cards = new cardContent[dataTable.Rows.Count];
           for (int i = 0; i < cards.Length; i++)
           {

               cards[i] = new cardContent();

               cards[i].FilmName = (string)dataTable.Rows[i]["FilmName"];
               cards[i].Genre = (string)dataTable.Rows[i]["Genre"];
               cards[i].Country = (string)dataTable.Rows[i]["Country"];
               cards[i].PG = (int)dataTable.Rows[i]["PG"];
               cards[i].FilmLink = (string)dataTable.Rows[i]["FilmLink"];
              // cards[i].BackgroundImage = GetImage((byte[])dataTable.Rows[i]["photo"]);
               cards[i].Price = dataTable.Rows[i]["Price"].ToString();
               cards[i].DateRealise = dataTable.Rows[i]["DateRealise"].ToString();
               cards[i].BackgroundImage = Image.FromStream(new MemoryStream((byte[])dataTable.Rows[i]["photo"]));
           }
           dataTable.Dispose();
       }
       */
        #endregion     
        public static T[] GetCards<T>(this IList<T> cardArr, string SelectionCriteria,string value)
           where T : ICardItem
        {
            
            string objectName = typeof(T).Name;
            if (objectName == "bascketPurchadeFilmCard") objectName = "cardContent";
            #region test query
            string queryString = " SELECT fd.idFilm , fd.FilmName,fd.Genre,fd.DateRealise,fd.Country,fd.PG,fd.Price,fd.FilmLink ,p.objectName,p.photoVariation"+
        " FROM  filmsdata fd inner join imageSource p on p.idFilm = fd.idFilm"+
    $" where {SwitchQuerySeparator.whereCommandBuilder(SelectionCriteria, value)} and objectName = '{objectName}'";
          
            #endregion

            OrderRepository orderRepository = new OrderRepository(new SSQLOrderRepository());
            DataTable dataTable = orderRepository.load(queryString);
           
            cardArr = new T[dataTable.Rows.Count];
                       
            for (int i = 0; i < cardArr.Count; i++)
            {
                cardArr[i] = GetInstance<T>();
                cardArr[i].Id = (int)dataTable.Rows[i]["idFilm"];
                cardArr[i].FilmName = dataTable.Rows[i]["FilmName"].ToString();
                cardArr[i].Genre = (string)dataTable.Rows[i]["Genre"];
                cardArr[i].Country = (string)dataTable.Rows[i]["Country"];
                cardArr[i].PG = (int)dataTable.Rows[i]["PG"];
                cardArr[i].Price = dataTable.Rows[i]["Price"].ToString();
                cardArr[i].DateRealise = dataTable.Rows[i]["DateRealise"].ToString();
                              
                cardArr[i].FilmLink = (string)dataTable.Rows[i]["FilmLink"];

                if (dataTable.Rows[i]["photoVariation"] != null)
                    cardArr[i].PhotoCard = Image.FromStream(new MemoryStream((byte[])dataTable.Rows[i]["photoVariation"]));                             
                    for (int k = 0; k < UserLibrary.Length; k++)
                    {

                        if ((dataTable.Rows[i]["idFilm"].ToString() == UserLibrary[k]))
                        {
                            cardArr[i].Acquired = true;
                        }
                    }               
            }         
            dataTable.Dispose();
            
            return cardArr.ToArray();
        }
       
        public static void TransferUserData(string userLogin)
        {
            UserLogin = userLogin;
        }       
         public static void TransferUserLibrary(string[] userLibrary)
        {
            UserLibrary = userLibrary;             
        }        
    }
}
