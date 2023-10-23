using KuisPertemuan11_tisatun.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuisPertemuan11_tisatun.View
{
    public partial class Form2 : Form
    {
        private Tampil tampil;
        public Form2()
        {
            tampil = new Tampil();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tampil = new Tampil();
            tampil.tambah(txtnim.Text, txtnama.Text, txtalamat.Text, txtprodi.Text, txthobi.Text);
            this.Controls.Clear();
            this.InitializeComponent();
            txtnim.Focus();
            MessageBox.Show("data disimpan");
            Form1 lk = new Form1();

            lk.Show();
            this.Hide();
        }
    }
}
