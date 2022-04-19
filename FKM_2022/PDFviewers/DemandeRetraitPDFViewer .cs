using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FKM_2022.benifinciere.signlePageForms;
namespace FKM_2022.PDFviewers
{
    public partial class DemandeRetraitPDFViewer : Form
    {
        int code = demandeRetrait.getCodeforPDF;
        public DemandeRetraitPDFViewer()
        {
            InitializeComponent();
            affichepdf();
        }
        private void affichepdf()
        {
            bool res = false;
            System.Data.SqlClient.SqlConnection con = new SqlConnection("Data Source=DESKTOP-MOT8LB0;Initial Catalog=FKM;Integrated Security=True");
            con.Open();

            //MessageBox.Show(test);
            using (SqlCommand command = new SqlCommand("select Document from demandesRetrait where CodeDemande=" + code + "", con))
            {

                using (SqlDataReader Reader = command.ExecuteReader(CommandBehavior.Default))
                {
                    try
                    {
                        if (Reader.Read())
                        {

                            res = true;
                            byte[] filedata = (byte[])Reader.GetValue(0);
                            using (FileStream fs = new FileStream("test", FileMode.Create, FileAccess.ReadWrite))
                            {
                                using (BinaryWriter bw = new BinaryWriter(fs))
                                {
                                    bw.Write(filedata);
                                    bw.Close();
                                    axAcroPDF1.LoadFile("test");
                                }
                                File.Delete("test");
                            }

                        }
                        if (res == false)
                        {
                            MessageBox.Show("erreur", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        Reader.Close();
                    }
                    catch (System.InvalidCastException)
                    {
                        MessageBox.Show("pas de PDF pour cette demande ", "alert ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                con.Close();
            }
        }
    }
}
