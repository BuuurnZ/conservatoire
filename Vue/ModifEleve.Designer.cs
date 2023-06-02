namespace Connecte
{
    partial class ModifEleve
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
            this.listBoxEleve = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tBourse = new System.Windows.Forms.TextBox();
            this.labelBourse = new System.Windows.Forms.Label();
            this.labelNiveau = new System.Windows.Forms.Label();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.tAdresse = new System.Windows.Forms.TextBox();
            this.tMail = new System.Windows.Forms.TextBox();
            this.tTelephone = new System.Windows.Forms.TextBox();
            this.labelTéléphone = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.tPrenom = new System.Windows.Forms.TextBox();
            this.tNom = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.modifier = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxEleve
            // 
            this.listBoxEleve.FormattingEnabled = true;
            this.listBoxEleve.Location = new System.Drawing.Point(12, 12);
            this.listBoxEleve.Name = "listBoxEleve";
            this.listBoxEleve.Size = new System.Drawing.Size(776, 212);
            this.listBoxEleve.TabIndex = 0;
            this.listBoxEleve.SelectedIndexChanged += new System.EventHandler(this.listBoxEleve_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tBourse);
            this.groupBox3.Controls.Add(this.labelBourse);
            this.groupBox3.Controls.Add(this.labelNiveau);
            this.groupBox3.Controls.Add(this.labelAdresse);
            this.groupBox3.Controls.Add(this.labelMail);
            this.groupBox3.Controls.Add(this.tAdresse);
            this.groupBox3.Controls.Add(this.tMail);
            this.groupBox3.Controls.Add(this.tTelephone);
            this.groupBox3.Controls.Add(this.labelTéléphone);
            this.groupBox3.Controls.Add(this.labelPrenom);
            this.groupBox3.Controls.Add(this.labelNom);
            this.groupBox3.Controls.Add(this.tPrenom);
            this.groupBox3.Controls.Add(this.tNom);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 230);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(401, 208);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Insertion";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // tBourse
            // 
            this.tBourse.Location = new System.Drawing.Point(198, 130);
            this.tBourse.Name = "tBourse";
            this.tBourse.Size = new System.Drawing.Size(100, 20);
            this.tBourse.TabIndex = 34;
            // 
            // labelBourse
            // 
            this.labelBourse.AutoSize = true;
            this.labelBourse.Location = new System.Drawing.Point(315, 133);
            this.labelBourse.Name = "labelBourse";
            this.labelBourse.Size = new System.Drawing.Size(40, 13);
            this.labelBourse.TabIndex = 33;
            this.labelBourse.Text = "Bourse";
            this.labelBourse.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelNiveau
            // 
            this.labelNiveau.AutoSize = true;
            this.labelNiveau.Location = new System.Drawing.Point(315, 130);
            this.labelNiveau.Name = "labelNiveau";
            this.labelNiveau.Size = new System.Drawing.Size(0, 13);
            this.labelNiveau.TabIndex = 32;
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Location = new System.Drawing.Point(315, 82);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(45, 13);
            this.labelAdresse.TabIndex = 31;
            this.labelAdresse.Text = "Adresse";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(315, 36);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(26, 13);
            this.labelMail.TabIndex = 30;
            this.labelMail.Text = "Mail";
            // 
            // tAdresse
            // 
            this.tAdresse.Location = new System.Drawing.Point(198, 82);
            this.tAdresse.Name = "tAdresse";
            this.tAdresse.Size = new System.Drawing.Size(100, 20);
            this.tAdresse.TabIndex = 28;
            // 
            // tMail
            // 
            this.tMail.Location = new System.Drawing.Point(198, 33);
            this.tMail.Name = "tMail";
            this.tMail.Size = new System.Drawing.Size(100, 20);
            this.tMail.TabIndex = 27;
            // 
            // tTelephone
            // 
            this.tTelephone.Location = new System.Drawing.Point(15, 123);
            this.tTelephone.Name = "tTelephone";
            this.tTelephone.Size = new System.Drawing.Size(79, 20);
            this.tTelephone.TabIndex = 26;
            // 
            // labelTéléphone
            // 
            this.labelTéléphone.AutoSize = true;
            this.labelTéléphone.Location = new System.Drawing.Point(100, 126);
            this.labelTéléphone.Name = "labelTéléphone";
            this.labelTéléphone.Size = new System.Drawing.Size(58, 13);
            this.labelTéléphone.TabIndex = 25;
            this.labelTéléphone.Text = "Téléphone";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(100, 82);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(43, 13);
            this.labelPrenom.TabIndex = 24;
            this.labelPrenom.Text = "Prenom";
            this.labelPrenom.Click += new System.EventHandler(this.labelPrenom_Click);
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(100, 33);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(29, 13);
            this.labelNom.TabIndex = 23;
            this.labelNom.Text = "Nom";
            // 
            // tPrenom
            // 
            this.tPrenom.Location = new System.Drawing.Point(15, 79);
            this.tPrenom.Name = "tPrenom";
            this.tPrenom.Size = new System.Drawing.Size(79, 20);
            this.tPrenom.TabIndex = 21;
            // 
            // tNom
            // 
            this.tNom.Location = new System.Drawing.Point(15, 30);
            this.tNom.Name = "tNom";
            this.tNom.Size = new System.Drawing.Size(79, 20);
            this.tNom.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(158, 179);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
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
            this.modifier.Location = new System.Drawing.Point(573, 311);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(112, 62);
            this.modifier.TabIndex = 25;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // AjoutEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.listBoxEleve);
            this.Name = "AjoutEleve";
            this.Text = "AjoutEleve";
            this.Load += new System.EventHandler(this.AjoutEleve_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEleve;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.TextBox tPrenom;
        private System.Windows.Forms.TextBox tNom;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBourse;
        private System.Windows.Forms.Label labelBourse;
        private System.Windows.Forms.Label labelNiveau;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.TextBox tAdresse;
        private System.Windows.Forms.TextBox tMail;
        private System.Windows.Forms.TextBox tTelephone;
        private System.Windows.Forms.Label labelTéléphone;
        private System.Windows.Forms.Button modifier;
    }
}