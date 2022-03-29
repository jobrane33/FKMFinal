using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FKM_2022.benifinciere.signlePageForms
{
    public partial class AjouterQuizaines : Form
    {
        public AjouterQuizaines()
        {
            InitializeComponent();
            uperPannel.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (uperPannel.Visible)
            {
                uperPannel.Visible = false;
            }
            else
            {
                uperPannel.Visible = true;
            }
        }
    }
}
