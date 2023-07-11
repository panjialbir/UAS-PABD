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
    public partial class Form3 : Form
    {
        private string stringConnection = "Data Source = LAPTOP-K5VL3AER;" + "database=penyewaan_baju;User ID=sa;Password=123456";
        private SqlConnection koneksi;

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select nama_prodi from dbo.baju";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }
        private void refreshform()
        {
            idb.Text = "";
            idb.Enabled = false;
            mbj.Text = "";
            mbj.Enabled = false;
            ukr.Text = "";
            ukr.Enabled = false;
            hrg.Text = "";
            hrg.Enabled = false;
            idk.Text = "";
            idk.Enabled = false;
            sve.Enabled = false;
            clr.Enabled = false;
        }
        public Form3()
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
            idb.Enabled = true;
            mbj.Enabled = true;
            ukr.Enabled = true;
            hrg.Enabled = true;
            idk.Enabled = true;
        }

        private void sve_Click(object sender, EventArgs e)
        {
            string idbj = idb.Text;
            string mrkb = mbj.Text;
            string ukrn = ukr.Text;
            string hrga = hrg.Text;
            string idkt = idk.Text;

            if (mrkb == "")
            {
                MessageBox.Show("Masukkan Merk Baju", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();


                string query = "INSERT INTO dbo.baju (id_baju, merk_baju, ukuran, harga, id_kategori) VALUES (@idb, @mrk, @ukr, @hrg, @idk)";
                using (SqlCommand command = new SqlCommand(query, koneksi))
                {
                    command.Parameters.Add("@idb", SqlDbType.VarChar).Value = idbj;
                    command.Parameters.Add("@mbj", SqlDbType.VarChar).Value = mrkb;
                    command.Parameters.Add("@ukr", SqlDbType.VarChar).Value = ukrn;
                    command.Parameters.Add("@hrg", SqlDbType.VarChar).Value = hrga;
                    command.Parameters.Add("@idk", SqlDbType.VarChar).Value = idkt;
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
