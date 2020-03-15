using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;
using System.Text;
using System.IO;
using System.Data.OleDb;
using System.Threading.Tasks;

namespace Prodavnica
{
    static class DBManager
    {
        private static string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Directory.GetCurrentDirectory() + @"\ProdavnicaDB.accdb";
        private static OleDbConnection connection = new OleDbConnection(connectionString);

        public static string ConnectionString { get => connectionString; }
        public static OleDbConnection Connection { get => connection; }

        public static void RunQuery(string q, OleDbCommand cmd)
        {
            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); connection.Close(); }
            finally { connection.Close(); }
        }

        public static void RunQuery(string q)
        {
            try
            {
                connection.Open();
                var command = new OleDbCommand(q, connection).ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); connection.Close(); }
            finally { connection.Close(); }
        }
    }
}