using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FKM_2022.CRUDforms;
using FKM_2022.crudAlgoClasses;

namespace FKM_2022.referntiel
{
    public partial class JoursFériers : Form
    {
        public JoursFériers()
        {
            InitializeComponent();
        }

        private void JoursFériers_Load(object sender, EventArgs e)
        {
            crudMethodes cm = new crudMethodes();
            DataTable dt = new DataTable();
            dt = cm.selectJoursFerier();
            dataGridView1.DataSource = dt;
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            AjoutJoursFeriers newDay = new AjoutJoursFeriers();
            
            newDay.Show();
        }
    }
}
