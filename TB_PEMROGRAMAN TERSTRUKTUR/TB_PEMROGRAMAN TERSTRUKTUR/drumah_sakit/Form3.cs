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
    public partial class Form3 : Form
    {
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox textnopendaftaran;
        private TextBox textalamat;
        private TextBox textnama;
        private Button btnubah;
        private Button btnkeluar;
        private DataGridView dataGridView1;
        private Button btnsimpan;
        private BindingSource bindingSource1;
        private IContainer components;
        private Button button1view;
        private CheckedListBox checkedListBox1;
        private Button btnhapus;
        private Label label4;
    
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MOJEGGE\MICROSOFT;Initial Catalog=bismillahrumahsakit;Integrated Security=True");
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textnopendaftaran = new System.Windows.Forms.TextBox();
            this.textalamat = new System.Windows.Forms.TextBox();
            this.textnama = new System.Windows.Forms.TextBox();
            this.btnubah = new System.Windows.Forms.Button();
            this.btnkeluar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1view = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnhapus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "No Pendaftaran";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nama";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jenis Kelamin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Alamat";
            // 
            // textnopendaftaran
            // 
            this.textnopendaftaran.Location = new System.Drawing.Point(166, 22);
            this.textnopendaftaran.Multiline = true;
            this.textnopendaftaran.Name = "textnopendaftaran";
            this.textnopendaftaran.Size = new System.Drawing.Size(166, 24);
            this.textnopendaftaran.TabIndex = 6;
            this.textnopendaftaran.Text = " ";
            // 
            // textalamat
            // 
            this.textalamat.Location = new System.Drawing.Point(166, 172);
            this.textalamat.Multiline = true;
            this.textalamat.Name = "textalamat";
            this.textalamat.Size = new System.Drawing.Size(166, 24);
            this.textalamat.TabIndex = 7;
            this.textalamat.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textnama
            // 
            this.textnama.Location = new System.Drawing.Point(166, 65);
            this.textnama.Multiline = true;
            this.textnama.Name = "textnama";
            this.textnama.Size = new System.Drawing.Size(166, 24);
            this.textnama.TabIndex = 9;
            // 
            // btnubah
            // 
            this.btnubah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnubah.Image = global::drumah_sakit.Properties.Resources.Rumah_sakit_perawat_seragam_jas_lab_Gaya_Korea_wanita_medis_rumah_sakit_pakaian_scrub_Seragam_busana;
            this.btnubah.Location = new System.Drawing.Point(641, 22);
            this.btnubah.Name = "btnubah";
            this.btnubah.Size = new System.Drawing.Size(96, 39);
            this.btnubah.TabIndex = 11;
            this.btnubah.Text = "UBAH";
            this.btnubah.UseVisualStyleBackColor = true;
            this.btnubah.Click += new System.EventHandler(this.btnubah_Click);
            // 
            // btnkeluar
            // 
            this.btnkeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkeluar.Image = global::drumah_sakit.Properties.Resources.Rumah_sakit_perawat_seragam_jas_lab_Gaya_Korea_wanita_medis_rumah_sakit_pakaian_scrub_Seragam_busana;
            this.btnkeluar.Location = new System.Drawing.Point(641, 112);
            this.btnkeluar.Name = "btnkeluar";
            this.btnkeluar.Size = new System.Drawing.Size(92, 39);
            this.btnkeluar.TabIndex = 14;
            this.btnkeluar.Text = "KELUAR";
            this.btnkeluar.UseVisualStyleBackColor = true;
            this.btnkeluar.Click += new System.EventHandler(this.btnkeluar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(166, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(477, 187);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // btnsimpan
            // 
            this.btnsimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsimpan.Image = global::drumah_sakit.Properties.Resources.Rumah_sakit_perawat_seragam_jas_lab_Gaya_Korea_wanita_medis_rumah_sakit_pakaian_scrub_Seragam_busana;
            this.btnsimpan.Location = new System.Drawing.Point(641, 69);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(92, 39);
            this.btnsimpan.TabIndex = 16;
            this.btnsimpan.Text = "SIMPAN";
            this.btnsimpan.UseVisualStyleBackColor = true;
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);
            // 
            // button1view
            // 
            this.button1view.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1view.Image = global::drumah_sakit.Properties.Resources.Rumah_sakit_perawat_seragam_jas_lab_Gaya_Korea_wanita_medis_rumah_sakit_pakaian_scrub_Seragam_busana;
            this.button1view.Location = new System.Drawing.Point(523, 67);
            this.button1view.Name = "button1view";
            this.button1view.Size = new System.Drawing.Size(96, 39);
            this.button1view.TabIndex = 17;
            this.button1view.Text = "VIEW";
            this.button1view.UseVisualStyleBackColor = true;
            this.button1view.Click += new System.EventHandler(this.button1view_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "perempuan",
            "laki-laki"});
            this.checkedListBox1.Location = new System.Drawing.Point(166, 95);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(166, 49);
            this.checkedListBox1.TabIndex = 18;
            // 
            // btnhapus
            // 
            this.btnhapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhapus.Image = global::drumah_sakit.Properties.Resources.Rumah_sakit_perawat_seragam_jas_lab_Gaya_Korea_wanita_medis_rumah_sakit_pakaian_scrub_Seragam_busana;
            this.btnhapus.Location = new System.Drawing.Point(523, 22);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(96, 39);
            this.btnhapus.TabIndex = 43;
            this.btnhapus.Text = "HAPUS";
            this.btnhapus.UseVisualStyleBackColor = true;
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);
            // 
            // Form3
            // 
            this.BackgroundImage = global::drumah_sakit.Properties.Resources.Rumah_sakit_perawat_seragam_jas_lab_Gaya_Korea_wanita_medis_rumah_sakit_pakaian_scrub_Seragam_busana1;
            this.ClientSize = new System.Drawing.Size(795, 421);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button1view);
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnkeluar);
            this.Controls.Add(this.btnubah);
            this.Controls.Add(this.textnama);
            this.Controls.Add(this.textalamat);
            this.Controls.Add(this.textnopendaftaran);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form3";
            this.Text = "pendaftaran";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
            string query = "INSERT INTO pendaftaran (no_pendaftaran,nama,jenis_kelamin,alamat) VALUES ('" + textnopendaftaran.Text + "','" + textnama.Text + "','" + checkedListBox1.Text + "','" + textalamat.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("INSERTED SUCCESSFULY !!!!");
        
        
        }

        private void button1view_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT*FROM pendaftaran";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnubah_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE pendaftaran SET nama='" + textnama.Text + "',jenis_kelamin='" + checkedListBox1.Text + "',alamat='" + textalamat.Text + "'WHERE no_pendaftaran='" + textnopendaftaran.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("UPDATE SUCCESS !!!!"); 
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textnopendaftaran.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textnama.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            checkedListBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textalamat.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM pendaftaran where no_pendaftaran='" + textnopendaftaran.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("RECORD DELETE !!!!");
        }
       
    }
}
