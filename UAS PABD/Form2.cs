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

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select nama_prodi from dbo.prodi";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }


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
            idp.Enabled = true;
            nmp.Enabled = true;
            nhp.Enabled = true;
            sve.Enabled = true;
            clr.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView();
            opn.Enabled = false;
        }

        private void clr_Click(object sender, EventArgs e)
        {

        }

        private void sve_Click(object sender, EventArgs e)
        {

        }
    }
}
