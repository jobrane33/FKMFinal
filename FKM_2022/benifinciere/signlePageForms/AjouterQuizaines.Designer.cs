namespace FKM_2022.benifinciere.signlePageForms
{
    partial class AjouterQuizaines
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.filledPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilometrage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uperPannel = new System.Windows.Forms.Panel();
            this.roundBtn1 = new FKM_2022.selfmadecomp.RoundBtn();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.roundBtn3 = new FKM_2022.selfmadecomp.RoundBtn();
            this.roundBtn4 = new FKM_2022.selfmadecomp.RoundBtn();
            this.roundBtn2 = new FKM_2022.selfmadecomp.RoundBtn();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.filledPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.uperPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 980);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1441, 38);
            this.panel4.TabIndex = 1;
            // 
            // filledPanel
            // 
            this.filledPanel.AutoScroll = true;
            this.filledPanel.Controls.Add(this.dataGridView1);
            this.filledPanel.Controls.Add(this.uperPannel);
            this.filledPanel.Controls.Add(this.panel4);
            this.filledPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filledPanel.Location = new System.Drawing.Point(0, 0);
            this.filledPanel.Name = "filledPanel";
            this.filledPanel.Size = new System.Drawing.Size(1441, 1018);
            this.filledPanel.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jour,
            this.date,
            this.observation,
            this.kilometrage});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1441, 800);
            this.dataGridView1.TabIndex = 5;
            // 
            // jour
            // 
            this.jour.DataPropertyName = "jour";
            this.jour.HeaderText = "jour";
            this.jour.MinimumWidth = 6;
            this.jour.Name = "jour";
            this.jour.Width = 125;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "date du jour";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.Width = 78;
            // 
            // observation
            // 
            this.observation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.observation.HeaderText = "observation";
            this.observation.MinimumWidth = 6;
            this.observation.Name = "observation";
            // 
            // kilometrage
            // 
            this.kilometrage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kilometrage.DataPropertyName = "kilometrage";
            this.kilometrage.HeaderText = "ajouter kilometrage";
            this.kilometrage.MinimumWidth = 6;
            this.kilometrage.Name = "kilometrage";
            this.kilometrage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // uperPannel
            // 
            this.uperPannel.AutoScroll = true;
            this.uperPannel.BackColor = System.Drawing.Color.Lavender;
            this.uperPannel.Controls.Add(this.label1);
            this.uperPannel.Controls.Add(this.roundBtn1);
            this.uperPannel.Controls.Add(this.radioButton2);
            this.uperPannel.Controls.Add(this.pictureBox7);
            this.uperPannel.Controls.Add(this.radioButton1);
            this.uperPannel.Controls.Add(this.comboBox3);
            this.uperPannel.Controls.Add(this.label5);
            this.uperPannel.Controls.Add(this.comboBox2);
            this.uperPannel.Controls.Add(this.pictureBox6);
            this.uperPannel.Controls.Add(this.label4);
            this.uperPannel.Controls.Add(this.roundBtn3);
            this.uperPannel.Controls.Add(this.roundBtn4);
            this.uperPannel.Controls.Add(this.roundBtn2);
            this.uperPannel.Controls.Add(this.pictureBox5);
            this.uperPannel.Dock = System.Windows.Forms.DockStyle.Top;
            this.uperPannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uperPannel.Location = new System.Drawing.Point(0, 0);
            this.uperPannel.Name = "uperPannel";
            this.uperPannel.Size = new System.Drawing.Size(1441, 180);
            this.uperPannel.TabIndex = 4;
            // 
            // roundBtn1
            // 
            this.roundBtn1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.roundBtn1.BackgroudColor = System.Drawing.Color.DarkSlateBlue;
            this.roundBtn1.BorderRadius = 40;
            this.roundBtn1.BorderSize = 0;
            this.roundBtn1.FlatAppearance.BorderSize = 0;
            this.roundBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundBtn1.ForeColor = System.Drawing.Color.White;
            this.roundBtn1.Image = global::FKM_2022.Properties.Resources.icons8_boîte_24;
            this.roundBtn1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundBtn1.Location = new System.Drawing.Point(1195, 116);
            this.roundBtn1.Name = "roundBtn1";
            this.roundBtn1.Size = new System.Drawing.Size(150, 40);
            this.roundBtn1.TabIndex = 23;
            this.roundBtn1.Text = "roundBtn1";
            this.roundBtn1.TextColor = System.Drawing.Color.White;
            this.roundBtn1.UseVisualStyleBackColor = false;
            this.roundBtn1.Click += new System.EventHandler(this.roundBtn1_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(29, 49);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(159, 24);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "saisie quinzaines";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::FKM_2022.Properties.Resources.icons8_rendez_vous_périodique_50;
            this.pictureBox7.Location = new System.Drawing.Point(1446, 50);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(40, 28);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 21;
            this.pictureBox7.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(29, 75);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(140, 24);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "afficher details";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(729, 48);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(216, 28);
            this.comboBox3.TabIndex = 21;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(588, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "Quanzaine";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(336, 48);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(246, 28);
            this.comboBox2.TabIndex = 19;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::FKM_2022.Properties.Resources.icons8_case_cochée_24;
            this.pictureBox6.Location = new System.Drawing.Point(1271, 46);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(39, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 20;
            this.pictureBox6.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(193, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Personnel";
            // 
            // roundBtn3
            // 
            this.roundBtn3.BackColor = System.Drawing.Color.YellowGreen;
            this.roundBtn3.BackgroudColor = System.Drawing.Color.YellowGreen;
            this.roundBtn3.BorderRadius = 40;
            this.roundBtn3.BorderSize = 0;
            this.roundBtn3.FlatAppearance.BorderSize = 0;
            this.roundBtn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundBtn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundBtn3.ForeColor = System.Drawing.Color.White;
            this.roundBtn3.Location = new System.Drawing.Point(1131, 42);
            this.roundBtn3.Name = "roundBtn3";
            this.roundBtn3.Size = new System.Drawing.Size(123, 39);
            this.roundBtn3.TabIndex = 17;
            this.roundBtn3.Text = "valider ";
            this.roundBtn3.TextColor = System.Drawing.Color.White;
            this.roundBtn3.UseVisualStyleBackColor = false;
            this.roundBtn3.Click += new System.EventHandler(this.roundBtn3_Click);
            // 
            // roundBtn4
            // 
            this.roundBtn4.BackColor = System.Drawing.Color.Red;
            this.roundBtn4.BackgroudColor = System.Drawing.Color.Red;
            this.roundBtn4.BorderRadius = 40;
            this.roundBtn4.BorderSize = 0;
            this.roundBtn4.FlatAppearance.BorderSize = 0;
            this.roundBtn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundBtn4.ForeColor = System.Drawing.Color.White;
            this.roundBtn4.Location = new System.Drawing.Point(1316, 43);
            this.roundBtn4.Name = "roundBtn4";
            this.roundBtn4.Size = new System.Drawing.Size(124, 39);
            this.roundBtn4.TabIndex = 18;
            this.roundBtn4.Text = "réinitialiser";
            this.roundBtn4.TextColor = System.Drawing.Color.White;
            this.roundBtn4.UseVisualStyleBackColor = false;
            this.roundBtn4.Click += new System.EventHandler(this.roundBtn4_Click);
            // 
            // roundBtn2
            // 
            this.roundBtn2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundBtn2.BackgroudColor = System.Drawing.Color.MediumSlateBlue;
            this.roundBtn2.BorderRadius = 40;
            this.roundBtn2.BorderSize = 0;
            this.roundBtn2.FlatAppearance.BorderSize = 0;
            this.roundBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundBtn2.ForeColor = System.Drawing.Color.White;
            this.roundBtn2.Location = new System.Drawing.Point(951, 43);
            this.roundBtn2.Name = "roundBtn2";
            this.roundBtn2.Size = new System.Drawing.Size(122, 41);
            this.roundBtn2.TabIndex = 16;
            this.roundBtn2.Text = "enregistrer";
            this.roundBtn2.TextColor = System.Drawing.Color.White;
            this.roundBtn2.UseVisualStyleBackColor = false;
            this.roundBtn2.Click += new System.EventHandler(this.roundBtn2_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::FKM_2022.Properties.Resources.icons8_sauvegarder_24;
            this.pictureBox5.Location = new System.Drawing.Point(1079, 46);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 19;
            this.pictureBox5.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(621, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "label1";
            // 
            // AjouterQuizaines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 1018);
            this.Controls.Add(this.filledPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AjouterQuizaines";
            this.Text = "PersoFrom";
            this.Load += new System.EventHandler(this.AjouterQuizaines_Load);
            this.filledPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.uperPannel.ResumeLayout(false);
            this.uperPannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel filledPanel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel uperPannel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private selfmadecomp.RoundBtn roundBtn3;
        private selfmadecomp.RoundBtn roundBtn4;
        private selfmadecomp.RoundBtn roundBtn2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.DataGridViewTextBoxColumn jour;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn observation;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilometrage;
        private selfmadecomp.RoundBtn roundBtn1;
        private System.Windows.Forms.Label label1;
    }

        
   }
