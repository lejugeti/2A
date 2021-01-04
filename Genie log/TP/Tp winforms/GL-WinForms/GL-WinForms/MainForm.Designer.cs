namespace GL_WinForms
{
    partial class MainForm
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
            this.listBoxPospect = new System.Windows.Forms.ListBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelCourriel = new System.Windows.Forms.Label();
            this.labelLastContact = new System.Windows.Forms.Label();
            this.labelNotes = new System.Windows.Forms.Label();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxCourriel = new System.Windows.Forms.TextBox();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.buttonAddProspect = new System.Windows.Forms.Button();
            this.dateProspect = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // listBoxPospect
            // 
            this.listBoxPospect.FormattingEnabled = true;
            this.listBoxPospect.Location = new System.Drawing.Point(12, 12);
            this.listBoxPospect.Name = "listBoxPospect";
            this.listBoxPospect.Size = new System.Drawing.Size(130, 420);
            this.listBoxPospect.TabIndex = 0;
            this.listBoxPospect.SelectedIndexChanged += new System.EventHandler(this.listBoxPospect_SelectedIndexChanged);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Enabled = false;
            this.textBoxNom.Location = new System.Drawing.Point(288, 31);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(200, 20);
            this.textBoxNom.TabIndex = 1;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(208, 37);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(32, 13);
            this.labelNom.TabIndex = 2;
            this.labelNom.Text = "Nom:";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(194, 87);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(46, 13);
            this.labelPrenom.TabIndex = 3;
            this.labelPrenom.Text = "Prénom:";
            // 
            // labelCourriel
            // 
            this.labelCourriel.AutoSize = true;
            this.labelCourriel.Location = new System.Drawing.Point(194, 124);
            this.labelCourriel.Name = "labelCourriel";
            this.labelCourriel.Size = new System.Drawing.Size(45, 13);
            this.labelCourriel.TabIndex = 4;
            this.labelCourriel.Text = "Courriel:";
            // 
            // labelLastContact
            // 
            this.labelLastContact.AutoSize = true;
            this.labelLastContact.Location = new System.Drawing.Point(156, 155);
            this.labelLastContact.Name = "labelLastContact";
            this.labelLastContact.Size = new System.Drawing.Size(84, 13);
            this.labelLastContact.TabIndex = 5;
            this.labelLastContact.Text = "Dernier Contact:";
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Location = new System.Drawing.Point(193, 196);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(38, 13);
            this.labelNotes.TabIndex = 6;
            this.labelNotes.Text = "Notes:";
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Enabled = false;
            this.textBoxPrenom.Location = new System.Drawing.Point(288, 87);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(200, 20);
            this.textBoxPrenom.TabIndex = 7;
            // 
            // textBoxCourriel
            // 
            this.textBoxCourriel.Enabled = false;
            this.textBoxCourriel.Location = new System.Drawing.Point(288, 124);
            this.textBoxCourriel.Name = "textBoxCourriel";
            this.textBoxCourriel.Size = new System.Drawing.Size(200, 20);
            this.textBoxCourriel.TabIndex = 8;
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Enabled = false;
            this.textBoxNotes.Location = new System.Drawing.Point(288, 196);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(200, 93);
            this.textBoxNotes.TabIndex = 9;
            // 
            // buttonAddProspect
            // 
            this.buttonAddProspect.Location = new System.Drawing.Point(177, 373);
            this.buttonAddProspect.Name = "buttonAddProspect";
            this.buttonAddProspect.Size = new System.Drawing.Size(39, 34);
            this.buttonAddProspect.TabIndex = 11;
            this.buttonAddProspect.Text = "+";
            this.buttonAddProspect.UseVisualStyleBackColor = true;
            this.buttonAddProspect.Click += new System.EventHandler(this.buttonAddProspect_Click);
            // 
            // dateProspect
            // 
            this.dateProspect.Enabled = false;
            this.dateProspect.Location = new System.Drawing.Point(288, 155);
            this.dateProspect.Name = "dateProspect";
            this.dateProspect.Size = new System.Drawing.Size(200, 20);
            this.dateProspect.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateProspect);
            this.Controls.Add(this.buttonAddProspect);
            this.Controls.Add(this.textBoxNotes);
            this.Controls.Add(this.textBoxCourriel);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.labelNotes);
            this.Controls.Add(this.labelLastContact);
            this.Controls.Add(this.labelCourriel);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.listBoxPospect);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPospect;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelCourriel;
        private System.Windows.Forms.Label labelLastContact;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxCourriel;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.Button buttonAddProspect;
        private System.Windows.Forms.DateTimePicker dateProspect;
    }
}