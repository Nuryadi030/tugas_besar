namespace drumah_sakit
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pendftaranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dokterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apotekerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::drumah_sakit.Properties.Resources._1521258rumahsakit11780x390;
            this.label1.Location = new System.Drawing.Point(163, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(731, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "SELAMAT DATANG DI RUMAH SAKIT SEJAHTERAVIN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::drumah_sakit.Properties.Resources.Lowongan_Kerja_Rumah_Sakit_Ciputra_Hospital;
            this.pictureBox1.Location = new System.Drawing.Point(12, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(997, 343);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pendftaranToolStripMenuItem,
            this.pasienToolStripMenuItem,
            this.dokterToolStripMenuItem,
            this.apotekerToolStripMenuItem,
            this.administrasiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1021, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pendftaranToolStripMenuItem
            // 
            this.pendftaranToolStripMenuItem.Image = global::drumah_sakit.Properties.Resources.hospital;
            this.pendftaranToolStripMenuItem.Name = "pendftaranToolStripMenuItem";
            this.pendftaranToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.pendftaranToolStripMenuItem.Text = "pendaftaran";
            this.pendftaranToolStripMenuItem.Click += new System.EventHandler(this.pendftaranToolStripMenuItem_Click);
            // 
            // pasienToolStripMenuItem
            // 
            this.pasienToolStripMenuItem.Image = global::drumah_sakit.Properties.Resources.icu1;
            this.pasienToolStripMenuItem.Name = "pasienToolStripMenuItem";
            this.pasienToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pasienToolStripMenuItem.Text = "pasien";
            this.pasienToolStripMenuItem.Click += new System.EventHandler(this.pasienToolStripMenuItem_Click);
            // 
            // dokterToolStripMenuItem
            // 
            this.dokterToolStripMenuItem.Image = global::drumah_sakit.Properties.Resources.mm1;
            this.dokterToolStripMenuItem.Name = "dokterToolStripMenuItem";
            this.dokterToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.dokterToolStripMenuItem.Text = "dokter";
            this.dokterToolStripMenuItem.Click += new System.EventHandler(this.dokterToolStripMenuItem_Click);
            // 
            // apotekerToolStripMenuItem
            // 
            this.apotekerToolStripMenuItem.Image = global::drumah_sakit.Properties.Resources.thb;
            this.apotekerToolStripMenuItem.Name = "apotekerToolStripMenuItem";
            this.apotekerToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.apotekerToolStripMenuItem.Text = "apoteker";
            this.apotekerToolStripMenuItem.Click += new System.EventHandler(this.apotekerToolStripMenuItem_Click);
            // 
            // administrasiToolStripMenuItem
            // 
            this.administrasiToolStripMenuItem.Image = global::drumah_sakit.Properties.Resources.th;
            this.administrasiToolStripMenuItem.Name = "administrasiToolStripMenuItem";
            this.administrasiToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.administrasiToolStripMenuItem.Text = "administrasi";
            this.administrasiToolStripMenuItem.Click += new System.EventHandler(this.administrasiToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::drumah_sakit.Properties.Resources.Lowongan_Kerja_Rumah_Sakit_Ciputra_Hospital;
            this.ClientSize = new System.Drawing.Size(1021, 469);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form2";
            this.Text = "Menu utama";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pendftaranToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dokterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apotekerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrasiToolStripMenuItem;
    }
}