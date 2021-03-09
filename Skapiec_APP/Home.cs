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
        //wczytanie danych z bazy 
        private static string LoadConnetionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
        private void Odswiez()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnetionString()))
            {
                var output = cnn.Query("select search_query from search", new DynamicParameters());

                search.Text = output.ToString();
            }
        }


        public Home()
        {
            InitializeComponent();
            Odswiez();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
