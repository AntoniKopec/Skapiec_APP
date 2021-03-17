using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Dapper;

namespace Skapiec_APP
{
    public partial class History : Form
    {
        List<ProductsModel> products = new List<ProductsModel>();
        List<SearchModel> people = new List<SearchModel>();
        List<sName> query = new List<sName>();

        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            populateItems();
        }


        private void populateItems()
        {
            //List<string> Search = new List<string> {"deska0-", "deska1-", "deska2-", "deska3-", "deska4-", "deska5-", "deska6-", "deska7-"};            
            //wypełnienie                   
            List<SearchModel> Search = new List<SearchModel>();

            HistoryItem[] listItems = new HistoryItem[1];
            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new HistoryItem();
                
                listItems[i].Title = Search[i].search_query;

                // dodawnie do flow layout panelu 
                if (history_panel.Controls.Count < 0)
                {
                    history_panel.Controls.Clear();
                }
                else
                    history_panel.Controls.Add(listItems[i]);
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

    }
}
