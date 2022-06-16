using System.Collections.Generic;
using System.Windows.Forms;
using SimRenMovie.Card;
using SimRenMovie.Database;
using SimRenMovie.DatabaseLoader;
using SimRenMovie.ControlExtensions;

namespace SimRenMovie.CustomControls
{
    public partial class UserBascket : UserControl
    {
        public List<string> Items;
        
        private FlowLayoutPanel FlowLayoutPanel;
        public UserBascket()
        {
            InitializeComponent();
           
        }
        private void UserBascket_Load(object sender, System.EventArgs e)
        {           
          //  labelCount.Text = Items.Count.ToString();        //TODO Ссылка на объект не указывает на экземпляр объекта  
        }
       
        public new void Show()
        {
            if (Items.Count > 0)
            {
                FlowLayoutPanel = (this.Parent.Parent.Controls["flowLayoutPanelFilms"] as FlowLayoutPanel);
                FlowLayoutPanel.Controls.Clear();
                
                FlowLayoutPanel.Controls.AddRange(GetCardsData.GetCards(new List<bascketPurchadeFilmCard>(),
                        "idFilm", $"{string.Join(",", Items)}"));
            }
            else
            {
                MessageBox.Show("Корзина пуста");
            }                       
        }
        public void Remove(ICardItem cardMovie, string userName)
        {
            string query = $"delete from userbascket where idFilm = {cardMovie.Id} and idUser = (select u.id from users u where u.login = '{userName}')";
            OrderRepository orderRepository = new OrderRepository(new SSQLOrderRepository());
            bool filmsIsRemoveFromBascket = orderRepository.delete(query);
            if (filmsIsRemoveFromBascket)
            {
                MessageBox.Show("Товар успешно удален");
                int countElementsInBascket = int.Parse(labelCount.Text);
                countElementsInBascket--;
                //Todo Add Show for User bascket
                labelCount.Text = countElementsInBascket.ToString();
                Items.Remove(cardMovie.Id.ToString());
                
            }
        }
        public void Add(ICardItem cardMovie,string userName)
        {
            string query = "IF NOT EXISTS(SELECT*" +
            "FROM userbascket ub  inner join users u on ub.idUser = u.id" +
            $" WHERE ub.idFilm = {cardMovie.Id} and u.login = '{userName}')" +
            "BEGIN " +
           $" insert into userbascket(idFilm, idUser) values({cardMovie.Id}, (select u.id from users u where u.login = '{userName}'))" +
            "END ";
            OrderRepository orderRepository = new OrderRepository(new SSQLOrderRepository());
            bool filmsIsAddToBascket = orderRepository.save(query);
            if (filmsIsAddToBascket)
            {
                MessageBox.Show("Товар успешно добавлен в корзину");
                int countElementsInBascket = int.Parse(labelCount.Text);
                countElementsInBascket++;
                //Todo Add Show for User bascket
                labelCount.Text = countElementsInBascket.ToString();
                Items.Add(cardMovie.Id.ToString());
            }
            else MessageBox.Show("Товар уже в корзине");
        }
        public void ShowCountElementsInBascket()
        {
            labelCount.Text = Items.Count.ToString();
        }
        public void FillCountText()
        {
            labelCount.Text = Items.Count.ToString();
        }
    }
}
