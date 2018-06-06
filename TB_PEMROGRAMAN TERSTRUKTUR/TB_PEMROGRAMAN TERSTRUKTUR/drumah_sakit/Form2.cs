using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drumah_sakit
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pilihanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pendftaranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 tampil = new Form3();
            tampil.Show();
            
           
        }

        private void pasienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 tampil = new Form4();
            tampil.Show();
        }

        private void dokterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 tampil = new Form5();
            tampil.Show();
        }

        private void apotekerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 tampil = new Form6();
            tampil.Show();
        }

        private void administrasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 tampil = new Form8();
            tampil.Show();
          
        }
        
    }
}
