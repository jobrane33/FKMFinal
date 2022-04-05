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
    internal class crudUser
    {
        private string conString = "Data Source=DESKTOP-MOT8LB0;Initial Catalog=FKM;Integrated Security=True";
        public bool ajoutQuinzaine(string refQuinzaine , int sommeKM, string matricule ,string userREC)
        {
            bool success = false;
            SqlConnection con = new SqlConnection(conString);
            try
            {
                string sql = "EXEC	[dbo].[stockQuinzaine]@referanceQuinzaine = @refQ,@sommeKilometresQuinzaine = @sommeKm,@matriculePerso = @mat,@user = @userRec";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@refQ", SqlDbType.VarChar).Value = refQuinzaine;
                cmd.Parameters.Add("@sommekm", SqlDbType.Int).Value = sommeKM;
                cmd.Parameters.Add("@mat", SqlDbType.VarChar).Value = matricule;
                cmd.Parameters.Add("@userRec", SqlDbType.VarChar).Value = userREC;
                MessageBox.Show(sql);
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    success = true;
                }
                else
                {
                    success = false;
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally { con.Close(); }
            return success;
        }
        public bool confirmQuizaine(string referanceQuinzaine)
        {
            bool success = false;
            SqlConnection con = new SqlConnection(conString);
            try
            {
                string sql = "update Quinzaines set valide=1 where referanceQuinzaine=@refQ";
                SqlCommand command = new SqlCommand(sql, con);
                command.Parameters.Add("@refQ", SqlDbType.VarChar).Value = referanceQuinzaine;
                con.Open();
                int rows = command.ExecuteNonQuery();
                if (rows > 0)
                {
                    success = true;
                }
                else
                {
                    success = false;
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally { con.Close(); }
            return success;
        }
        public String  selectallQuinzaines(string referanceQuinzaine)
        {
            try
            {
                string sql = "select valide from Quinzaines where referanceQuinzaine=@refQ";
                SqlConnection con = new SqlConnection(conString); // making connection
                SqlCommand command = new SqlCommand(sql, con);
                command.Parameters.Add("@refQ", SqlDbType.VarChar).Value = referanceQuinzaine;
                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataTable dt = new DataTable(); //this is creating a virtual table  
                sda.Fill(dt);
                return dt.Rows[0][0].ToString();
            }
            catch(System.IndexOutOfRangeException)
            {
                MessageBox.Show("quinzaine pas encore saisie","verifiez",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return null;
            }
        }
        public bool stockKilometrages(int kilometrage ,string referanceQuinzaine,string jour , DateTime dateDuJour)
        {
            bool success = false;
            SqlConnection con = new SqlConnection(conString);
            try
            {
                string sql = "INSERT INTO [dbo].[detailsQuinzaine] ([jour],[dateDuJour],[observation],[kilometre],[refQuinzaine])VALUES (@jour , @dateDuJour, NULL ,@km,@ref)";
                SqlCommand command = new SqlCommand(sql, con);
                command.Parameters.Add("@km", SqlDbType.Int).Value = kilometrage;
                command.Parameters.Add("@ref", SqlDbType.VarChar).Value = referanceQuinzaine;
                command.Parameters.Add("@jour", SqlDbType.VarChar).Value = jour;
                command.Parameters.Add("@dateDuJour", SqlDbType.DateTime).Value = dateDuJour;
                

                con.Open();
                int rows = command.ExecuteNonQuery();
                if (rows > 0)
                {
                    success = true;
                }
                else
                {
                    success = false;
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally { con.Close(); }
            return success;
        }
        public DataTable selectDetailsQuinzaines(string refQ)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(conString);
            try
            {

                String sql = " select kilometre , jour, dateDuJour from detailsQuinzaine where refQuinzaine=@ref";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@ref", SqlDbType.VarChar).Value = refQ;
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

    }
}
