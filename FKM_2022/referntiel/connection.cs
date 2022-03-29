﻿using System;
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
        public connection()
        {
            InitializeComponent();
            
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
                if (type.Equals("benifisiere"))
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

        
    }
}