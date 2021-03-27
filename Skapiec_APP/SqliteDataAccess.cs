using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Configuration;
using System.Data.SQLite;
using Dapper;

namespace Skapiec_APP
{
    public class ProductsModel
    {
        public int ID { get; set; }
        public string search_query { get; set; }
        public string image { get; set; }
        public string title { get; set; }
        public string price { get; set; }
        public string link { get; set; }
        public string image_name { get; set; }
    }
    public class HistoryModel
    {
        public int ID { get; set; }
        public string search_query { get; set; }
    }

    public class RunSearch
    {
        public string search_text { get; set; }
    }

    class SqliteDataAccess
    {
        //wczytanie danych z bazy 
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }


        public static void SaveRun(RunSearch run)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("update run set search_text = @search_text where ID is 1", run);
            }
        }

        public static void DeleteProducts(ProductsModel productsModel)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE from products WHERE search_query in (select search_text from run where ID is 1)", productsModel);
            }
        }
        
        public static void SaveProducts(ProductsModel productsModel)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into products (search_query, image, title, price, link, image_name) values (@search_query, @image, @title, @price, @link, @image_name)", productsModel);
            }
        }

        public static List<RunSearch> LoadRun()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<RunSearch>("select * from run", new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<ProductsModel> LoadProducts()
        {            
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ProductsModel>("select * from products INNER JOIN run ON products.search_query = run.search_text", new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<HistoryModel> LoadHistory()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<HistoryModel>("select distinct search_query from products", new DynamicParameters());
                return output.ToList();
            }
        }

    }
}