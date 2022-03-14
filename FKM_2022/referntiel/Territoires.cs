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
    public partial class Territoires : Form
    {
        public Territoires()
        {
            InitializeComponent();
            uperPannel.Hide();
        }
       
       
        private void roundBtn3_Click(object sender, EventArgs e)
        {

            dataGridView1.SelectAll();
            DataObject data = dataGridView1.GetClipboardContent();
            if (data != null) Clipboard.SetDataObject(data);
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            xlapp.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook xlwbook;
            Microsoft.Office.Interop.Excel.Worksheet xlsheet;
            object miseddata = System.Reflection.Missing.Value;
            xlwbook = xlapp.Workbooks.Add(miseddata);
            xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlwbook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];
            xlr.Select();
            xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            uperPannel.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            if (!uperPannel.Visible)
            {
                uperPannel.Show();
            }
            else
            {
                uperPannel.Hide();
            }
        }

        private void roundBtn6_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog1.ShowDialog();
        }

        private void roundBtn4_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Click(object sender, EventArgs e)
        {
            ajouterTerritoire at = new ajouterTerritoire();
            at.Show();
        }

        private void Territoires_Load(object sender, EventArgs e)
        {
            crudAlgoClasses.crudMethodes cm = new crudAlgoClasses.crudMethodes();
            DataTable dt = cm.selectTerritoire();
            dataGridView1.DataSource = dt; 

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "supprimer")
            {
                DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("attention", "ce champ va etre deteruit", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Error);
                if (dialogResult == DialogResult.Yes)
                {
                   
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }

            }
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "update")
            {
                dataGridView1.Rows[0].Selected = true;
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["code"].Value);
                ajouterTerritoire at = new ajouterTerritoire();
                at.Visible = true;
                at.titreGroup = "update";
                at.buttonValider = false;
                int rowIndex = e.RowIndex;
                at.getDesignation = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
                at.getid=id.ToString();
                



            }
        }
    }
}
