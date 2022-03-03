using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace FKM_2022.crudAlgoClasses
{
    internal class crudMethodes
    {
        string conString = "Data Source=DESKTOP-MOT8LB0;Initial Catalog=FKM;Integrated Security=True";
        public bool InsertCategorie( float tr,float tc, float te, float montantpret , string observation ,string libelle)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(conString);
            try
            {
                // string sql = "execute ChercherNom @tr='"+tr+ "', @tc='" + tc + "' , @te= '" + te + "' ,@montantp='" + montantpret + "',@observation='" + observation + "',@libelle='" + libelle + "'";
                String sql = "INSERT INTO [dbo].[categories] VALUES(" + tr + "," + tc + "," + te + "," + montantpret + ",'" + observation + "','" + libelle + "',1)";
                SqlCommand command = new SqlCommand(sql, conn);
                //Console.WriteLine(sql);
                //MessageBox.Show(sql);
                conn.Open();
                int rows = command.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;

        }
        public bool updateCategorie (int id ,float tr,float tc, float te, float montantpret, string observation,string libelle)
        {
            bool success = false;
            SqlConnection con = new SqlConnection(conString);
            try
            {
                string sql = "update [dbo].[categories] set taux_reparation=@tr , taux_cagnotte=@tc ,taux_essance=@te, montant_pret=@montantpret ,observation=@observation,libelle=@libelle where code=@id";
                SqlCommand command = new SqlCommand(sql, con);
                command.Parameters.AddWithValue("@tr", tr);
                command.Parameters.AddWithValue("@tc", tc);
                command.Parameters.AddWithValue("@te", te);
                command.Parameters.AddWithValue("@montantpret", montantpret);
                command.Parameters.AddWithValue("@observation", observation);
                command.Parameters.AddWithValue("@libelle", libelle);
                command.Parameters.AddWithValue("@id", id);
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
            catch(Exception ex)
            {
               ex.ToString();
            }
            finally { con.Close(); }
            return success;
        }
    }
}
