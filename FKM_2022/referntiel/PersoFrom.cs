using FKM_2022.crudAlgoClasses;
using FKM_2022.CRUDforms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;


namespace FKM_2022.referntiel
{
    public partial class PersoFrom : Form
    {
        ajouterPerso perso = new ajouterPerso();
        crudMethodes cm = new crudMethodes();
        public PersoFrom()
        {
            InitializeComponent();
            uperPannel.Hide();
            comboBox1.Text = "matricule";
            
        }

        
        private void panel6_MouseClick(object sender, MouseEventArgs e)
        {
            ajouterPerso perso = new ajouterPerso();
            
            perso.Show();
            
            //uperPannel.Hide();
            perso.buttonvalider = true;
            perso.buttonmodifier = false;
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

        private void PersoFrom_Load(object sender, EventArgs e)
        {
            int archive;
            if (checkBox1.Checked)
                archive = 0;
            else archive = 1;
            crudMethodes cm = new crudAlgoClasses.crudMethodes();
            DataTable dt = cm.selectPersonnels(archive);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "supprimer")
            {
                DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("attention", "ce champ va etre deteruit", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Error);
                if (dialogResult == DialogResult.Yes)
                {
                    string mat = dataGridView1.Rows[e.RowIndex].Cells["mat"].Value.ToString();
                    
                    bool res =cm.archiverPersonnel(mat);
                    if (res)
                    {
                        MessageBox.Show("insertion complete", "Some title", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        DataTable dt = cm.selectPersonnels(1);
                        dataGridView1.DataSource = dt;

                    }
                    else
                    {
                        MessageBox.Show("erreur", "Some title", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }

            }
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "update")
            {

                dataGridView1.Rows[0].Selected = true;
                ajouterPerso perso = new ajouterPerso();
                perso.Visible = true;
                perso.groupboxText = "update";
                perso.buttonvalider = false;
                perso.buttonmodifier = true;
                int rowIndex = e.RowIndex;
                perso.matTextBox = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
                perso.nomTextBox = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
                perso.prenTextBox = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
                perso.copteFKMTextBox = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
                perso.compteNoteTextBox = dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
                perso.compteRebTextBox = dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();
                perso.compteCagnotteTextBox = dataGridView1.Rows[rowIndex].Cells[8].Value.ToString();
                




            }
        }

        private void roundBtn4_Click(object sender, EventArgs e)
        {
            int archive;
            if(checkBox1.Checked)
                archive = 0;
            else archive = 1;
            crudMethodes cm = new crudAlgoClasses.crudMethodes();
            DataTable dt = cm.selectPersonnels(archive);
            dataGridView1.DataSource = dt;

        }

        private void roundBtn7_Click(object sender, EventArgs e)
        {
           // DGVPrinter printer = new DGVPrinter();
        }

        private void roundBtn6_Click(object sender, EventArgs e)
        {
           DialogResult res = openFileDialog1.ShowDialog();

           
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        //pour filtrer les personnels
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var archive=0;
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            if (textBox2.Text != string.Empty )
            {
                if (checkBox1.Checked)
                {
                     archive = 0;
                }
                else
                {
                     archive = 1;
                }
                    dt = cm.filtrePerso(comboBox1.Text, textBox2.Text,archive);
                    
                    //MessageBox.Show(dt.ToString());
                    dataGridView1.DataSource = dt;
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("introuvable", "vide", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox2.Text=String.Empty;
                    dt2 = cm.selectPersonnels(archive);
                    dataGridView1.DataSource = dt2;
                }


            }
            else
            {
                dt = cm.selectPersonnels(archive);
                dataGridView1.DataSource = dt;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int archive;
            if (checkBox1.Checked)
                archive = 0;
            else archive = 1;
            crudMethodes cm = new crudAlgoClasses.crudMethodes();
            DataTable dt = cm.selectPersonnels(archive);
            dataGridView1.DataSource = dt;
        }
    }
}
