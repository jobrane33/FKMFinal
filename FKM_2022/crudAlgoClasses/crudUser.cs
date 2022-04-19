using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FKM_2022.crudAlgoClasses
{
    internal class crudUser
    {
        private string conString = "Data Source=DESKTOP-MOT8LB0;Initial Catalog=FKM;Integrated Security=True";
        public bool ajoutQuinzaine(string refQuinzaine, int sommeKM, string matricule, string userREC)
        {
            bool success = false;
            SqlConnection con = new SqlConnection(conString);
            try
            {
                string sql = "EXEC	[dbo].[stockQuinzaine]@referanceQuinzaine = @refQ ,@sommeKilometresQuinzaine=@sommekm , @matriculePerso =@mat ,@user = @userRec";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@refQ", SqlDbType.VarChar).Value = refQuinzaine;
                cmd.Parameters.Add("@sommekm", SqlDbType.Int).Value = sommeKM;
                cmd.Parameters.Add("@mat", SqlDbType.NVarChar).Value = matricule;
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
                string sql = "update Quinzaines set valide=1 , dateValidation=getdate() where referanceQuinzaine=@refQ";
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
        public String selectallQuinzaines(string referanceQuinzaine)
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
            catch (System.IndexOutOfRangeException)
            {
                //MessageBox.Show("quinzaine pas encore saisie", "verifiez", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }
        public bool stockKilometrages(int kilometrage, string referanceQuinzaine, string jour, DateTime dateDuJour)
        {
            bool success = false;
            SqlConnection con = new SqlConnection(conString);
            try
            {
                string sql = "INSERT INTO [dbo].[detailsQuinzaine] ([jour],[dateDesJours],[observation],[kilometre],[refQuinzaine])VALUES (@jour , @dateDuJour, NULL ,@km,@ref)";
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

                String sql = " select kilometre , jour, dateDesJours from detailsQuinzaine where refQuinzaine=@ref";
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
        public bool reinitialiserQuinzaine(string referanceQuinzaine)
        {
            bool success = false;
            SqlConnection con = new SqlConnection(conString);
            try
            {
                string sql = "delete from Quinzaines where referanceQuinzaine=@ref";
                SqlCommand command = new SqlCommand(sql, con);
                command.Parameters.Add("@ref", SqlDbType.VarChar).Value = referanceQuinzaine;
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
        public bool reinitialiserDetailsQuinzaine(string referanceQuinzaine)
        {
            bool success = false;
            SqlConnection con = new SqlConnection(conString);
            try
            {
                string sql = "delete from detailsQuinzaine where refQuinzaine=@ref";
                SqlCommand command = new SqlCommand(sql, con);
                command.Parameters.Add("@ref", SqlDbType.VarChar).Value = referanceQuinzaine;
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
        public DataTable selectQuinzaines(string matricule)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(conString);
            try
            {

                String sql = "  select  referanceQuinzaine , sommeKilometresQuinzaine ,matriculePerso , NouvelIndex ,ancienIndex,status , (select CONCAT(nom, ' ',prenom ,' ' , matricule) from personnels where matricule=@mat) as perso from Quinzaines where matriculePerso = @mat  and valide=1";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@mat", SqlDbType.VarChar).Value = matricule;
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
        public DataTable selectQuinzainesAvalider(string matricule)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(conString);
            try
            {
                

                String sql = "select referanceQuinzaine , NbreKilometreSociete , sommeKilometresQuinzaine,NouvelIndex, ancienIndex  from Quinzaines where SuperieurhearchiqueDevalidation =@mat and validationSupperieur=0 and valide=1";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@mat", SqlDbType.NVarChar).Value = matricule;
                //MessageBox.Show(sql);
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
        public bool validationSuperieurHearchique(string referanceQuinzaine)
        {
            bool success = false;
            SqlConnection con = new SqlConnection(conString);
            try
            {
                string sql = " EXEC ValidationSupHerarchique @ref";
                SqlCommand command = new SqlCommand(sql, con);
                command.Parameters.Add("@ref", SqlDbType.VarChar).Value = referanceQuinzaine;
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
        public String selectLastValidatedQuinzaines(string matricule)
        {
            try
            {
                string sql = "select top (1) referanceQuinzaine from Quinzaines where matriculePerso=@mat and valide=1 order by codeBonPayer desc";
                SqlConnection con = new SqlConnection(conString); // making connection
                SqlCommand command = new SqlCommand(sql, con);
                command.Parameters.Add("@mat", SqlDbType.VarChar).Value = matricule;
                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataTable dt = new DataTable(); //this is creating a virtual table  
                sda.Fill(dt);
                return dt.Rows[0][0].ToString();
            }
            catch (System.IndexOutOfRangeException)
            {
                return "0";
            }
        }
        public bool rejectQunzaineSup(string referanceQuinzaine)
        {
            bool success = false;
            SqlConnection con = new SqlConnection(conString);
            try
            {
                string sql = "EXEC	[dbo].[refuserQunzaine] @ref ='"+referanceQuinzaine+"'";
                MessageBox.Show(sql);
                SqlCommand command = new SqlCommand(sql, con);
                command.Parameters.Add("@reference", SqlDbType.VarChar).Value = referanceQuinzaine;
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
        public bool ajouterDemandeRetrait(float Montant , string fileName, string obsevation , string typeRetrait, string personnel_matricule, string user)
        {
            try
            {
                bool success = false;
                SqlConnection con = new SqlConnection(conString);
                FileStream fStream = File.OpenRead(fileName);
                byte[] contents = new byte[fStream.Length];
                fStream.Read(contents, 0, (int)fStream.Length);
                fStream.Close();
                try
                {
                    string sql = "EXEC	[dbo].[ajoutDemandes] @montantDemander = @montant, @document =@content , @observation = @observation , @typeDeRetrait = @typeDeRetrait, @personnel_mat = @mat, @user = @user";
                    SqlCommand command = new SqlCommand(sql, con);
                    command.Parameters.AddWithValue("@content", contents);
                    command.Parameters.Add("@montant", SqlDbType.Float).Value = Montant;
                    command.Parameters.Add("@observation", SqlDbType.VarChar).Value = obsevation;
                    command.Parameters.Add("@typeDeRetrait", SqlDbType.VarChar).Value = typeRetrait;
                    command.Parameters.Add("@mat", SqlDbType.NVarChar).Value = personnel_matricule;
                    command.Parameters.Add("@user", SqlDbType.VarChar).Value = user;
                    con.Open();
                    MessageBox.Show(sql);
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
            catch (System.ArgumentException)
            {
                bool success = false;
                SqlConnection con = new SqlConnection(conString);
                try
                {
                    string sql = "EXEC	[dbo].[ajoutDemandes] @montantDemander = @montant, @document =null , @observation = @observation , @typeDeRetrait = @typeDeRetrait, @personnel_mat = @mat, @user = @user";
                    SqlCommand command = new SqlCommand(sql, con);
                    //command.Parameters.AddWithValue("@content", contents);
                    command.Parameters.Add("@montant", SqlDbType.Float).Value = Montant;
                    command.Parameters.Add("@observation", SqlDbType.VarChar).Value = obsevation;
                    command.Parameters.Add("@typeDeRetrait", SqlDbType.VarChar).Value = typeRetrait;
                    command.Parameters.Add("@mat", SqlDbType.NVarChar).Value = personnel_matricule;
                    command.Parameters.Add("@user", SqlDbType.VarChar).Value = user;
                    con.Open();
                    MessageBox.Show(sql);
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
        public DataTable afficheDemandes(string user)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(conString);
            try
            {


                String sql = "select CodeDemande , cast(Montant as decimal(10,3)) as Montant " +
                    ",demandeur , observation ,recDateCreation,Status from demandesRetrait where Actif=1 and recUser= @user";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@user", SqlDbType.NVarChar).Value = user;
                //MessageBox.Show(sql);
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
        public DataTable filtrageDemandesRetrait( string user , string matricule )
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(conString);
            try
            {


                String sql = "select CodeDemande , cast(Montant as decimal(10,3)) as Montant " +
                    ",demandeur , observation ,recDateCreation,Status from demandesRetrait where Actif=1 and recUser= @user and Personnel_matricule like '%"+matricule+"%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@user", SqlDbType.NVarChar).Value = user;
                //cmd.Parameters.Add("@mat", SqlDbType.NVarChar).Value = matricule;
                //MessageBox.Show(sql);
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
        public bool archiveDelamandeRetrait(string code)
        {

            bool success = false;
            SqlConnection con = new SqlConnection(conString);
            try
            {
                string sql = "update demandesRetrait set Actif = 0 where CodeDemande ="+code+"";
                MessageBox.Show(sql);
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
        //update demandesRetrait set Actif = 0 where CodeDemande =
        public DataTable afficheDemandesAdmin()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(conString);
            try
            {


                String sql = "select CodeDemande , cast(Montant as decimal(10,3)) as Montant ,demandeur , observation ,recDateCreation,Status from demandesRetrait order by recDateCreation desc";
                SqlCommand cmd = new SqlCommand(sql, conn);
                //MessageBox.Show(sql);
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
        public DataTable DemandesAvaliderAdmin(string matricule)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(conString);
            try
            {

                String sql = "select CodeDemande ,cast(Montant as decimal(10,3)) as Montant, demandeur , Status , typeRetrait , recDateCreation , observation from demandesRetrait where suphearchique=@mat ";
                // MessageBox.Show(sql);
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.Parameters.Add("@mat", SqlDbType.VarChar).Value = matricule;
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
        public DataTable filtrageDemandesRetraitAdmin(string matricule)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(conString);
            try
            {


                String sql = "select CodeDemande , cast(Montant as decimal(10,3)) as Montant ,demandeur , observation ,recDateCreation,Status from demandesRetrait where Actif=1 and Personnel_matricule=@mat";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@mat", SqlDbType.NVarChar).Value = matricule;
                //cmd.Parameters.Add("@mat", SqlDbType.NVarChar).Value = matricule;
                //MessageBox.Show(sql);
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
        public DataTable selectConsultationAdminQunzaine()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(conString);
            try
            {


                String sql = "select* from Quinzaines";
                SqlCommand cmd = new SqlCommand(sql, conn);
                //cmd.Parameters.Add("@mat", SqlDbType.NVarChar).Value = matricule;
                //MessageBox.Show(sql);
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



