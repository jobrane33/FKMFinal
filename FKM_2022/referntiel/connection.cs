using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FKM_2022.referntiel
{
    public partial class connection : Form
    {
        Home p = new Home();
        public connection()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void personnel_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void NFKMtext_Enter(object sender, EventArgs e)
        {
            if (NFKMtext.Text == "numero compte FKM" )
            {
                NFKMtext.Text = String.Empty;
                NFKMtext.ForeColor = Color.WhiteSmoke;
            }
           
        }

        private void MATtext_Enter(object sender, EventArgs e)
        {
            if (MATtext.Text== "Matricule")
            {
                MATtext.Text = String.Empty;
                MATtext.ForeColor = Color.WhiteSmoke;
            }
        }

        private void MATtext_Leave(object sender, EventArgs e)
        {
            if (MATtext.Text == String.Empty)
            {
                MATtext.Text = "Matricule";
                MATtext.ForeColor = Color.Black;
            }
        }

        private void NFKMtext_Leave(object sender, EventArgs e)
        {
            if (NFKMtext.Text == String.Empty)
            {
                NFKMtext.Text = "numero compte FKM";
                NFKMtext.ForeColor = Color.Black;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NFKMtext.Text = "numero compte FKM";
            MATtext.Text = "Matricule";
            NFKMtext.ForeColor = Color.Black;
            MATtext.ForeColor = Color.Black;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            p.Show();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
