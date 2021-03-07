using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Configuration;
using Dapper;
using System.Data;

namespace Skapiec_APP
{
    class SqliteDataAccess
    {
        

        public static List<SearchModel> LoadSearch()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnetionString()))
            {
                var output = cnn.Query<SearchModel>("select * from Search", new DynamicParameters());
                return output.ToList();
            }
        }
        public static void SaveSearch(SearchModel search)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnetionString()))
            {
                cnn.Execute("insert into Search (SearchQuery) values (@SearchQuery)",search);
            }

        }

        private static string LoadConnetionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }



    }
}
