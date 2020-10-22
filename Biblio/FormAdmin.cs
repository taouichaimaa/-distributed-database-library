using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblio
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            panelHome.Show();
            panelStudent.Hide();
            panelLib.Hide();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            panelHome.Hide();
            panelStudent.Show();
            panelLib.Hide();
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            panelHome.Hide();
            panelStudent.Hide();
            panelLib.Show();
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            Form1 ff = new Form1();
            ff.Show();
            this.Hide();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            panelHome.Show();
            panelStudent.Hide();
            panelLib.Hide();

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
