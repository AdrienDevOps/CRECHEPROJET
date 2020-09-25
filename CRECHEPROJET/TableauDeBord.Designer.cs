namespace CRECHEPROJET
{
    partial class TableauDeBord
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
            this.UniteListe = new System.Windows.Forms.TabControl();
            this.EnfantsTotal = new System.Windows.Forms.ListBox();
            this.EnfantDetail = new System.Windows.Forms.Button();
            this.detailsprevue = new System.Windows.Forms.GroupBox();
            this.Detailseffectuee = new System.Windows.Forms.GroupBox();
            this.Texteprevue = new System.Windows.Forms.Label();
            this.texteeffectuees = new System.Windows.Forms.Label();
            this.detailsprevue.SuspendLayout();
            this.Detailseffectuee.SuspendLayout();
            this.SuspendLayout();
            // 
            // UniteListe
            // 
            this.UniteListe.Location = new System.Drawing.Point(12, 67);
            this.UniteListe.Name = "UniteListe";
            this.UniteListe.SelectedIndex = 0;
            this.UniteListe.Size = new System.Drawing.Size(957, 247);
            this.UniteListe.TabIndex = 0;
            // 
            // EnfantsTotal
            // 
            this.EnfantsTotal.FormattingEnabled = true;
            this.EnfantsTotal.Location = new System.Drawing.Point(12, 333);
            this.EnfantsTotal.Name = "EnfantsTotal";
            this.EnfantsTotal.Size = new System.Drawing.Size(120, 186);
            this.EnfantsTotal.TabIndex = 1;
            // 
            // EnfantDetail
            // 
            this.EnfantDetail.Location = new System.Drawing.Point(189, 388);
            this.EnfantDetail.Name = "EnfantDetail";
            this.EnfantDetail.Size = new System.Drawing.Size(80, 80);
            this.EnfantDetail.TabIndex = 2;
            this.EnfantDetail.Text = "Détails";
            this.EnfantDetail.UseVisualStyleBackColor = true;
            this.EnfantDetail.Click += new System.EventHandler(this.EnfantDetail_Click);
            // 
            // detailsprevue
            // 
            this.detailsprevue.Controls.Add(this.Texteprevue);
            this.detailsprevue.Location = new System.Drawing.Point(355, 384);
            this.detailsprevue.Name = "detailsprevue";
            this.detailsprevue.Size = new System.Drawing.Size(166, 135);
            this.detailsprevue.TabIndex = 3;
            this.detailsprevue.TabStop = false;
            this.detailsprevue.Text = "Prévue";
            // 
            // Detailseffectuee
            // 
            this.Detailseffectuee.Controls.Add(this.texteeffectuees);
            this.Detailseffectuee.Location = new System.Drawing.Point(647, 384);
            this.Detailseffectuee.Name = "Detailseffectuee";
            this.Detailseffectuee.Size = new System.Drawing.Size(166, 135);
            this.Detailseffectuee.TabIndex = 4;
            this.Detailseffectuee.TabStop = false;
            this.Detailseffectuee.Text = "Effectuées";
            // 
            // Texteprevue
            // 
            this.Texteprevue.AutoSize = true;
            this.Texteprevue.Location = new System.Drawing.Point(32, 47);
            this.Texteprevue.Name = "Texteprevue";
            this.Texteprevue.Size = new System.Drawing.Size(0, 13);
            this.Texteprevue.TabIndex = 0;
            // 
            // texteeffectuees
            // 
            this.texteeffectuees.AutoSize = true;
            this.texteeffectuees.Location = new System.Drawing.Point(36, 47);
            this.texteeffectuees.Name = "texteeffectuees";
            this.texteeffectuees.Size = new System.Drawing.Size(0, 13);
            this.texteeffectuees.TabIndex = 5;
            // 
            // TableauDeBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 541);
            this.Controls.Add(this.Detailseffectuee);
            this.Controls.Add(this.detailsprevue);
            this.Controls.Add(this.EnfantDetail);
            this.Controls.Add(this.EnfantsTotal);
            this.Controls.Add(this.UniteListe);
            this.Name = "TableauDeBord";
            this.Text = "TableauDeBord";
            this.Load += new System.EventHandler(this.Chargement);
            this.detailsprevue.ResumeLayout(false);
            this.detailsprevue.PerformLayout();
            this.Detailseffectuee.ResumeLayout(false);
            this.Detailseffectuee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl UniteListe;
        private System.Windows.Forms.ListBox EnfantsTotal;
        private System.Windows.Forms.Button EnfantDetail;
        private System.Windows.Forms.GroupBox detailsprevue;
        private System.Windows.Forms.Label Texteprevue;
        private System.Windows.Forms.GroupBox Detailseffectuee;
        private System.Windows.Forms.Label texteeffectuees;
    }
}