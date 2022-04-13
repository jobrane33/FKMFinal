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
using FKM_2022.crudAlgoClasses;
using FKM_2022.referntiel;

namespace FKM_2022.benifinciere.signlePageForms
{
    public partial class ConsultationQuinzaines : Form
    {
        private string matriculeUser = connection.getMatricule;
        private string  nomprenom = connection.getNomPrenom;
        public ConsultationQuinzaines()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string matriculeSelected = comboBox2.SelectedValue.ToString();
            crudUser cu = new crudUser();
            DataTable dt = new DataTable();
            dt = cu.selectQuinzaines(matriculeSelected);
            dataGridView1.DataSource = dt;
        }

        private void ConsultationQuinzaines_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-MOT8LB0;Initial Catalog=FKM;Integrated Security=True"))
            {
                SqlCommand sqlCmd = new SqlCommand("(select matricule ,concat(nom,' ',prenom,' ',matricule) as perso  from personnels where superieurHerchiqueMatricule='" + matriculeUser + "') union ( select matricule , concat(nom,' ',prenom,' ',matricule) as perso from personnels where matricule='" + matriculeUser + "')", sqlConnection);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = sqlCmd;
                DataTable dt2 = new DataTable();
                da.Fill(dt2);
                comboBox2.DataSource = dt2;
                comboBox2.DisplayMember = "perso";
                comboBox2.ValueMember = "matricule";
                //comboBox2.Items.Add(user + " " + matricule);
                sqlConnection.Open();
                

            }
            crudUser cu = new crudUser();
            DataTable dt = new DataTable();
            dt= cu.selectQuinzaines(matriculeUser);
            dataGridView1.DataSource = dt;
           
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[dataGridView1.Columns["statut"].Index].Value.ToString().Equals("en attente la validation du superieeur héarchique "))
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                }
                else if(dataGridView1.Rows[i].Cells[dataGridView1.Columns["statut"].Index].Value.ToString().Equals("valider par le superieeur héarchique"))
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if(dataGridView1.Rows[i].Cells[dataGridView1.Columns["statut"].Index].Value.ToString().Equals("valider par le services d'assurance"))
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }
    }
}
