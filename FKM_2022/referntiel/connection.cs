using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FKM_2022.crudAlgoClasses;

namespace FKM_2022.referntiel
{
    public partial class connection : Form
    {

        public static string type = String.Empty;
        public static string nomPrenom = String.Empty;
        public static string matricule = String.Empty;
        public static string territoire = string.Empty; 
        public connection()
        {
            InitializeComponent();
            customtextbox1.Texts = "jobrane_bensalah";
            customtextbox2.Texts = "123";
        }
        public static string gettypeuser
        {
            get { return type; }
            set { type = value; }
        }
        public static string getNomPrenom
        {
            get { return nomPrenom; }
            set { type = value; }
        }
        public static string getMatricule
        {
            get { return matricule; }
            set { type = value; }
        }
        public static string getTerritoire
        {
            get { return territoire; }
            set { type = value; }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            login login = new login();

            bool result = login.loginuser(customtextbox1.Texts, customtextbox2.Texts);
            
            if (result)
            {
                
                type = login.usertype(customtextbox1.Texts, customtextbox2.Texts);
                nomPrenom = login.nomPrenomUser(customtextbox1.Texts);
                matricule = login.matricule(customtextbox1.Texts);
                territoire = login.territoire(customtextbox1.Texts);
                if (type.Equals("benifisiere") || type.Equals("agentDeSaisie"))
                {
                    benifinciere.userHome user = new benifinciere.userHome();
                    this.Hide();
                    user.Show();
                }
                else
                {
                    Home home = new Home();
                    this.Hide();
                    home.Show();
                }
            }
        }

        private void customtextbox2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
            if (customtextbox2.PasswordChar)
            {
                customtextbox2.PasswordChar = false;
            }
            else
            {
                customtextbox2.PasswordChar = true;
                
            }
        }

        private void roundBtn1_Click(object sender, EventArgs e)
        {
            customtextbox1.Texts= String.Empty;
            customtextbox2.Texts= String.Empty;
        }
    }
}