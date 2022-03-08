using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FKM_2022.CRUDforms
{
    public partial class ajouterBurauxPayeurs : Form
    {
        public ajouterBurauxPayeurs()
        {
            InitializeComponent();
        }
         ~ajouterBurauxPayeurs()
        {
           this.Close();
           
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
