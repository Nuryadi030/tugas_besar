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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MOJEGGE\MICROSOFT;Initial Catalog=bismillahrumahsakit;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("ingin keluar ?", "kofirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO pembayaran (kd_pembayaran,lama_rawat,harga_kamar,harga_obat) VALUES ('" + textkdpembayaran.Text + "','" + textkdpasien.Text + "','" + texthargakamar.Text + "','" + texthargaobat+ "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("INSERTED SUCCESSFULY !!!!");
        }

        private void btntotal_Click(object sender, EventArgs e)
        {

           


        }

        private void button1view_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT*FROM pembayaran";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btnubah_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE pembayaran SET lama_rawat='"+textkdpasien.Text + "',harga_kamar='" + texthargakamar.Text + "',harga_obat='" + texthargaobat.Text + "'WHERE kd_pembayaran='" + textkdpembayaran + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("UPDATE SUCCESS !!!!"); 
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textkdpembayaran.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textkdpasien.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            texthargakamar.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            texthargaobat.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM pembayaran where kd_pembayaran='" + textkdpembayaran.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("RECORD DELETE !!!!");
        }
    }
}
