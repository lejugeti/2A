namespace WindowsFormsApplication1
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
            this.buttonInitReseau = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxnbentrees = new System.Windows.Forms.TextBox();
            this.textBoxnbcouches = new System.Windows.Forms.TextBox();
            this.textBoxnbneurcouche = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxnbiter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxalpha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.labelerreursclasse1 = new System.Windows.Forms.Label();
            this.labelerreursclasse2 = new System.Windows.Forms.Label();
            this.labelerreursprecision = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonInitReseau
            // 
            this.buttonInitReseau.Location = new System.Drawing.Point(267, 108);
            this.buttonInitReseau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInitReseau.Name = "buttonInitReseau";
            this.buttonInitReseau.Size = new System.Drawing.Size(155, 46);
            this.buttonInitReseau.TabIndex = 0;
            this.buttonInitReseau.Text = "Init réseau";
            this.buttonInitReseau.UseVisualStyleBackColor = true;
            this.buttonInitReseau.Click += new System.EventHandler(this.buttonInitReseau_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 375);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 58);
            this.button2.TabIndex = 1;
            this.button2.Text = "apprentissage classification 1D";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxnbentrees
            // 
            this.textBoxnbentrees.Location = new System.Drawing.Point(224, 7);
            this.textBoxnbentrees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxnbentrees.Name = "textBoxnbentrees";
            this.textBoxnbentrees.Size = new System.Drawing.Size(71, 22);
            this.textBoxnbentrees.TabIndex = 3;
            this.textBoxnbentrees.Text = "1";
            // 
            // textBoxnbcouches
            // 
            this.textBoxnbcouches.Location = new System.Drawing.Point(224, 34);
            this.textBoxnbcouches.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxnbcouches.Name = "textBoxnbcouches";
            this.textBoxnbcouches.Size = new System.Drawing.Size(71, 22);
            this.textBoxnbcouches.TabIndex = 4;
            this.textBoxnbcouches.Text = "1";
            // 
            // textBoxnbneurcouche
            // 
            this.textBoxnbneurcouche.Location = new System.Drawing.Point(224, 63);
            this.textBoxnbneurcouche.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxnbneurcouche.Name = "textBoxnbneurcouche";
            this.textBoxnbneurcouche.Size = new System.Drawing.Size(71, 22);
            this.textBoxnbneurcouche.TabIndex = 5;
            this.textBoxnbneurcouche.Text = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "nb entrées";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "nb couches cachées";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "nb neurones par couche cachée";
            // 
            // textBoxnbiter
            // 
            this.textBoxnbiter.Location = new System.Drawing.Point(158, 231);
            this.textBoxnbiter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxnbiter.Name = "textBoxnbiter";
            this.textBoxnbiter.Size = new System.Drawing.Size(79, 22);
            this.textBoxnbiter.TabIndex = 15;
            this.textBoxnbiter.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(376, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "nb de fois qu\'on présente chaque exemple (nb d\'époques)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(470, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "alpha (coefficient d\'apprentissage, constant pour ce programme simplifié)";
            // 
            // textBoxalpha
            // 
            this.textBoxalpha.Location = new System.Drawing.Point(158, 307);
            this.textBoxalpha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxalpha.Name = "textBoxalpha";
            this.textBoxalpha.Size = new System.Drawing.Size(55, 22);
            this.textBoxalpha.TabIndex = 18;
            this.textBoxalpha.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(303, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(232, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "0 au minimum, 2 maximum conseillé";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(50, 123);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(210, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "Obligatoire pour créer le réseau";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(80, 356);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(534, 17);
            this.label13.TabIndex = 24;
            this.label13.Text = "Cliquez plusieurs fois pour poursuivre l\'apprentissage, en adaptant le nb d\'époqu" +
    "es";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(319, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "F(x)=si x dans ]0.3;0.7[ alors sortie =0.2 sinon 0.8";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(28, 447);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 58);
            this.button3.TabIndex = 26;
            this.button3.Text = "apprentissage régression  1D";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "F(x)=Sin(x * 20) / 2.5 + 0.5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(221, 413);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(202, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Dataset : 1000 couples (x,F(x))";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(220, 474);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(202, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "Dataset : 1000 couples (x,F(x))";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(28, 556);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 77);
            this.button4.TabIndex = 30;
            this.button4.Text = "apprentissage classification 2D (init. réseau avec 2 entrées !)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(239, 556);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(292, 66);
            this.label11.TabIndex = 32;
            this.label11.Text = "F(x,y)=Si Sqrt((x - 200) * (x - 200) + (y - 200) * (y - 200)) <200 alors sortie= " +
    "0.8 sinon 0.2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(239, 596);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(217, 17);
            this.label14.TabIndex = 33;
            this.label14.Text = "Dataset : 1000 triplets (x,y,F(x,y))";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.image_noire_800;
            this.pictureBox2.Location = new System.Drawing.Point(708, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(800, 800);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(313, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(199, 17);
            this.label15.TabIndex = 34;
            this.label15.Text = "1 ou 2 dans le cadre de ce TP";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(313, 63);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(220, 17);
            this.label16.TabIndex = 35;
            this.label16.Text = "3 minimum, 25 maximum conseillé";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(239, 616);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(350, 17);
            this.label17.TabIndex = 36;
            this.label17.Text = "bleu classe 1, jaune classe 2; autres couleurs=erreurs";
            // 
            // labelerreursclasse1
            // 
            this.labelerreursclasse1.AutoSize = true;
            this.labelerreursclasse1.Location = new System.Drawing.Point(113, 678);
            this.labelerreursclasse1.Name = "labelerreursclasse1";
            this.labelerreursclasse1.Size = new System.Drawing.Size(134, 17);
            this.labelerreursclasse1.TabIndex = 37;
            this.labelerreursclasse1.Text = "% erreurs classe 1 :";
            // 
            // labelerreursclasse2
            // 
            this.labelerreursclasse2.AutoSize = true;
            this.labelerreursclasse2.Location = new System.Drawing.Point(113, 707);
            this.labelerreursclasse2.Name = "labelerreursclasse2";
            this.labelerreursclasse2.Size = new System.Drawing.Size(134, 17);
            this.labelerreursclasse2.TabIndex = 38;
            this.labelerreursclasse2.Text = "% erreurs classe 2 :";
            // 
            // labelerreursprecision
            // 
            this.labelerreursprecision.AutoSize = true;
            this.labelerreursprecision.Location = new System.Drawing.Point(113, 735);
            this.labelerreursprecision.Name = "labelerreursprecision";
            this.labelerreursprecision.Size = new System.Drawing.Size(248, 17);
            this.labelerreursprecision.TabIndex = 39;
            this.labelerreursprecision.Text = "% erreurs de précision (erreur > 0.1) :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1535, 953);
            this.Controls.Add(this.labelerreursprecision);
            this.Controls.Add(this.labelerreursclasse2);
            this.Controls.Add(this.labelerreursclasse1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxalpha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxnbiter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxnbneurcouche);
            this.Controls.Add(this.textBoxnbcouches);
            this.Controls.Add(this.textBoxnbentrees);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonInitReseau);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Perceptron multi-couches";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInitReseau;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxnbentrees;
        private System.Windows.Forms.TextBox textBoxnbcouches;
        private System.Windows.Forms.TextBox textBoxnbneurcouche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxnbiter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxalpha;
        private System.Windows.Forms.Label label8;
       
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labelerreursclasse1;
        private System.Windows.Forms.Label labelerreursclasse2;
        private System.Windows.Forms.Label labelerreursprecision;
    }
}