using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SQLite;
using Dapper;

namespace Skapiec_APP
{
    public class SearchModel
    {
        public int ID { get; set; }
        public string search_query { get; set; }
       
    }

    public class sName
    {
        public string search_query { get; set; }
    }

    public class ProductsModel
    {
        public int ID { get; set; }
        public int search_query { get; set; }
        public string image { get; set; }
        public string title { get; set; }
        public bool price { get; set; }
    }


    class SqliteDataAccess
    {
        //wczytanie danych z bazy 
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }


        public static List<SearchModel> LoadSearch()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<SearchModel>("select * from search", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<sName> sName()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<sName>("select search_query from search", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<ProductsModel> LoadProducts()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ProductsModel>("select * from products", new DynamicParameters());
                return output.ToList();
            }
        }

    }
}
