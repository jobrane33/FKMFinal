using FKM_2022.crudAlgoClasses;
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

namespace FKM_2022.CRUDforms
{
    
    public partial class ajouterContrat : Form
    {
        private string filename = "";
        public string matTextBox
        {
            get { return customtextbox3.Texts; }
            set { customtextbox3.Texts = value; }
        }
        public string categorieComboBox
        {
            get { return comboBox1.Text; }
            set { comboBox1.Text = value; }
        }
        //public string nomDocument
        //{
        //    get { return customtextbox2.Texts;}
        //    set { customtextbox2.Texts = value; }
        //}
        public string groupBoxSetter
        {
            get { return groupBox1.Text; }
            set { groupBox1.Text = value; }
        }
        public bool btnValider
        {
            get { return roundBtn1.Enabled; }
            set { roundBtn1.Enabled= value; }
        }
        public bool btnModifier
        {
            get { return roundBtn2.Enabled; }
            set { roundBtn2.Enabled= value; }
        }

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
        public ajouterContrat()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            using (SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-MOT8LB0;Initial Catalog=FKM;Integrated Security=True"))
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT code , libelle FROM categories", sqlConnection);
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

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customtextbox1__TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Some text", "Some title",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        

        

        

        private void customtextbox3_Enter(object sender, EventArgs e)
        {
            customtextbox3.BorderColor = Color.Green;
            label10.Hide();
        }

        private void customtextbox3_Leave(object sender, EventArgs e)
        {
            if (customtextbox3.Texts == string.Empty)
            {
                customtextbox3.BorderColor = Color.Red;
                label10.Show();
            }
        }

       

        private void roundBtn1_Click(object sender, EventArgs e)
        {
            if(  customtextbox3.Texts == String.Empty )
            {
                MessageBox.Show("voudriez-vous svp remplir toutes les zones de texte", "champ vide !",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string codecat = comboBox1.SelectedValue.ToString();
                int numcodecat = Int32.Parse(codecat);
                crudMethodes cm = new crudMethodes();
               bool test = cm.ajoutContrat(customtextbox3.Texts, numcodecat,filename);
                if (test)
                {
                    MessageBox.Show("suecess", "bien fait !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("erreur d'insertion", "erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void customtextbox5__TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Some text", "Some title",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customtextbox3__TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customtextbox2__TextChanged(object sender, EventArgs e)
        {

        }

        private void roundBtn2_Click(object sender, EventArgs e)
        {
            if (customtextbox3.Texts == String.Empty)
            {
                MessageBox.Show("voudriez-vous svp remplir toutes les zones de texte", "champ vide !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string codecat = comboBox1.SelectedValue.ToString();
                int numcodecat = Int32.Parse(codecat);
                crudMethodes cm = new crudMethodes();
                bool test = cm.updateContrat(customtextbox3.Texts, numcodecat, filename);
                if (test)
                {
                    MessageBox.Show("suecess", "bien fait !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("erreur d'insertion", "erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            using( OpenFileDialog dig = new OpenFileDialog() { Filter = "PDF Documents(*.pdf)|*.pdf" ,ValidateNames = true })
            {
                if(dig.ShowDialog() == DialogResult.OK)
                {
                    DialogResult result = MessageBox.Show("êtes-vous sûr de vouloir télécharger ce fichier ?","verifier", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        filename=dig.FileName;
                        
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }
    }
}
