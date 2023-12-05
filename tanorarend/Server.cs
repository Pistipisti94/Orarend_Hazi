using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;

namespace tanorarend
{
    internal static class Server
    {
        public static MySqlConnection conn = null;
        public static MySqlCommand cmd = null;
        public static string userId = null;

        public static void csatlakozas()
        {
        
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "orarend";
            builder.CharacterSet = "utf8";
            conn = new MySqlConnection(builder.ConnectionString);
            cmd = conn.CreateCommand();
            try
            {
                Console.WriteLine("Az adatbázis csatlakozás megtörtént.");
                conn.Open();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                Console.ReadLine();
                Environment.Exit(1);
            }
        }
        public static void bejelentkezes()
        {
            
        }
    }
}
