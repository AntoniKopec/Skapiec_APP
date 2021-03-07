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
using System.Configuration;
using Dapper;

namespace Skapiec_APP
{
    public partial class Form1 : Form
    {
        List<SearchModel> search = new List<SearchModel>();

        public Form1()
        {
            InitializeComponent();

            LoadSearchList();
        }

        private void LoadSearchList()
        {
            search = SqliteDataAccess.LoadSearch();

            WireUpSearchList();
        }

        private void WireUpSearchList()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = search;
            comboBox1.DisplayMember = "SearchCombo";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchModel s = new SearchModel();

            s.SearchQuery = textBox1.Text;

            SqliteDataAccess.SaveSearch(s);

            textBox1.Text = ""; 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
         
           
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
