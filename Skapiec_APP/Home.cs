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
        List<SearchModel> people = new List<SearchModel>();
       

        public Home()
        {
            InitializeComponent();
            LoadSearchList();
            populateItems();
        }

        private void populateItems()
        {
            //wypełnienie
            HomeItem[] listItems = new HomeItem[20];

            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new HomeItem();

                listItems[i].Title = "weź dane z skądś";
                
                listItems[i].Price = "weź cene z skądś";

                // dodawnie do flow layout panelu 
                if (home_panel.Controls.Count < 0)
                {
                    home_panel.Controls.Clear();
                }
                else
                    home_panel.Controls.Add(listItems[i]);
            }
        }


        private void LoadSearchList()
        {
            people = SqliteDataAccess.LoadSearch();
            WireUpSearchList();
        }

        private void WireUpSearchList()
        {
            test.DataSource = null;
            test.DataSource = people;
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
