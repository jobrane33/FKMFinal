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
            string sql = "SELECT COUNT(*) FROM CompteFKM WHERE nomDutilisateur=@username and mot_de_pass =@password ";
            SqlConnection con = new SqlConnection(conString); // making connection
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@username", userName);
            command.Parameters.AddWithValue("@password", passWord);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid username or password");
                return false;
            }

        }
        public string usertype(string userName, string passWord)
        {
            string sql = "SELECT type_utilisateur FROM CompteFKM WHERE nomDutilisateur=@username and mot_de_pass =@password ";
            SqlConnection con = new SqlConnection(conString); // making connection
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@username", userName);
            command.Parameters.AddWithValue("@password", passWord);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            
            return dt.Rows[0][0].ToString();
           

        }
    }
    
}
