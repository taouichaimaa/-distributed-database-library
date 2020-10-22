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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            PanelListBooks.Show();
          RentedBooks.Hide();
            profilePanel.Hide();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)

        {
            RentedBooks.Hide();
            PanelListBooks.Show();
            profilePanel.Hide();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           
            RentedBooks.Show();
            PanelListBooks.Hide();
            profilePanel.Hide();

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            profilePanel.Show();
            RentedBooks.Hide();
            PanelListBooks.Hide();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
