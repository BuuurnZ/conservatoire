namespace Connecte.Vue
{
    partial class ModifSeance
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
            this.listSeance = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cJour = new System.Windows.Forms.ComboBox();
            this.cTranche = new System.Windows.Forms.ComboBox();
            this.Tranche = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.modifier = new System.Windows.Forms.Button();
            this.cProf = new System.Windows.Forms.ComboBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listSeance
            // 
            this.listSeance.FormattingEnabled = true;
            this.listSeance.Location = new System.Drawing.Point(12, 12);
            this.listSeance.Name = "listSeance";
            this.listSeance.Size = new System.Drawing.Size(776, 212);
            this.listSeance.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cProf);
            this.groupBox3.Controls.Add(this.cJour);
            this.groupBox3.Controls.Add(this.cTranche);
            this.groupBox3.Controls.Add(this.Tranche);
            this.groupBox3.Controls.Add(this.labelMail);
            this.groupBox3.Controls.Add(this.labelNom);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 230);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(571, 208);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Insertion";
            // 
            // cJour
            // 
            this.cJour.FormattingEnabled = true;
            this.cJour.Items.AddRange(new object[] {
            "Lundi",
            "Mardi",
            "Mercredi ",
            "Jeudi ",
            "Vendredi",
            "Samedi ",
            "Dimanche"});
            this.cJour.Location = new System.Drawing.Point(186, 32);
            this.cJour.Name = "cJour";
            this.cJour.Size = new System.Drawing.Size(121, 21);
            this.cJour.TabIndex = 38;
            this.cJour.SelectedIndexChanged += new System.EventHandler(this.cJour_SelectedIndexChanged);
            // 
            // cTranche
            // 
            this.cTranche.FormattingEnabled = true;
            this.cTranche.Location = new System.Drawing.Point(376, 32);
            this.cTranche.Name = "cTranche";
            this.cTranche.Size = new System.Drawing.Size(121, 21);
            this.cTranche.TabIndex = 37;
            // 
            // Tranche
            // 
            this.Tranche.AutoSize = true;
            this.Tranche.Location = new System.Drawing.Point(518, 37);
            this.Tranche.Name = "Tranche";
            this.Tranche.Size = new System.Drawing.Size(47, 13);
            this.Tranche.TabIndex = 36;
            this.Tranche.Text = "Tranche";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(315, 36);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(27, 13);
            this.labelMail.TabIndex = 30;
            this.labelMail.Text = "Jour";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(130, 40);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(26, 13);
            this.labelNom.TabIndex = 23;
            this.labelNom.Text = "Prof";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(186, 119);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 65);
            this.button3.TabIndex = 15;
            this.button3.Text = "Insérer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 18;
            // 
            // modifier
            // 
            this.modifier.Location = new System.Drawing.Point(648, 314);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(112, 62);
            this.modifier.TabIndex = 27;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // cProf
            // 
            this.cProf.FormattingEnabled = true;
            this.cProf.Location = new System.Drawing.Point(6, 32);
            this.cProf.Name = "cProf";
            this.cProf.Size = new System.Drawing.Size(108, 21);
            this.cProf.TabIndex = 39;
            // 
            // ModifSeance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.listSeance);
            this.Name = "ModifSeance";
            this.Text = "ModifSeance";
            this.Load += new System.EventHandler(this.ModifSeance_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listSeance;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cTranche;
        private System.Windows.Forms.Label Tranche;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.ComboBox cJour;
        private System.Windows.Forms.ComboBox cProf;
    }
}