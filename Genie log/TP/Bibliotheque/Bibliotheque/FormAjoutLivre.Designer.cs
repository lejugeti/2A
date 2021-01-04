namespace App
{
    partial class FormAjoutLivre
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
            this.lbTitre = new System.Windows.Forms.Label();
            this.tbTitre = new System.Windows.Forms.TextBox();
            this.tbAuteur = new System.Windows.Forms.TextBox();
            this.lbAuteur = new System.Windows.Forms.Label();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.lbISBN = new System.Windows.Forms.Label();
            this.btnAjout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitre
            // 
            this.lbTitre.AutoSize = true;
            this.lbTitre.Location = new System.Drawing.Point(97, 17);
            this.lbTitre.Name = "lbTitre";
            this.lbTitre.Size = new System.Drawing.Size(28, 13);
            this.lbTitre.TabIndex = 0;
            this.lbTitre.Text = "Titre";
            // 
            // tbTitre
            // 
            this.tbTitre.Location = new System.Drawing.Point(100, 34);
            this.tbTitre.Name = "tbTitre";
            this.tbTitre.Size = new System.Drawing.Size(100, 20);
            this.tbTitre.TabIndex = 1;
            // 
            // tbAuteur
            // 
            this.tbAuteur.Location = new System.Drawing.Point(100, 89);
            this.tbAuteur.Name = "tbAuteur";
            this.tbAuteur.Size = new System.Drawing.Size(100, 20);
            this.tbAuteur.TabIndex = 3;
            // 
            // lbAuteur
            // 
            this.lbAuteur.AutoSize = true;
            this.lbAuteur.Location = new System.Drawing.Point(97, 72);
            this.lbAuteur.Name = "lbAuteur";
            this.lbAuteur.Size = new System.Drawing.Size(38, 13);
            this.lbAuteur.TabIndex = 2;
            this.lbAuteur.Text = "Auteur";
            // 
            // tbISBN
            // 
            this.tbISBN.Location = new System.Drawing.Point(100, 139);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(100, 20);
            this.tbISBN.TabIndex = 5;
            // 
            // lbISBN
            // 
            this.lbISBN.AutoSize = true;
            this.lbISBN.Location = new System.Drawing.Point(97, 122);
            this.lbISBN.Name = "lbISBN";
            this.lbISBN.Size = new System.Drawing.Size(32, 13);
            this.lbISBN.TabIndex = 4;
            this.lbISBN.Text = "ISBN";
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(81, 179);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(138, 46);
            this.btnAjout.TabIndex = 6;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // FormAjoutLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 268);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.tbISBN);
            this.Controls.Add(this.lbISBN);
            this.Controls.Add(this.tbAuteur);
            this.Controls.Add(this.lbAuteur);
            this.Controls.Add(this.tbTitre);
            this.Controls.Add(this.lbTitre);
            this.Name = "FormAjoutLivre";
            this.Text = "FormAjoutLivre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitre;
        private System.Windows.Forms.TextBox tbTitre;
        private System.Windows.Forms.TextBox tbAuteur;
        private System.Windows.Forms.Label lbAuteur;
        private System.Windows.Forms.TextBox tbISBN;
        private System.Windows.Forms.Label lbISBN;
        private System.Windows.Forms.Button btnAjout;
    }
}