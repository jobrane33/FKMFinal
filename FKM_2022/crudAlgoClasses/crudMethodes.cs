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
    internal class crudMethodes
    {
        string conString = "Data Source=DESKTOP-MOT8LB0;Initial Catalog=FKM;Integrated Security=True";
        //insertion d'une categorie
        public bool InsertCategorie(float tr, float tc, float te, float montantpret, string observation, string libelle)
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
                ex.ToString();
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;

        }
        //missajour d'une categorie 
        public bool updateCategorie(int id, float tr, float tc, float te, float montantpret, string observation, string libelle)
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
                //MessageBox.Show(sql);
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
        //ajout personnels 
        public bool ajoutPersonnels(string matricule, string nom, string prenom, string compteFKM, string compteNote, string compteRemb, string comptecan, int codeTerr)
        {
            bool success = false;
            SqlConnection con = new SqlConnection(conString);
            try
            {
                string sql = "EXEC	ajoutPersonnls @matricule ='" + matricule + "' ,@nom = '" + nom + "',@prenom = '" + prenom +
                "',@compteFKM = '" + compteFKM + "',@comptenote = '" + compteNote +
                "',@compteRem = '" + compteRemb + "',@compteCang = '" + comptecan + "',@codeterr = " + codeTerr + "";
                SqlCommand command = new SqlCommand(sql, con);
                
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
        //archiver personnels
        public bool archiverPersonnel(string mat)
        {
            bool success = false;
            SqlConnection con = new SqlConnection(conString);
            try
            {
                string sql = "UPDATE [dbo].[personnels] SET archive = 0 WHERE  matricule='" + mat + "'";
                SqlCommand command = new SqlCommand(sql, con);
                //command.Parameters.AddWithValue("@mat", mat);

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
        public DataTable selectPersonnels(int archive )
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MOT8LB0;Initial Catalog=FKM;Integrated Security=True");
            try
            {

                String sql = "SELECT [matricule],[nom],[prenom],[compteFKM],[compteNote],[compteRemboursement],[compteCagnotte],[codeTerritoire],[designation] FROM [FKM].[dbo].[personnels] where [archive]="+archive+"";
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
        public bool updaterPersonnel(string matricule, string nom, string prenom, string compteFKM, string compteNote, string compteRemb, string comptecan, int codeTerr)
        {
            bool success = false;
            SqlConnection con = new SqlConnection(conString);
            try
            {
                string sql = "EXEC	[dbo].[updatePersonnel] @matricule = '" + matricule + "',@nom = '" + nom + "',@prenom = '" + prenom + "',@compteFKM = '" + compteFKM + "',@comptenote ='" + compteNote + "',@compteRem ='" + compteRemb + "',@compteCang ='" + comptecan + "',@codeterr = " + codeTerr + "";
                SqlCommand command = new SqlCommand(sql, con);
                
                con.Open();
               // MessageBox.Show(sql);
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
        public DataTable filtrePerso(string comboBoxvalue, string textBoxinput,int archive)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MOT8LB0;Initial Catalog=FKM;Integrated Security=True");
            try
            {

                String sql = "select [matricule],[nom],[prenom],[compteFKM],[compteNote],[compteRemboursement],[compteCagnotte],[codeTerritoire],[designation]from personnels where " + comboBoxvalue + " like '%" + textBoxinput + "%'  AND [archive]="+archive+"  ";
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
        public DataTable selectContrat()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(conString);
            try
            {

                String sql = "EXEC [dbo].[afficheContrat]";
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
        public bool ajoutContrat(string mat,int code )
        {
            bool success = false;
            SqlConnection con = new SqlConnection(conString);
            try
            {
                string sql = "EXEC	 [dbo].[stockcontrat] @mat = '"+mat+"', @codeCat = "+code+ ", @nomdoc = NUll";
                SqlCommand command = new SqlCommand(sql, con);
                //command.Parameters.AddWithValue("@mat", matricule);
                //command.Parameters.AddWithValue("@name", nom);
                //command.Parameters.AddWithValue("@secondname", prenom);
                //command.Parameters.AddWithValue("@cFKM", compteFKM);
                //command.Parameters.AddWithValue("@cnote", compteNote);
                //command.Parameters.AddWithValue("@crem", compteRemb);
                //command.Parameters.AddWithValue("@cCang", comptecan);
                //command.Parameters.AddWithValue("@codeTR", codeTerr);
                con.Open();
               // MessageBox.Show(sql);
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
        public bool updateContrat(string mat,int codecat)
        {
            bool success = false;
            SqlConnection con = new SqlConnection(conString);
            try
            {
                string sql = "EXEC	 [dbo].[updateContrat] @mat = '" + mat + "' ,@codeCat = " + codecat + " ,@nomdoc = NULL";
                SqlCommand command = new SqlCommand(sql, con);
                //command.Parameters.AddWithValue("@mat", mat);

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
        public bool deleteContrat(int code)
        {
            bool success = false;
            SqlConnection con = new SqlConnection(conString);
            try
            {
                string sql = "UPDATE contratsVoitures set actif=0 where code ="+code+"";
                SqlCommand command = new SqlCommand(sql, con);
                //command.Parameters.AddWithValue("@mat", mat);

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
        public bool ajouterTerritoire(string designation, string user_id)
        {
            bool success = false;
            user_id = "null";
            SqlConnection con = new SqlConnection(conString);
            try
            {
                string sql = "EXEC	 [dbo].[stockTerritoires]@designation = '"+designation+ "', @user =  " + user_id + "";
                SqlCommand command = new SqlCommand(sql, con);
                //command.Parameters.AddWithValue("@mat", matricule);
                //command.Parameters.AddWithValue("@name", nom);
                //command.Parameters.AddWithValue("@secondname", prenom);
                //command.Parameters.AddWithValue("@cFKM", compteFKM);
                //command.Parameters.AddWithValue("@cnote", compteNote);
                //command.Parameters.AddWithValue("@crem", compteRemb);
                //command.Parameters.AddWithValue("@cCang", comptecan);
                //command.Parameters.AddWithValue("@codeTR", codeTerr);
                con.Open();
                //MessageBox.Show(sql);
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
        public DataTable selectTerritoire()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(conString);
            try
            {

                String sql = "EXEC[dbo].[afficherTerritoires]";
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
        public bool updateTerritoires(int code, string newDesignation)
        {

            bool success = false;
            
            SqlConnection con = new SqlConnection(conString);
            try
            {
                string sql = "EXEC	 [dbo].[updateTerritoire] @code = "+code+ ", @newDesignation = '" + newDesignation + "'";

                SqlCommand command = new SqlCommand(sql, con);
                //command.Parameters.AddWithValue("@mat", matricule);
                //command.Parameters.AddWithValue("@name", nom);
                //command.Parameters.AddWithValue("@secondname", prenom);
                //command.Parameters.AddWithValue("@cFKM", compteFKM);
                //command.Parameters.AddWithValue("@cnote", compteNote);
                //command.Parameters.AddWithValue("@crem", compteRemb);
                //command.Parameters.AddWithValue("@cCang", comptecan);
                //command.Parameters.AddWithValue("@codeTR", codeTerr);
                con.Open();
                //MessageBox.Show(sql);
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

    }
}
