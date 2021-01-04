using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GL_WinForms
{
    public partial class Calculatrice : Form
    {
        private double Result;

        public Calculatrice()
        {
            InitializeComponent();

            
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = ((Button)sender);
            string pattern = "^[0-9]$";
            Regex reg = new Regex(pattern);

            if (reg.IsMatch(btn.Text))
            {
                textBoxEcriture.Text += btn.Text;
            }
            else if(btn.Text == "+")
            {
                textBoxEcriture.Text += btn.Text;
            }
            else if(btn.Text == "-")
            {
                textBoxEcriture.Text += btn.Text;
            }
            else if (btn.Text == "C")
            {
                textBoxEcriture.Text = "";
            }
            else if(btn.Text == "=")
            {
                
                string[] tempChiffre;
                int indexPlus = textBoxEcriture.Text.IndexOf('+');
                int indexMinus = textBoxEcriture.Text.IndexOf('-');

                if (indexPlus != -1)
                {
                    tempChiffre = textBoxEcriture.Text.Split('+');
                    Result = Int32.Parse(tempChiffre[0]) + Int32.Parse(tempChiffre[1]);
                }
                else if (indexMinus != -1)
                {
                    tempChiffre = textBoxEcriture.Text.Split('-');
                    Result = Int32.Parse(tempChiffre[0]) - Int32.Parse(tempChiffre[1]);
                }

                textBoxEcriture.Text = Result.ToString();
            }
        }

    }
}
