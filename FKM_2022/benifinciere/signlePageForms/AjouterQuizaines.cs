using FKM_2022.crudAlgoClasses;
using FKM_2022.referntiel;
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

namespace FKM_2022.benifinciere.signlePageForms
{
    public partial class AjouterQuizaines : Form
    {
        private string matricule = connection.getMatricule;
        private string user = connection.getNomPrenom;
        public AjouterQuizaines()
        {
            InitializeComponent();
            setQuinzaines();
            selectCalendrierQuinzainedefault();
            radioButton2.Checked = true;
        }
        private void selectCalendrierQuinzainedefault()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MOT8LB0;Initial Catalog=FKM;Integrated Security=True");
            DateTime date = DateTime.Now;
            comboBox2.Text = user;
            comboBox2.Enabled = false;
            int month = date.Month;
            switch (month)
            {
                case 1:
                    comboBox3.Text = "janvier Quinzaine 1";
                    break;
                case 2:
                    comboBox3.Text = "fevrier Quinzaine 1";
                    break;
                case 3:
                    comboBox3.Text = "mars Quinzaine 1";
                    break;
                case 4:
                    comboBox3.Text = "avril Quinzaine 1";
                    break;
                case 5:
                    comboBox3.Text = "mai Quinzaine 1";
                    break;
                case 6:
                    comboBox3.Text = "juin Quinzaine 1";
                    break;
                case 7:
                    comboBox3.Text = "juillet Quinzaine 1";
                    break;
                case 8:
                    comboBox3.Text = "août Quinzaine 1";
                    break;
                case 9:
                    comboBox3.Text = "septembre Quinzaine 1";
                    break;
                case 10:
                    comboBox3.Text = "octobre Quinzaine 1";
                    break;
                case 11:
                    comboBox3.Text = "novembre Quinzaine 1";
                    break;
                case 12:
                    comboBox3.Text = "décembre Quinzaine 1";
                    break;
                default:

                    break;
            }

