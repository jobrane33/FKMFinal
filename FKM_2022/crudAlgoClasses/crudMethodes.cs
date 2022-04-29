using FKM_2022.referntiel;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
namespace FKM_2022.crudAlgoClasses
{
    internal class crudMethodes
    {
        string nomPrenom = connection.getNomPrenom;
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
                Console.WriteLine(sql);
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
        public bool ajoutPersonnels(string matricule, string nom, string prenom, string compteFKM, string compteNote, string compteRemb, string comptecan, int codeTerr, string matSuperieur, string agent)
        {
            bool success = false;
            SqlConnection con = new SqlConnection(conString);
            try
            {
                string sql = "EXEC	ajoutPersonnls @matricule ='" + matricule + "' ,@nom = '" + nom + "',@prenom = '" + prenom +
                "',@compteFKM = '" + compteFKM + "',@comptenote = '" + compteNote +
                "',@compteRem = '" + compteRemb + "',@compteCang = '" + comptecan + "',@codeterr = " + codeTerr + ",@matAgent='" + matSuperieur + "',@matSup= '" + agent + "'";
                SqlCommand command = new SqlCommand(sql, con);
                MessageBox.Show(sql);
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
                string sql = "exec  ArchivePerso '" + mat + "'";
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
        public DataTable selectPersonnels(int archive)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(conString);
            try
            {

                String sql = "SELECT [matricule],[nom],[prenom],[compteFKM],[compteNote],[compteRemboursement],[compteCagnotte],[codeTerritoire],[designation] FROM [FKM].[dbo].[personnels] where [archive]=" + archive + "";
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
        public DataTable filtrePerso(string comboBoxvalue, string textBoxinput, int archive)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(conString);
            try
            {

                String sql = "select [matricule],[nom],[prenom],[compteFKM],[compteNote],[compteRemboursement],[compteCagnotte],[codeTerritoire],[designation]from personnels where " + comboBoxvalue + " like '%" + textBoxinput + "%'  AND [archive]=" + archive + "  ";
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
        public DataTable selectContrat(int archive)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(conString);
            try
            {

                String sql = "EXEC [dbo].[afficheContrat] @actif = " + archive + "";
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
        public bool ajoutContrat(string mat, int code, string Fname)
        {
            try
            {
                bool success = false;
                MessageBox.Show(nomPrenom);
                SqlConnection con = new SqlConnection(conString);
                FileStream fStream = File.OpenRead(Fname);
                byte[] contents = new byte[fStream.Length];
                fStream.Read(contents, 0, (int)fStream.Length);
                fStream.Close();
                try
                {
                    string sql = "EXEC	 [dbo].[stockcontrat] @mat = '" + mat + "', @codeCat = " + code + ", @nomdoc = @content, @user = '" + nomPrenom + "' ";
                    SqlCommand command = new SqlCommand(sql, con);
                    command.Parameters.AddWithValue("@content", contents);
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
                MessageBox.Show("ajoutez un document", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool updateContrat(string mat, int codecat, string Fname)
        {
            bool success = false;
            SqlConnection con = new SqlConnection(conString);
            FileStream fStream = File.OpenRead(Fname);
            byte[] contents = new byte[fStream.Length];
            fStream.Read(contents, 0, (int)fStream.Length);
            fStream.Close();
            try
            {
                string sql = "EXEC	 [dbo].[updateContrat] @mat = '" + mat + "' ,@codeCat = " + codecat + " ,@nomdoc = @content";
                SqlCommand command = new SqlCommand(sql, con);
                command.Parameters.AddWithValue("@content", contents);

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
                string sql = "UPDATE contratsVoitures set actif=0 where code =" + code + "";
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
                string sql = "EXEC	 [dbo].[stockTerritoires]@designation = '" + designation + "', @user =  " + user_id + "";
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
                string sql = "EXEC	 [dbo].[updateTerritoire] @code = " + code + ", @newDesignation = '" + newDesignation + "'";

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
        public void telechargerPDF(string file, int code)
        {

            bool res = false;
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            using (SqlCommand command = new SqlCommand("select Documents from contratsVoitures where code=@id", con))
            {
                command.Parameters.AddWithValue("@id", code);
                using (SqlDataReader Reader = command.ExecuteReader(CommandBehavior.Default))
                {
                    if (Reader.Read())
                    {
                        res = true;
                        byte[] filedata = (byte[])Reader.GetValue(0);
                        using (FileStream fs = new FileStream(file, FileMode.Create, FileAccess.ReadWrite))
                        {
                            using (BinaryWriter bw = new BinaryWriter(fs))
                            {
                                bw.Write(filedata);
                                bw.Close();
                            }
                        }
                        MessageBox.Show("done", "done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (res == false)
                    {
                        MessageBox.Show("erreur", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Reader.Close();
                }
                con.Close();
            }
            //Response.Clear();

        }
        public DataTable filtreContrat(string comboBoxvalue, string textBoxinput, int archive)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(conString);
            try
            {

                String sql = "select code , Libelle , matricule, concat(Personnel_Matricule ,'  ' ,'  ' ,nom ,'  ' ,'  ', prenom ) as Personnel, libelle_categorie  from  contratsVoitures c " +
                    ", personnels p where p.matricule=c.Personnel_Matricule and Actif=" + archive + " and " + comboBoxvalue + " like '%" + textBoxinput + "%'";
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
        public DataTable selectVehicule()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(conString);
            try
            {

                String sql = "EXEC [dbo].[afficheVehicule]";
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
        public bool ajoutVehicule(DateTime DateAchat, string montantPret, string Immatriculation, string Puissance, string Marque, DateTime DateMiseEnCirculation, string MontantAchat,
            int codeContratint, string ValeurInitKilometrage, DateTime DatetMiseEnExploitation, string Modele, DateTime DatetMiseHorsExploitation, string Fname)
        {
            try
            {
                FileStream fStream = File.OpenRead(Fname);
                byte[] contents = new byte[fStream.Length];
                fStream.Read(contents, 0, (int)fStream.Length);
                fStream.Close();
                bool result = false;
                string connectionString = "Data Source=DESKTOP-MOT8LB0;Initial Catalog=FKM;Integrated Security=True";
                string query = "EXEC[dbo].[stockVehicule]@montantPret = @mp ,@Immatriculation = @mat ,@DateAchat = @dateA,@Puissance = @chv" +
                    " ,@actif = 1,@Statut ='actif' ,@Marque = @mar,@DateMiseEnCirculation = @dateC,@MontantAchat = @ma,@Contrat_Code = @code" +
                    ",@ValeurInitKilometrage = @km,@Documents = @doc,@DatetMiseEnExploitation = @dateM,@DatetMiseHorsExploitation = @dateMH ,@Modele = @mode";

                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@dateA", SqlDbType.Date).Value = DateAchat;
                    cmd.Parameters.Add("@mp", SqlDbType.Decimal).Value = montantPret;
                    cmd.Parameters.Add("@mat", SqlDbType.VarChar).Value = Immatriculation;
                    cmd.Parameters.Add("@chv", SqlDbType.Int).Value = Puissance;
                    cmd.Parameters.Add("@mar", SqlDbType.VarChar).Value = Marque;
                    cmd.Parameters.Add("@dateC", SqlDbType.Date).Value = DateMiseEnCirculation;
                    cmd.Parameters.Add("@ma", SqlDbType.Decimal).Value = MontantAchat;
                    cmd.Parameters.AddWithValue("@code", codeContratint);
                    cmd.Parameters.Add("@km", SqlDbType.Decimal).Value = ValeurInitKilometrage;
                    cmd.Parameters.Add("@dateM", SqlDbType.Date).Value = DatetMiseEnExploitation;
                    cmd.Parameters.Add("@mode", SqlDbType.VarChar).Value = Modele;
                    cmd.Parameters.Add("@dateMH", SqlDbType.Date).Value = DatetMiseHorsExploitation;
                    cmd.Parameters.Add("@doc", SqlDbType.VarBinary).Value = contents;
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    if (rows > 0)
                    {
                        result = true;
                    }
                    return result;
                }
            }
            catch (System.ArgumentException ex)
            {
                ex.ToString();
                MessageBox.Show("vous devaiz abouter un document PDF de la voiture ", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public void telechargerPDFVehicule(string file, int code)
        {

            bool res = false;
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            using (SqlCommand command = new SqlCommand("select documents from Vehicule where code =@id", con))
            {
                command.Parameters.AddWithValue("@id", code);
                using (SqlDataReader Reader = command.ExecuteReader(CommandBehavior.Default))
                {
                    if (Reader.Read())
                    {
                        res = true;
                        byte[] filedata = (byte[])Reader.GetValue(0);
                        using (FileStream fs = new FileStream(file, FileMode.Create, FileAccess.ReadWrite))
                        {
                            using (BinaryWriter bw = new BinaryWriter(fs))
                            {
                                bw.Write(filedata);
                                bw.Close();
                            }
                        }
                        MessageBox.Show("done", "done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (res == false)
                    {
                        MessageBox.Show("erreur", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Reader.Close();
                }
                con.Close();
            }

        }
        public bool archiveVehicule(int code)
        {
            bool success = false;

            SqlConnection con = new SqlConnection(conString);
            try
            {
                string sql = "EXEC	 [dbo].[archiveVehicule] @code = @var";

                SqlCommand command = new SqlCommand(sql, con);
                command.Parameters.AddWithValue("@var", code);

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

        public bool ajoutJour(string jour,string date,string observation)
        {
            bool success = false;

            SqlConnection con = new SqlConnection(conString);
            try
            {
                string sql = "exec AjoutJour @date, @observation ,@NomJour";

                SqlCommand command = new SqlCommand(sql, con);
                command.Parameters.Add("@date", SqlDbType.Date).Value = date;
                command.Parameters.Add("@observation", SqlDbType.VarChar).Value = observation;
                command.Parameters.Add("@NomJour", SqlDbType.VarChar).Value = jour;
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
        public DataTable selectJoursFerier()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(conString);
            try
            {

                String sql = "select* from joursFeriers where year(dateJourFerier)="+DateTime.Now.Year.ToString();
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
    }
}
