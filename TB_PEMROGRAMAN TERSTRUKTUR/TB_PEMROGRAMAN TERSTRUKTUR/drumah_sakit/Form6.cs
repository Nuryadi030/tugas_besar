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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MOJEGGE\MICROSOFT;Initial Catalog=bismillahrumahsakit;Integrated Security=True");
        private void btnmasuk_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
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
            string query = "INSERT INTO ruang_inap (kd_kamar,jenis_kamar) VALUES ('" + textkdkamar.Text + "','" +checkedjeniskamar.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("INSERTED SUCCESSFULY !!!!");
        }

        private void button1view_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT*FROM ruang_inap";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btnubah_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE ruang_inap SET jenis_kamar='" + checkedjeniskamar.Text + "'WHERE kd_kamar='" + textkdkamar.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("UPDATE SUCCESS !!!!"); 
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textkdkamar.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            checkedjeniskamar.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
      
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM ruang_inap where kd_kamar='" + textkdkamar.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("RECORD DELETE !!!!");
        }
    }
}
