using FKM_2022.crudAlgoClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FKM_2022.CRUDforms
{
    public partial class ajouterTerritoire : Form
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
        public ajouterTerritoire()
        {


            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            label3.Hide();
            var CurrentCultureInfo = new CultureInfo("en", false);
            CurrentCultureInfo.NumberFormat.NumberDecimalSeparator = ".";
            CurrentCultureInfo.NumberFormat.CurrencyDecimalSeparator = ".";
            Thread.CurrentThread.CurrentUICulture = CurrentCultureInfo;
            Thread.CurrentThread.CurrentCulture = CurrentCultureInfo;
            CultureInfo.DefaultThreadCurrentCulture = CurrentCultureInfo;
        }
        public string getDesignation
        {
            get { return customtextbox1.Texts; }
            set { customtextbox1.Texts = value; }
        }
        public string titreGroup
        {
            get { return groupBox1.Text; }
            set { groupBox1.Text = value; }
        }
        public bool buttonValider
        {
            get { return roundBtn1.Enabled; }
            set { roundBtn1.Enabled = value; }
        }
        public bool buttonModifier
        {
            get { return roundBtn2.Enabled; }
            set { roundBtn2.Enabled = value; }
        }
        public string getid
        {
            get { return label3.Text; }
            set { label3.Text = value; }
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void roundBtn1_Click(object sender, EventArgs e)
        {
            if (customtextbox1.Texts == string.Empty)
            {
                MessageBox.Show("le champ est vide", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                crudMethodes cm = new crudMethodes();
                bool sucess = cm.ajouterTerritoire(customtextbox1.Texts, "null");
                if (sucess)
                {
                    MessageBox.Show("insertion complet", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    MessageBox.Show("erreur", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void customtextbox1_Enter(object sender, EventArgs e)
        {

            customtextbox1.BorderColor = Color.Green;
            label7.Hide();

        }
        private void customtextbox1_Leave(object sender, EventArgs e)
        {
            if (customtextbox1.Texts == string.Empty)
            {
                customtextbox1.BorderColor = Color.Red;
                label7.Show();
            }
        }

        private void roundBtn2_Click(object sender, EventArgs e)
        {
            
            if (customtextbox1.Texts == string.Empty)
            {
                MessageBox.Show("le champ est vide", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                crudMethodes cm = new crudMethodes();
                int code = int.Parse(label3.Text);
                bool sucess = cm.updateTerritoires(code, customtextbox1.Texts);
                if (sucess)
                {
                    MessageBox.Show("insertion complet", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("erreur", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
