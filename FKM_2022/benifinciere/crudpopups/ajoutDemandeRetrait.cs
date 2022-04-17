using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FKM_2022.referntiel;
//using Syncfusion.Pdf.Grid;
namespace FKM_2022.benifinciere.crudpopups
{
    public partial class ajoutDemandeRetrait : Form
    {
        private string filename=string.Empty;
        private string matricule = connection.getMatricule;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
         (

             int nLeftRect,     // x-coordinate of upper-left corner
             int nTopRect,      // y-coordinate of upper-left corner
             int nRightRect,    // x-coordinate of lower-right corner
             int nBottomRect,   // y-coordinate of lower-right corner
             int nWidthEllipse, // height of ellipse
             int nHeightEllipse // width of ellipse
         );

        public ajoutDemandeRetrait()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            roundBtn1.Enabled = true;
            roundBtn2.Enabled = true;
            pictureBox4.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dig = new OpenFileDialog() { Filter = "PDF Documents(*.pdf)|*.pdf", ValidateNames = true })
            {
                if (dig.ShowDialog() == DialogResult.OK)
                {
                    DialogResult result = MessageBox.Show("êtes-vous sûr de vouloir télécharger ce fichier ?", "verifier", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                       filename = dig.FileName;

                    }
                    else
                    {
                        return;
                    }
                }
            }
        }
    

        private void ajoutDemandeRetrait_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-MOT8LB0;Initial Catalog=FKM;Integrated Security=True"))
            {
                SqlCommand sqlCmd = new SqlCommand("(select matricule ,concat(nom,' ',prenom,' ',matricule) as perso  from personnels where matriculeAgentDesaisie='" + matricule + "') union ( select matricule , concat(nom,' ',prenom,' ',matricule) as perso from personnels where matricule='" + matricule + "')", sqlConnection);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = sqlCmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "perso";
                comboBox2.ValueMember = "matricule";
                //comboBox2.Items.Add(user + " " + matricule);
                sqlConnection.Open();
                //label1.Text = matricule.ToString();

            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "pret")
            {
                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-MOT8LB0;Initial Catalog=FKM;Integrated Security=True"))
                    {
                        SqlCommand sqlCmd = new SqlCommand("select montant_pret from categories where code=(select CategoriePret_Code from contratsVoitures where Personnel_Matricule='" + comboBox2.SelectedValue.ToString() + "')", sqlConnection);
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = sqlCmd;
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        label12.Text = dt.Rows[0][0].ToString();
                        pictureBox4.Show();
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("personnel sans contrat contacter votre administrateur !", "Alert !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            if (comboBox1.Text == "Reparation")
            {
                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-MOT8LB0;Initial Catalog=FKM;Integrated Security=True"))
                    {
                        SqlCommand sqlCmd = new SqlCommand("select max (TauxRepartion) from Quinzaines where matriculePerso='" + comboBox2.SelectedValue.ToString() + "'", sqlConnection);
                        //MessageBox.Show(sqlCmd.ToString);
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = sqlCmd;
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        label12.Text = dt.Rows[0][0].ToString();
                        pictureBox4.Show();
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("personnel sans contrat contacter votre administrateur !", "Alert !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            if (comboBox1.Text == "Cagnotte")
            {
                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-MOT8LB0;Initial Catalog=FKM;Integrated Security=True"))
                    {
                        SqlCommand sqlCmd = new SqlCommand("select max (TauxCagnotte) from Quinzaines where matriculePerso='" + comboBox2.SelectedValue.ToString() + "'", sqlConnection);
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = sqlCmd;
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        label12.Text = dt.Rows[0][0].ToString();
                        pictureBox4.Show();
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("personnel sans contrat contacter votre administrateur !", "Alert !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "pret")
            {
                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-MOT8LB0;Initial Catalog=FKM;Integrated Security=True"))
                    {
                        SqlCommand sqlCmd = new SqlCommand("select montant_pret from categories where code=(select CategoriePret_Code from contratsVoitures where Personnel_Matricule='" + comboBox2.SelectedValue.ToString() + "')", sqlConnection);
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = sqlCmd;
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        label12.Text = dt.Rows[0][0].ToString();
                        pictureBox4.Show();
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("personnel sans contrat contacter votre administrateur !", "Alert !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                
            }
            if (comboBox1.Text == "Reparation")
            {
                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-MOT8LB0;Initial Catalog=FKM;Integrated Security=True"))
                    {
                        SqlCommand sqlCmd = new SqlCommand("select max (TauxRepartion) from Quinzaines where matriculePerso='" + comboBox2.SelectedValue.ToString() + "')", sqlConnection);
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = sqlCmd;
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        label12.Text = dt.Rows[0][0].ToString();
                        pictureBox4.Show();
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("personnel sans contrat contacter votre administrateur !", "Alert !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }

            
            }
        }
    }

