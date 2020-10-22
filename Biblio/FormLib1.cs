using Guna.UI2.WinForms;
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
    public partial class FormLib1 : Form
    {
        public FormLib1()
        {
            InitializeComponent();
            panel3.Hide();
            PanelBooks.Hide();
            PanelWelcome.Show();
            PanelReturn.Hide();
        }

        private void FormLib1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void moveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            imgSlide.Location = new Point(b.Location.X + 65, b.Location.Y - 10);
            imgSlide.SendToBack();


        }

        private void guna2Button1_CheckedChanged_1(object sender, EventArgs e)
        {
            moveImageBox(sender);
            Console.WriteLine("shakespear");

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            panel3.Show();
            PanelBooks.Hide();
            PanelWelcome.Hide();
            PanelReturn.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            PanelBooks.Show();
            PanelWelcome.Hide();
            panel3.Hide();
            PanelReturn.Hide();
        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PanelBooks.Hide();
            PanelWelcome.Show();
            panel3.Hide();
            PanelReturn.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            PanelBooks.Hide();
            PanelWelcome.Hide();
            panel3.Hide();
            PanelReturn.Show();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            PanelBooks.Hide();
            PanelWelcome.Show();
            panel3.Hide();
            PanelReturn.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Form1 ff = new Form1();
            ff.Show();
            this.Hide();

        }
    }
}
