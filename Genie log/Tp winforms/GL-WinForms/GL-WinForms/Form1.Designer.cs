namespace GL_WinForms
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxAnnees = new System.Windows.Forms.GroupBox();
            this.checkBoxCourriels = new System.Windows.Forms.CheckBox();
            this.radioButtonF = new System.Windows.Forms.RadioButton();
            this.radioButtonM = new System.Windows.Forms.RadioButton();
            this.textBoxRemarques = new System.Windows.Forms.TextBox();
            this.labelRemarques = new System.Windows.Forms.Label();
            this.labelAnnee = new System.Windows.Forms.Label();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.labelSexe = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.buttonEnvoyer = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.comboBoxAnnees = new System.Windows.Forms.ComboBox();
            this.groupBoxAnnees.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAnnees
            // 
            this.groupBoxAnnees.Controls.Add(this.comboBoxAnnees);
            this.groupBoxAnnees.Controls.Add(this.checkBoxCourriels);
            this.groupBoxAnnees.Controls.Add(this.radioButtonF);
            this.groupBoxAnnees.Controls.Add(this.radioButtonM);
            this.groupBoxAnnees.Controls.Add(this.textBoxRemarques);
            this.groupBoxAnnees.Controls.Add(this.labelRemarques);
            this.groupBoxAnnees.Controls.Add(this.labelAnnee);
            this.groupBoxAnnees.Controls.Add(this.textBoxPrenom);
            this.groupBoxAnnees.Controls.Add(this.textBoxNom);
            this.groupBoxAnnees.Controls.Add(this.labelSexe);
            this.groupBoxAnnees.Controls.Add(this.labelPrenom);
            this.groupBoxAnnees.Controls.Add(this.labelNom);
            this.groupBoxAnnees.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAnnees.Name = "groupBoxAnnees";
            this.groupBoxAnnees.Size = new System.Drawing.Size(299, 302);
            this.groupBoxAnnees.TabIndex = 0;
            this.groupBoxAnnees.TabStop = false;
            this.groupBoxAnnees.Text = "Informations";
            this.groupBoxAnnees.Enter += new System.EventHandler(this.groupBoxInfos_Enter);
            // 
            // checkBoxCourriels
            // 
            this.checkBoxCourriels.AutoSize = true;
            this.checkBoxCourriels.Checked = true;
            this.checkBoxCourriels.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCourriels.Location = new System.Drawing.Point(22, 174);
            this.checkBoxCourriels.Name = "checkBoxCourriels";
            this.checkBoxCourriels.Size = new System.Drawing.Size(127, 17);
            this.checkBoxCourriels.TabIndex = 11;
            this.checkBoxCourriels.Text = "Recevoir les courriels";
            this.checkBoxCourriels.UseVisualStyleBackColor = true;
            // 
            // radioButtonF
            // 
            this.radioButtonF.AutoSize = true;
            this.radioButtonF.Location = new System.Drawing.Point(129, 113);
            this.radioButtonF.Name = "radioButtonF";
            this.radioButtonF.Size = new System.Drawing.Size(31, 17);
            this.radioButtonF.TabIndex = 10;
            this.radioButtonF.Text = "F";
            this.radioButtonF.UseVisualStyleBackColor = true;
            // 
            // radioButtonM
            // 
            this.radioButtonM.AutoSize = true;
            this.radioButtonM.Checked = true;
            this.radioButtonM.Location = new System.Drawing.Point(89, 113);
            this.radioButtonM.Name = "radioButtonM";
            this.radioButtonM.Size = new System.Drawing.Size(34, 17);
            this.radioButtonM.TabIndex = 9;
            this.radioButtonM.TabStop = true;
            this.radioButtonM.Text = "M";
            this.radioButtonM.UseVisualStyleBackColor = true;
            // 
            // textBoxRemarques
            // 
            this.textBoxRemarques.Location = new System.Drawing.Point(105, 216);
            this.textBoxRemarques.Multiline = true;
            this.textBoxRemarques.Name = "textBoxRemarques";
            this.textBoxRemarques.Size = new System.Drawing.Size(131, 80);
            this.textBoxRemarques.TabIndex = 8;
            // 
            // labelRemarques
            // 
            this.labelRemarques.AutoSize = true;
            this.labelRemarques.Location = new System.Drawing.Point(19, 216);
            this.labelRemarques.Name = "labelRemarques";
            this.labelRemarques.Size = new System.Drawing.Size(70, 13);
            this.labelRemarques.TabIndex = 7;
            this.labelRemarques.Text = "Remarques : ";
            // 
            // labelAnnee
            // 
            this.labelAnnee.AutoSize = true;
            this.labelAnnee.Location = new System.Drawing.Point(19, 140);
            this.labelAnnee.Name = "labelAnnee";
            this.labelAnnee.Size = new System.Drawing.Size(113, 13);
            this.labelAnnee.TabIndex = 5;
            this.labelAnnee.Text = "Année de naissance : ";
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(89, 73);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrenom.TabIndex = 4;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(89, 33);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(100, 20);
            this.textBoxNom.TabIndex = 3;
            // 
            // labelSexe
            // 
            this.labelSexe.AutoSize = true;
            this.labelSexe.Location = new System.Drawing.Point(19, 115);
            this.labelSexe.Name = "labelSexe";
            this.labelSexe.Size = new System.Drawing.Size(37, 13);
            this.labelSexe.TabIndex = 2;
            this.labelSexe.Text = "Sexe :";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(19, 73);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(52, 13);
            this.labelPrenom.TabIndex = 1;
            this.labelPrenom.Text = "Prenom : ";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(19, 33);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(35, 13);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom :";
            // 
            // buttonEnvoyer
            // 
            this.buttonEnvoyer.Location = new System.Drawing.Point(13, 321);
            this.buttonEnvoyer.Name = "buttonEnvoyer";
            this.buttonEnvoyer.Size = new System.Drawing.Size(75, 23);
            this.buttonEnvoyer.TabIndex = 1;
            this.buttonEnvoyer.Text = "Envoyer";
            this.buttonEnvoyer.UseVisualStyleBackColor = true;
            this.buttonEnvoyer.Click += new System.EventHandler(this.buttonEnvoyer_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(117, 321);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Réinitialiser";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(213, 321);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(75, 23);
            this.buttonQuitter.TabIndex = 3;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // comboBoxAnnees
            // 
            this.comboBoxAnnees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAnnees.FormattingEnabled = true;
            this.comboBoxAnnees.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003"});
            this.comboBoxAnnees.Location = new System.Drawing.Point(138, 140);
            this.comboBoxAnnees.Name = "comboBoxAnnees";
            this.comboBoxAnnees.Size = new System.Drawing.Size(65, 21);
            this.comboBoxAnnees.TabIndex = 12;
            this.comboBoxAnnees.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 363);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnvoyer);
            this.Controls.Add(this.groupBoxAnnees);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxAnnees.ResumeLayout(false);
            this.groupBoxAnnees.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAnnees;
        private System.Windows.Forms.RadioButton radioButtonF;
        private System.Windows.Forms.RadioButton radioButtonM;
        private System.Windows.Forms.TextBox textBoxRemarques;
        private System.Windows.Forms.Label labelRemarques;
        private System.Windows.Forms.Label labelAnnee;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label labelSexe;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.CheckBox checkBoxCourriels;
        private System.Windows.Forms.Button buttonEnvoyer;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.ComboBox comboBoxAnnees;
    }
}

