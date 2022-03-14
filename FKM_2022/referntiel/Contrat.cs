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
            imageColumn();
            

            //optMenu.Hide();
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
            img.Image= image;
            dataGridView1.Columns.Add(img);
            img.HeaderText = "consulter PDF";
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
                    crudAlgoClasses.crudMethodes cm = new crudAlgoClasses.crudMethodes();
                    string codestring = dataGridView1.Rows[e.RowIndex].Cells["code"].Value.ToString();
                    int code = int.Parse(codestring);
                    bool res =cm.deleteContrat(code);
                    if (res)
                    {
                        MessageBox.Show("archive !", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        dataGridView1.DataSource= cm.selectContrat();
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

        private void roundBtn7_Click(object sender, EventArgs e)
        {
            
        }
    }
}
