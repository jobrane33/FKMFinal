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
    public partial class ajouterPerso : Form
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
        public string matTextBox
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string nomTextBox
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public string prenTextBox
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        public string copteFKMTextBox
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }
        public string compteNoteTextBox
        {
            get { return textBox5.Text; }
            set { textBox5.Text = value; }
        }
        public string compteRebTextBox
        {
            get { return textBox6.Text; }
            set { textBox6.Text = value; }
        }
        public string compteCagnotteTextBox
        {
            get { return textBox7.Text; }
            set { textBox7.Text = value; }
        }
        public string codeTerrTextBox
        {
            get { return textBox8.Text; }
            set { textBox8.Text = value; }
        }
        public string designationTextBox
        {
            get { return textBox9.Text; }
            set { textBox9.Text = value; }
        }
        public string groupboxText
        {
            get { return groupBox1.Text; }
            set { groupBox1.Text = value; }
        }
        public string button
        {
            
            set { button1.Text = value; }
        }
        public ajouterPerso()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

        }
        public void validerChamps()
        {
            if(textBox1.Text == "Matricule" || textBox2.Text == "Nom" || 
                textBox3.Text== "Prenom" || textBox4.Text== "Compte FKM" || textBox5.Text== "compte note" || textBox6.Text== "compte rebourcement" ||
                textBox7.Text== "compte cagnotte" || textBox8.Text== "code territoire" || textBox9.Text== "Designation")
            {
                MessageBox.Show("un des champs est vide", "erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "Matricule")
            {
                textBox1.Text = String.Empty;
            }
            
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty)
            {
                textBox1.Text = "Matricule";
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if(textBox2.Text == "Nom")
            {
                textBox2.Text = String.Empty;
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == String.Empty)
            {
                textBox2.Text = "Nom";
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Prenom")
            {
                textBox3.Text = String.Empty;
            }

        }
        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == String.Empty)
            {
                textBox3.Text = "Prenom";
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Compte FKM")
            {
                textBox4.Text = String.Empty;
            }
        }
        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == String.Empty)
            {
                textBox4.Text = "Compte FKM";
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "compte note")
            {
                textBox5.Text = String.Empty;
            }
        }
        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == String.Empty)
            {
                textBox5.Text = "compte note";
            }
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "compte rebourcement")
            {
                textBox6.Text = String.Empty;
            }
        }
        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == String.Empty)
            {
                textBox6.Text = "compte rebourcement";
            }
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (textBox7.Text == "compte cagnotte")
            {
                textBox7.Text = String.Empty;
            }
            
        }
        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == String.Empty)
            {
                textBox7.Text = "compte cagnotte";
            }
        }

        private void textBox8_Enter(object sender, EventArgs e)
        {
            if (textBox8.Text == "code territoire")
            {
                textBox8.Text = String.Empty;
            }
            
        }
        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (textBox8.Text == String.Empty)
            {
                textBox8.Text = "code territoire";
            }
        }

        private void textBox9_Enter(object sender, EventArgs e)
        {
            if (textBox9.Text == "Designation")
            {
                textBox9.Text = String.Empty;
            }
            
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            if (textBox9.Text == String.Empty)
            {
                textBox9.Text = "Designation";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "valider") { 
            }
            else
            {

            }
            validerChamps();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
    }

