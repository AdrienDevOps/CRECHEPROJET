namespace CRECHEPROJET
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.temps = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.CrecheAffiche = new System.Windows.Forms.Label();
            this.UniteList = new System.Windows.Forms.TabControl();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.DateDeNaissance = new System.Windows.Forms.Label();
            this.MotDePasse = new System.Windows.Forms.GroupBox();
            this.b0 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BoiteADate = new System.Windows.Forms.TextBox();
            this.bsupp = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ValidMdp = new System.Windows.Forms.Button();
            this.FermerMotDePasse = new System.Windows.Forms.Button();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.TDB = new System.Windows.Forms.Button();
            this.MotDePasse.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // temps
            // 
            this.temps.AutoSize = true;
            this.temps.BackColor = System.Drawing.Color.Transparent;
            this.temps.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temps.Location = new System.Drawing.Point(473, 57);
            this.temps.Name = "temps";
            this.temps.Size = new System.Drawing.Size(120, 31);
            this.temps.TabIndex = 0;
            this.temps.Text = "00:00:00";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // CrecheAffiche
            // 
            this.CrecheAffiche.AutoSize = true;
            this.CrecheAffiche.BackColor = System.Drawing.Color.Transparent;
            this.CrecheAffiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrecheAffiche.Location = new System.Drawing.Point(665, 9);
            this.CrecheAffiche.Name = "CrecheAffiche";
            this.CrecheAffiche.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CrecheAffiche.Size = new System.Drawing.Size(147, 25);
            this.CrecheAffiche.TabIndex = 2;
            this.CrecheAffiche.Text = "CrecheAffiche";
            this.CrecheAffiche.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.CrecheAffiche.DoubleClick += new System.EventHandler(this.CrecheAffiche_Click);
            // 
            // UniteList
            // 
            this.UniteList.Location = new System.Drawing.Point(131, 91);
            this.UniteList.Name = "UniteList";
            this.UniteList.SelectedIndex = 0;
            this.UniteList.Size = new System.Drawing.Size(779, 480);
            this.UniteList.TabIndex = 3;
            // 
            // DateDeNaissance
            // 
            this.DateDeNaissance.AutoSize = true;
            this.DateDeNaissance.BackColor = System.Drawing.Color.Transparent;
            this.DateDeNaissance.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateDeNaissance.ForeColor = System.Drawing.Color.DarkBlue;
            this.DateDeNaissance.Location = new System.Drawing.Point(183, 63);
            this.DateDeNaissance.Name = "DateDeNaissance";
            this.DateDeNaissance.Size = new System.Drawing.Size(607, 46);
            this.DateDeNaissance.TabIndex = 5;
            this.DateDeNaissance.Text = "ENTRER LA DATE DE NAISSANCE";
            // 
            // MotDePasse
            // 
            this.MotDePasse.BackColor = System.Drawing.Color.Pink;
            this.MotDePasse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MotDePasse.Controls.Add(this.b0);
            this.MotDePasse.Controls.Add(this.groupBox1);
            this.MotDePasse.Controls.Add(this.bsupp);
            this.MotDePasse.Controls.Add(this.b9);
            this.MotDePasse.Controls.Add(this.b8);
            this.MotDePasse.Controls.Add(this.b6);
            this.MotDePasse.Controls.Add(this.b5);
            this.MotDePasse.Controls.Add(this.b7);
            this.MotDePasse.Controls.Add(this.b4);
            this.MotDePasse.Controls.Add(this.b3);
            this.MotDePasse.Controls.Add(this.b2);
            this.MotDePasse.Controls.Add(this.b1);
            this.MotDePasse.Controls.Add(this.label4);
            this.MotDePasse.Controls.Add(this.ValidMdp);
            this.MotDePasse.Controls.Add(this.FermerMotDePasse);
            this.MotDePasse.Controls.Add(this.DateDeNaissance);
            this.MotDePasse.ForeColor = System.Drawing.Color.Black;
            this.MotDePasse.Location = new System.Drawing.Point(-3, 2);
            this.MotDePasse.Name = "MotDePasse";
            this.MotDePasse.Size = new System.Drawing.Size(1025, 575);
            this.MotDePasse.TabIndex = 6;
            this.MotDePasse.TabStop = false;
            this.MotDePasse.Visible = false;
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(200, 495);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(60, 60);
            this.b0.TabIndex = 27;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.BoiteADate);
            this.groupBox1.Location = new System.Drawing.Point(482, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 120);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // BoiteADate
            // 
            this.BoiteADate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoiteADate.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoiteADate.Location = new System.Drawing.Point(52, 42);
            this.BoiteADate.Name = "BoiteADate";
            this.BoiteADate.Size = new System.Drawing.Size(267, 40);
            this.BoiteADate.TabIndex = 25;
            // 
            // bsupp
            // 
            this.bsupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsupp.Location = new System.Drawing.Point(275, 495);
            this.bsupp.Name = "bsupp";
            this.bsupp.Size = new System.Drawing.Size(135, 60);
            this.bsupp.TabIndex = 24;
            this.bsupp.Text = "Effacer";
            this.bsupp.UseVisualStyleBackColor = true;
            this.bsupp.Click += new System.EventHandler(this.bsupp_Click);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(350, 420);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(60, 60);
            this.b9.TabIndex = 23;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(275, 420);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(60, 60);
            this.b8.TabIndex = 22;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(350, 345);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(60, 60);
            this.b6.TabIndex = 21;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(275, 345);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(60, 60);
            this.b5.TabIndex = 20;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(200, 420);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(60, 60);
            this.b7.TabIndex = 19;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(200, 345);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(60, 60);
            this.b4.TabIndex = 18;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(350, 270);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(60, 60);
            this.b3.TabIndex = 17;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(275, 270);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(60, 60);
            this.b2.TabIndex = 16;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(200, 269);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(60, 60);
            this.b1.TabIndex = 15;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(279, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(464, 46);
            this.label4.TabIndex = 14;
            this.label4.Text = "POUR VOUS IDENTIFIER !";
            // 
            // ValidMdp
            // 
            this.ValidMdp.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ValidMdp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ValidMdp.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidMdp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ValidMdp.Location = new System.Drawing.Point(482, 473);
            this.ValidMdp.Name = "ValidMdp";
            this.ValidMdp.Size = new System.Drawing.Size(352, 82);
            this.ValidMdp.TabIndex = 10;
            this.ValidMdp.Text = "Valider";
            this.ValidMdp.UseVisualStyleBackColor = false;
            this.ValidMdp.Click += new System.EventHandler(this.ValideMdp);
            // 
            // FermerMotDePasse
            // 
            this.FermerMotDePasse.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.FermerMotDePasse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FermerMotDePasse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FermerMotDePasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FermerMotDePasse.Location = new System.Drawing.Point(6, 0);
            this.FermerMotDePasse.Name = "FermerMotDePasse";
            this.FermerMotDePasse.Size = new System.Drawing.Size(150, 56);
            this.FermerMotDePasse.TabIndex = 6;
            this.FermerMotDePasse.Text = "Fermer";
            this.FermerMotDePasse.UseVisualStyleBackColor = false;
            this.FermerMotDePasse.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FermeMotDePasse);
            // 
            // TDB
            // 
            this.TDB.Location = new System.Drawing.Point(889, 2);
            this.TDB.Name = "TDB";
            this.TDB.Size = new System.Drawing.Size(133, 23);
            this.TDB.TabIndex = 7;
            this.TDB.Text = "Tableau de bord";
            this.TDB.UseVisualStyleBackColor = true;
            this.TDB.Click += new System.EventHandler(this.TDB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 574);
            this.Controls.Add(this.TDB);
            this.Controls.Add(this.MotDePasse);
            this.Controls.Add(this.UniteList);
            this.Controls.Add(this.CrecheAffiche);
            this.Controls.Add(this.temps);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Crèche";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MotDePasse.ResumeLayout(false);
            this.MotDePasse.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label temps;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label CrecheAffiche;
        private System.Windows.Forms.TabControl UniteList;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label DateDeNaissance;
        private System.Windows.Forms.GroupBox MotDePasse;
        private System.Windows.Forms.Button FermerMotDePasse;
        private System.Windows.Forms.Button ValidMdp;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bsupp;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.TextBox BoiteADate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button TDB;
    }
}

