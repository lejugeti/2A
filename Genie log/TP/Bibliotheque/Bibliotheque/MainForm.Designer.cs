namespace App
{
    partial class MainForm
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
            this.dgvLivres = new System.Windows.Forms.DataGridView();
            this.colISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tabPageLivres = new System.Windows.Forms.TabPage();
            this.tabPageUtilisateurs = new System.Windows.Forms.TabPage();
            this.tabPageEmprunt = new System.Windows.Forms.TabPage();
            this.btnAjoutLivre = new System.Windows.Forms.Button();
            this.dgvUtilisateurs = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmprunts = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLivreTitre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLivreISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivres)).BeginInit();
            this.tabCtrl.SuspendLayout();
            this.tabPageLivres.SuspendLayout();
            this.tabPageUtilisateurs.SuspendLayout();
            this.tabPageEmprunt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilisateurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprunts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLivres
            // 
            this.dgvLivres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colISBN,
            this.colTitre,
            this.colAuteur});
            this.dgvLivres.Location = new System.Drawing.Point(6, 6);
            this.dgvLivres.Name = "dgvLivres";
            this.dgvLivres.ReadOnly = true;
            this.dgvLivres.Size = new System.Drawing.Size(371, 291);
            this.dgvLivres.TabIndex = 0;
            // 
            // colISBN
            // 
            this.colISBN.HeaderText = "ISBN";
            this.colISBN.Name = "colISBN";
            this.colISBN.ReadOnly = true;
            // 
            // colTitre
            // 
            this.colTitre.HeaderText = "Titre";
            this.colTitre.Name = "colTitre";
            this.colTitre.ReadOnly = true;
            // 
            // colAuteur
            // 
            this.colAuteur.HeaderText = "Auteur";
            this.colAuteur.Name = "colAuteur";
            this.colAuteur.ReadOnly = true;
            // 
            // tabCtrl
            // 
            this.tabCtrl.Controls.Add(this.tabPageLivres);
            this.tabCtrl.Controls.Add(this.tabPageUtilisateurs);
            this.tabCtrl.Controls.Add(this.tabPageEmprunt);
            this.tabCtrl.Location = new System.Drawing.Point(12, 12);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(430, 332);
            this.tabCtrl.TabIndex = 1;
            // 
            // tabPageLivres
            // 
            this.tabPageLivres.Controls.Add(this.dgvLivres);
            this.tabPageLivres.Location = new System.Drawing.Point(4, 22);
            this.tabPageLivres.Name = "tabPageLivres";
            this.tabPageLivres.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLivres.Size = new System.Drawing.Size(384, 306);
            this.tabPageLivres.TabIndex = 0;
            this.tabPageLivres.Text = "Livres";
            this.tabPageLivres.UseVisualStyleBackColor = true;
            // 
            // tabPageUtilisateurs
            // 
            this.tabPageUtilisateurs.Controls.Add(this.dgvUtilisateurs);
            this.tabPageUtilisateurs.Location = new System.Drawing.Point(4, 22);
            this.tabPageUtilisateurs.Name = "tabPageUtilisateurs";
            this.tabPageUtilisateurs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUtilisateurs.Size = new System.Drawing.Size(384, 306);
            this.tabPageUtilisateurs.TabIndex = 1;
            this.tabPageUtilisateurs.Text = "Utilisateurs";
            this.tabPageUtilisateurs.UseVisualStyleBackColor = true;
            // 
            // tabPageEmprunt
            // 
            this.tabPageEmprunt.Controls.Add(this.dgvEmprunts);
            this.tabPageEmprunt.Location = new System.Drawing.Point(4, 22);
            this.tabPageEmprunt.Name = "tabPageEmprunt";
            this.tabPageEmprunt.Size = new System.Drawing.Size(422, 306);
            this.tabPageEmprunt.TabIndex = 2;
            this.tabPageEmprunt.Text = "Emprunt";
            this.tabPageEmprunt.UseVisualStyleBackColor = true;
            // 
            // btnAjoutLivre
            // 
            this.btnAjoutLivre.Location = new System.Drawing.Point(448, 272);
            this.btnAjoutLivre.Name = "btnAjoutLivre";
            this.btnAjoutLivre.Size = new System.Drawing.Size(129, 68);
            this.btnAjoutLivre.TabIndex = 2;
            this.btnAjoutLivre.Text = "Ajouter un livre";
            this.btnAjoutLivre.UseVisualStyleBackColor = true;
            this.btnAjoutLivre.Click += new System.EventHandler(this.btnAjoutLivre_Click);
            // 
            // dgvUtilisateurs
            // 
            this.dgvUtilisateurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtilisateurs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNom,
            this.colPrenom});
            this.dgvUtilisateurs.Location = new System.Drawing.Point(6, 6);
            this.dgvUtilisateurs.Name = "dgvUtilisateurs";
            this.dgvUtilisateurs.ReadOnly = true;
            this.dgvUtilisateurs.Size = new System.Drawing.Size(372, 294);
            this.dgvUtilisateurs.TabIndex = 0;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colNom
            // 
            this.colNom.HeaderText = "Nom";
            this.colNom.Name = "colNom";
            this.colNom.ReadOnly = true;
            // 
            // colPrenom
            // 
            this.colPrenom.HeaderText = "Prénom";
            this.colPrenom.Name = "colPrenom";
            this.colPrenom.ReadOnly = true;
            // 
            // dgvEmprunts
            // 
            this.dgvEmprunts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmprunts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.colUtilisateur,
            this.colLivreTitre,
            this.colLivreISBN});
            this.dgvEmprunts.Location = new System.Drawing.Point(4, 3);
            this.dgvEmprunts.Name = "dgvEmprunts";
            this.dgvEmprunts.ReadOnly = true;
            this.dgvEmprunts.Size = new System.Drawing.Size(415, 300);
            this.dgvEmprunts.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // colUtilisateur
            // 
            this.colUtilisateur.HeaderText = "Utilisateur";
            this.colUtilisateur.Name = "colUtilisateur";
            this.colUtilisateur.ReadOnly = true;
            // 
            // colLivreTitre
            // 
            this.colLivreTitre.HeaderText = "Titre";
            this.colLivreTitre.Name = "colLivreTitre";
            this.colLivreTitre.ReadOnly = true;
            // 
            // colLivreISBN
            // 
            this.colLivreISBN.HeaderText = "ISBN";
            this.colLivreISBN.Name = "colLivreISBN";
            this.colLivreISBN.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAjoutLivre);
            this.Controls.Add(this.tabCtrl);
            this.Name = "MainForm";
            this.Text = "Bibliothèque";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivres)).EndInit();
            this.tabCtrl.ResumeLayout(false);
            this.tabPageLivres.ResumeLayout(false);
            this.tabPageUtilisateurs.ResumeLayout(false);
            this.tabPageEmprunt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilisateurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprunts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLivres;
        private System.Windows.Forms.DataGridViewTextBoxColumn colISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuteur;
        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.TabPage tabPageLivres;
        private System.Windows.Forms.TabPage tabPageUtilisateurs;
        private System.Windows.Forms.TabPage tabPageEmprunt;
        private System.Windows.Forms.Button btnAjoutLivre;
        private System.Windows.Forms.DataGridView dgvUtilisateurs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrenom;
        private System.Windows.Forms.DataGridView dgvEmprunts;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLivreTitre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLivreISBN;
    }
}

