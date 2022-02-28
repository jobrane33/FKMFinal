using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FKM_2022.CRUDforms
{
    
    public partial class ajouterContrat : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );
        public ajouterContrat()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customtextbox1__TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Some text", "Some title",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void customtextbox1_Enter(object sender, EventArgs e)
        {
            customtextbox1.BorderColor = Color.Green;
            label7.Hide();
            //customtextbox1.isfocused = true;
        }

        private void customtextbox1_Leave(object sender, EventArgs e)
        {
            if (customtextbox1.Texts == string.Empty)
            {
                customtextbox1.BorderColor = Color.Red;
                label7.Show();
            }
            
        }

        private void customtextbox2_Enter(object sender, EventArgs e)
        {
            customtextbox2.BorderColor = Color.Green;
            label8.Hide();
        }

        private void customtextbox2_Leave(object sender, EventArgs e)
        {
            if (customtextbox2.Texts == string.Empty)
            {
                customtextbox2.BorderColor = Color.Red;
                label8.Show();
            }
        }

        private void customtextbox3_Enter(object sender, EventArgs e)
        {
            customtextbox3.BorderColor = Color.Green;
            label10.Hide();
        }

        private void customtextbox3_Leave(object sender, EventArgs e)
        {
            if (customtextbox3.Texts == string.Empty)
            {
                customtextbox3.BorderColor = Color.Red;
                label10.Show();
            }
        }

        private void customtextbox4_Enter(object sender, EventArgs e)
        {
            customtextbox4.BorderColor = Color.Green;
            label11.Hide();
        }

        private void customtextbox4_Leave(object sender, EventArgs e)
        {
            if (customtextbox4.Texts == string.Empty)
            {
                customtextbox4.BorderColor = Color.Red;
                label11.Show();
            }
        }

        private void roundBtn1_Click(object sender, EventArgs e)
        {
            if(customtextbox1.Texts==String.Empty || customtextbox2.Texts == String.Empty || customtextbox3.Texts == String.Empty || customtextbox4.Texts == String.Empty)
            {
                MessageBox.Show("voudriez-vous svp remplir toutes les zones de texte", "champ vide !",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void customtextbox5__TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Some text", "Some title",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customtextbox3__TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
