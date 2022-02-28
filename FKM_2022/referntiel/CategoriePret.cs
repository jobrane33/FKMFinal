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
    public partial class CategoriePret : Form
    {
        public CategoriePret()
        {
            InitializeComponent();
            uperPannel.Hide();
        }
        
        
        private DataTable select()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MOT8LB0;Initial Catalog=FKM;Integrated Security=True");
            try
            {

                String sql = "execute affichageCat";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                conn.Close();
            }
            return dt;

        }
        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "supprimer")
                {
                    DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("attention", "ce champ va etre deteruit", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Error);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int id= Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["code"].Value);
                        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MOT8LB0;Initial Catalog=FKM;Integrated Security=True");
                        conn.Open();
                    try
                    {
                        string sql = "update categories set archived=0 where code=@code";
                        SqlCommand command = new SqlCommand(sql, conn);
                        command.Parameters.AddWithValue("@code", id);
                        int res = command.ExecuteNonQuery();
                        if (res > 0)
                        {
                            MessageBox.Show("archivé!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("error", "retry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch(Exception ex)
                    {
                        ex.ToString();
                    }
                    finally { conn.Close();
                        DataTable dt = select();
                        dataGridView1.DataSource = dt;
                    }

                }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }

                }
                if(dataGridView1.Columns[e.ColumnIndex].HeaderText == "update")
            {
                dataGridView1.Rows[0].Selected = true;
                ajouterCat addingcat = new ajouterCat();
                addingcat.Visible= true;
                addingcat.groupbox = "update";
                int rowIndex = e.RowIndex;
                addingcat.tauxRep = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
                addingcat.tauxCag = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
                addingcat.tauxEssance= dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
                addingcat.montantPret = dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
                addingcat.observation = dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();
                addingcat.libelle = dataGridView1.Rows[rowIndex].Cells[8].Value.ToString();
                

            }
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

        private void CategoriePret_Load(object sender, EventArgs e)
        {
            DataTable dt = select();
            dataGridView1.DataSource = dt;
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

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            ajouterCat ac  = new ajouterCat();
            ac.Show();                 
        }
    }
}
