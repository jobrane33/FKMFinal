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
using FKM_2022.PDF_viewers;
using FKM_2022.crudAlgoClasses;

namespace FKM_2022.referntiel
{
    public partial class Contrat : Form
    {
        crudMethodes cm = new crudMethodes();
        private string filename = "";
        private static int codeforPDF = 0;
        public static int CodeforPDF
        {
            get { return codeforPDF; }
            set { codeforPDF = value; }
        }
        public Contrat()
        {
            InitializeComponent();
            uperPannel.Hide();
            imageColumn();
            disablearchive();
            dataGridView1.RowTemplate.Height = 40;
            comboBox1.Text = "matricule";

            //optMenu.Hide();
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
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
        private void imageColumn()
        {
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            Image image = Properties.Resources.PDF2;
            img.Image = image;
            dataGridView1.Columns.Add(img);
            img.HeaderText = " télecharger PDF";
            img.Name = "PDF";
            img.ImageLayout = DataGridViewImageCellLayout.Normal;
            img.Width = 60;
            img.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            c.btnModifier = false;
            c.Show();
            c.StartPosition = FormStartPosition.CenterScreen;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "selectionner pour affichage")
            {
                string pdfstring = dataGridView1.Rows[e.RowIndex].Cells["code"].Value.ToString();
                int codepdf = int.Parse(pdfstring);
                codeforPDF = codepdf;

            }

            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "supprimer")
            {

                DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("attention", "ce champ va etre deteruit", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Error);
                if (dialogResult == DialogResult.Yes)
                {
                    crudAlgoClasses.crudMethodes cm = new crudAlgoClasses.crudMethodes();
                    string codestring = dataGridView1.Rows[e.RowIndex].Cells["code"].Value.ToString();
                    int code = int.Parse(codestring);
                    codeforPDF = code;

                    bool res = cm.deleteContrat(code);
                    if (res)
                    {
                        MessageBox.Show("archive !", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dataGridView1.DataSource = cm.selectContrat(1);
                    }
                    else
                        MessageBox.Show("arreur!", "!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }

            }
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "update")
            {

                dataGridView1.Rows[0].Selected = true;
                ajouterContrat ac = new ajouterContrat();
                ac.Visible = true;
                ac.groupBoxSetter = "modifer";
                ac.btnValider = false;
                int rowIndex = e.RowIndex;
                ac.matTextBox = dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
                ac.categorieComboBox = dataGridView1.Rows[rowIndex].Cells[8].Value.ToString();
                //ac.nomDocument = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();              
            }
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == " télecharger PDF")
            {
                crudAlgoClasses.crudMethodes cm = new crudAlgoClasses.crudMethodes();
                string codestring = dataGridView1.Rows[e.RowIndex].Cells["code"].Value.ToString();
                int code = int.Parse(codestring);

                using (SaveFileDialog dig = new SaveFileDialog() { Filter = "PDF Documents(*.pdf)|*.pdf", ValidateNames = true })
                {
                    if (dig.ShowDialog() == DialogResult.OK)
                    {
                        DialogResult result = MessageBox.Show("êtes-vous sûr de vouloir télécharger ce fichier ?", "verifier", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            filename = dig.FileName;
                            cm.telechargerPDF(filename, code);
                        }
                        else
                        {
                            return;
                        }
                    }
                }

            }
        }

        private void Contrat_Load(object sender, EventArgs e)
        {
            crudAlgoClasses.crudMethodes cm = new crudAlgoClasses.crudMethodes();
            int archive;
            if (checkBox1.Checked)
                archive = 0;
            else archive = 1;
            dataGridView1.DataSource = cm.selectContrat(archive);
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

        private void roundBtn3_Click(object sender, EventArgs e)
        {
            if (codeforPDF == 0)
            {
                MessageBox.Show("erreur", "selectionner un contrat!");
            }
            else
            {
                ContratPDFViewer cpdfv = new ContratPDFViewer();
                cpdfv.Show();
                cpdfv.StartPosition = FormStartPosition.CenterScreen;
                cpdfv.WindowState = FormWindowState.Maximized;
            }
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap printdatagridBitmap = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(printdatagridBitmap, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(printdatagridBitmap, 0, 0);

        }

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
                dt = cm.filtreContrat(comboBox1.Text, textBox2.Text, archive);

                //MessageBox.Show(dt.ToString());
                dataGridView1.DataSource = dt;
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("introuvable", "vide", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox2.Text = String.Empty;
                    dt2 = cm.selectContrat(archive);
                    dataGridView1.DataSource = dt2;
                }


            }
            else
            {
                dt = cm.selectContrat(archive);
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
            DataTable dt = cm.selectContrat(archive);
            dataGridView1.DataSource = dt;
        }
    }
}
