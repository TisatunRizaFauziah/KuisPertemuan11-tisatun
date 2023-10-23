using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuisPertemuan11_tisatun.Controller
{
    internal class Tampil : Model.conecction
    {
        public DataTable tampilkan()
        {
            DataTable dt = new DataTable();

            try
            {
                string muncul = "select * from mahasiswa";
                da = new MySqlConnector.MySqlDataAdapter(muncul, GetCoo());
                da.Fill(dt);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        public void tambah(string Nim,string Nama,string Alamat,string Prodi,string Hobi)
        {
            string nambah = " insert into mahasiswa values (" + "@nim,@nama,@alamat,@prodi,@hobi)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(nambah, GetCoo());
                cmd.Parameters.Add("@nim", MySqlConnector.MySqlDbType.VarChar).Value = Nim;
                cmd.Parameters.Add("@nama", MySqlConnector.MySqlDbType.VarChar).Value = Nama;
                cmd.Parameters.Add("@alamat", MySqlConnector.MySqlDbType.VarChar).Value = Alamat;
                cmd.Parameters.Add("@prodi", MySqlConnector.MySqlDbType.VarChar).Value = Prodi;
                cmd.Parameters.Add("@hobi", MySqlConnector.MySqlDbType.VarChar).Value = Hobi;
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex) {
                MessageBox.Show("tambah gagal " + ex.Message);
                    }
        }
    }
}
