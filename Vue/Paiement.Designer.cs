namespace Connecte
{
    partial class Paiement
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
            this.modifier = new System.Windows.Forms.Button();
            this.listBoxPaiement = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxEleve
            // 
            this.listBoxEleve.FormattingEnabled = true;
            this.listBoxEleve.Location = new System.Drawing.Point(12, 12);
            this.listBoxEleve.Name = "listBoxEleve";
            this.listBoxEleve.Size = new System.Drawing.Size(776, 212);
            this.listBoxEleve.TabIndex = 1;
            // 
            // modifier
            // 
            this.modifier.Location = new System.Drawing.Point(519, 300);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(142, 75);
            this.modifier.TabIndex = 26;
            this.modifier.Text = "Voir Paiement";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // listBoxPaiement
            // 
            this.listBoxPaiement.FormattingEnabled = true;
            this.listBoxPaiement.Location = new System.Drawing.Point(12, 269);
            this.listBoxPaiement.Name = "listBoxPaiement";
            this.listBoxPaiement.Size = new System.Drawing.Size(296, 147);
            this.listBoxPaiement.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 28;
            // 
            // Paiement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxPaiement);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.listBoxEleve);
            this.Name = "Paiement";
            this.Text = "Paiement";
            this.Load += new System.EventHandler(this.Paiement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEleve;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.ListBox listBoxPaiement;
        private System.Windows.Forms.Label label1;
    }
}