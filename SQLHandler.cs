using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace StellarMVVM_2024
{
    internal class SQLHandler
    {
        SQLiteConnection sqlite_conn;
        public SQLHandler() {
            sqlite_conn = CreateConnection();
        }

        private SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlite_connection;
            sqlite_connection = new SQLiteConnection("Data Source=database.db; Version = 3; New = True; Compress = True; ");
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return sqlite_connection;
        }

        private void Close()
        {

        }
    }
}
