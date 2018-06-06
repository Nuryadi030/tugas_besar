namespace drumah_sakit
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textkdkamar = new System.Windows.Forms.TextBox();
            this.checkedjeniskamar = new System.Windows.Forms.CheckedListBox();
            this.btnmasuk = new System.Windows.Forms.Button();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.btnubah = new System.Windows.Forms.Button();
            this.btnkeluar = new System.Windows.Forms.Button();
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
            this.label2.Location = new System.Drawing.Point(-2, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kd Kamar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Jenis Kamar";
            // 
            // textkdkamar
            // 
            this.textkdkamar.Location = new System.Drawing.Point(124, 5);
            this.textkdkamar.Multiline = true;
            this.textkdkamar.Name = "textkdkamar";
            this.textkdkamar.Size = new System.Drawing.Size(166, 24);
            this.textkdkamar.TabIndex = 11;
            // 
            // checkedjeniskamar
            // 
            this.checkedjeniskamar.FormattingEnabled = true;
            this.checkedjeniskamar.Items.AddRange(new object[] {
            "VIP",
            "Kelas I",
            "Kelas II",
            "Kelas III"});
            this.checkedjeniskamar.Location = new System.Drawing.Point(124, 50);
            this.checkedjeniskamar.Name = "checkedjeniskamar";
            this.checkedjeniskamar.Size = new System.Drawing.Size(166, 64);
            this.checkedjeniskamar.TabIndex = 12;
            // 
            // btnmasuk
            // 
            this.btnmasuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmasuk.Image = global::drumah_sakit.Properties.Resources.Rumah_sakit_perawat_seragam_jas_lab_Gaya_Korea_wanita_medis_rumah_sakit_pakaian_scrub_Seragam_busana;
            this.btnmasuk.Location = new System.Drawing.Point(397, 12);
            this.btnmasuk.Name = "btnmasuk";
            this.btnmasuk.Size = new System.Drawing.Size(96, 39);
            this.btnmasuk.TabIndex = 18;
            this.btnmasuk.Text = "MASUK";
            this.btnmasuk.UseVisualStyleBackColor = true;
            this.btnmasuk.Click += new System.EventHandler(this.btnmasuk_Click);
            // 
            // btnsimpan
            // 
            this.btnsimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsimpan.Image = global::drumah_sakit.Properties.Resources.Rumah_sakit_perawat_seragam_jas_lab_Gaya_Korea_wanita_medis_rumah_sakit_pakaian_scrub_Seragam_busana;
            this.btnsimpan.Location = new System.Drawing.Point(397, 57);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(96, 39);
            this.btnsimpan.TabIndex = 36;
            this.btnsimpan.Text = "SIMPAN";
            this.btnsimpan.UseVisualStyleBackColor = true;
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);
            // 
            // btnubah
            // 
            this.btnubah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnubah.Image = global::drumah_sakit.Properties.Resources.Rumah_sakit_perawat_seragam_jas_lab_Gaya_Korea_wanita_medis_rumah_sakit_pakaian_scrub_Seragam_busana;
            this.btnubah.Location = new System.Drawing.Point(499, 57);
            this.btnubah.Name = "btnubah";
            this.btnubah.Size = new System.Drawing.Size(96, 39);
            this.btnubah.TabIndex = 37;
            this.btnubah.Text = "UBAH";
            this.btnubah.UseVisualStyleBackColor = true;
            this.btnubah.Click += new System.EventHandler(this.btnubah_Click);
            // 
            // btnkeluar
            // 
            this.btnkeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkeluar.Image = global::drumah_sakit.Properties.Resources.Rumah_sakit_perawat_seragam_jas_lab_Gaya_Korea_wanita_medis_rumah_sakit_pakaian_scrub_Seragam_busana;
            this.btnkeluar.Location = new System.Drawing.Point(601, 12);
            this.btnkeluar.Name = "btnkeluar";
            this.btnkeluar.Size = new System.Drawing.Size(96, 39);
            this.btnkeluar.TabIndex = 38;
            this.btnkeluar.Text = "KELUAR";
            this.btnkeluar.UseVisualStyleBackColor = true;
            this.btnkeluar.Click += new System.EventHandler(this.btnkeluar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(225, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(291, 125);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // btnhapus
            // 
            this.btnhapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhapus.Image = global::drumah_sakit.Properties.Resources.Rumah_sakit_perawat_seragam_jas_lab_Gaya_Korea_wanita_medis_rumah_sakit_pakaian_scrub_Seragam_busana;
            this.btnhapus.Location = new System.Drawing.Point(499, 12);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(96, 39);
            this.btnhapus.TabIndex = 44;
            this.btnhapus.Text = "HAPUS";
            this.btnhapus.UseVisualStyleBackColor = true;
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);
            // 
            // button1view
            // 
            this.button1view.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1view.Image = global::drumah_sakit.Properties.Resources.Rumah_sakit_perawat_seragam_jas_lab_Gaya_Korea_wanita_medis_rumah_sakit_pakaian_scrub_Seragam_busana;
            this.button1view.Location = new System.Drawing.Point(601, 57);
            this.button1view.Name = "button1view";
            this.button1view.Size = new System.Drawing.Size(96, 39);
            this.button1view.TabIndex = 45;
            this.button1view.Text = "VIEW";
            this.button1view.UseVisualStyleBackColor = true;
            this.button1view.Click += new System.EventHandler(this.button1view_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::drumah_sakit.Properties.Resources._1521258rumahsakit11780x390;
            this.ClientSize = new System.Drawing.Size(932, 441);
            this.Controls.Add(this.button1view);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnkeluar);
            this.Controls.Add(this.btnubah);
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.btnmasuk);
            this.Controls.Add(this.checkedjeniskamar);
            this.Controls.Add(this.textkdkamar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form6";
            this.Text = "Ruang Rawat Inap";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textkdkamar;
        private System.Windows.Forms.CheckedListBox checkedjeniskamar;
        private System.Windows.Forms.Button btnmasuk;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.Button btnubah;
        private System.Windows.Forms.Button btnkeluar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Button button1view;
    }
}