                dt = selectCalendrierQuinzaine();
                dataGridView1.DataSource = dt;
            
        }
        private void setQuinzaines()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MOT8LB0;Initial Catalog=FKM;Integrated Security=True");
            DateTime date = DateTime.Now;
            comboBox2.Text = user;
            comboBox2.Enabled = false;
            int month = date.Month;
            switch (month)
            {
                case 1:
                    comboBox3.Items.Add("janvier Quinzaine 1");
                    comboBox3.Items.Add("janvier Quinzaine 2");
                    break;
                case 2:
                    comboBox3.Items.Add("janvier Quinzaine 1");
                    comboBox3.Items.Add("janvier Quinzaine 2");
                    comboBox3.Items.Add("fevrier Quinzaine 1");
                    comboBox3.Items.Add("fevrier Quinzaine 2");
                    break;
                case 3:
                    comboBox3.Items.Add("janvier Quinzaine 1");
                    comboBox3.Items.Add("janvier Quinzaine 2");
                    comboBox3.Items.Add("fevrier Quinzaine 1");
                    comboBox3.Items.Add("fevrier Quinzaine 2");
                    comboBox3.Items.Add("mars Quinzaine 1");
                    comboBox3.Items.Add("mars Quinzaine 2");
                    break;
                case 4:
                    comboBox3.Items.Add("janvier Quinzaine 1");
                    comboBox3.Items.Add("janvier Quinzaine 2");
                    comboBox3.Items.Add("fevrier Quinzaine 1");
                    comboBox3.Items.Add("fevrier Quinzaine 2");
                    comboBox3.Items.Add("mars Quinzaine 1");
                    comboBox3.Items.Add("mars Quinzaine 2");
                    comboBox3.Items.Add("avril Quinzaine 1");
                    comboBox3.Items.Add("avril Quinzaine 2");
                    break;
                case 5:
                    comboBox3.Items.Add("janvier Quinzaine 1");
                    comboBox3.Items.Add("janvier Quinzaine 2");
                    comboBox3.Items.Add("fevrier Quinzaine 1");
                    comboBox3.Items.Add("fevrier Quinzaine 2");
                    comboBox3.Items.Add("mars Quinzaine 1");
                    comboBox3.Items.Add("mars Quinzaine 2");
                    comboBox3.Items.Add("avril Quinzaine 1");
                    comboBox3.Items.Add("avril Quinzaine 2");
                    comboBox3.Items.Add("mai Quinzaine 1");
                    comboBox3.Items.Add("mai Quinzaine 2");
                    break;
                case 6:
                    comboBox3.Items.Add("janvier Quinzaine 1");
                    comboBox3.Items.Add("janvier Quinzaine 2");
                    comboBox3.Items.Add("fevrier Quinzaine 1");
                    comboBox3.Items.Add("fevrier Quinzaine 2");
                    comboBox3.Items.Add("mars Quinzaine 1");
                    comboBox3.Items.Add("mars Quinzaine 2");
                    comboBox3.Items.Add("avril Quinzaine 1");
                    comboBox3.Items.Add("avril Quinzaine 2");
                    comboBox3.Items.Add("mai Quinzaine 1");
                    comboBox3.Items.Add("mai Quinzaine 2");
                    comboBox3.Items.Add("juin Quinzaine 1");
                    comboBox3.Items.Add("juin Quinzaine 2");
                    break;
                case 7:
                    comboBox3.Items.Add("janvier Quinzaine 1");
                    comboBox3.Items.Add("janvier Quinzaine 2");
                    comboBox3.Items.Add("fevrier Quinzaine 1");
                    comboBox3.Items.Add("fevrier Quinzaine 2");
                    comboBox3.Items.Add("mars Quinzaine 1");
                    comboBox3.Items.Add("mars Quinzaine 2");
                    comboBox3.Items.Add("avril Quinzaine 1");
                    comboBox3.Items.Add("avril Quinzaine 2");
                    comboBox3.Items.Add("mai Quinzaine 1");
                    comboBox3.Items.Add("mai Quinzaine 2");
                    comboBox3.Items.Add("juin Quinzaine 1");
                    comboBox3.Items.Add("juin Quinzaine 2");
                    comboBox3.Items.Add("juillet Quinzaine 1");
                    comboBox3.Items.Add("juillet Quinzaine 2");
                    break;
                case 8:
                    comboBox3.Items.Add("janvier Quinzaine 1");
                    comboBox3.Items.Add("janvier Quinzaine 2");
                    comboBox3.Items.Add("fevrier Quinzaine 1");
                    comboBox3.Items.Add("fevrier Quinzaine 2");
                    comboBox3.Items.Add("mars Quinzaine 1");
                    comboBox3.Items.Add("mars Quinzaine 2");
                    comboBox3.Items.Add("avril Quinzaine 1");
                    comboBox3.Items.Add("avril Quinzaine 2");
                    comboBox3.Items.Add("mai Quinzaine 1");
                    comboBox3.Items.Add("mai Quinzaine 2");
                    comboBox3.Items.Add("juin Quinzaine 1");
                    comboBox3.Items.Add("juin Quinzaine 2");
                    comboBox3.Items.Add("juillet Quinzaine 1");
                    comboBox3.Items.Add("juillet Quinzaine 2");
                    comboBox3.Items.Add("août Quinzaine 1");
                    comboBox3.Items.Add("août Quinzaine 2");
                    break;
                case 9:
                    comboBox3.Items.Add("janvier Quinzaine 1");
                    comboBox3.Items.Add("janvier Quinzaine 2");
                    comboBox3.Items.Add("fevrier Quinzaine 1");
                    comboBox3.Items.Add("fevrier Quinzaine 2");
                    comboBox3.Items.Add("mars Quinzaine 1");
                    comboBox3.Items.Add("mars Quinzaine 2");
                    comboBox3.Items.Add("avril Quinzaine 1");
                    comboBox3.Items.Add("avril Quinzaine 2");
                    comboBox3.Items.Add("mai Quinzaine 1");
                    comboBox3.Items.Add("mai Quinzaine 2");
                    comboBox3.Items.Add("juin Quinzaine 1");
                    comboBox3.Items.Add("juin Quinzaine 2");
                    comboBox3.Items.Add("juillet Quinzaine 1");
                    comboBox3.Items.Add("juillet Quinzaine 2");
                    comboBox3.Items.Add("août Quinzaine 1");
                    comboBox3.Items.Add("août Quinzaine 2");
                    comboBox3.Items.Add("septembre Quinzaine 1");
                    comboBox3.Items.Add("septembre Quinzaine 2");
                    break;
                case 10:
                    comboBox3.Items.Add("janvier Quinzaine 1");
                    comboBox3.Items.Add("janvier Quinzaine 2");
                    comboBox3.Items.Add("fevrier Quinzaine 1");
                    comboBox3.Items.Add("fevrier Quinzaine 2");
                    comboBox3.Items.Add("mars Quinzaine 1");
                    comboBox3.Items.Add("mars Quinzaine 2");
                    comboBox3.Items.Add("avril Quinzaine 1");
                    comboBox3.Items.Add("avril Quinzaine 2");
                    comboBox3.Items.Add("mai Quinzaine 1");
                    comboBox3.Items.Add("mai Quinzaine 2");
                    comboBox3.Items.Add("juin Quinzaine 1");
                    comboBox3.Items.Add("juin Quinzaine 2");
                    comboBox3.Items.Add("juillet Quinzaine 1");
                    comboBox3.Items.Add("juillet Quinzaine 2");
                    comboBox3.Items.Add("août Quinzaine 1");
                    comboBox3.Items.Add("août Quinzaine 2");
                    comboBox3.Items.Add("septembre Quinzaine 1");
                    comboBox3.Items.Add("septembre Quinzaine 2");
                    break;
                case 11:
                    comboBox3.Items.Add("janvier Quinzaine 1");
                    comboBox3.Items.Add("janvier Quinzaine 2");
                    comboBox3.Items.Add("fevrier Quinzaine 1");
                    comboBox3.Items.Add("fevrier Quinzaine 2");
                    comboBox3.Items.Add("mars Quinzaine 1");
                    comboBox3.Items.Add("mars Quinzaine 2");
                    comboBox3.Items.Add("avril Quinzaine 1");
                    comboBox3.Items.Add("avril Quinzaine 2");
                    comboBox3.Items.Add("mai Quinzaine 1");
                    comboBox3.Items.Add("mai Quinzaine 2");
                    comboBox3.Items.Add("juin Quinzaine 1");
                    comboBox3.Items.Add("juin Quinzaine 2");
                    comboBox3.Items.Add("juillet Quinzaine 1");
                    comboBox3.Items.Add("juillet Quinzaine 2");
                    comboBox3.Items.Add("août Quinzaine 1");
                    comboBox3.Items.Add("août Quinzaine 2");
                    comboBox3.Items.Add("septembre Quinzaine 1");
                    comboBox3.Items.Add("septembre Quinzaine 2");
                    comboBox3.Items.Add("octobre Quinzaine 1");
                    comboBox3.Items.Add("octobre Quinzaine 2");
                    break;
                case 12:
                    comboBox3.Items.Add("janvier Quinzaine 1");
                    comboBox3.Items.Add("janvier Quinzaine 2");
                    comboBox3.Items.Add("fevrier Quinzaine 1");
                    comboBox3.Items.Add("fevrier Quinzaine 2");
                    comboBox3.Items.Add("mars Quinzaine 1");
                    comboBox3.Items.Add("mars Quinzaine 2");
                    comboBox3.Items.Add("avril Quinzaine 1");
                    comboBox3.Items.Add("avril Quinzaine 2");
                    comboBox3.Items.Add("mai Quinzaine 1");
                    comboBox3.Items.Add("mai Quinzaine 2");
                    comboBox3.Items.Add("juin Quinzaine 1");
                    comboBox3.Items.Add("juin Quinzaine 2");
                    comboBox3.Items.Add("juillet Quinzaine 1");
                    comboBox3.Items.Add("juillet Quinzaine 2");
                    comboBox3.Items.Add("août Quinzaine 1");
                    comboBox3.Items.Add("août Quinzaine 2");
                    comboBox3.Items.Add("septembre Quinzaine 1");
                    comboBox3.Items.Add("septembre Quinzaine 2");
                    comboBox3.Items.Add("octobre Quinzaine 1");
                    comboBox3.Items.Add("octobre Quinzaine 2");
                    comboBox3.Items.Add("décembre Quinzaine 1");
                    comboBox3.Items.Add("décembre Quinzaine 2");
                    break;
                default:

                    break;
            }

        }
       
        private DataTable selectCalendrierQuinzaine()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MOT8LB0;Initial Catalog=FKM;Integrated Security=True");
            try
            {

                String sql = "(SELECT date , jour from CalendrierQuinzaine where  codeQuinzaine ='" + comboBox3.Text + "' and jour <> 'sunday' EXCEPT SELECT  dateJourFerier , nomDUjour from joursFeriers) UNION ( SELECT dateJourFerier, nomDUjour from joursFeriers EXCEPT SELECT date, jour from CalendrierQuinzaine where  codeQuinzaine = '" + comboBox3.Text + "' and jour  <> 'sunday')";
                // MessageBox.Show(sql);
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
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (uperPannel.Visible)
            {
                uperPannel.Visible = false;
            }
            else
            {
                uperPannel.Visible = true;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = selectCalendrierQuinzaine();

            if (radioButton1.Checked)
            {
                dt = selectCalendrierQuinzaine();
                dataGridView1.DataSource = dt;
            }
            else if (radioButton2.Checked)
            {
                dt = selectCalendrierQuinzaine();
                dataGridView1.DataSource = dt;

            }
        }

        private void roundBtn2_Click(object sender, EventArgs e)
        {
            crudUser cru = new crudUser();
            string referanceQ = comboBox3.Text + "/" + matricule + "/" + DateTime.Now.Year.ToString();
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                try
                {
                    if (dataGridView1.Rows[i].Cells[dataGridView1.Columns["kilometrage"].Index].Value != null)
                    {
                        sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[dataGridView1.Columns["kilometrage"].Index].Value);

                    }
                    else
                    {
                        MessageBox.Show("les valeurs doit avoir un 0 si les kilometrages sont nulls", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("les valeurs doivent être numériques", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
           
            
            string refQuaineaine = comboBox3.Text + "/" + matricule + "/" + DateTime.Now.Year.ToString();
            bool result = cru.ajoutQuinzaine(refQuaineaine, sum, matricule, user);
            if (result)
            {
                MessageBox.Show("done");
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    var KM = Convert.ToInt32(dataGridView1.Rows[i].Cells[dataGridView1.Columns["kilometrage"].Index].Value);
                    var datejour = Convert.ToDateTime(dataGridView1.Rows[i].Cells[dataGridView1.Columns["dateDuJour"].Index].Value);
                    var jour = dataGridView1.Rows[i].Cells[dataGridView1.Columns["jour"].Index].Value.ToString();

                    bool res = cru.stockKilometrages(KM, refQuaineaine, jour, datejour);
                    if (res)
                    {
                        MessageBox.Show("ok");

                    }
                    else
                    {
                        MessageBox.Show("le");
                    }
                }
            }
            else
            {
                MessageBox.Show("la quinzaine est saisie ! voulez vous consultez les details !", "erreur",MessageBoxButtons.OK,MessageBoxIcon.Stop) ;
            }
            
            
        }

        private void roundBtn3_Click(object sender, EventArgs e)
        {

            crudUser cru = new crudUser();
            string refQuaineaine = comboBox3.Text + "/" + matricule + "/" + DateTime.Now.Year.ToString();
            DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("attention", "coulez-vouz vraiment valider ?", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Error);
            if (dialogResult == DialogResult.Yes)
            {
                if (cru.selectallQuinzaines(refQuaineaine) != "1")
                {
                    bool result = cru.confirmQuizaine(refQuaineaine);
                    if (result)
                    {
                        MessageBox.Show("Quizaine valider en attente la validation du superieur héarchique ", "valide", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("erreur du validation", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("déjà validé", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            crudUser cru = new crudUser();
            DataTable dt = new DataTable(); 
            DataTable dt2 = new DataTable();
            if (radioButton1.Checked)
            {
                
                string refQuaineaine = comboBox3.Text + "/" + matricule + "/" + DateTime.Now.Year.ToString();
                dt2 = cru.selectDetailsQuinzaines(refQuaineaine);
                if (dataGridView1.Rows.Count != 0)
                {
                    dataGridView1.DataSource = dt2;
                }
                else
                {
                    MessageBox.Show("vous douvez saise la quinzaine dabord", "pas de details ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt = selectCalendrierQuinzaine();
                    dataGridView1.DataSource = dt;
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                }
            }
            else if (radioButton2.Checked)
            {
                dt = selectCalendrierQuinzaine();
                dataGridView1.DataSource = dt;

            }
        }
    }
    }


