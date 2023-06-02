namespace Connecte.Vue
{
    partial class AjoutProf
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
            this.tPrenom = new System.Windows.Forms.TextBox();
            this.tNom = new System.Windows.Forms.TextBox();
            this.tTelophone = new System.Windows.Forms.TextBox();
            this.tMail = new System.Windows.Forms.TextBox();
            this.tAdresse = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tSalaire = new System.Windows.Forms.TextBox();
            this.Prenom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Insérer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tPrenom
            // 
            this.tPrenom.Location = new System.Drawing.Point(123, 73);
            this.tPrenom.Name = "tPrenom";
            this.tPrenom.Size = new System.Drawing.Size(100, 20);
            this.tPrenom.TabIndex = 0;
            // 
            // tNom
            // 
            this.tNom.Location = new System.Drawing.Point(123, 127);
            this.tNom.Name = "tNom";
            this.tNom.Size = new System.Drawing.Size(100, 20);
            this.tNom.TabIndex = 1;
            // 
            // tTelophone
            // 
            this.tTelophone.Location = new System.Drawing.Point(123, 177);
            this.tTelophone.Name = "tTelophone";
            this.tTelophone.Size = new System.Drawing.Size(100, 20);
            this.tTelophone.TabIndex = 2;
            // 
            // tMail
            // 
            this.tMail.Location = new System.Drawing.Point(123, 230);
            this.tMail.Name = "tMail";
            this.tMail.Size = new System.Drawing.Size(100, 20);
            this.tMail.TabIndex = 3;
            // 
            // tAdresse
            // 
            this.tAdresse.Location = new System.Drawing.Point(123, 282);
            this.tAdresse.Name = "tAdresse";
            this.tAdresse.Size = new System.Drawing.Size(100, 20);
            this.tAdresse.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Flûte",
            "Piano",
            "Gospel",
            "Solfège"});
            this.comboBox1.Location = new System.Drawing.Point(417, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tSalaire
            // 
            this.tSalaire.Location = new System.Drawing.Point(123, 337);
            this.tSalaire.Name = "tSalaire";
            this.tSalaire.Size = new System.Drawing.Size(100, 20);
            this.tSalaire.TabIndex = 6;
            this.tSalaire.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Prenom
            // 
            this.Prenom.AutoSize = true;
            this.Prenom.Location = new System.Drawing.Point(267, 80);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(43, 13);
            this.Prenom.TabIndex = 7;
            this.Prenom.Text = "Prenom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telephone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mail";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Adresse";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Salaire";
            // 
            // Insérer
            // 
            this.Insérer.Location = new System.Drawing.Point(463, 337);
            this.Insérer.Name = "Insérer";
            this.Insérer.Size = new System.Drawing.Size(75, 23);
            this.Insérer.TabIndex = 13;
            this.Insérer.Text = "Insérer";
            this.Insérer.UseVisualStyleBackColor = true;
            this.Insérer.Click += new System.EventHandler(this.Insérer_Click);
            // 
            // AjoutProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Insérer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.tSalaire);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tAdresse);
            this.Controls.Add(this.tMail);
            this.Controls.Add(this.tTelophone);
            this.Controls.Add(this.tNom);
            this.Controls.Add(this.tPrenom);
            this.Name = "AjoutProf";
            this.Text = "AjoutProf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tPrenom;
        private System.Windows.Forms.TextBox tNom;
        private System.Windows.Forms.TextBox tTelophone;
        private System.Windows.Forms.TextBox tMail;
        private System.Windows.Forms.TextBox tAdresse;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tSalaire;
        private System.Windows.Forms.Label Prenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Insérer;
    }
}