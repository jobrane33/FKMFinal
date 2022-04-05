using FKM_2022.exploitation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FKM_2022.referntiel
{
    public partial class Home : Form
    {   connection con= new connection();
        string type = connection.gettypeuser;
        string nomPrenom = connection.getNomPrenom;
        public Home()
        {
            InitializeComponent();
            CustomeDisigne();
            fullScreen();
            openSildperso(new PersoFrom());
            userInterfaceSittings();
            button2.BackColor = System.Drawing.SystemColors.ControlDark;
            label1.Text = "utilisateur "+nomPrenom +" date et temps du connection " + DateTime.Now.ToString("h:mm:ss tt"); 
        }
        public void userInterfaceSittings()
        {
            
            if (type.Equals("superieur herchique"))
            {
                this.button1.Hide();
                openSildperso(new ValidationQuanzaine());
            }
            
            
        }
        public void openSildperso(object Form)
        {
            if (this.childPanel.Controls.Count > 0)
            {
                this.childPanel.Controls.RemoveAt(0);
            }
                Form f = Form as Form;
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.childPanel.Controls.Add(f);
                this.childPanel.Tag = f;
                f.Show();
            
        }
        public void fullScreen()
        {
            //int w = Screen.PrimaryScreen.Bounds.Width;
            //int h= Screen.PrimaryScreen.Bounds.Height;
            //this.Location = new Point(0, 0);
            //this.Size = new Size(w, h);
            //this.fullScreen();
            WindowState = FormWindowState.Maximized;
        }
        public void CustomeDisigne()
        {
            refpanel.Visible = false;
            Explpanel.Visible = false;

        }
        public void hidepannelRef()
        {
            if (refpanel.Visible)
            {
                refpanel.Visible=false;
            }
            
        }
        public void showmenueRef()
        {
            if (refpanel.Visible == false)
            {
                hidepannelRef();
                refpanel.Visible=true;
                

            }
            else
            {
                refpanel.Visible=false;
                Explpanel.Visible= false;
            }
        }
        public void hideMenueExp()
        {
            if (Explpanel.Visible)
            {
                Explpanel.Visible = false;
            }
        }
        public void showMenueExp()
        {
            if (Explpanel.Visible == false)
            {
                hideMenueExp();
                Explpanel.Visible = true;
            }
            else
            {
                Explpanel.Visible = false;
            }
            }
       
        private void Personnel_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(sidepanel.Visible == false)
            {
                sidepanel.Visible=true;
            }
            else
            {
                sidepanel.Visible=false;
                panel3.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showmenueRef();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openSildperso(new PersoFrom());
            button2.BackColor = System.Drawing.SystemColors.ControlDark;
            button3.BackColor = System.Drawing.SystemColors.Window;
            button4.BackColor = System.Drawing.SystemColors.Window;
            button5.BackColor = System.Drawing.SystemColors.Window;
            button6.BackColor = System.Drawing.SystemColors.Window;
            button7.BackColor = System.Drawing.SystemColors.Window;
            button8.BackColor = System.Drawing.SystemColors.Window;
            button9.BackColor = System.Drawing.SystemColors.Window;
            button9.BackColor = System.Drawing.SystemColors.Window;
            button11.BackColor = System.Drawing.SystemColors.Window;
            button12.BackColor = System.Drawing.SystemColors.Window;
            button13.BackColor = System.Drawing.SystemColors.Window;
            button14.BackColor = System.Drawing.SystemColors.Window;
            button15.BackColor = System.Drawing.SystemColors.Window;
            button16.BackColor = System.Drawing.SystemColors.Window;
            button17.BackColor = System.Drawing.SystemColors.Window;
            button18.BackColor = System.Drawing.SystemColors.Window;
            button19.BackColor = System.Drawing.SystemColors.Window;
            


        }

        private void button8_Click(object sender, EventArgs e)
        {
            openSildperso(new Service());
            button8.BackColor = System.Drawing.SystemColors.ControlDark;
            button2.BackColor = System.Drawing.SystemColors.Window;
            button4.BackColor = System.Drawing.SystemColors.Window;
            button3.BackColor = System.Drawing.SystemColors.Window;
            button6.BackColor = System.Drawing.SystemColors.Window;
            button7.BackColor = System.Drawing.SystemColors.Window;
            button5.BackColor = System.Drawing.SystemColors.Window;
            button5.BackColor = System.Drawing.SystemColors.Window;
            button9.BackColor = System.Drawing.SystemColors.Window;
            button9.BackColor = System.Drawing.SystemColors.Window;
            button11.BackColor = System.Drawing.SystemColors.Window;
            button12.BackColor = System.Drawing.SystemColors.Window;
            button13.BackColor = System.Drawing.SystemColors.Window;
            button14.BackColor = System.Drawing.SystemColors.Window;
            button15.BackColor = System.Drawing.SystemColors.Window;
            button16.BackColor = System.Drawing.SystemColors.Window;
            button17.BackColor = System.Drawing.SystemColors.Window;
            button18.BackColor = System.Drawing.SystemColors.Window;
            button19.BackColor = System.Drawing.SystemColors.Window;
            button10.BackColor = System.Drawing.SystemColors.Window;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            openSildperso(new ValidationQuanzaine());
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            showMenueExp();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void themesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void sombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sidepanel.BackColor == Color.WhiteSmoke)
            {
                sidepanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            }
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sidepanel.BackColor == System.Drawing.SystemColors.ControlDarkDark)
            {
                sidepanel.BackColor = Color.WhiteSmoke;
                childPanel.BackColor = Color.WhiteSmoke;
                //IEnumerable<Button> c = null;
                //foreach (Button b in c)
                //{
                    //b.BackColor = System.Drawing.SystemColors.ControlDarkDark;
               // }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openSildperso(new Contrat());
            button3.BackColor = System.Drawing.SystemColors.ControlDark;
            button2.BackColor = System.Drawing.SystemColors.Window;
            button4.BackColor = System.Drawing.SystemColors.Window;
            button5.BackColor = System.Drawing.SystemColors.Window;
            button6.BackColor = System.Drawing.SystemColors.Window;
            button7.BackColor = System.Drawing.SystemColors.Window;
            button8.BackColor = System.Drawing.SystemColors.Window;
            button9.BackColor = System.Drawing.SystemColors.Window;
            button9.BackColor = System.Drawing.SystemColors.Window;
            button11.BackColor = System.Drawing.SystemColors.Window;
            button12.BackColor = System.Drawing.SystemColors.Window;
            button13.BackColor = System.Drawing.SystemColors.Window;
            button14.BackColor = System.Drawing.SystemColors.Window;
            button15.BackColor = System.Drawing.SystemColors.Window;
            button16.BackColor = System.Drawing.SystemColors.Window;
            button17.BackColor = System.Drawing.SystemColors.Window;
            button18.BackColor = System.Drawing.SystemColors.Window;
            button19.BackColor = System.Drawing.SystemColors.Window;
            button10.BackColor = System.Drawing.SystemColors.Window;



        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            openSildperso(new Vehicule());
            button4.BackColor = System.Drawing.SystemColors.ControlDark;
            button2.BackColor = System.Drawing.SystemColors.Window;
            button3.BackColor = System.Drawing.SystemColors.Window;
            button5.BackColor = System.Drawing.SystemColors.Window;
            button6.BackColor = System.Drawing.SystemColors.Window;
            button7.BackColor = System.Drawing.SystemColors.Window;
            button8.BackColor = System.Drawing.SystemColors.Window;
            button9.BackColor = System.Drawing.SystemColors.Window;
            button9.BackColor = System.Drawing.SystemColors.Window;
            button11.BackColor = System.Drawing.SystemColors.Window;
            button12.BackColor = System.Drawing.SystemColors.Window;
            button13.BackColor = System.Drawing.SystemColors.Window;
            button14.BackColor = System.Drawing.SystemColors.Window;
            button15.BackColor = System.Drawing.SystemColors.Window;
            button16.BackColor = System.Drawing.SystemColors.Window;
            button17.BackColor = System.Drawing.SystemColors.Window;
            button18.BackColor = System.Drawing.SystemColors.Window;
            button19.BackColor = System.Drawing.SystemColors.Window;
            button10.BackColor = System.Drawing.SystemColors.Window;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            openSildperso(new BureauPayeur());
            button5.BackColor = System.Drawing.SystemColors.ControlDark;
            button2.BackColor = System.Drawing.SystemColors.Window;
            button4.BackColor = System.Drawing.SystemColors.Window;
            button3.BackColor = System.Drawing.SystemColors.Window;
            button6.BackColor = System.Drawing.SystemColors.Window;
            button7.BackColor = System.Drawing.SystemColors.Window;
            button8.BackColor = System.Drawing.SystemColors.Window;
            button9.BackColor = System.Drawing.SystemColors.Window;
            button9.BackColor = System.Drawing.SystemColors.Window;
            button11.BackColor = System.Drawing.SystemColors.Window;
            button12.BackColor = System.Drawing.SystemColors.Window;
            button13.BackColor = System.Drawing.SystemColors.Window;
            button14.BackColor = System.Drawing.SystemColors.Window;
            button15.BackColor = System.Drawing.SystemColors.Window;
            button16.BackColor = System.Drawing.SystemColors.Window;
            button17.BackColor = System.Drawing.SystemColors.Window;
            button18.BackColor = System.Drawing.SystemColors.Window;
            button19.BackColor = System.Drawing.SystemColors.Window;
            button10.BackColor = System.Drawing.SystemColors.Window;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            openSildperso(new JoursFériers());
            button6.BackColor = System.Drawing.SystemColors.ControlDark;
            button2.BackColor = System.Drawing.SystemColors.Window;
            button4.BackColor = System.Drawing.SystemColors.Window;
            button5.BackColor = System.Drawing.SystemColors.Window;
            button3.BackColor = System.Drawing.SystemColors.Window;
            button7.BackColor = System.Drawing.SystemColors.Window;
            button8.BackColor = System.Drawing.SystemColors.Window;
            button9.BackColor = System.Drawing.SystemColors.Window;
            button9.BackColor = System.Drawing.SystemColors.Window;
            button11.BackColor = System.Drawing.SystemColors.Window;
            button12.BackColor = System.Drawing.SystemColors.Window;
            button13.BackColor = System.Drawing.SystemColors.Window;
            button14.BackColor = System.Drawing.SystemColors.Window;
            button15.BackColor = System.Drawing.SystemColors.Window;
            button16.BackColor = System.Drawing.SystemColors.Window;
            button17.BackColor = System.Drawing.SystemColors.Window;
            button18.BackColor = System.Drawing.SystemColors.Window;
            button19.BackColor = System.Drawing.SystemColors.Window;
            button10.BackColor = System.Drawing.SystemColors.Window;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openSildperso(new CategoriePret());
            button7.BackColor = System.Drawing.SystemColors.ControlDark;
            button2.BackColor = System.Drawing.SystemColors.Window;
            button4.BackColor = System.Drawing.SystemColors.Window;
            button5.BackColor = System.Drawing.SystemColors.Window;
            button6.BackColor = System.Drawing.SystemColors.Window;
            button3.BackColor = System.Drawing.SystemColors.Window;
            button8.BackColor = System.Drawing.SystemColors.Window;
            button9.BackColor = System.Drawing.SystemColors.Window;
            button9.BackColor = System.Drawing.SystemColors.Window;
            button11.BackColor = System.Drawing.SystemColors.Window;
            button12.BackColor = System.Drawing.SystemColors.Window;
            button13.BackColor = System.Drawing.SystemColors.Window;
            button14.BackColor = System.Drawing.SystemColors.Window;
            button15.BackColor = System.Drawing.SystemColors.Window;
            button16.BackColor = System.Drawing.SystemColors.Window;
            button17.BackColor = System.Drawing.SystemColors.Window;
            button18.BackColor = System.Drawing.SystemColors.Window;
            button19.BackColor = System.Drawing.SystemColors.Window;
            button10.BackColor = System.Drawing.SystemColors.Window;
        }

        private void sidepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            openSildperso(new ValidationQuanzaineSuperieur());
            button10.BackColor = System.Drawing.SystemColors.ControlDark;
            button2.BackColor = System.Drawing.SystemColors.Window;
            button4.BackColor = System.Drawing.SystemColors.Window;
            button5.BackColor = System.Drawing.SystemColors.Window;
            button6.BackColor = System.Drawing.SystemColors.Window;
            button7.BackColor = System.Drawing.SystemColors.Window;
            button8.BackColor = System.Drawing.SystemColors.Window;
            button9.BackColor = System.Drawing.SystemColors.Window;
            button9.BackColor = System.Drawing.SystemColors.Window;
            button3.BackColor = System.Drawing.SystemColors.Window;
            button11.BackColor = System.Drawing.SystemColors.Window;
            button12.BackColor = System.Drawing.SystemColors.Window;
            button13.BackColor = System.Drawing.SystemColors.Window;
            button14.BackColor = System.Drawing.SystemColors.Window;
            button15.BackColor = System.Drawing.SystemColors.Window;
            button16.BackColor = System.Drawing.SystemColors.Window;
            button17.BackColor = System.Drawing.SystemColors.Window;
            button18.BackColor = System.Drawing.SystemColors.Window;
            button19.BackColor = System.Drawing.SystemColors.Window;
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            openSildperso(new ConsultationQuanzaine());
            button11.BackColor = System.Drawing.SystemColors.ControlDark;
            button2.BackColor = System.Drawing.SystemColors.Window;
            button4.BackColor = System.Drawing.SystemColors.Window;
            button3.BackColor = System.Drawing.SystemColors.Window;
            button6.BackColor = System.Drawing.SystemColors.Window;
            button7.BackColor = System.Drawing.SystemColors.Window;
            button8.BackColor = System.Drawing.SystemColors.Window;
            button9.BackColor = System.Drawing.SystemColors.Window;
            button9.BackColor = System.Drawing.SystemColors.Window;
            button5.BackColor = System.Drawing.SystemColors.Window;
            button12.BackColor = System.Drawing.SystemColors.Window;
            button13.BackColor = System.Drawing.SystemColors.Window;
            button14.BackColor = System.Drawing.SystemColors.Window;
            button15.BackColor = System.Drawing.SystemColors.Window;
            button16.BackColor = System.Drawing.SystemColors.Window;
            button17.BackColor = System.Drawing.SystemColors.Window;
            button18.BackColor = System.Drawing.SystemColors.Window;
            button19.BackColor = System.Drawing.SystemColors.Window;
            button10.BackColor = System.Drawing.SystemColors.Window;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            openSildperso(new Comptabilité());
            button12.BackColor = System.Drawing.SystemColors.ControlDark;
            button2.BackColor = System.Drawing.SystemColors.Window;
            button4.BackColor = System.Drawing.SystemColors.Window;
            button3.BackColor = System.Drawing.SystemColors.Window;
            button6.BackColor = System.Drawing.SystemColors.Window;
            button7.BackColor = System.Drawing.SystemColors.Window;
            button8.BackColor = System.Drawing.SystemColors.Window;
            button9.BackColor = System.Drawing.SystemColors.Window;
            button9.BackColor = System.Drawing.SystemColors.Window;
            button11.BackColor = System.Drawing.SystemColors.Window;
            button5.BackColor = System.Drawing.SystemColors.Window;
            button13.BackColor = System.Drawing.SystemColors.Window;
            button14.BackColor = System.Drawing.SystemColors.Window;
            button15.BackColor = System.Drawing.SystemColors.Window;
            button16.BackColor = System.Drawing.SystemColors.Window;
            button17.BackColor = System.Drawing.SystemColors.Window;
            button18.BackColor = System.Drawing.SystemColors.Window;
            button19.BackColor = System.Drawing.SystemColors.Window;
            button10.BackColor = System.Drawing.SystemColors.Window;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            openSildperso(new DemandeRetrait());
            button13.BackColor = System.Drawing.SystemColors.ControlDark;
            button2.BackColor = System.Drawing.SystemColors.Window;
            button4.BackColor = System.Drawing.SystemColors.Window;
            button3.BackColor = System.Drawing.SystemColors.Window;
            button6.BackColor = System.Drawing.SystemColors.Window;
            button7.BackColor = System.Drawing.SystemColors.Window;
            button8.BackColor = System.Drawing.SystemColors.Window;
            button9.BackColor = System.Drawing.SystemColors.Window;
            button9.BackColor = System.Drawing.SystemColors.Window;
            button11.BackColor = System.Drawing.SystemColors.Window;
            button12.BackColor = System.Drawing.SystemColors.Window;
            button5.BackColor = System.Drawing.SystemColors.Window;
            button14.BackColor = System.Drawing.SystemColors.Window;
            button15.BackColor = System.Drawing.SystemColors.Window;
            button16.BackColor = System.Drawing.SystemColors.Window;
            button17.BackColor = System.Drawing.SystemColors.Window;
            button18.BackColor = System.Drawing.SystemColors.Window;
            button19.BackColor = System.Drawing.SystemColors.Window;
            button10.BackColor = System.Drawing.SystemColors.Window;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            openSildperso(new ValidationDemandeRetrait());
            button14.BackColor = System.Drawing.SystemColors.ControlDark;
            button2.BackColor = System.Drawing.SystemColors.Window;
            button4.BackColor = System.Drawing.SystemColors.Window;
            button3.BackColor = System.Drawing.SystemColors.Window;
            button6.BackColor = System.Drawing.SystemColors.Window;
            button7.BackColor = System.Drawing.SystemColors.Window;
            button8.BackColor = System.Drawing.SystemColors.Window;
            button9.BackColor = System.Drawing.SystemColors.Window;
            button9.BackColor = System.Drawing.SystemColors.Window;
            button11.BackColor = System.Drawing.SystemColors.Window;
            button12.BackColor = System.Drawing.SystemColors.Window;
            button13.BackColor = System.Drawing.SystemColors.Window;
            button5.BackColor = System.Drawing.SystemColors.Window;
            button15.BackColor = System.Drawing.SystemColors.Window;
            button16.BackColor = System.Drawing.SystemColors.Window;
            button17.BackColor = System.Drawing.SystemColors.Window;
            button18.BackColor = System.Drawing.SystemColors.Window;
            button19.BackColor = System.Drawing.SystemColors.Window;
            button10.BackColor = System.Drawing.SystemColors.Window;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            openSildperso(new BonEssence());
            button15.BackColor = System.Drawing.SystemColors.ControlDark;
            button2.BackColor = System.Drawing.SystemColors.Window;
            button4.BackColor = System.Drawing.SystemColors.Window;
            button3.BackColor = System.Drawing.SystemColors.Window;
            button6.BackColor = System.Drawing.SystemColors.Window;
            button7.BackColor = System.Drawing.SystemColors.Window;
            button8.BackColor = System.Drawing.SystemColors.Window;
            button9.BackColor = System.Drawing.SystemColors.Window;
            button9.BackColor = System.Drawing.SystemColors.Window;
            button11.BackColor = System.Drawing.SystemColors.Window;
            button12.BackColor = System.Drawing.SystemColors.Window;
            button13.BackColor = System.Drawing.SystemColors.Window;
            button14.BackColor = System.Drawing.SystemColors.Window;
            button5.BackColor = System.Drawing.SystemColors.Window;
            button16.BackColor = System.Drawing.SystemColors.Window;
            button17.BackColor = System.Drawing.SystemColors.Window;
            button18.BackColor = System.Drawing.SystemColors.Window;
            button19.BackColor = System.Drawing.SystemColors.Window;
            button10.BackColor = System.Drawing.SystemColors.Window;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            openSildperso(new Operation());
            button16.BackColor = System.Drawing.SystemColors.ControlDark;
            button2.BackColor = System.Drawing.SystemColors.Window;
            button4.BackColor = System.Drawing.SystemColors.Window;
            button3.BackColor = System.Drawing.SystemColors.Window;
            button6.BackColor = System.Drawing.SystemColors.Window;
            button7.BackColor = System.Drawing.SystemColors.Window;
            button8.BackColor = System.Drawing.SystemColors.Window;
            button9.BackColor = System.Drawing.SystemColors.Window;
            button9.BackColor = System.Drawing.SystemColors.Window;
            button11.BackColor = System.Drawing.SystemColors.Window;
            button12.BackColor = System.Drawing.SystemColors.Window;
            button13.BackColor = System.Drawing.SystemColors.Window;
            button14.BackColor = System.Drawing.SystemColors.Window;
            button15.BackColor = System.Drawing.SystemColors.Window;
            button5.BackColor = System.Drawing.SystemColors.Window;
            button17.BackColor = System.Drawing.SystemColors.Window;
            button18.BackColor = System.Drawing.SystemColors.Window;
            button19.BackColor = System.Drawing.SystemColors.Window;
            button10.BackColor = System.Drawing.SystemColors.Window;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button20_Click(object sender, EventArgs e)
        {
            openSildperso(new Territoires());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
