using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_714240035
{
    internal class Koneksi
    {
        private string connectionString =
           "Server=localhost;Database=pemrog2ulbi;Uid=root;Pwd=;";

        private MySqlConnection kon;

        public void OpenConnection()
        {
            kon = new MySqlConnection(connectionString);
            kon.Open();
        }

        public void CloseConnection()
        {
            if (kon != null && kon.State == ConnectionState.Open)
            {
                kon.Close();
            }
        }

        public object ShowData(string query)
        {
            OpenConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter(query, kon);
            DataTable table = new DataTable();
            adapter.Fill(table);

            CloseConnection();
            return table;
        }
    }
}
