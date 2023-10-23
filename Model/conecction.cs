using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuisPertemuan11_tisatun.Model
{
    internal class conecction
    {
        public MySqlCommand cmd;
        public DataSet ds;
        public MySqlDataAdapter da;
        public MySqlConnection Conn;

        public MySqlConnection GetCoo()
        {
            Conn = new MySqlConnection();
            Conn.ConnectionString = "server = localhost;user=root;database=unaspasim";
            try
            {
                Conn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Koneksi gagal " + ex.Message);
            }
            return Conn;

        }
    }
}
