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
    public partial class Form5 : Form
    {

        private string stringConnection = "Data Source = LAPTOP-K5VL3AER;" + "database=penyewaan_baju;User ID=sa;Password=123456";
        private SqlConnection koneksi;

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select nama_kategori from dbo.kategori";
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
            sve.Enabled = false;
            clr.Enabled = false;
        }
        public Form5()
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
            sve.Enabled = true;
            clr.Enabled = true;
        }

        private void sve_Click(object sender, EventArgs e)
        {
            string idkt = idk.Text;
            string nmkt = nmk.Text;


            if (nmkt == "")
            {
                MessageBox.Show("Masukkan Nama Kategori", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string randomCode = GenerateRandomNonRepetitiveString(5);

                string query = "INSERT INTO dbo.kategori (id_kategori, nama_kategori) VALUES (@id, @nama)";
                using (SqlCommand command = new SqlCommand(query, koneksi))
                {
                    command.Parameters.Add("@id", SqlDbType.VarChar).Value = idkt;
                    command.Parameters.Add("@nama", SqlDbType.VarChar).Value = nmkt;

                    command.ExecuteNonQuery();
                }

                koneksi.Close();
                MessageBox.Show("Data telah ditambahkan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }
        }
        static string GenerateRandomNonRepetitiveString(int size)
        {
            Random random = new Random();
            const string chars = "123456789abcdef";
            char[] hexChars = new char[size];

            for (int i = 0; i < size; i++)
            {
                hexChars[i] = chars[random.Next(chars.Length)];

            }

            return new string(hexChars);

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
