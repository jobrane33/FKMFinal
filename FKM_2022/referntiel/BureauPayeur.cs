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
    public partial class BureauPayeur : Form
    {
        public BureauPayeur()
        {
            InitializeComponent();
            uperPannel.Hide();
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

        private void roundBtn4_Click(object sender, EventArgs e)
        {
            DialogResult d;

            Timer t = new Timer();
            t.Interval = 100;
            if (!t.Enabled)
            {
                d = MessageBox.Show("refreshing pease wait ", "wait", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //  DataTable dt;
                //dataGridView1.DataSource = dt;
            }
            else
            {
                Close();
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            ajouterBurauxPayeurs bp = new ajouterBurauxPayeurs();
            bp.Show();
            bp.StartPosition = FormStartPosition.CenterParent;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
