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
using FKM_2022.crudAlgoClasses;
using FKM_2022.referntiel;

namespace FKM_2022.CRUDforms
{
    public partial class ajouterCat : Form
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
        
        public ajouterCat()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            label13.Hide();
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
        public string tauxCag
        {
            get { return customtextbox2.Texts; }
            set { customtextbox2.Texts = value; }
        }
        public string tauxEssance
        {
            get { return customtextbox3.Texts; }
            set { customtextbox3.Texts = value; }
        }
        public string montantPret
        {
            get { return customtextbox4.Texts; }
            set { customtextbox4.Texts = value; }
        }
        public string observation
        {
            get { return customtextbox5.Texts; }
            set { customtextbox5.Texts = value; }
        }
        public string matTextBox
        {
            get { return customtextbox5.Texts; }
            set { customtextbox5.Texts = value; }
        }
        public string libelle
        {
            get { return customtextbox6.Texts; }
            set { customtextbox6.Texts = value; }
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
        public string getid
        {
            get { return label13.Text ;}
            set { label13.Text = value; }
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customtextbox1__TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Some text", "Some title",MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                customtextbox1.Texts=String.Empty;
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
            if (customtextbox2.Texts.Contains(','))
            {
                MessageBox.Show("changer la vigule par un Point!", "erreur de saisie !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                customtextbox2.Texts = String.Empty;
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
            if (customtextbox3.Texts.Contains(','))
            {
                MessageBox.Show("changer la vigule par un Point!", "erreur de saisie !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                customtextbox3.Texts = String.Empty;
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
            if (customtextbox4.Texts.Contains(','))
            {
                MessageBox.Show("changer la vigule par un Point!", "erreur de saisie !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                customtextbox4.Texts = String.Empty;
            }
        }

        private void roundBtn1_Click(object sender, EventArgs e)
        {
            
            if ((customtextbox1.Texts == String.Empty || customtextbox2.Texts == String.Empty || customtextbox3.Texts == String.Empty || customtextbox4.Texts == String.Empty ))
                {
                    MessageBox.Show("voudriez-vous svp remplir toutes les zones de texte", "champ vide !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
                else
                {
                
                float outputValue = 0;
                bool isNumber = false;
                isNumber = float.TryParse(customtextbox1.Texts, out outputValue);
                isNumber = float.TryParse(customtextbox2.Texts, out outputValue);
                isNumber = float.TryParse(customtextbox3.Texts, out outputValue);
                isNumber = float.TryParse(customtextbox4.Texts, out outputValue);
                
                
                if (!isNumber)
                {
                    MessageBox.Show("les taux doivent être numerique !", "erreur de saisie !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var ci = (CultureInfo)CultureInfo.CurrentCulture.Clone();
                    ci.NumberFormat.NumberDecimalSeparator = ".";

                    float tr =  float.Parse(customtextbox1.Texts, ci);
                    float tc = float.Parse(customtextbox2.Texts, ci);
                    label14.Text = tc.ToString();
                    float te = float.Parse(customtextbox3.Texts, ci);
                    float montantpret = float.Parse(customtextbox4.Texts, ci);
                    string observation = customtextbox5.Texts;
                    string libelle = customtextbox6.Texts;
                    crudMethodes cm = new crudMethodes();
                    
                    bool sucess = cm.InsertCategorie(tr, tc, te, montantpret, observation, libelle);
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

            CategoriePret cp = new CategoriePret();
            cp.refresh();
            this.Hide();
            

        }

        private void customtextbox5__TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Some text", "Some title",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        
        private void customtextbox5__TextChanged_1(object sender, EventArgs e)
        {
            customtextbox5.BorderColor = System.Drawing.Color.DarkBlue;
        }

        private void customtextbox6__TextChanged(object sender, EventArgs e)
        {

        }

        private void customtextbox6_Enter(object sender, EventArgs e)
        {
            customtextbox6.BorderColor = Color.Green;
            label12.Hide();
        }

        private void customtextbox6_Leave(object sender, EventArgs e)
        {
            if (customtextbox6.Texts == string.Empty)
            {
                customtextbox6.BorderColor = Color.Red;
                label12.Show();
            }
        }

        private void customtextbox5_Enter(object sender, EventArgs e)
        {
            customtextbox5.BorderColor = Color.Green;
        }

        private void customtextbox5_Leave(object sender, EventArgs e)
        {
            if (customtextbox5.Texts == string.Empty)
            {
                customtextbox5.BorderColor = Color.MediumSlateBlue;

            }
        }

        private void roundBtn2_Click(object sender, EventArgs e)
        {
            if (customtextbox1.Texts == String.Empty || customtextbox2.Texts == String.Empty || customtextbox3.Texts == String.Empty || customtextbox4.Texts == String.Empty)
            {
                MessageBox.Show("voudriez-vous svp remplir toutes les zones de texte", "champ vide !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                float tr = float.Parse(customtextbox1.Texts, CultureInfo.InvariantCulture.NumberFormat);
                float tc = float.Parse(customtextbox2.Texts, CultureInfo.InvariantCulture.NumberFormat);
                float te = float.Parse(customtextbox3.Texts, CultureInfo.InvariantCulture.NumberFormat);
                float montantpret = float.Parse(customtextbox4.Texts, CultureInfo.InvariantCulture.NumberFormat);
                string observation = customtextbox5.Texts;
                string libelle = customtextbox6.Texts;
                int id = Convert.ToInt32(label13.Text);

                crudMethodes cm = new crudMethodes();
                bool x = cm.updateCategorie(id,tr, tc, te, montantpret, observation, libelle);
                if (x)
                {
                    MessageBox.Show("update complete", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("erreur", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
