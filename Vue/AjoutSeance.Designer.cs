namespace Connecte.Vue
{
    partial class AjoutSeance
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
            this.cProf = new System.Windows.Forms.ComboBox();
            this.cJour = new System.Windows.Forms.ComboBox();
            this.cTranche = new System.Windows.Forms.ComboBox();
            this.Prof = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cNiveau = new System.Windows.Forms.ComboBox();
            this.cCapacite = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cProf
            // 
            this.cProf.FormattingEnabled = true;
            this.cProf.Location = new System.Drawing.Point(41, 47);
            this.cProf.Name = "cProf";
            this.cProf.Size = new System.Drawing.Size(121, 21);
            this.cProf.TabIndex = 0;
            this.cProf.SelectedIndexChanged += new System.EventHandler(this.cProf_SelectedIndexChanged);
            // 
            // cJour
            // 
            this.cJour.FormattingEnabled = true;
            this.cJour.Items.AddRange(new object[] {
            "Lundi ",
            "Mardi ",
            "Mercredi",
            "Jeudi",
            "Vendredi",
            "Samedi",
            "Dimanche"});
            this.cJour.Location = new System.Drawing.Point(41, 117);
            this.cJour.Name = "cJour";
            this.cJour.Size = new System.Drawing.Size(121, 21);
            this.cJour.TabIndex = 1;
            this.cJour.SelectedIndexChanged += new System.EventHandler(this.cJour_SelectedIndexChanged);
            // 
            // cTranche
            // 
            this.cTranche.FormattingEnabled = true;
            this.cTranche.Location = new System.Drawing.Point(41, 188);
            this.cTranche.Name = "cTranche";
            this.cTranche.Size = new System.Drawing.Size(121, 21);
            this.cTranche.TabIndex = 2;
            // 
            // Prof
            // 
            this.Prof.AutoSize = true;
            this.Prof.Location = new System.Drawing.Point(191, 54);
            this.Prof.Name = "Prof";
            this.Prof.Size = new System.Drawing.Size(26, 13);
            this.Prof.TabIndex = 3;
            this.Prof.Text = "Prof";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Jour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tranche";
            // 
            // cNiveau
            // 
            this.cNiveau.FormattingEnabled = true;
            this.cNiveau.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cNiveau.Location = new System.Drawing.Point(385, 47);
            this.cNiveau.Name = "cNiveau";
            this.cNiveau.Size = new System.Drawing.Size(121, 21);
            this.cNiveau.TabIndex = 6;
            // 
            // cCapacite
            // 
            this.cCapacite.FormattingEnabled = true;
            this.cCapacite.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.cCapacite.Location = new System.Drawing.Point(385, 117);
            this.cCapacite.Name = "cCapacite";
            this.cCapacite.Size = new System.Drawing.Size(121, 21);
            this.cCapacite.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Niveau";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(574, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Capacité ";
            // 
            // bValider
            // 
            this.bValider.Location = new System.Drawing.Point(385, 191);
            this.bValider.Name = "bValider";
            this.bValider.Size = new System.Drawing.Size(143, 45);
            this.bValider.TabIndex = 10;
            this.bValider.Text = "Valider";
            this.bValider.UseVisualStyleBackColor = true;
            this.bValider.Click += new System.EventHandler(this.bValider_Click);
            // 
            // AjoutSeance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bValider);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cCapacite);
            this.Controls.Add(this.cNiveau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Prof);
            this.Controls.Add(this.cTranche);
            this.Controls.Add(this.cJour);
            this.Controls.Add(this.cProf);
            this.Name = "AjoutSeance";
            this.Text = "AjoutSeance";
            this.Load += new System.EventHandler(this.AjoutSeance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cProf;
        private System.Windows.Forms.ComboBox cJour;
        private System.Windows.Forms.ComboBox cTranche;
        private System.Windows.Forms.Label Prof;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cNiveau;
        private System.Windows.Forms.ComboBox cCapacite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bValider;
    }
}