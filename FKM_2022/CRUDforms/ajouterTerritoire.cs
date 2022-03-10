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
            
            var CurrentCultureInfo = new CultureInfo("en", false);
            CurrentCultureInfo.NumberFormat.NumberDecimalSeparator = ".";
            CurrentCultureInfo.NumberFormat.CurrencyDecimalSeparator = ".";
            Thread.CurrentThread.CurrentUICulture = CurrentCultureInfo;
            Thread.CurrentThread.CurrentCulture = CurrentCultureInfo;
            CultureInfo.DefaultThreadCurrentCulture = CurrentCultureInfo;
        }
       

        
        public string tauxRep
        {
            get { return String.Format("{0:0.00}", customtextbox1.Texts); }
            set { customtextbox1.Texts = String.Format("{0:0.00}", value); }
        }
        
       
        public string groupbox
        {
            get { return groupBox1.Text; }
            set { groupBox1.Text = value; }
        }
        public bool button
        {
            get { return roundBtn2.Enabled; }
            set { roundBtn2.Enabled = value; }
        }
        public bool addbtn
        {
            get { return roundBtn1.Enabled; }
            set { roundBtn1.Enabled = value; }
        }
        
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customtextbox1__TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Some text", "Some title", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (customtextbox1.Texts.Contains(','))
            {
                MessageBox.Show("changer la vigule par un Point!", "erreur de saisie !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                customtextbox1.Texts = String.Empty;
            }

        }

       

       
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
