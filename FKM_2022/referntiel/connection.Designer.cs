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
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customtextbox2 = new FKM_2022.selfmadecomp.customtextbox();
            this.customtextbox1 = new FKM_2022.selfmadecomp.customtextbox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.roundBtn1 = new FKM_2022.selfmadecomp.RoundBtn();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "© 2022 SOCIÉTÉ INFORMATIQUE  ET TELEMATIQUE";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.customtextbox2);
            this.groupBox1.Controls.Add(this.customtextbox1);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Location = new System.Drawing.Point(94, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 277);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "passez vos donnes";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::FKM_2022.Properties.Resources.icons8_visible_48;
            this.pictureBox4.Location = new System.Drawing.Point(325, 162);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(39, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mot de Passe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "nom d\'utilisateur";
            // 
            // customtextbox2
            // 
            this.customtextbox2.BackColor = System.Drawing.SystemColors.Window;
            this.customtextbox2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customtextbox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customtextbox2.BorderSize = 2;
            this.customtextbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customtextbox2.ForeColor = System.Drawing.Color.DimGray;
            this.customtextbox2.isfocused = false;
            this.customtextbox2.Location = new System.Drawing.Point(39, 162);
            this.customtextbox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customtextbox2.Multiline = false;
            this.customtextbox2.Name = "customtextbox2";
            this.customtextbox2.Padding = new System.Windows.Forms.Padding(7);
            this.customtextbox2.PasswordChar = true;
            this.customtextbox2.Size = new System.Drawing.Size(280, 35);
            this.customtextbox2.TabIndex = 11;
            this.customtextbox2.Texts = "";
            this.customtextbox2.UnderlinedStyle = true;
            // 
            // customtextbox1
            // 
            this.customtextbox1.BackColor = System.Drawing.SystemColors.Window;
            this.customtextbox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customtextbox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customtextbox1.BorderSize = 2;
            this.customtextbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customtextbox1.ForeColor = System.Drawing.Color.DimGray;
            this.customtextbox1.isfocused = false;
            this.customtextbox1.Location = new System.Drawing.Point(39, 74);
            this.customtextbox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customtextbox1.Multiline = false;
            this.customtextbox1.Name = "customtextbox1";
            this.customtextbox1.Padding = new System.Windows.Forms.Padding(7);
            this.customtextbox1.PasswordChar = false;
            this.customtextbox1.Size = new System.Drawing.Size(280, 35);
            this.customtextbox1.TabIndex = 10;
            this.customtextbox1.Texts = "";
            this.customtextbox1.UnderlinedStyle = true;
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
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // roundBtn1
            // 
            this.roundBtn1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundBtn1.BackgroudColor = System.Drawing.Color.MediumSlateBlue;
            this.roundBtn1.BorderRadius = 40;
            this.roundBtn1.BorderSize = 0;
            this.roundBtn1.FlatAppearance.BorderSize = 0;
            this.roundBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundBtn1.ForeColor = System.Drawing.Color.White;
            this.roundBtn1.Location = new System.Drawing.Point(366, 445);
            this.roundBtn1.Name = "roundBtn1";
            this.roundBtn1.Size = new System.Drawing.Size(98, 48);
            this.roundBtn1.TabIndex = 12;
            this.roundBtn1.Text = "effacer les champs";
            this.roundBtn1.TextColor = System.Drawing.Color.White;
            this.roundBtn1.UseVisualStyleBackColor = false;
            this.roundBtn1.Click += new System.EventHandler(this.roundBtn1_Click);
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
            // connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(566, 574);
            this.Controls.Add(this.roundBtn1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "connection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FKM";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private GroupBox groupBox1;
        private Label label3;
        private selfmadecomp.customtextbox customtextbox2;
        private selfmadecomp.customtextbox customtextbox1;
        private Label label4;
        private selfmadecomp.RoundBtn roundBtn1;
        private PictureBox pictureBox4;
    }
}