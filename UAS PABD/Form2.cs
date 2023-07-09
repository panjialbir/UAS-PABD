using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS_PABD
{
    public partial class Form2 : Form
    {
        private string stringConnection = "data source=LAPTOP-K5VL3AER;" + "database=penyewaan_baju;Integrated Security=True;";
        private SqlConnection koneksi;

        private void refreshform()
        {
            idp.Text = "";
            idp.Enabled = false;
            nmp.Text = "";
            nmp.Enabled = false;
            nhp.Text = "";
            nhp.Enabled = false;
            sve.Enabled = false;
            clr.Enabled = false;
        }
        public Form2()
        {
            InitializeComponent();
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
