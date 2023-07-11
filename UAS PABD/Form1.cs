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
    }
}
