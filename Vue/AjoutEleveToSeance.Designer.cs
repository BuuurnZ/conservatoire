namespace Connecte.Vue
{
    partial class AjoutEleveToSeance
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
            this.bConfirmer = new System.Windows.Forms.Button();
            this.bSupprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxEleve
            // 
            this.listBoxEleve.FormattingEnabled = true;
            this.listBoxEleve.Location = new System.Drawing.Point(12, 12);
            this.listBoxEleve.Name = "listBoxEleve";
            this.listBoxEleve.Size = new System.Drawing.Size(776, 212);
            this.listBoxEleve.TabIndex = 2;
            // 
            // bConfirmer
            // 
            this.bConfirmer.Location = new System.Drawing.Point(83, 293);
            this.bConfirmer.Name = "bConfirmer";
            this.bConfirmer.Size = new System.Drawing.Size(180, 103);
            this.bConfirmer.TabIndex = 28;
            this.bConfirmer.Text = "Confirmer";
            this.bConfirmer.UseVisualStyleBackColor = true;
            this.bConfirmer.Click += new System.EventHandler(this.bConfirmer_Click);
            // 
            // bSupprimer
            // 
            this.bSupprimer.Location = new System.Drawing.Point(486, 297);
            this.bSupprimer.Name = "bSupprimer";
            this.bSupprimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bSupprimer.Size = new System.Drawing.Size(186, 94);
            this.bSupprimer.TabIndex = 29;
            this.bSupprimer.Text = "Ajouter";
            this.bSupprimer.UseVisualStyleBackColor = true;
            this.bSupprimer.Click += new System.EventHandler(this.bSupprimer_Click);
            // 
            // AjoutEleveToSeance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bSupprimer);
            this.Controls.Add(this.bConfirmer);
            this.Controls.Add(this.listBoxEleve);
            this.Name = "AjoutEleveToSeance";
            this.Text = "AjoutEleveToSeance";
            this.Load += new System.EventHandler(this.AjoutEleveToSeance_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEleve;
        private System.Windows.Forms.Button bConfirmer;
        private System.Windows.Forms.Button bSupprimer;
    }
}