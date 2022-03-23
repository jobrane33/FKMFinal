using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FKM_2022.crudAlgoClasses;

namespace FKM_2022.referntiel
{
    public partial class connection : Form
    {
       
        public  static  string type=String.Empty;
        public connection()
        {
            InitializeComponent();
        }
        public static string gettypeuser
        {
            get { return type; }
            set { type = value; }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            login login = new login();
            bool result = login.loginuser(customtextbox1.Texts,customtextbox2.Texts);
            if (result)
            {
                
                type = login.usertype(customtextbox1.Texts, customtextbox2.Texts);
                MessageBox.Show(type);
                Home home = new Home();
                this.Hide();
                home.Show();
            }
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
