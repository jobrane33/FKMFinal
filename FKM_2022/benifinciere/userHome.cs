using FKM_2022.benifinciere.signlePageForms;
using FKM_2022.referntiel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FKM_2022.benifinciere
{
    public partial class userHome : Form
    {
        private string matricule = connection.getMatricule;
        public userHome()
        {
            InitializeComponent();
            fullScreen();
            label1.Text = matricule;

        }
        private void fullScreen()
        {
            this.WindowState = FormWindowState.Maximized;
        }
        public void openSildbenificiere(object Form)
        {
            if (this.childPanel.Controls.Count > 0)
            {

                this.childPanel.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.childPanel.Controls.Add(f);
            this.childPanel.Tag = f;
            f.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Explpanel.Visible)
            {
                Explpanel.Visible = false;
            }
            else
            {
                Explpanel.Visible = true;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            openSildbenificiere(new AjouterQuizaines());
        }
    }
}
