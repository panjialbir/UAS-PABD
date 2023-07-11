using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS_PABD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataPenyewaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 hu = new Form2();
            hu.Show();
            this.Hide();
        }

        private void dataBajuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 fm = new Form3();
            fm.Show();
            this.Hide();
        }

        private void dataKaryawanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 fm = new Form4();
            fm.Show();
            this.Hide();
        }

        private void dataKategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 fm = new Form5();
            fm.Show();
            this.Hide();
        }

        private void dataCabangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 fm = new Form6();
            fm.Show();
            this.Hide();
        }

        private void dataPenyewaanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 fm = new Form7();
            fm.Show();
            this.Hide();
        }
    }
}
