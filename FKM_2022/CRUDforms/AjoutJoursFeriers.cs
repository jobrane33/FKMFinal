using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FKM_2022.crudAlgoClasses;
namespace FKM_2022.CRUDforms
{
    public partial class AjoutJoursFeriers : Form
    {
        private string dayName=string.Empty;
        private string date=string.Empty;
        public AjoutJoursFeriers()
        {
            InitializeComponent();
            dayName = dateTimePicker1.Value.ToString();
            dateTimePicker1.CustomFormat = "yyyy/MM/dd";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("fr-FR");
            System.Threading.Thread.CurrentThread.CurrentCulture = ci;
            date = dateTimePicker1.Value.Date.ToString();
            dayName = dateTimePicker1.Value.DayOfWeek.ToString();
            
            switch (dayName)
            {
                case "Monday":
                    dayName = "Lundi";
                    break;
                case "Tuesday":
                    dayName = "Mardi";
                    break;
                case "Wednesday":
                    dayName = "Mercredi";
                    break;
                case "Thursday":
                    dayName = "Jeudi";
                    break;
                case "Friday":
                    dayName = "Vendredi";
                    break;
                case "Saturday":
                    dayName = "Samedi";
                    break;
                case "Sunday":
                    dayName = "Dimanche";
                    break;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void roundBtn1_Click(object sender, EventArgs e)
        {
            if (customtextbox5.Texts == String.Empty)
            {
                MessageBox.Show("remplir l'observation !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                crudMethodes cm = new crudMethodes();
                bool result = cm.ajoutJour(dayName, date, customtextbox5.Texts.ToString());
                if (result)
                {
                    MessageBox.Show("Jour ajouter avec success", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("jour existant !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
