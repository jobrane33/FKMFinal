using FKM_2022.crudAlgoClasses;
using FKM_2022.CRUDforms;
using System;
using System.Data;
using System.Drawing;

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
            disablearchive();
            dataGridView1.RowTemplate.Height = 40;

        }


        private void panel6_MouseClick(object sender, MouseEventArgs e)
        {
            ajouterPerso perso = new ajouterPerso();

            perso.Show();

            //uperPannel.Hide();
            perso.buttonvalider = true;
            perso.buttonmodifier = false;
        }
        private void disablearchive()
        {
            if (checkBox1.Checked)
            {
                dataGridView1.Columns["supprimer"].Visible = false;
            }
            else
            {
                dataGridView1.Columns["supprimer"].Visible = true;
            }
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

                    bool res = cm.archiverPersonnel(mat);
                    if (res)
                    {
                        MessageBox.Show("archivé avec success", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        DataTable dt = cm.selectPersonnels(1);
                        dataGridView1.DataSource = dt;

                    }
                    else
                    {
                        MessageBox.Show("contrat active !!!", "up contrat est active ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (checkBox1.Checked)
                archive = 0;
            else archive = 1;
            crudMethodes cm = new crudAlgoClasses.crudMethodes();
            DataTable dt = cm.selectPersonnels(archive);
            dataGridView1.DataSource = dt;

        }

        private void roundBtn7_Click(object sender, EventArgs e)
        {
            PrintDialog printdatagrid = new PrintDialog();
            printdatagrid.Document = printDocument1;
            printdatagrid.UseEXDialog = true;
            DialogResult result = printdatagrid.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.DocumentName = "print";
                printDocument1.Print();
            }

        }

        private void roundBtn6_Click(object sender, EventArgs e)
        {



        }



        //pour filtrer les personnels
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var archive = 0;
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            if (textBox2.Text != string.Empty)
            {
                if (checkBox1.Checked)
                {
                    archive = 0;
                }
                else
                {
                    archive = 1;
                }
                dt = cm.filtrePerso(comboBox1.Text, textBox2.Text, archive);

                //MessageBox.Show(dt.ToString());
                dataGridView1.DataSource = dt;
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("introuvable", "vide", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox2.Text = String.Empty;
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
            {
                disablearchive();
                archive = 0;
            }
            else { archive = 1; }
            disablearchive();
            crudMethodes cm = new crudMethodes();
            DataTable dt = cm.selectPersonnels(archive);
            dataGridView1.DataSource = dt;

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap printdatagridBitmap = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(printdatagridBitmap, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(printdatagridBitmap, 0, 0);

        }
    }
}
