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
            LoadPeopleList();
        }

        private void LoadPeopleList()
        {
            people = SqliteDataAccess.LoadPeople();                      
            WireUpPeopleList();
        }

        private void WireUpPeopleList()
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
