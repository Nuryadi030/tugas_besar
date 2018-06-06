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
    public partial class Form7 : Form
    {
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox textkdobat;
        private TextBox textstok;
        private TextBox textexpaired;
        private TextBox texttanggalmasuk;
        private ComboBox cbjenis;
        private Button btnsimpan;
        private Button btnubah;
        private Button button1;
        private DataGridView dataGridView1;
        private Button btnhapus;
        private Button button1view;
        private Label label5;
    
        public Form7()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MOJEGGE\MICROSOFT;Initial Catalog=bismillahrumahsakit;Integrated Security=True");
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textkdobat = new System.Windows.Forms.TextBox();
            this.textstok = new System.Windows.Forms.TextBox();
            this.textexpaired = new System.Windows.Forms.TextBox();
            this.texttanggalmasuk = new System.Windows.Forms.TextBox();
            this.cbjenis = new System.Windows.Forms.ComboBox();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.btnubah = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnhapus = new System.Windows.Forms.Button();
            this.button1view = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kd Obat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Jenis ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stok";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-1, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Expaired";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-1, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tanggal Masuk";
            // 
            // textkdobat
            // 
            this.textkdobat.Location = new System.Drawing.Point(122, 5);
            this.textkdobat.Multiline = true;
            this.textkdobat.Name = "textkdobat";
            this.textkdobat.Size = new System.Drawing.Size(166, 24);
            this.textkdobat.TabIndex = 12;
            // 
            // textstok
            // 
            this.textstok.Location = new System.Drawing.Point(122, 76);
            this.textstok.Multiline = true;
            this.textstok.Name = "textstok";
            this.textstok.Size = new System.Drawing.Size(166, 24);
            this.textstok.TabIndex = 13;
            // 
            // textexpaired
            // 
            this.textexpaired.Location = new System.Drawing.Point(122, 112);
            this.textexpaired.Multiline = true;
            this.textexpaired.Name = "textexpaired";
            this.textexpaired.Size = new System.Drawing.Size(166, 24);
            this.textexpaired.TabIndex = 14;
            // 
            // texttanggalmasuk
            // 
            this.texttanggalmasuk.Location = new System.Drawing.Point(122, 158);
            this.texttanggalmasuk.Multiline = true;
            this.texttanggalmasuk.Name = "texttanggalmasuk";
            this.texttanggalmasuk.Size = new System.Drawing.Size(166, 24);
            this.texttanggalmasuk.TabIndex = 15;
            // 
            // cbjenis
            // 
            this.cbjenis.FormattingEnabled = true;
            this.cbjenis.Items.AddRange(new object[] {
            "Tablet",
            "Pil",
            "Salep",
            "Serbuk",
            "Kapsul"});
            this.cbjenis.Location = new System.Drawing.Point(122, 35);
            this.cbjenis.Name = "cbjenis";
            this.cbjenis.Size = new System.Drawing.Size(166, 21);
            this.cbjenis.TabIndex = 16;
            // 
            // btnsimpan
            // 
            this.btnsimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsimpan.Image = global::drumah_sakit.Properties.Resources.Rumah_sakit_perawat_seragam_jas_lab_Gaya_Korea_wanita_medis_rumah_sakit_pakaian_scrub_Seragam_busana;
            this.btnsimpan.Location = new System.Drawing.Point(442, 9);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(96, 39);
            this.btnsimpan.TabIndex = 37;
            this.btnsimpan.Text = "SIMPAN";
            this.btnsimpan.UseVisualStyleBackColor = true;
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);
            // 
            // btnubah
            // 
            this.btnubah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnubah.Image = global::drumah_sakit.Properties.Resources.Rumah_sakit_perawat_seragam_jas_lab_Gaya_Korea_wanita_medis_rumah_sakit_pakaian_scrub_Seragam_busana;
            this.btnubah.Location = new System.Drawing.Point(340, 9);
            this.btnubah.Name = "btnubah";
            this.btnubah.Size = new System.Drawing.Size(96, 39);
            this.btnubah.TabIndex = 40;
            this.btnubah.Text = "UBAH";
            this.btnubah.UseVisualStyleBackColor = true;
            this.btnubah.Click += new System.EventHandler(this.btnubah_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::drumah_sakit.Properties.Resources.Rumah_sakit_perawat_seragam_jas_lab_Gaya_Korea_wanita_medis_rumah_sakit_pakaian_scrub_Seragam_busana;
            this.button1.Location = new System.Drawing.Point(544, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 39);
            this.button1.TabIndex = 41;
            this.button1.Text = "KELUAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(122, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(432, 150);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // btnhapus
            // 
            this.btnhapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhapus.Image = global::drumah_sakit.Properties.Resources.Rumah_sakit_perawat_seragam_jas_lab_Gaya_Korea_wanita_medis_rumah_sakit_pakaian_scrub_Seragam_busana;
            this.btnhapus.Location = new System.Drawing.Point(340, 54);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(96, 39);
            this.btnhapus.TabIndex = 45;
            this.btnhapus.Text = "HAPUS";
            this.btnhapus.UseVisualStyleBackColor = true;
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);
            // 
            // button1view
            // 
            this.button1view.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1view.Image = global::drumah_sakit.Properties.Resources.Rumah_sakit_perawat_seragam_jas_lab_Gaya_Korea_wanita_medis_rumah_sakit_pakaian_scrub_Seragam_busana;
            this.button1view.Location = new System.Drawing.Point(442, 54);
            this.button1view.Name = "button1view";
            this.button1view.Size = new System.Drawing.Size(96, 39);
            this.button1view.TabIndex = 46;
            this.button1view.Text = "VIEW";
            this.button1view.UseVisualStyleBackColor = true;
            this.button1view.Click += new System.EventHandler(this.button1view_Click);
            // 
            // Form7
            // 
            this.BackgroundImage = global::drumah_sakit.Properties.Resources.Rumah_sakit_perawat_seragam_jas_lab_Gaya_Korea_wanita_medis_rumah_sakit_pakaian_scrub_Seragam_busana1;
            this.ClientSize = new System.Drawing.Size(923, 396);
            this.Controls.Add(this.button1view);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnubah);
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.cbjenis);
            this.Controls.Add(this.texttanggalmasuk);
            this.Controls.Add(this.textexpaired);
            this.Controls.Add(this.textstok);
            this.Controls.Add(this.textkdobat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form7";
            this.Text = "Obat";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void btnkeluar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
            f2.Hide();
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO obat (kd_obat,jenis,stok,expaired,tanggal_masuk) VALUES ('" + textkdobat.Text + "','" + cbjenis.Text + "','" + textstok.Text + "','" + textexpaired.Text + "','"+texttanggalmasuk.Text+"')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("INSERTED SUCCESSFULY !!!!");
        
        }

        private void button1view_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT*FROM obat";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btnubah_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE obat SET jenis='" + cbjenis.Text + "',stok='" + textstok.Text + "',expaired='" + textexpaired.Text+"',tanggal_masuk='"+texttanggalmasuk.Text + "'WHERE kd_obat='" + textkdobat.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("UPDATE SUCCESS !!!!"); 
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textkdobat.Text= dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            cbjenis.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textstok.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textexpaired.Text= dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            texttanggalmasuk.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM obat where kd_obat='" + textkdobat.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("RECORD DELETE !!!!");
        }
    }
}
