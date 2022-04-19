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
using FKM_2022.referntiel;
using FKM_2022.crudAlgoClasses;
using System.Data.SqlClient;
using FKM_2022.PDF_viewers;
using FKM_2022.PDFviewers;

namespace FKM_2022.benifinciere.signlePageForms
{
    public partial class demandeRetrait : Form

    {
        public static int codeforPDF = 0;
        private string matricule = connection.getMatricule;
        private string nomPrenom = connection.getNomPrenom;

        public static int getCodeforPDF
        {
            get { return codeforPDF; }
        }

        public demandeRetrait()
        {
            InitializeComponent();
            dataGridView1.RowTemplate.Height = 40;
            comboBox1.Text = String.Empty;
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            ajoutDemandeRetrait adr = new ajoutDemandeRetrait();
            adr.StartPosition = FormStartPosition.CenterScreen;
            adr.Show();
        }

        private void demandeRetrait_Load(object sender, EventArgs e)
        {

            using (SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-MOT8LB0;Initial Catalog=FKM;Integrated Security=True"))
            {
                SqlCommand sqlCmd = new SqlCommand("(select matricule ,concat(nom,' ',prenom,' ',matricule) as perso  from personnels where matriculeAgentDesaisie='" + matricule + "') union ( select matricule , concat(nom,' ',prenom,' ',matricule) as perso from personnels where matricule='" + matricule + "')", sqlConnection);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = sqlCmd;
                DataTable dt2 = new DataTable();
                da.Fill(dt2);
                comboBox1.DataSource = dt2;
                comboBox1.DisplayMember = "perso";
                comboBox1.ValueMember = "matricule";
                //comboBox2.Items.Add(user + " " + matricule);
                sqlConnection.Open();
                //label1.Text = matricule.ToString();
                comboBox1.Text = "";
            }
            if (comboBox1.Text == "")
            {
                crudUser cru = new crudUser();
                DataTable dt = new DataTable();
                dt = cru.afficheDemandes(nomPrenom);
                dataGridView1.DataSource = dt;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            crudUser cru = new crudUser();
            DataTable dt = new DataTable();
            dt = cru.filtrageDemandesRetrait(nomPrenom, comboBox1.SelectedValue.ToString());
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            crudUser cru = new crudUser();
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "supprimer")
            {
                DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("attention", "ce champ va etre deteruit", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Error);
                if (dialogResult == DialogResult.Yes)
                {
                    string code = dataGridView1.Rows[e.RowIndex].Cells["code"].Value.ToString();

                    bool res = cru.archiveDelamandeRetrait(code);
                    if (res)
                    {
                        MessageBox.Show("archivé avec success", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        comboBox1.Text = "";
                        DataTable dt = new DataTable();
                        dt = cru.afficheDemandes(nomPrenom);
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("contrat active !!!", "up contrat est active ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "selectionner pour affichage")
            {
                string pdfstring = dataGridView1.Rows[e.RowIndex].Cells["code"].Value.ToString();
                int codepdf = int.Parse(pdfstring);
                codeforPDF = codepdf;
                //label2.Text = pdfstring;
                
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
                DemandeRetraitPDFViewer cpdfv = new DemandeRetraitPDFViewer();
                cpdfv.Show();
                cpdfv.StartPosition = FormStartPosition.CenterScreen;
                cpdfv.WindowState = FormWindowState.Maximized;
            }
        }

        private void roundBtn1_Click(object sender, EventArgs e)
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
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
