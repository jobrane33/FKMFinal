using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FKM_2022.crudAlgoClasses
{
    internal class crudMethodes
    {
        public bool InsertCategorie( float tr,float tc, float te, float montantpret , string observation ,string libelle)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MOT8LB0;Initial Catalog=FKM;Integrated Security=True");
            try
            {
                // string sql = "execute ChercherNom @tr='"+tr+ "', @tc='" + tc + "' , @te= '" + te + "' ,@montantp='" + montantpret + "',@observation='" + observation + "',@libelle='" + libelle + "'";
                String sql = "INSERT INTO [dbo].[categories] VALUES('" + tr + "','" + tc + "','" + te + "','" + montantpret + "','" + observation + "','" + libelle + "')";
                SqlCommand command = new SqlCommand(sql, conn);
                
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
    }
}
