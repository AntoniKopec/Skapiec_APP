﻿using System.Collections.Generic;
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
        public byte[] image { get; set; }
        public string title { get; set; }
        public string price { get; set; }
        public string link { get; set; }
    }

    public class RunSearch
    {
        public int ID { get; set; }
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
                cnn.Execute("insert into run (search_text) values (@search_text)", run);
            }
        }

        public static void SaveProducts(ProductsModel productsModel)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into products (search_query, image, title, price, link) values (@search_query, @image, @title, @price, @link)", productsModel);
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
                var output = cnn.Query<ProductsModel>("select * from products", new DynamicParameters());
                return output.ToList();
            }
        }

    }
}