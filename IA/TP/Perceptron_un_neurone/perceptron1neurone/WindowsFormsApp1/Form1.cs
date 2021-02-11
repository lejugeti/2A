using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Random rd = new Random();
     
        Point[] Examples = new Point[1000];  // Exemples
        int[] ClassToLearn = new int[1000];   // classe 1 ou 2 pré-associée à chaque exemple
        int[] ClassAssigned = new int[1000];
        double w1, w2, w3, constante, seuil;
        double k = 2; // coeff d'apprentissage

        public Form1()
        {
            InitializeComponent();
        }

        void affichage()
        {
            // on efface
            for (int x = 0; x < pictureBox1.Width; x++)
                for (int y = 0; y < pictureBox1.Height; y++)
                    bmp.SetPixel(x, y, Color.White);

            for (int i=0; i<1000; i++)
            {
                int x = (int)Examples[i].x;
                int y = (int)Examples[i].y;

                bmp.SetPixel(x, pictureBox1.Height-1 - y, Color.Black);
            }

            pictureBox1.Invalidate();

        }

        private void buttonInit_Click(object sender, EventArgs e)
        {
            Examples = new Point[1000];  // Exemples
            ClassToLearn = new int[1000];   // classe 1 ou 2 pré-associée à chaque exemple
            ClassAssigned = new int[1000];

            bmp = (Bitmap)pictureBox1.Image;

            double x1 = Convert.ToDouble(textBoxX1.Text);
            double y1 = Convert.ToDouble(textBoxY1.Text);
            double x2 = Convert.ToDouble(textBoxX2.Text);
            double y2 = Convert.ToDouble(textBoxY2.Text);
            double sigma1 = Convert.ToDouble(textBoxSigma1.Text);
            double sigma2 = Convert.ToDouble(textBoxSigma2.Text);

            // initialisation des points aléatoires
            int num=0;
            for (int i=0; i<500; i++)
            {
                double U1, U2, x, y, T1;
                
                // Un point de la classe 1
                U1 = rd.NextDouble();
                U2 = rd.NextDouble();
                T1 = Math.Sqrt(-2 * Math.Log(U1)) * Math.Cos(2 * Math.PI * U2); 
                // T1 suit une loi normale centrée sur 0.
                x = x1 + T1 * sigma1;   // pour centrer sur x1 et avec un écart-type sigma1.

                U1 = rd.NextDouble();
                U2 = rd.NextDouble();
                T1 = Math.Sqrt(-2 * Math.Log(U1)) * Math.Cos(2 * Math.PI * U2);
                // T1 suit une loi normale centrée sur 0.
                y = y1 + T1 * sigma1;

                Examples[num] = new Point((float)x, (float)y);
                ClassToLearn[num]= 1;
                num++;

                // un point de C2
                U1 = rd.NextDouble();
                U2 = rd.NextDouble();
                T1 = Math.Sqrt(-2 * Math.Log(U1)) * Math.Cos(2 * Math.PI * U2);
                // T1 suit une loi normale centrée sur 0.
                x = x2 + T1 * sigma2;   // pour centrer sur x2 et avec un écart-type sigma1.

                U1 = rd.NextDouble();
                U2 = rd.NextDouble();
                T1 = Math.Sqrt(-2 * Math.Log(U1)) * Math.Cos(2 * Math.PI * U2);
                y = y2 + T1 * sigma2;

                Examples[num] = new Point((float)x, (float)y);
                ClassToLearn[num]  = 2;
                num++;
            }

            // Initialisation du neurone
            // Initialisation des poids w1, w2 et w3 de manière aléatoire entre -100 et + 100.
            w1 = rd.NextDouble() * 200 - 100;  // entre -100 et 100
            w2 = rd.NextDouble() * 200 - 100;
            w3 = rd.NextDouble() * 200 - 100;
            constante = 100; // même ordre de grandeur que x et y

            // Initialisation de l'attribution des classes
            for (int i=0; i< 1000; i++)
            {
                int sortie = calcule_sortie(Examples[i].x, Examples[i].y);
                if (sortie == 1)
                {
                    ClassAssigned[i] = 1;
                }
                else
                    ClassAssigned[i] = 2 ;
            }

            affichage();
        }

       
        /*  Classification */
        private void buttonClassification_Click(object sender, EventArgs e)
        {
            // On classe tous les pts de l'image
            for (int x2 = 0; x2 < pictureBox1.Width; x2++)
                for (int y2 = 0; y2 < pictureBox1.Height; y2++)
                {
                   int myClass = calcule_sortie(x2, y2);
                   if (myClass ==1)
                        bmp.SetPixel(x2, pictureBox1.Height-1- y2, Color.Yellow);
                   else
                        bmp.SetPixel(x2, pictureBox1.Height-1 - y2, Color.Red);
                    // remarque : Height - y2 car les ordonnées sont inversées
                }

            // On réaffiche les points par dessus et on compte les erreurs par classe
            int cptC1bons = 0;   // Le nb de points de la classe 1 bien classés en classe 1
            int cptC1mauvais = 0;  // Le nb points de la classe 1 affectés en classe 2
            int cptC2bons = 0;  // le nb de points de la classe 2 affectés en classe 2
            int cptC2mauvais = 0;  // Le nb de points de la classe 1 affectés en classe 1
            for (int i = 0; i < 1000; i++)
            {
                int x = (int)Examples[i].x;
                int y = (int)Examples[i].y;

                if (ClassToLearn[i] == 1)
                {
                    bmp.SetPixel(x, pictureBox1.Height - 1 - y, Color.Orange);
                    if (ClassAssigned[i] == 1)
                        cptC1bons++;
                    else
                        cptC1mauvais++;
                }
                else
                {
                    bmp.SetPixel(x, pictureBox1.Height - 1 - y, Color.Purple);
                    if (ClassAssigned[i] == 1)
                        cptC2mauvais++;
                    else
                        cptC2bons++;
                }
            }
            labelC1bons.Text = Convert.ToString(cptC1bons * 100 / 500.0) + "%";
            labelC2bons.Text = Convert.ToString(cptC2bons * 100 / 500.0) + "%";
            labelC1mauvais.Text = Convert.ToString(cptC1mauvais * 100 / 500.0) + "%";
            labelC2mauvais.Text = Convert.ToString(cptC2mauvais * 100 / 500.0) + "%";

            pictureBox1.Invalidate();

        }

        private int calcule_sortie(double x, double y)
        {
            // A modifier, il suffit de calculer la somme et de retourner 1 si elle dépasse le seuil et 0 sinon
            double somme = w1 * x + w2 * y + w3 * constante;
            if (somme > 0) return 1;
            else return 0;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Apprentissage du perceptron 1 neurone
            int nberreurs = 200;
            int nbIter = 0;
            seuil = 0;
            int nbiterationsmax = Convert.ToInt32(textBoxnbiter.Text);

            // A vous d'écrire l'algorithme d'apprentissage
            while (nberreurs > 0)
            {
                nberreurs = 0;

                for (int index = 0; index < 1000; index++)
                {
                    nbIter++;
                    int id = rd.Next(0, 999);
                    Point p = Examples[id];
                    int sortie = calcule_sortie(p.x, p.y);
                    ClassAssigned[id] = sortie == 1 ? 1 : 2;

                    if (sortie == 0 && ClassToLearn[id] != 2)
                    {
                        w1 = w1 + k * p.x;
                        w2 = w2 + k * p.y;
                        w3 = w3 + k * constante;

                        nberreurs++;
                    }
                    else if (sortie == 1 && ClassToLearn[id] != 1)
                    {
                        w1 = w1 - k * p.x;
                        w2 = w2 - k * p.y;
                        w3 = w3 - k * constante;

                        nberreurs++;
                    }
                }
            }

            label2.Text = nbIter.ToString();


            // On regarde le résultat obtenu en procédant à la classification de tous les points de l'image
            this.buttonClassification_Click(null, null);

        }
    }
}
