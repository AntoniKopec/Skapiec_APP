using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SQLite;
using Dapper;

namespace Skapiec_APP
{
    public partial class Home : Form
    {
        List<ProductsModel> Product = new List<ProductsModel>();
        List<SearchModel> Search = new List<SearchModel>();       

        public Home()
        {
            InitializeComponent();
            LoadProductsList();
            LoadSearchList();
            populateItems();            
        }

        private void populateItems()
        {
            //wypełnienie
            HomeItem[] listItems = new HomeItem[2];

            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new HomeItem();

                listItems[i].Title = Product[i].title;
                
                listItems[i].Price = Product[i].price;

                listItems[i].Icon = Image.FromFile(@"C:\Users\domin\Documents\Studia\Zespołowy Projekt Programistyczny\Skapiec_APP\img\" + Product[i].title + ".jpg");
                //każdy niech daje swoją ścieżkę żeby spawdzać czy działa                
                //wygląda na to że tytuły zdjęć muszą być takie jak tytuły ofert   

                // dodawnie do flow layout panelu 
                if (home_panel.Controls.Count < 0)
                {
                    home_panel.Controls.Clear();
                }
                else
                    home_panel.Controls.Add(listItems[i]);
            }
        }         

        private void LoadProductsList()
        {
            Product = SqliteDataAccess.LoadProducts();            
        }    

        private void LoadSearchList()
        {
            Search = SqliteDataAccess.LoadSearch();
            WireUpSearchList();
        }

        private void WireUpSearchList()
        {
            test.DataSource = null;
            test.DataSource = Search;
            test.DisplayMember = "search_query";
        }

        private void search_TextChanged(object sender, EventArgs e)
        {

        }

        private void test_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void history_btn_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
            this.Hide();
        }
    }
}
