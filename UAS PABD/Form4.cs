using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS_PABD
{
    public partial class Form4 : Form
    {
        private string stringConnection = "Data Source = LAPTOP-K5VL3AER;" + "database=penyewaan_baju;User ID=sa;Password=123456";
        private SqlConnection koneksi;

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select nama_karyawan from dbo.karyawan";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void refreshform()
        {
            idk.Text = "";
            idk.Enabled = false;
            nmk.Text = "";
            nmk.Enabled = false;
            idc.Text = "";
            idc.Enabled = false;
            sve.Enabled = false;
            clr.Enabled = false;
        }
        public Form4()
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
            idk.Enabled = true;
            nmk.Enabled = true;
            idc.Enabled = true;
            sve.Enabled = true;
            clr.Enabled = true;
        }


        private void sve_Click(object sender, EventArgs e)
        {
            string idkr = idk.Text;
            string nmkr = nmk.Text;
            string idcb = idc.Text;

            if (nmkr == "")
            {
                MessageBox.Show("Masukkan Nama Karyawan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();


                string query = "INSERT INTO dbo.karyawan (id_karyawan, nama_karyawan, id_cabang) VALUES (@id, @nama, @idc)";
                using (SqlCommand command = new SqlCommand(query, koneksi))
                {
                    command.Parameters.Add("@id", SqlDbType.VarChar).Value = idkr;
                    command.Parameters.Add("@nama", SqlDbType.VarChar).Value = nmkr;
                    command.Parameters.Add("@idc", SqlDbType.VarChar).Value = idcb;
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
