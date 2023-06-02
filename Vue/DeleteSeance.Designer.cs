namespace Connecte.Vue
{
    partial class DeleteSeance
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
            this.listBoxSeance = new System.Windows.Forms.ListBox();
            this.bDelete = new System.Windows.Forms.Button();
            this.bValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxSeance
            // 
            this.listBoxSeance.FormattingEnabled = true;
            this.listBoxSeance.Location = new System.Drawing.Point(12, 12);
            this.listBoxSeance.Name = "listBoxSeance";
            this.listBoxSeance.Size = new System.Drawing.Size(776, 212);
            this.listBoxSeance.TabIndex = 3;
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(102, 302);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(131, 90);
            this.bDelete.TabIndex = 4;
            this.bDelete.Text = "Supprimer";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bValider
            // 
            this.bValider.Location = new System.Drawing.Point(495, 302);
            this.bValider.Name = "bValider";
            this.bValider.Size = new System.Drawing.Size(177, 90);
            this.bValider.TabIndex = 5;
            this.bValider.Text = "Valider";
            this.bValider.UseVisualStyleBackColor = true;
            this.bValider.Click += new System.EventHandler(this.bValider_Click);
            // 
            // DeleteSeance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bValider);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.listBoxSeance);
            this.Name = "DeleteSeance";
            this.Text = "DeleteSeance";
            this.Load += new System.EventHandler(this.DeleteSeance_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSeance;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bValider;
    }
}