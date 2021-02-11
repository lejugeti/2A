namespace WindowsFormsApp1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonInit = new System.Windows.Forms.Button();
            this.buttonClassification = new System.Windows.Forms.Button();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.labelX1 = new System.Windows.Forms.Label();
            this.textBoxY1 = new System.Windows.Forms.TextBox();
            this.textBoxY2 = new System.Windows.Forms.TextBox();
            this.labelY2 = new System.Windows.Forms.Label();
            this.labelX2 = new System.Windows.Forms.Label();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.textBoxSigma1 = new System.Windows.Forms.TextBox();
            this.Y1 = new System.Windows.Forms.Label();
            this.labelSigma1 = new System.Windows.Forms.Label();
            this.labelSigma2 = new System.Windows.Forms.Label();
            this.textBoxSigma2 = new System.Windows.Forms.TextBox();
            this.labelClasse1 = new System.Windows.Forms.Label();
            this.labelClasse2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxnbiter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelC1bons = new System.Windows.Forms.Label();
            this.labelC2mauvais = new System.Windows.Forms.Label();
            this.labelC1mauvais = new System.Windows.Forms.Label();
            this.labelC2bons = new System.Windows.Forms.Label();
            this.labelclasstolearn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Sans_titre;
            this.pictureBox1.Location = new System.Drawing.Point(496, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 600);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonInit
            // 
            this.buttonInit.Location = new System.Drawing.Point(214, 124);
            this.buttonInit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInit.Name = "buttonInit";
            this.buttonInit.Size = new System.Drawing.Size(56, 19);
            this.buttonInit.TabIndex = 1;
            this.buttonInit.Text = "Init";
            this.buttonInit.UseVisualStyleBackColor = true;
            this.buttonInit.Click += new System.EventHandler(this.buttonInit_Click);
            // 
            // buttonClassification
            // 
            this.buttonClassification.Location = new System.Drawing.Point(201, 184);
            this.buttonClassification.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClassification.Name = "buttonClassification";
            this.buttonClassification.Size = new System.Drawing.Size(98, 29);
            this.buttonClassification.TabIndex = 3;
            this.buttonClassification.Text = "Classification";
            this.buttonClassification.UseVisualStyleBackColor = true;
            this.buttonClassification.Click += new System.EventHandler(this.buttonClassification_Click);
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(174, 43);
            this.textBoxX1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(48, 20);
            this.textBoxX1.TabIndex = 5;
            this.textBoxX1.Text = "200";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(151, 45);
            this.labelX1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(20, 13);
            this.labelX1.TabIndex = 6;
            this.labelX1.Text = "X1";
            // 
            // textBoxY1
            // 
            this.textBoxY1.Location = new System.Drawing.Point(275, 43);
            this.textBoxY1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.Size = new System.Drawing.Size(48, 20);
            this.textBoxY1.TabIndex = 8;
            this.textBoxY1.Text = "400";
            // 
            // textBoxY2
            // 
            this.textBoxY2.Location = new System.Drawing.Point(275, 80);
            this.textBoxY2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.Size = new System.Drawing.Size(48, 20);
            this.textBoxY2.TabIndex = 12;
            this.textBoxY2.Text = "400";
            // 
            // labelY2
            // 
            this.labelY2.AutoSize = true;
            this.labelY2.Location = new System.Drawing.Point(252, 81);
            this.labelY2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelY2.Name = "labelY2";
            this.labelY2.Size = new System.Drawing.Size(20, 13);
            this.labelY2.TabIndex = 11;
            this.labelY2.Text = "Y2";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(151, 81);
            this.labelX2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(20, 13);
            this.labelX2.TabIndex = 10;
            this.labelX2.Text = "X2";
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(174, 80);
            this.textBoxX2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(48, 20);
            this.textBoxX2.TabIndex = 9;
            this.textBoxX2.Text = "340";
            // 
            // textBoxSigma1
            // 
            this.textBoxSigma1.Location = new System.Drawing.Point(392, 42);
            this.textBoxSigma1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSigma1.Name = "textBoxSigma1";
            this.textBoxSigma1.Size = new System.Drawing.Size(48, 20);
            this.textBoxSigma1.TabIndex = 13;
            this.textBoxSigma1.Text = "20";
            // 
            // Y1
            // 
            this.Y1.AutoSize = true;
            this.Y1.Location = new System.Drawing.Point(252, 45);
            this.Y1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Y1.Name = "Y1";
            this.Y1.Size = new System.Drawing.Size(20, 13);
            this.Y1.TabIndex = 7;
            this.Y1.Text = "Y1";
            // 
            // labelSigma1
            // 
            this.labelSigma1.AutoSize = true;
            this.labelSigma1.Location = new System.Drawing.Point(346, 45);
            this.labelSigma1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSigma1.Name = "labelSigma1";
            this.labelSigma1.Size = new System.Drawing.Size(42, 13);
            this.labelSigma1.TabIndex = 14;
            this.labelSigma1.Text = "Sigma1";
            // 
            // labelSigma2
            // 
            this.labelSigma2.AutoSize = true;
            this.labelSigma2.Location = new System.Drawing.Point(346, 80);
            this.labelSigma2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSigma2.Name = "labelSigma2";
            this.labelSigma2.Size = new System.Drawing.Size(42, 13);
            this.labelSigma2.TabIndex = 15;
            this.labelSigma2.Text = "Sigma2";
            // 
            // textBoxSigma2
            // 
            this.textBoxSigma2.Location = new System.Drawing.Point(392, 79);
            this.textBoxSigma2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSigma2.Name = "textBoxSigma2";
            this.textBoxSigma2.Size = new System.Drawing.Size(48, 20);
            this.textBoxSigma2.TabIndex = 16;
            this.textBoxSigma2.Text = "20";
            // 
            // labelClasse1
            // 
            this.labelClasse1.AutoSize = true;
            this.labelClasse1.Location = new System.Drawing.Point(84, 46);
            this.labelClasse1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClasse1.Name = "labelClasse1";
            this.labelClasse1.Size = new System.Drawing.Size(47, 13);
            this.labelClasse1.TabIndex = 17;
            this.labelClasse1.Text = "Classe 1";
            // 
            // labelClasse2
            // 
            this.labelClasse2.AutoSize = true;
            this.labelClasse2.Location = new System.Drawing.Point(84, 81);
            this.labelClasse2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClasse2.Name = "labelClasse2";
            this.labelClasse2.Size = new System.Drawing.Size(47, 13);
            this.labelClasse2.TabIndex = 18;
            this.labelClasse2.Text = "Classe 2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 266);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 36);
            this.button1.TabIndex = 19;
            this.button1.Text = "Apprentissage et classification";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxnbiter
            // 
            this.textBoxnbiter.Location = new System.Drawing.Point(118, 284);
            this.textBoxnbiter.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxnbiter.Name = "textBoxnbiter";
            this.textBoxnbiter.Size = new System.Drawing.Size(65, 20);
            this.textBoxnbiter.TabIndex = 20;
            this.textBoxnbiter.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 266);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nb itérations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 417);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Class assigned";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 371);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "1               2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 395);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 431);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(56, 363);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Confusion matrix";
            // 
            // labelC1bons
            // 
            this.labelC1bons.AutoSize = true;
            this.labelC1bons.Location = new System.Drawing.Point(209, 395);
            this.labelC1bons.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelC1bons.Name = "labelC1bons";
            this.labelC1bons.Size = new System.Drawing.Size(13, 13);
            this.labelC1bons.TabIndex = 28;
            this.labelC1bons.Text = "0";
            // 
            // labelC2mauvais
            // 
            this.labelC2mauvais.AutoSize = true;
            this.labelC2mauvais.Location = new System.Drawing.Point(263, 395);
            this.labelC2mauvais.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelC2mauvais.Name = "labelC2mauvais";
            this.labelC2mauvais.Size = new System.Drawing.Size(13, 13);
            this.labelC2mauvais.TabIndex = 29;
            this.labelC2mauvais.Text = "0";
            // 
            // labelC1mauvais
            // 
            this.labelC1mauvais.AutoSize = true;
            this.labelC1mauvais.Location = new System.Drawing.Point(209, 431);
            this.labelC1mauvais.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelC1mauvais.Name = "labelC1mauvais";
            this.labelC1mauvais.Size = new System.Drawing.Size(13, 13);
            this.labelC1mauvais.TabIndex = 30;
            this.labelC1mauvais.Text = "0";
            // 
            // labelC2bons
            // 
            this.labelC2bons.AutoSize = true;
            this.labelC2bons.Location = new System.Drawing.Point(263, 431);
            this.labelC2bons.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelC2bons.Name = "labelC2bons";
            this.labelC2bons.Size = new System.Drawing.Size(13, 13);
            this.labelC2bons.TabIndex = 31;
            this.labelC2bons.Text = "0";
            // 
            // labelclasstolearn
            // 
            this.labelclasstolearn.AutoSize = true;
            this.labelclasstolearn.Location = new System.Drawing.Point(212, 348);
            this.labelclasstolearn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelclasstolearn.Name = "labelclasstolearn";
            this.labelclasstolearn.Size = new System.Drawing.Size(70, 13);
            this.labelclasstolearn.TabIndex = 32;
            this.labelclasstolearn.Text = "Class to learn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 220);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nb itérations";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 644);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelclasstolearn);
            this.Controls.Add(this.labelC2bons);
            this.Controls.Add(this.labelC1mauvais);
            this.Controls.Add(this.labelC2mauvais);
            this.Controls.Add(this.labelC1bons);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxnbiter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelClasse2);
            this.Controls.Add(this.labelClasse1);
            this.Controls.Add(this.textBoxSigma2);
            this.Controls.Add(this.labelSigma2);
            this.Controls.Add(this.labelSigma1);
            this.Controls.Add(this.textBoxSigma1);
            this.Controls.Add(this.textBoxY2);
            this.Controls.Add(this.labelY2);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.textBoxY1);
            this.Controls.Add(this.Y1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.buttonClassification);
            this.Controls.Add(this.buttonInit);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Perceptron 1 neurone";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonInit;
        private System.Windows.Forms.Button buttonClassification;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.TextBox textBoxY1;
        private System.Windows.Forms.TextBox textBoxY2;
        private System.Windows.Forms.Label labelY2;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.TextBox textBoxSigma1;
        private System.Windows.Forms.Label Y1;
        private System.Windows.Forms.Label labelSigma1;
        private System.Windows.Forms.Label labelSigma2;
        private System.Windows.Forms.TextBox textBoxSigma2;
        private System.Windows.Forms.Label labelClasse1;
        private System.Windows.Forms.Label labelClasse2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxnbiter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelC1bons;
        private System.Windows.Forms.Label labelC2mauvais;
        private System.Windows.Forms.Label labelC1mauvais;
        private System.Windows.Forms.Label labelC2bons;
        private System.Windows.Forms.Label labelclasstolearn;
        private System.Windows.Forms.Label label2;
    }
}

