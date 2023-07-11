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
    public partial class Form7 : Form
    {
        private string stringConnection = "Data Source = LAPTOP-K5VL3AER;" + "database=penyewaan_baju;User ID=sa;Password=123456";
        private SqlConnection koneksi;
        private void dataGridView()
        {
            koneksi.Open();
            string str = "select id_penyewaan from dbo.penyewaan";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }
        private void refreshform()
        {
            idpa.Text = "";
            idpa.Enabled = false;
            idp.Text = "";
            idp.Enabled = false;
            idb.Text = "";
            idb.Enabled = false;
            tsw.Text = "";
            tsw.Enabled = false;
            tkm.Text = "";
            tkm.Enabled = false;
            hrg.Text = "";
            hrg.Enabled = false;
            sve.Enabled = false;
            clr.Enabled = false;
        }
        public Form7()
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
            idpa.Enabled = true;
            idp.Enabled = true;
            idb.Enabled = true;
            tsw.Enabled = true;
            tkm.Enabled = true;
            hrg.Enabled = true;
           
        }

        private void sve_Click(object sender, EventArgs e)
        {
            string idpaan = idpa.Text;
            string idpny = idp.Text;
            string idbj = idb.Text;
            string tsewa = tsw.Text;
            string tkmb = tkm.Text;
            string hrga = hrg.Text;

            if (idpaan == "")
            {
                MessageBox.Show("Masukkan ID Penyewaan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string randomCode = GenerateRandomNonRepetitiveString(5);

                string query = "INSERT INTO dbo.penyewaan (id_penyewaan, id_penyewa, id_baju, tgl_sewa, tgl_kembali, total_harga) VALUES (@idpa, @idp, @idb, @tsw, @tkm, @hrg)";
                using (SqlCommand command = new SqlCommand(query, koneksi))
                {
                    command.Parameters.Add("@idpa", SqlDbType.VarChar).Value = idpaan;
                    command.Parameters.Add("@idp", SqlDbType.VarChar).Value = idpny;
                    command.Parameters.Add("@idb", SqlDbType.VarChar).Value = idbj;
                    command.Parameters.Add("@tsw", SqlDbType.VarChar).Value = tsewa;
                    command.Parameters.Add("@tkm", SqlDbType.VarChar).Value = tkmb;
                    command.Parameters.Add("@hrg", SqlDbType.VarChar).Value = hrga;
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
