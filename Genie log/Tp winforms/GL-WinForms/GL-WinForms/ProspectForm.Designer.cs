namespace GL_WinForms
{
    partial class ProspectForm
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
            this.textBoxAddNotes = new System.Windows.Forms.TextBox();
            this.textBoxAddCourriel = new System.Windows.Forms.TextBox();
            this.textBoxAddPrenom = new System.Windows.Forms.TextBox();
            this.labelNotes = new System.Windows.Forms.Label();
            this.labelLastContact = new System.Windows.Forms.Label();
            this.labelCourriel = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.textBoxAddNom = new System.Windows.Forms.TextBox();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.datePickerAddContact = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // textBoxAddNotes
            // 
            this.textBoxAddNotes.Location = new System.Drawing.Point(126, 176);
            this.textBoxAddNotes.Multiline = true;
            this.textBoxAddNotes.Name = "textBoxAddNotes";
            this.textBoxAddNotes.Size = new System.Drawing.Size(173, 93);
            this.textBoxAddNotes.TabIndex = 19;
            // 
            // textBoxAddCourriel
            // 
            this.textBoxAddCourriel.Location = new System.Drawing.Point(126, 104);
            this.textBoxAddCourriel.Name = "textBoxAddCourriel";
            this.textBoxAddCourriel.Size = new System.Drawing.Size(173, 20);
            this.textBoxAddCourriel.TabIndex = 18;
            // 
            // textBoxAddPrenom
            // 
            this.textBoxAddPrenom.Location = new System.Drawing.Point(126, 67);
            this.textBoxAddPrenom.Name = "textBoxAddPrenom";
            this.textBoxAddPrenom.Size = new System.Drawing.Size(173, 20);
            this.textBoxAddPrenom.TabIndex = 17;
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Location = new System.Drawing.Point(63, 176);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(38, 13);
            this.labelNotes.TabIndex = 16;
            this.labelNotes.Text = "Notes:";
            // 
            // labelLastContact
            // 
            this.labelLastContact.AutoSize = true;
            this.labelLastContact.Location = new System.Drawing.Point(26, 135);
            this.labelLastContact.Name = "labelLastContact";
            this.labelLastContact.Size = new System.Drawing.Size(84, 13);
            this.labelLastContact.TabIndex = 15;
            this.labelLastContact.Text = "Dernier Contact:";
            // 
            // labelCourriel
            // 
            this.labelCourriel.AutoSize = true;
            this.labelCourriel.Location = new System.Drawing.Point(64, 104);
            this.labelCourriel.Name = "labelCourriel";
            this.labelCourriel.Size = new System.Drawing.Size(45, 13);
            this.labelCourriel.TabIndex = 14;
            this.labelCourriel.Text = "Courriel:";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(64, 67);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(46, 13);
            this.labelPrenom.TabIndex = 13;
            this.labelPrenom.Text = "Prénom:";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(78, 33);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(32, 13);
            this.labelNom.TabIndex = 12;
            this.labelNom.Text = "Nom:";
            // 
            // textBoxAddNom
            // 
            this.textBoxAddNom.Location = new System.Drawing.Point(126, 33);
            this.textBoxAddNom.Name = "textBoxAddNom";
            this.textBoxAddNom.Size = new System.Drawing.Size(173, 20);
            this.textBoxAddNom.TabIndex = 11;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(81, 303);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(157, 35);
            this.buttonAjouter.TabIndex = 21;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // datePickerAddContact
            // 
            this.datePickerAddContact.Location = new System.Drawing.Point(126, 135);
            this.datePickerAddContact.Name = "datePickerAddContact";
            this.datePickerAddContact.Size = new System.Drawing.Size(173, 20);
            this.datePickerAddContact.TabIndex = 22;
            // 
            // ProspectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 350);
            this.Controls.Add(this.datePickerAddContact);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.textBoxAddNotes);
            this.Controls.Add(this.textBoxAddCourriel);
            this.Controls.Add(this.textBoxAddPrenom);
            this.Controls.Add(this.labelNotes);
            this.Controls.Add(this.labelLastContact);
            this.Controls.Add(this.labelCourriel);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.textBoxAddNom);
            this.Name = "ProspectForm";
            this.Text = "ProspectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxAddNotes;
        private System.Windows.Forms.TextBox textBoxAddCourriel;
        private System.Windows.Forms.TextBox textBoxAddPrenom;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.Label labelLastContact;
        private System.Windows.Forms.Label labelCourriel;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.TextBox textBoxAddNom;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.DateTimePicker datePickerAddContact;
    }
}