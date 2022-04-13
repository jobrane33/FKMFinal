using FKM_2022.CRUDforms;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FKM_2022.referntiel
{
    public partial class Vehicule : Form
    {
        string filename = "";
        public Vehicule()
        {
            InitializeComponent();
            uperPannel.Hide();
            imageColumn();
            dataGridView1.RowTemplate.Height = 40;
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

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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
                            cm.telechargerPDFVehicule(filename, code);
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "update")
            {


                ajouterVehicule av = new ajouterVehicule();
                av.Visible = true;
                av.validButton = false;
                ////ac.groupBoxSetter = "modifer";
                ////ac.btnValider = false;
                int rowIndex = e.RowIndex;
                av.immatbox = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
                av.montantpret = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
                av.dateAchat = Convert.ToDateTime(dataGridView1.Rows[rowIndex].Cells[dataGridView1.Columns["Datedachat"].Index].Value.ToString());
                av.Puissance = dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();
                av.Marque = dataGridView1.Rows[rowIndex].Cells[dataGridView1.Columns["Marque"].Index].Value.ToString();
                av.Modele = dataGridView1.Rows[rowIndex].Cells[dataGridView1.Columns["modele"].Index].Value.ToString();
                av.montantAchat = dataGridView1.Rows[rowIndex].Cells[dataGridView1.Columns["Montantdachat"].Index].Value.ToString();
                av.DateMiseEnCirculation = Convert.ToDateTime(dataGridView1.Rows[rowIndex].Cells[dataGridView1.Columns["DMEC"].Index].Value.ToString());
                av.ValeurInitialeKilometrage = dataGridView1.Rows[rowIndex].Cells[dataGridView1.Columns["valeurKM"].Index].Value.ToString();
                av.datemiseEnExploitation = Convert.ToDateTime(dataGridView1.Rows[rowIndex].Cells[dataGridView1.Columns["DatetMiseEnExploitation"].Index].Value.ToString());
                av.datemiseHorsExploitation = Convert.ToDateTime(dataGridView1.Rows[rowIndex].Cells[dataGridView1.Columns["DatetMiseHorsExploitation"].Index].Value.ToString());
                //ac.nomDocument = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            }
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "supprimer")
            {

                DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("attention", "ce champ va etre deteruit", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Error);
                if (dialogResult == DialogResult.Yes)
                {
                    crudAlgoClasses.crudMethodes cm = new crudAlgoClasses.crudMethodes();
                    string codestring = dataGridView1.Rows[e.RowIndex].Cells["code"].Value.ToString();
                    int code = int.Parse(codestring);


                    bool res = cm.archiveVehicule(code);
                    if (res)
                    {
                        MessageBox.Show("archive !", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dataGridView1.DataSource = cm.selectVehicule();
                    }
                    else
                        MessageBox.Show("erreur un contrat est active ", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }

            }
        }


        private void panel6_Click(object sender, EventArgs e)
        {
            ajouterVehicule av = new ajouterVehicule();
            av.Show();

        }

        private void Vehicule_Load(object sender, EventArgs e)
        {
            crudAlgoClasses.crudMethodes cm = new crudAlgoClasses.crudMethodes();
            DataTable dt = cm.selectVehicule();
            dataGridView1.DataSource = dt;
        }
    }
}
