using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FKM_2022.PDFviewers;
namespace FKM_2022.referntiel
{
    public partial class imprimerBonPayer : Form
    {
        private string territoireBon = connection.getTerritoire;
        public static string referanceQ= string.Empty;
        public imprimerBonPayer()
        {
            InitializeComponent();
            label2.Text = "territoire : "+territoireBon;
        }
        public static string getRefanceQ
        {
            get { return referanceQ; }
        }

        private void imprimerBonPayer_Load(object sender, EventArgs e)
        {
            crudAlgoClasses.crudUser cru = new crudAlgoClasses.crudUser();
            DataTable dt = new DataTable();
            dt= cru.selectBonApayer();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Whatever index is your checkbox column
            //try
            //{
            //    var columnIndex = 0;
            //    if (e.ColumnIndex == columnIndex)
            //    {
            //        // If the user checked this box, then uncheck all the other rows
            //        bool isChecked = false;
            //        isChecked = (bool)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            //        if (isChecked)
            //        {
            //            foreach (DataGridViewRow row in dataGridView1.Rows)
            //            {
            //                if (row.Index != e.RowIndex)
            //                {
            //                    row.Cells[columnIndex].Value = !isChecked;
            //                }
            //            }
            //        }
            //    }
            //}
            //catch (Exception)
            //{
                
            //}
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Check to ensure that the row CheckBox is clicked.
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                //Loop and uncheck all other CheckBoxes.
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Index == e.RowIndex)
                    {
                        row.Cells["checkbox"].Value = !Convert.ToBoolean(row.Cells["checkbox"].EditedFormattedValue);
                    }
                    else
                    {
                        row.Cells["checkbox"].Value = false;
                    }
                }
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                crudAlgoClasses.crudUser cru = new crudAlgoClasses.crudUser();
                if (Convert.ToBoolean(row.Cells[dataGridView1.Columns["checkbox"].Index].Value))
                {
                    referanceQ= row.Cells[dataGridView1.Columns["referance"].Index].Value.ToString();
                    //row.Cells[dataGridView1.Columns["checkbox"].Index].Value
                    _ = new DataTable();
                    DataTable dataTable = cru.selectDetailsQunzaines(row.Cells[dataGridView1.Columns["referance"].Index].Value.ToString());
                    dataGridView2.DataSource = dataTable;
                }
            }
        }

        private void roundBtn1_Click(object sender, EventArgs e)
        {
            PrintPDFBon ppb= new PrintPDFBon();
            ppb.Show();
        }
    }
}
