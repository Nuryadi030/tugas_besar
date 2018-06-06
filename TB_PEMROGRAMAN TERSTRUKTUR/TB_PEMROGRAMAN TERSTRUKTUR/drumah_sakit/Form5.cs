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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MOJEGGE\MICROSOFT;Initial Catalog=bismillahrumahsakit;Integrated Security=True");
        private void Form5_Load(object sender, EventArgs e)
        {

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
            string query = "INSERT INTO dokter (kd_dokter,nama,jenis_kelamin,alamat,tanggal_praktek,no_tlp,spesialis) VALUES ('" + textKddokter.Text + "','" + textnamadokter.Text + "','" + checkedListBox1.Text + "','" + textalamat.Text + "','"+ texttanggalpraktek.Text+"','"+textnotelp.Text+"','"+textspesialis.Text+"')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("INSERTED SUCCESSFULY !!!!");
        
        }

        private void button1view_Click(object sender, EventArgs e)
        {

            con.Open();
            string query = "SELECT*FROM dokter";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btnubah_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE dokter SET nama='" + textnamadokter.Text + "',jenis_kelamin='" + checkedListBox1.Text + "',alamat='" + textalamat.Text +"',tanggal_praktek='"+texttanggalpraktek.Text+"',no_tlp='"+textnotelp.Text+"',spesialis='"+textspesialis.Text+ "'WHERE kd_dokter='" + textKddokter.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("UPDATE SUCCESS !!!!"); 
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textKddokter.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textnamadokter.Text= dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            checkedListBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textalamat.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            texttanggalpraktek.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textnotelp.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textspesialis.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM dokter where kd_dokter='" + textKddokter.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("RECORD DELETE !!!!");
        }
    }
}
