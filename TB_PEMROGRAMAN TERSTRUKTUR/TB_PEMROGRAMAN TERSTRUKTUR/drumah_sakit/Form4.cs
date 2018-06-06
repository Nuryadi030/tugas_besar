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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MOJEGGE\MICROSOFT;Initial Catalog=bismillahrumahsakit;Integrated Security=True");
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbGolDrh_DropDownStyleChanged(object sender, EventArgs e)
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
            string query = "INSERT INTO pasien (kd_pasien,nama,TTL,jenis_kelamin,no_pendaftaran,alamat,gol_darah,berat_badan,tinggi_badan,jenis_penyakit,umur) VALUES ('" + textkdpasien.Text + "','" + textnama.Text + "','" + textTTL.Text + "','" + checkedListBox1.Text + "','" + textnopendaftaran.Text + "','" + textalamatp.Text + "','" + cmbGolDrh.Text + "','" + textberatbadan.Text + "','" + texttinggibadan + "','" + textjenispenyakit + "','" + textumur + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("INSERTED SUCCESSFULY !!!!");
        }

        private void button1view_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT*FROM pasien";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btnubah_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE pasien SET nama='" + textnama.Text + "',TTL='" + textTTL.Text + "',jenis_kelamin='" + checkedListBox1.Text + "',no_pendaftaran='" + textnopendaftaran.Text + "',alamat='" + textalamatp.Text + "',gol_darah='" + cmbGolDrh.Text + "',berat_badan='" + textberatbadan.Text + "',tinggi_badan='" + texttinggibadan.Text + "',jenis_penyakit='" + textjenispenyakit.Text + "',umur='" + textumur.Text + "'WHERE kd_pasien='" + textkdpasien.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("UPDATE SUCCESS !!!!"); 
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM pasien where kd_pasien='" + textkdpasien.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("RECORD DELETE !!!!");
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textkdpasien.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textnama.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textTTL.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            checkedListBox1.Text= dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textnopendaftaran.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textalamatp.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            cmbGolDrh.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textberatbadan.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            texttinggibadan.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            textjenispenyakit.Text= dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            textumur.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
        }
    }
}
