using FKM_2022.referntiel;
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

namespace FKM_2022.PDF_viewers
{
    public partial class ContratPDFViewer : Form
    {

        int code = Contrat.CodeforPDF;
        public ContratPDFViewer()
        {
            InitializeComponent();
            affichepdf();
        }
        public void affichepdf()
        {
            bool res = false;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-MOT8LB0;Initial Catalog=FKM;Integrated Security=True");
            con.Open();
            bool result = false;
            string test = code.ToString();
            MessageBox.Show(test);
            using (SqlCommand command = new SqlCommand("select Documents from contratsVoitures where code="+code+"", con))
            {

                using (SqlDataReader Reader = command.ExecuteReader(CommandBehavior.Default))
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
                        }
                       
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
                  
    }
}
