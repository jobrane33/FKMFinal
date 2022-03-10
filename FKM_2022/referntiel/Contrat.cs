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
    public partial class Contrat : Form
    {
        public Contrat()
        {
            InitializeComponent();
            uperPannel.Hide();
            
            //optMenu.Hide();
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
            c.Show();
            c.StartPosition = FormStartPosition.CenterScreen;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "supprimer")
            {
                DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("attention", "ce champ va etre deteruit", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Error);
                if (dialogResult == DialogResult.Yes)
                {
                    string mat = dataGridView1.Rows[e.RowIndex].Cells["code"].Value.ToString();

                   

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
                ac.matTextBox = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
                ac.categorieComboBox = dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();
                ac.nomDocument = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();

                





            }
        }

        private void Contrat_Load(object sender, EventArgs e)
        {
            crudAlgoClasses.crudMethodes cm = new crudAlgoClasses.crudMethodes();
            dataGridView1.DataSource = cm.selectContrat();
        }
    }
}
