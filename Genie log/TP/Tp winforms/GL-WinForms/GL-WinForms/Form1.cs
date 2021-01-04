using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GL_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBoxAnnees.SelectedIndex = 0;
        }

        
        private void buttonReset_Click(object sender, EventArgs e)
        {
            List<TextBox> textList = groupBoxAnnees.Controls.OfType<TextBox>().ToList();
            textList.ForEach(delegate(TextBox t) { t.Text = ""; });
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonEnvoyer_Click(object sender, EventArgs e)
        {
            bool remplis = true;
            List<TextBox> textList = groupBoxAnnees.Controls.OfType<TextBox>().ToList();
            textList.ForEach(delegate (TextBox t) { if (t.Text.Length == 0) remplis = false; });

            if (remplis)
            {
                string courriel = checkBoxCourriels.Checked ? "oui" : "non";
                string message = $"{textBoxPrenom.Text} {textBoxNom.Text}, né(e) en {"a"}\n Recevoir courriels : {courriel}\n Remarques : {textBoxRemarques.Text}";
                MessageBoxButtons btn = MessageBoxButtons.OK;
                DialogResult res = MessageBox.Show(message, "bonjour", btn);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxInfos_Enter(object sender, EventArgs e)
        {

        }
    }

    
}
