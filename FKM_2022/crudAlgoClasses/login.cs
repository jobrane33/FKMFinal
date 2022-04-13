using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FKM_2022.crudAlgoClasses
{
    internal class login
    {
        private string conString = "Data Source=DESKTOP-MOT8LB0;Initial Catalog=FKM;Integrated Security=True";
        public bool loginuser(string userName ,string passWord)
        {
            string sql = "SELECT COUNT(*) FROM CompteFKM WHERE nomDutilisateur=@username and mot_de_pass =HASHBYTES('MD5',@password) and valide=1";
            SqlConnection con = new SqlConnection(conString); // making connection
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@username", userName);
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = passWord;
            //MessageBox.Show(sql);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                return true;
            }
            else if(userName==String.Empty || passWord==string.Empty)
            {
                MessageBox.Show("un des champs est vide ! ","erreur",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                MessageBox.Show("nom d'utilisateuro mot de pass invalide ", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        public string usertype(string userName, string passWord)
        {
            string sql = "SELECT type_utilisateur FROM CompteFKM WHERE nomDutilisateur=@username and mot_de_pass =HASHBYTES('MD5','" + passWord + "') ";
            SqlConnection con = new SqlConnection(conString); // making connection
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@username", userName);
            command.Parameters.AddWithValue("@password", passWord);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            
            return dt.Rows[0][0].ToString();
           

        }
        public string nomPrenomUser(string userName)
        {
            string sql = "select concat (nom,' ',prenom,' ',matricule) as nomPrenom  from personnels p , CompteFKM c where p.matricule = c.matriculePersonnel and c.nomDutilisateur=@username";
            SqlConnection con = new SqlConnection(conString); // making connection
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@username", userName);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);

            return dt.Rows[0][0].ToString();


        }
        public string matricule(string userName)
        {
            string sql = "select matricule  from personnels p , CompteFKM c where p.matricule = c.matriculePersonnel and c.nomDutilisateur=@username";
            SqlConnection con = new SqlConnection(conString); // making connection
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@username", userName);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);

            return dt.Rows[0][0].ToString();


        }
    }

    
}
