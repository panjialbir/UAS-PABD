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
        private string stringConnection = "Data Source = LAPTOP-K5VL3AER;" + "database =penyewaan_baju;User ID=sa;Password=123456";
        private SqlConnection koneksi;

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select nama_prodi from dbo.penyewa";
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
            refreshform();
        }

        private void sve_Click(object sender, EventArgs e)
        {
            string idpnyw = idp.Text;
            string nmpnyw = nmp.Text;
            string noHp = nhp.Text;

            if (nmpnyw == "")
            {
                MessageBox.Show("Masukkan Nama Penyewa", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                

                string query = "INSERT INTO dbo.penyewa (id_penyewa, nama_penyewa, no_hp) VALUES (@id, @nama, @nohp)";
                using (SqlCommand command = new SqlCommand(query, koneksi))
                {
                    command.Parameters.Add("@id", SqlDbType.VarChar).Value = idpnyw;
                    command.Parameters.Add("@nama", SqlDbType.VarChar).Value = nmpnyw;
                    command.Parameters.Add("@nohp", SqlDbType.VarChar).Value = noHp;
                    command.ExecuteNonQuery();
                }

                koneksi.Close();
                MessageBox.Show("Data telah ditambahkan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }

        }

        private void cls_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Membuka kembali Form1
            Form1 form1 = new Form1();
            form1.ShowDialog();

            // Menutup aplikasi setelah menutup Form1 (jika diperlukan)
            Application.Exit();
        }
    }
}
