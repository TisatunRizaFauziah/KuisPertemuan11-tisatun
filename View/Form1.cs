using KuisPertemuan11_tisatun.Controller;
using KuisPertemuan11_tisatun.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuisPertemuan11_tisatun
{
    public partial class Form1 : Form
    {
        private Tampil tampil;
        public Form1()
        {
            tampil = new Tampil();
            InitializeComponent();
        }

        private void segarkan()
        {
            dataGridView1.DataSource = tampil.tampilkan();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
           Form2 fr = new Form2();
            fr.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            segarkan();
        }
    }
}
