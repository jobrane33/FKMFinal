using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FKM_2022.CRUDforms
{
    public partial class ajouterVehicule : Form
    {
        private string filename = "";
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


        public ajouterVehicule()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            comboBox1.Text = "contrat";
            var CurrentCultureInfo = new CultureInfo("en", false);
            CurrentCultureInfo.NumberFormat.NumberDecimalSeparator = ".";
            CurrentCultureInfo.NumberFormat.CurrencyDecimalSeparator = ".";
            Thread.CurrentThread.CurrentUICulture = CurrentCultureInfo;
            Thread.CurrentThread.CurrentCulture = CurrentCultureInfo;
            CultureInfo.DefaultThreadCurrentCulture = CurrentCultureInfo;
            using (SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-MOT8LB0;Initial Catalog=FKM;Integrated Security=True"))
            {
                SqlCommand sqlCmd = new SqlCommand("select code , libelle from contratsVoitures --where Actif=1 ", sqlConnection);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = sqlCmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "libelle";
                comboBox1.ValueMember = "code";
                sqlConnection.Open();

            }
        }
        public string immatbox
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string montantpret
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public DateTime dateAchat
        {
            get { return dateTimePicker2.Value.Date; }
            set { dateTimePicker2.Value = value; }
        }
        public string montantAchat
        {
            get { return textBox9.Text; }
            set { textBox9.Text = value; }
        }
        public string Puissance
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }
        public string Marque
        {
            get { return textBox6.Text; }
            set { textBox6.Text = value; }
        }
        public string Modele
        {
            get { return textBox7.Text; }
            set { textBox7.Text = value; }
        }
        public DateTime DateMiseEnCirculation
        {
            get { return dateTimePicker1.Value.Date; }
            set { dateTimePicker1.Value = value; }
        }
        public string ValeurInitialeKilometrage
        {
            get { return textBox10.Text; }
            set { textBox10.Text = value; }
        }
        public DateTime datemiseEnExploitation
        {
            get { return dateTimePicker3.Value.Date; }
            set { dateTimePicker3.Value = value; }
        }
        public DateTime datemiseHorsExploitation
        {
            get { return dateTimePicker4.Value.Date; }
            set { dateTimePicker4.Value = value; }
        }
        public bool validButton
        {
            set { button1.Enabled = value; }
        }
        public bool updateButton
        {
            set { button2.Enabled = value; }
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "immatriculation")
            {
                textBox1.Text = String.Empty;
            }

        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty)
            {
                textBox1.Text = "immatriculation";
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Montant Pret")
            {
                textBox2.Text = String.Empty;
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == String.Empty)
            {
                textBox2.Text = "Montant Pret";
            }
        }

       
       

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Puissance")
            {
                textBox4.Text = String.Empty;
            }
        }
        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == String.Empty)
            {
                textBox4.Text = "Puissance";
            }
        }

        

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "Marque")
            {
                textBox6.Text = String.Empty;
            }
        }
        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == String.Empty)
            {
                textBox6.Text = "Marque";
            }
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (textBox7.Text == "Modele")
            {
                textBox7.Text = String.Empty;
            }

        }
        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == String.Empty)
            {
                textBox7.Text = "Modele";
            }
        }

       
        

        private void textBox9_Enter(object sender, EventArgs e)
        {
            if (textBox9.Text == "Montant d'achat")
            {
                textBox9.Text = String.Empty;
            }
        }

       
        private void textBox10_Enter(object sender, EventArgs e)
        {
            if (textBox10.Text == "Valeur Initiale Kilometrage")
            {
                textBox10.Text = String.Empty;
            }
        }

        private void textBox10_Leave(object sender, EventArgs e)

        {
            if (textBox10.Text == String.Empty)
            {
                textBox10.Text = "Valeur Initiale Kilometrage";
            }
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
        //ajout voiture
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "immatriculation" || textBox2.Text == "Montant Pret" || textBox9.Text == "Montant d'achat" || textBox4.Text == "Puissance" || 
                textBox6.Text == "Marque" || textBox7.Text == "Modele" || textBox10.Text == "Valeur Initiale Kilometrage")
            {
                MessageBox.Show("voudriez-vous svp remplir toutes les zones de texte", "champ vide !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                float outputValue = 0;
                bool isNumber = false;
                bool isNumber2 = false;
                isNumber2 = float.TryParse(textBox9.Text, out outputValue);
                isNumber = float.TryParse(textBox2.Text, out outputValue);
                if (isNumber && isNumber2)
                {
                    string codeContrat = comboBox1.SelectedValue.ToString();
                    int codeContratint = int.Parse(codeContrat);
                    string connectionString = "Data Source=DESKTOP-MOT8LB0;Initial Catalog=FKM;Integrated Security=True";
                    string query = "EXEC[dbo].[stockVehicule]@montantPret = @mp ,@Immatriculation = @mat ,@DateAchat = @dateA,@Puissance = @chv" +
                        " ,@actif = 1,@Statut ='actif' ,@Marque = @mar,@DateMiseEnCirculation = @dateC,@MontantAchat = @ma,@Contrat_Code = @code" +
                        ",@ValeurInitKilometrage = @km,@Documents = NULL,@DatetMiseEnExploitation = @dateM,@DatetMiseHorsExploitation = NULL ,@Modele = @mode";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                      crudAlgoClasses.crudMethodes cm = new crudAlgoClasses.crudMethodes ();
                        bool result = cm.ajoutVehicule(dateTimePicker2.Value.Date, textBox2.Text, textBox1.Text ,
                            textBox4.Text, textBox6.Text, dateTimePicker2.Value.Date, textBox9.Text,codeContratint, textBox10.Text, dateTimePicker3.Value.Date, textBox7.Text,dateTimePicker4.Value.Date,filename);
                        if (result)
                        {
                            MessageBox.Show("insertion valider", "valide", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("matricule non valide", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("les  montants ! doivent être numerique !", "erreur de saisie !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
