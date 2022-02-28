using FKM_2022.CRUDforms;
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
    public partial class Contrat : Form
    {
        public Contrat()
        {
            InitializeComponent();
            uperPannel.Hide();
            //optMenu.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (!uperPannel.Visible)
            {
                uperPannel.Visible = true;
            }
            else
            {
                uperPannel.Visible = false;
            }
        }

        private void roundBtn6_Click(object sender, EventArgs e)
        {
           
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            ajouterContrat c = new ajouterContrat();
            c.Show();
            c.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
