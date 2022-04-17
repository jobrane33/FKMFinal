using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FKM_2022.benifinciere.crudpopups;

namespace FKM_2022.benifinciere.signlePageForms
{
    public partial class demandeRetrait : Form
    {
       
        public demandeRetrait()
        {
            InitializeComponent();
           
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            ajoutDemandeRetrait adr = new ajoutDemandeRetrait();
            adr.StartPosition = FormStartPosition.CenterScreen;
            adr.Show();
        }
    }
}
