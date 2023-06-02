namespace Connecte.Vue
{
    partial class DeleteEleveToSeance
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
            this.bSupprimer = new System.Windows.Forms.Button();
            this.bConfirmer = new System.Windows.Forms.Button();
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
            // bSupprimer
            // 
            this.bSupprimer.Location = new System.Drawing.Point(525, 303);
            this.bSupprimer.Name = "bSupprimer";
            this.bSupprimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bSupprimer.Size = new System.Drawing.Size(152, 75);
            this.bSupprimer.TabIndex = 26;
            this.bSupprimer.Text = "Supprimer";
            this.bSupprimer.UseVisualStyleBackColor = true;
            this.bSupprimer.Click += new System.EventHandler(this.bSupprimer_Click);
            // 
            // bConfirmer
            // 
            this.bConfirmer.Location = new System.Drawing.Point(104, 303);
            this.bConfirmer.Name = "bConfirmer";
            this.bConfirmer.Size = new System.Drawing.Size(153, 75);
            this.bConfirmer.TabIndex = 27;
            this.bConfirmer.Text = "Confirmer";
            this.bConfirmer.UseVisualStyleBackColor = true;
            this.bConfirmer.Click += new System.EventHandler(this.bConfirmer_Click);
            // 
            // DeleteEleveToSeance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bConfirmer);
            this.Controls.Add(this.bSupprimer);
            this.Controls.Add(this.listBoxEleve);
            this.Name = "DeleteEleveToSeance";
            this.Text = "DeleteEleveToSeance";
            this.Load += new System.EventHandler(this.DeleteEleveToSeance_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEleve;
        private System.Windows.Forms.Button bSupprimer;
        private System.Windows.Forms.Button bConfirmer;
    }
}