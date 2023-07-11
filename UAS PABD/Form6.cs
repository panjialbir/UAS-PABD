using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS_PABD
{
    public partial class Form6 : Form
    {
        private string stringConnection = "Data Source = LAPTOP-K5VL3AER;" + "database=penyewaan_baju;User ID=sa;Password=123456";
        private SqlConnection koneksi;

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select nama_cabang from dbo.cabang";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }
        private void refreshform()
        {
            idc.Text = "";
            idc.Enabled = false;
            nmc.Text = "";
            nmc.Enabled = false;
            alm.Text = "";
            alm.Enabled = false;
            tlp.Text = "";
            tlp.Enabled = false;
            sve.Enabled = false;
            clr.Enabled = false;
        }
        public Form6()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void opn_Click(object sender, EventArgs e)
        {
            dataGridView();
            opn.Enabled = false;

        }

        private void add_Click(object sender, EventArgs e)
        {
            idc.Enabled = true;
            nmc.Enabled = true;
            alm.Enabled = true;
            tlp.Enabled = true;
            sve.Enabled = true;
            clr.Enabled = true;

        }

        private void sve_Click(object sender, EventArgs e)
        {
            string idcb = idc.Text;
            string nmcb = nmc.Text;
            string almt = alm.Text;
            string tlpn = tlp.Text;

            if (nmcb == "")
            {
                MessageBox.Show("Masukkan Nama Cabang", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();


                string query = "INSERT INTO dbo.cabang (id_cabang, nama_cabang, alamat, telepon) VALUES (@id, @nama, @almt, @tlpn)";
                using (SqlCommand command = new SqlCommand(query, koneksi))
                {
                    command.Parameters.Add("@id", SqlDbType.VarChar).Value = idcb;
                    command.Parameters.Add("@nama", SqlDbType.VarChar).Value = nmcb;
                    command.Parameters.Add("@almt", SqlDbType.VarChar).Value = almt;
                    command.Parameters.Add("@tlpn", SqlDbType.VarChar).Value = tlpn;
                    command.ExecuteNonQuery();
                }

                koneksi.Close();
                MessageBox.Show("Data telah ditambahkan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }
        }
    

        private void clr_Click(object sender, EventArgs e)
        {
            refreshform();
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
