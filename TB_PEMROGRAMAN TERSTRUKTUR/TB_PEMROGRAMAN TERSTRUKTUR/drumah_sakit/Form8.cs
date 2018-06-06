using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace drumah_sakit
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MOJEGGE\MICROSOFT;Initial Catalog=bismillahrumahsakit;Integrated Security=True");
        private void btnmasuk_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            this.Hide();
        }

        private void btnkeluar_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
            f2.Hide();
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO petugas (kd_petugas,nama,alamat,tanggal_bertugas,jenis_kelamin) VALUES ('" + textkdpetugas.Text + "','" + textnamapetugas.Text + "','" + textalamat.Text + "','" + texttanggalbertugas.Text + "','"+checkedListBox1.Text+"')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("INSERTED SUCCESSFULY !!!!");
        }

        private void button1view_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT*FROM petugas";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btnubah_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE petugas SET nama='" + textnamapetugas.Text + "',alamat='" + textalamat.Text + "',tanggal_bertugas='" + texttanggalbertugas.Text +"',jenis_kelamin='"+checkedListBox1.Text+ "'WHERE kd_petugas='" + textkdpetugas.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("UPDATE SUCCESS !!!!"); 
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textkdpetugas.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textnamapetugas.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textalamat.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            texttanggalbertugas.Text= dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            checkedListBox1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM petugas where kd_petugas='" + textkdpetugas.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("RECORD DELETE !!!!");
        }
    }
}
