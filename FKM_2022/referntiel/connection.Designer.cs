using System.Windows.Forms;

namespace FKM_2022.referntiel
{
    partial class connection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.NFKMtext = new System.Windows.Forms.TextBox();
            this.lineunderlogin = new System.Windows.Forms.Panel();
            this.MATtext = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "se connecter";
            // 
            // NFKMtext
            // 
            this.NFKMtext.BackColor = System.Drawing.SystemColors.Control;
            this.NFKMtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NFKMtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NFKMtext.Location = new System.Drawing.Point(39, 62);
            this.NFKMtext.Multiline = true;
            this.NFKMtext.Name = "NFKMtext";
            this.NFKMtext.Size = new System.Drawing.Size(280, 44);
            this.NFKMtext.TabIndex = 1;
            this.NFKMtext.Text = "numero compte FKM";
            this.NFKMtext.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.NFKMtext.Enter += new System.EventHandler(this.NFKMtext_Enter);
            this.NFKMtext.Leave += new System.EventHandler(this.NFKMtext_Leave);
            // 
            // lineunderlogin
            // 
            this.lineunderlogin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lineunderlogin.Location = new System.Drawing.Point(39, 200);
            this.lineunderlogin.Name = "lineunderlogin";
            this.lineunderlogin.Size = new System.Drawing.Size(280, 1);
            this.lineunderlogin.TabIndex = 2;
            // 
            // MATtext
            // 
            this.MATtext.BackColor = System.Drawing.SystemColors.Control;
            this.MATtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MATtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MATtext.Location = new System.Drawing.Point(39, 150);
            this.MATtext.Multiline = true;
            this.MATtext.Name = "MATtext";
            this.MATtext.Size = new System.Drawing.Size(280, 44);
            this.MATtext.TabIndex = 3;
            this.MATtext.Text = "Matricule";
            this.MATtext.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.MATtext.Enter += new System.EventHandler(this.MATtext_Enter);
            this.MATtext.Leave += new System.EventHandler(this.MATtext_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(39, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 1);
            this.panel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.NFKMtext);
            this.groupBox1.Controls.Add(this.lineunderlogin);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.MATtext);
            this.groupBox1.Location = new System.Drawing.Point(94, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 277);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "passez vos donnes";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::FKM_2022.Properties.Resources.icons8_connexion_48;
            this.pictureBox2.Location = new System.Drawing.Point(312, 226);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(362, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 44);
            this.button2.TabIndex = 7;
            this.button2.Text = "effacer les champs";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FKM_2022.Properties.Resources.icons8_user_64;
            this.pictureBox1.Location = new System.Drawing.Point(80, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "© 2022 SOCIÉTÉ INFORMATIQUE  ET TELEMATIQUE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 544);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(566, 30);
            this.panel2.TabIndex = 10;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FKM_2022.Properties.Resources.icons8_annuler_48;
            this.pictureBox3.Location = new System.Drawing.Point(493, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(566, 574);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "connection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FKM";
            this.Load += new System.EventHandler(this.personnel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox NFKMtext;
        private Panel lineunderlogin;
        private TextBox MATtext;
        private Panel panel1;
        private GroupBox groupBox1;
        private Button button2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private Panel panel2;
        private PictureBox pictureBox3;
    }
}