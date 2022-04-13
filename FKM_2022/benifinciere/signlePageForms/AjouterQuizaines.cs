using FKM_2022.crudAlgoClasses;
using FKM_2022.referntiel;
using System;
using System.Data;
using System.Data.SqlClient;
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
            comboBox3.Text = "janvier Quinzaine 1";
            //comboBox3.Text = "juillet Quinzaine 1";
            radioButton2.Checked = true;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void setQuinzaines()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MOT8LB0;Initial Catalog=FKM;Integrated Security=True");
            DateTime date = DateTime.Now;
            comboBox2.Text = user;
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
        public void checkValide()
        {
            crudUser cru = new crudUser();
            foreach (var item in comboBox3.Items)
            {
                string refQuaineaine = item + "/" + matricule + "/" + DateTime.Now.Year.ToString();
                bool result = cru.selectallQuinzaines(refQuaineaine) != "1";
                if (result)
                {
                    comboBox3.Items.Remove(item);
                }
            }
        }




        private DataTable selectCalendrierQuinzaine()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MOT8LB0;Initial Catalog=FKM;Integrated Security=True");
            int month;
            switch (comboBox3.Text)
            {
                case "janvier Quinzaine 1":
                case "janvier Quinzaine 2":
                    month = 1;
                    break;
                case "fevrier Quinzaine 1":
                case "fevrier Quinzaine 2":
                    month = 2;
                    break;
                case "mars Quinzaine 1":
                case "mars Quinzaine 2":
                    month = 3;
                    break;
                case "avril Quinzaine 1":
                case "avril Quinzaine 2":
                    month = 4;
                    break;
                case "mai Quinzaine 1":
                case "mai Quinzaine 2":
                    month = 5;
                    break;
                case "juin Quinzaine 1":
                case "juin Quinzaine 2":
                    month = 6;
                    break;
                case "c":
                case "juillet Quinzaine 2":
                    month = 7;
                    break;
                case "août Quinzaine 1":
                case "août Quinzaine 2":
                    month = 8;
                    break;
                case "septembre Quinzaine 1":
                case "septembre Quinzaine 2":
                    month = 9;
                    break;
                case "octobre Quinzaine 1":
                case "octobre Quinzaine 2":
                    month = 10;
                    break;
                case "novembre Quinzaine 1":
                case "novembre Quinzaine 2":
                    month = 11;
                    break;
                case "décembre Quinzaine 1":
                case "décembre Quinzaine 2":
                    month = 12;
                    break;
                default:
                    month = 1;
                    break;
            }
            try
            {

                String sql = "(SELECT date , jour from CalendrierQuinzaine where  codeQuinzaine ='" + comboBox3.Text + "' and jour <> 'sunday' and MONTH(date)=" + month + " EXCEPT SELECT  dateJourFerier , nomDUjour from joursFeriers where MONTH(dateJourFerier)=" + month + ") UNION ( SELECT dateJourFerier, nomDUjour from joursFeriers where  MONTH(dateJourFerier)=" + month + " EXCEPT SELECT date, jour from CalendrierQuinzaine where  codeQuinzaine = '" + comboBox3.Text + "' and jour  <> 'sunday' and MONTH(date)=" + month + ")";
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
            crudUser cru = new crudUser();
            string referanceQunzaineUser = label1.Text;
            string referanceQ = comboBox3.Text + "/" + referanceQunzaineUser + "/" + DateTime.Now.Year.ToString();
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
            int index = comboBox3.SelectedIndex;
            bool result = cru.selectallQuinzaines(referanceQ) != "1";
            if (index != 0)
            {
                if (result)
                   
                {
                    string newref = comboBox3.Items[index - 1].ToString() + "/" + referanceQunzaineUser + "/" + DateTime.Now.Year.ToString();
                    if (cru.selectallQuinzaines(newref) != "1")
                    {
                        MessageBox.Show("le précédent Quinzaine n'est pas encore validé");
                        string lastValidatedQuinzaineRef = cru.selectLastValidatedQuinzaines(label1.Text);
                        if (lastValidatedQuinzaineRef.Contains("/"))
                        {
                            int indexof_ = lastValidatedQuinzaineRef.IndexOf('/');
                            string referance = lastValidatedQuinzaineRef.Substring(0, indexof_);
                            int index2 = comboBox3.Items.IndexOf(referance);
                            comboBox3.Text = comboBox3.Items[index2 + 1].ToString();
                        }
                        else
                        {
                            comboBox3.Text = "janvier Quinzaine 1";
                            
                        }
                    }
                }
            }

            //    DataTable dt2 = new DataTable();


            //    string refQuaineaine = comboBox3.Text + "/" + referanceQunzaineUser + "/" + DateTime.Now.Year.ToString();
            //    dt2 = cru.selectDetailsQuinzaines(refQuaineaine);

            //    dataGridView1.DataSource = dt2;

            //    if (dataGridView1.Rows.Count != 0)
            //    {
            //        dataGridView1.DataSource = dt2;
            //    }
            //    else if (dataGridView1.Rows.Count == 0)
            //    {
            //        MessageBox.Show("vous douvez saise la quinzaine dabord", "pas de details ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        dt = selectCalendrierQuinzaine();
            //        dataGridView1.DataSource = dt;
            //        radioButton1.Checked = false;
            //        radioButton2.Checked = true;
            //    }

        }

        private void roundBtn2_Click(object sender, EventArgs e)
        {
            crudUser cru = new crudUser();
            string referanceQunzaineUser = comboBox2.SelectedValue.ToString();
            string referanceQ = comboBox3.Text + "/" + referanceQunzaineUser + "/" + DateTime.Now.Year.ToString();
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

            bool res = false;
            string refQuaineaine = comboBox3.Text + "/" + referanceQunzaineUser + "/" + DateTime.Now.Year.ToString();
            bool result = cru.ajoutQuinzaine(refQuaineaine, sum, referanceQunzaineUser, user);
            if (result)
            {
                MessageBox.Show("done");
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    try
                    {
                        var KM = Convert.ToInt32(dataGridView1.Rows[i].Cells[dataGridView1.Columns["kilometrage"].Index].Value);
                        DateTime datejour = Convert.ToDateTime(dataGridView1.Rows[i].Cells[dataGridView1.Columns["date"].Index].Value?.ToString());
                        var jour = dataGridView1.Rows[i].Cells[dataGridView1.Columns["jour"].Index].Value.ToString();

                        res = cru.stockKilometrages(KM, refQuaineaine, jour, datejour);

                    }

                    catch (System.NullReferenceException)
                    {
                        MessageBox.Show("somthing went wrong ");
                        cru.reinitialiserQuinzaine(refQuaineaine);
                        userHome userhome = new userHome();
                        Invalidate();
                        userhome.Refresh();
                        return;
                    }
                }
                if (res)
                {
                    MessageBox.Show("well tested ");

                }
                else
                {
                    MessageBox.Show("somthing went wrong");
                }
            }
            else
            {
                MessageBox.Show("la quinzaine est saisie ! voulez vous consultez les details !", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void roundBtn3_Click(object sender, EventArgs e)
        {

            crudUser cru = new crudUser();
            string referanceQunzaineUser = comboBox2.SelectedValue.ToString();
            string refQuaineaine = comboBox3.Text + "/" + referanceQunzaineUser + "/" + DateTime.Now.Year.ToString();
            //comboBox3.Text+combobox2.text+DateTime.Now.Year.ToString();
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


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            crudUser cru = new crudUser();
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            if (radioButton1.Checked)
            {
                string referanceQunzaineUser = comboBox2.SelectedValue.ToString();
                string refQuaineaine = comboBox3.Text + "/" + referanceQunzaineUser + "/" + DateTime.Now.Year.ToString();
                dt2 = cru.selectDetailsQuinzaines(refQuaineaine);

                dataGridView1.DataSource = dt2;

                if (dataGridView1.Rows.Count != 0)
                {
                    dataGridView1.DataSource = dt2;
                }
                else if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("vous douvez saise la quinzaine dabord", "pas de details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt = selectCalendrierQuinzaine();
                    dataGridView1.DataSource = dt;
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                }
            }
            else if (radioButton2.Checked)
            {
                this.dataGridView1.Columns["kilometrage"].Visible = true;
                //dataGridView1.Columns["dateDuJour"].Visible = true;
                dt = selectCalendrierQuinzaine();
                dataGridView1.DataSource = dt;

            }
        }

        private void roundBtn4_Click(object sender, EventArgs e)
        {
            crudUser cru = new crudUser();
            DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("attention la quinzaine va etre réinitialiser", "attention", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                string referanceQunzaineUser = comboBox2.SelectedValue.ToString();
                string refQuaineaine = comboBox3.Text + "/" + referanceQunzaineUser + "/" + DateTime.Now.Year.ToString();
                if (cru.selectallQuinzaines(refQuaineaine) == "0")
                {
                    bool result = cru.reinitialiserQuinzaine(refQuaineaine);
                    bool resultdetails = cru.reinitialiserDetailsQuinzaine(refQuaineaine);
                    if (result && resultdetails)
                    {
                        MessageBox.Show("la quinzaine est réinitialiser", "fait", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("vous douvez saise la quinzaine dabord", "pas de details ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }
                else if (cru.selectallQuinzaines(refQuaineaine) == "1")
                {
                    MessageBox.Show("la quinzaine est deja valide vous ne peuvez pas la réinitialiser", "erreru", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

        }

        private void AjouterQuizaines_Load(object sender, EventArgs e)
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
                label1.Text = matricule.ToString();

            }



        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = selectCalendrierQuinzaine();
            dataGridView1.DataSource = dt;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void roundBtn1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox2.SelectedValue.ToString();
            comboBox3.Text = comboBox3.Items[0].ToString();
        }
    }
}


